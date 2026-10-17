namespace ProjectMate.Models;

public sealed record TechTag(string Slug, string Name);

public sealed record ProjectIdea(
    string Slug,
    string Title,
    string Summary,
    string Kind,
    string Difficulty,
    IReadOnlyList<TechTag> Technologies,
    IReadOnlyList<string> Steps,
    IReadOnlyList<string> YouWillLearn);

public sealed record ProjectProblem(
    string Slug,
    string Title,
    string Symptom,
    string Cause,
    string Fix,
    IReadOnlyList<TechTag> Technologies);

public sealed record TechnologyGuide(
    string Slug,
    string Name,
    string BestFor,
    string Summary,
    IReadOnlyList<string> Fits,
    IReadOnlyList<string> WatchOuts);

public sealed record Lesson(
    int Number,
    string Title,
    string Summary,
    IReadOnlyList<string> Practice,
    IReadOnlyList<string> ProjectSlugs);
