using System.ComponentModel.DataAnnotations;

namespace Mailroom.Models;

public class Resident
{
    public int ResidentID {get; set;}
    public string name {get; set;} = string.Empty;
    public string email {get; set;} = string.Empty;
    public int unitNumber {get; set;}
}