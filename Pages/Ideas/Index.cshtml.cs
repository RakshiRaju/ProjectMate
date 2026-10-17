using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectMate.Data;
using ProjectMate.Models;

namespace ProjectMate.Pages.Ideas;

public class IndexModel : PageModel
{
    private readonly ProjectCatalog _catalog;

    public IndexModel(ProjectCatalog catalog)
    {
        _catalog = catalog;
    }

    [BindProperty(SupportsGet = true)]
    public string? Q { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Kind { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Difficulty { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Tech { get; set; }

    public IReadOnlyList<ProjectIdea> Projects { get; private set; } = [];

    public TechnologyGuide? ActiveTechnology { get; private set; }

    public void OnGet()
    {
        ActiveTechnology = string.IsNullOrWhiteSpace(Tech) ? null : _catalog.FindTechnology(Tech);
        Projects = _catalog.SearchIdeas(Q, Kind, Difficulty, Tech);
    }
}
