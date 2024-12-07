using System.ComponentModel.DataAnnotations;

namespace Mailroom.Models;

public class Package
{
    public int PackageID {get; set;}
    public string postalService {get; set;} = string.Empty;
    public Resident? Residents {get; set;}
}