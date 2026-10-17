using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectMate.Data;
using ProjectMate.Models;

namespace ProjectMate.Pages.Problems;

public class IndexModel : PageModel
{
    private readonly ProjectCatalog _catalog;

    public IndexModel(ProjectCatalog catalog)
    {
        _catalog = catalog;
    }

    [BindProperty(SupportsGet = true)]
    public string? Q { get; set; }

    public IReadOnlyList<ProjectProblem> Problems { get; private set; } = [];

    public void OnGet()
    {
        Problems = _catalog.SearchProblems(Q);
    }
}
