using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mailroom.Models;

namespace MailroomFinal.Pages;
public class IndexModel : PageModel
{
    // Add: Property for database context
    private readonly MailroomDbContext _context; // Replaces the "db" variable from before
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public StaffLogin StaffLogin {get; set;} = null!;
    
    public IndexModel(MailroomDbContext context, ILogger<IndexModel> logger)
    {
        _context = context; // Set database context - this is part 2 of dependency injection
        _logger = logger;        
    }

    public void OnGet()
    {

    }
}
