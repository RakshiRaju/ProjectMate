using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectMate.Data;
using ProjectMate.Models;

namespace ProjectMate.Pages;

public class IndexModel : PageModel
{
    private readonly ProjectCatalog _catalog;

    public IndexModel(ProjectCatalog catalog)
    {
        _catalog = catalog;
    }

    public int IdeaCount { get; private set; }

    public int ProblemCount { get; private set; }

    public int TechnologyCount { get; private set; }

    public int LessonCount { get; private set; }

    public ProjectIdea Featured { get; private set; } = null!;

    public void OnGet()
    {
        IdeaCount = _catalog.Ideas.Count;
        ProblemCount = _catalog.Problems.Count;
        TechnologyCount = _catalog.Technologies.Count;
        LessonCount = _catalog.Lessons.Count;
        Featured = _catalog.FindIdea("online-quiz") ?? _catalog.Ideas[0];
    }
}
