using System.ComponentModel.DataAnnotations;
namespace Mailroom.Models;

public class UnknownPackage
{
    public int UnknownPackageID {get; set;}
    public string name {get; set;} = string.Empty;
    public string postalService {get; set;} = string.Empty;
}