using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectMate.Data;
using ProjectMate.Models;

namespace ProjectMate.Pages.Learning;

public class IndexModel : PageModel
{
    private readonly ProjectCatalog _catalog;

    public IndexModel(ProjectCatalog catalog)
    {
        _catalog = catalog;
    }

    public IReadOnlyList<Lesson> Lessons { get; private set; } = [];

    public IReadOnlyDictionary<string, ProjectIdea> ProjectsBySlug { get; private set; } =
        new Dictionary<string, ProjectIdea>();

    public void OnGet()
    {
        Lessons = _catalog.Lessons;
        ProjectsBySlug = _catalog.Ideas.ToDictionary(idea => idea.Slug);
    }
}
