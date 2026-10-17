using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectMate.Data;
using ProjectMate.Models;

namespace ProjectMate.Pages.Technologies;

public class IndexModel : PageModel
{
    private readonly ProjectCatalog _catalog;

    public IndexModel(ProjectCatalog catalog)
    {
        _catalog = catalog;
    }

    public IReadOnlyList<TechnologyGuide> Technologies { get; private set; } = [];

    public IReadOnlyDictionary<string, int> ProjectCounts { get; private set; } =
        new Dictionary<string, int>();

    public void OnGet()
    {
        Technologies = _catalog.Technologies;
        ProjectCounts = _catalog.Technologies.ToDictionary(
            tech => tech.Slug,
            tech => _catalog.SearchIdeas(null, null, null, tech.Slug).Count);
    }
}
