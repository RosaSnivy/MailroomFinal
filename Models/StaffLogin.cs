using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mailroom.Models;

public class StaffLogin
{
    public int StaffLoginID {get; set;}
    [Required]
    [Display(Name = "User Name")]
    public string username {get; set;} = string.Empty;
    [Required]
    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public string password {get; set;} = string.Empty;

}