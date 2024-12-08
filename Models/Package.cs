using System.ComponentModel.DataAnnotations;

namespace Mailroom.Models;

public class Package
{
    public int PackageID {get; set;}
    public string postalService {get; set;} = string.Empty;
    public List<Resident> Residents {get; set;} = default!;
}