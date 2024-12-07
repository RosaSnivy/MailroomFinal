using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Mailroom.Models;

public class StaffLogin
{
    public int StaffLoginID {get; set;}
    [Required]
    public string username {get; set;} = string.Empty;
    [Required]
    [DataType(DataType.Password)]
    public string password {get; set;} = string.Empty;
}