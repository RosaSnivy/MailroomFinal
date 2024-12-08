using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mailroom.Models;
using Microsoft.VisualBasic;

namespace MailroomFinal.Pages;

public class DashboardModel : PageModel
{
    // Add: Property for database context
    private readonly MailroomDbContext _context; // Replaces the "db" variable from before
    private readonly ILogger<IndexModel> _logger;
    
    public DashboardModel(MailroomDbContext context, ILogger<IndexModel> logger)
    {
        _context = context; // Set database context - this is part 2 of dependency injection
        _logger = logger;        
    }

    public void OnGet()
    {

    }
}
