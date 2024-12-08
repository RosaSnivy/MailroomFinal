using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mailroom.Models;
using Microsoft.VisualBasic;

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

    public IActionResult OnPost()
    {
    if (string.IsNullOrWhiteSpace(StaffLogin.username) || string.IsNullOrWhiteSpace(StaffLogin.password))
    {
        // Do not perform validation and simply return the page
        return Page();
    }
        // Use LINQ to find a matching staff login
    var login = _context.StaffLogins
        .FirstOrDefault(item => item.username == StaffLogin.username && item.password == StaffLogin.password);

    if (login != null)
    {
        // Redirect to Dashboard if login matches
        return RedirectToPage("/Dashboard");
    } else {
        ModelState.AddModelError(string.Empty, "Invalid username or password.");
        return Page();
    }
    }
}
