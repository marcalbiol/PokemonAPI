using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace Acceso_BD.Repository.Entity;

public class Register
{
    [Key] public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public DateTime Date { get; set; } = DateTime.Today;
    // public DateTime Update { get; set; } = DateTime.Today;
}