using System.ComponentModel.DataAnnotations;

namespace Mailroom.Models;

public class History
{
    public int HistoryID {get; set;}
    public Package Package {get; set;} = null!;
    public DateTime timeReceived {get; set;}
    public Resident Resident {get; set;} = null!;
}