namespace Mailroom.Models;

public class StaffLogin
{
    public int StaffLoginID {get; set;}
    public string username {get; set;} = string.Empty;
    public string password {get; set;} = string.Empty;
}