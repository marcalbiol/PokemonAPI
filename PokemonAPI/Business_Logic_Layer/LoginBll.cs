using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XAct;
using XSystem.Security.Cryptography;

namespace Business_Logic_Layer;

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
        {
            return System.Convert.FromBase64String(source);
        }

        public string Convert(byte[] source, string destination, ResolutionContext context)
        {
            return System.Convert.ToBase64String(source);
        }
    }

    public List<RegisterModel> GetAll()
    {
        var entity = repository.GetAllData();
        return Mapper.Map<List<User>, List<RegisterModel>>(entity);
    }

    public void PostRegister([FromBody] RegisterModel model)
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
            var encData_byte = new byte[password.Length];
            encData_byte = Encoding.UTF8.GetBytes(password);
            var encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }
        catch (Exception ex)
        {
            throw new Exception("Error in base64Encode" + ex.Message);
        }
    }


    public static string GenerateSalt()
    {
        var random = new Random();
        var salt = "";
        for (var i = 1; i <= 50; i++)
        {
            var numero = random.Next(0, 255);
            var letra = Convert.ToChar(numero);
            salt += letra;
        }

        return salt;
    }

    public static byte[] EncriptarPassword(string password, string salt)
    {
        var contenido = password + salt;
        var sha = new SHA256Managed();
        var salida = Encoding.Unicode.GetBytes(contenido);
        for (var i = 1; i <= 107; i++) salida = sha.ComputeHash(salida);

        sha.Clear();
        return salida;
    }
}