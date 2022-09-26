using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XAct;
using SHA256Managed = XSystem.Security.Cryptography.SHA256Managed;

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
        var ent = Mapper.Map<RegisterModel, User>(model);

        ent.Salt = GenerateSalt();
        ent.Password = EncryptPassword(model.Password, ent.Salt);

        repository.Insert(ent);
    }

    private string GenerateSalt()
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

    private string EncryptPassword(string password, string salt)
    {
        using (var sha256 = SHA256.Create())
        {
            var saltedPassword = string.Format("{0}{1}", salt, password);
            byte[] saltedPasswordAsBytes = Encoding.UTF8.GetBytes(saltedPassword);
            return Convert.ToBase64String(sha256.ComputeHash(saltedPasswordAsBytes));
        }
    }
}