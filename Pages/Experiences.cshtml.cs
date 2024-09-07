using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalSite.Pages;

public class ExperiencesModel : PageModel
{
    private readonly ILogger<ExperiencesModel> _logger;

    public ExperiencesModel(ILogger<ExperiencesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

