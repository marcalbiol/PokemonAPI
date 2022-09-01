using System.ComponentModel.DataAnnotations;

namespace PokemonBackend.Models;

public class UserInfo
{
    [Key] public string? Email { get; set; }

    public string? Password { get; set; }
}