using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct;
using XSystem.Security.Cryptography;

namespace Business_Logic_Layer
{
    public class LoginBll
    {
        private readonly Mapper Mapper;
        private readonly IGenericRepository<User> repository;


        public LoginBll()
        {
            repository = new GenericRepository<User>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<string, byte[]>().ConvertUsing<Base64Converter>();
                cfg.CreateMap<byte[], string>().ConvertUsing<Base64Converter>();
                cfg.CreateMap<User, RegisterModel>().ReverseMap();
            });
            Mapper = new Mapper(config);
        }

        private class Base64Converter : ITypeConverter<string, byte[]>, ITypeConverter<byte[], string>
        {
            public byte[] Convert(string source, byte[] destination, ResolutionContext context)
                => System.Convert.FromBase64String(source);

            public string Convert(byte[] source, string destination, ResolutionContext context)
                => System.Convert.ToBase64String(source);
        }


        public void PostRegister(RegisterModel model)
        {

            var pwEncr = EncodePasswordToBase64(model.Password);
            model.Password = pwEncr;
            var ent = Mapper.Map<RegisterModel, User>(model);
            ent.Salt = GenerateSalt();
            
            repository.Insert(ent);
        }

        
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        

        public static string GenerateSalt()
        {
            Random random = new Random();
            string salt = "";
            for (int i = 1; i <= 50; i++)
            {
                int numero = random.Next(0, 255);
                char letra = Convert.ToChar(numero);
                salt += letra;
            }
            return salt;
        }

        public static byte[] EncriptarPassword(string password, string salt)
        {
            string contenido = password + salt;
            SHA256Managed sha = new SHA256Managed();
            byte[] salida = Encoding.Unicode.GetBytes(contenido);
            for (int i = 1; i <= 107; i++)
            {
                salida = sha.ComputeHash(salida);
            }
            sha.Clear();
            return salida;

        }

    }
}
