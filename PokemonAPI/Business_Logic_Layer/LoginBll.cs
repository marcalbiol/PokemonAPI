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
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using XAct;
using SHA256Managed = XSystem.Security.Cryptography.SHA256Managed;

namespace Business_Logic_Layer;

public class LoginBll
{
    private readonly MyDbContext _db = new();
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
        var hashsalt = EncryptPassword(ent.Password);
        ent.Password = hashsalt.Hash;
        ent.Salt = hashsalt.Salt;


        repository.Insert(ent);
    }

    public bool Login(RegisterModel model)
    {
        var userFromDb = _db.Users.FirstOrDefault(u => u.Username == model.Username);
        var isPasswordMatched = VerifyPassword(model.Password, userFromDb.Salt, userFromDb.Password);

        if (isPasswordMatched)
        {
            return true;
        }

        return false;
    }


    public HashSalt EncryptPassword(string password)
    {
        byte[] salt = new byte[128 / 8]; // Generate a 128-bit salt using a secure PRNG
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        string encryptedPassw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8
        ));
        return new HashSalt { Hash = encryptedPassw, Salt = salt };
    }

    public static bool VerifyPassword(string enteredPassword, byte[] salt, string storedPassword)
    {
        string encryptedPassw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: enteredPassword,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8
        ));
        return encryptedPassw == storedPassword;
    }
}