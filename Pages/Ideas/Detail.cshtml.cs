using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectMate.Data;
using ProjectMate.Models;

namespace ProjectMate.Pages.Ideas;

public class DetailModel : PageModel
{
    private readonly ProjectCatalog _catalog;

    public DetailModel(ProjectCatalog catalog)
    {
        _catalog = catalog;
    }

    public ProjectIdea? Idea { get; private set; }

    public IReadOnlyList<ProjectIdea> Related { get; private set; } = [];

    public IActionResult OnGet(string slug)
    {
        Idea = _catalog.FindIdea(slug);
        if (Idea is null)
        {
            Response.StatusCode = StatusCodes.Status404NotFound;
            return Page();
        }

        Related = _catalog.RelatedIdeas(Idea);
        return Page();
    }
}
