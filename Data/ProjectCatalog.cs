using ProjectMate.Models;

namespace ProjectMate.Data;

public sealed class ProjectCatalog
{
    private static readonly TechTag Csharp = new("csharp", "C# and ASP.NET Core");
    private static readonly TechTag Html = new("html-css", "HTML and CSS");
    private static readonly TechTag Sql = new("sql", "SQL");
    private static readonly TechTag Python = new("python", "Python");
    private static readonly TechTag JavaScript = new("javascript", "JavaScript");

    public IReadOnlyList<ProjectIdea> Ideas { get; } =
    [
        new(
            "student-task-manager",
            "Student Task Manager",
            "A page where you add assignments, set a due date, and mark them done.",
            "Mini",
            "Beginner",
            [Csharp, Sql],
            [
                "Make a list page that shows each task and its due date.",
                "Add a form with a title, a course name, and a due date.",
                "Save the tasks so they are still there after a refresh.",
                "Mark a task done, and show overdue tasks in a separate group."
            ],
            [
                "How a form sends data to the server",
                "How to store a short list of records",
                "How to split one list into done and still open"
            ]),
        new(
            "expense-tracker",
            "Smart Expense Tracker",
            "Record what you spent today and see the total for the week.",
            "Mini",
            "Beginner",
            [Csharp, Sql],
            [
                "List each expense with an amount, a category, and a date.",
                "Add a form that refuses an empty amount or a negative number.",
                "Show a total at the top of the page.",
                "Filter the list to one category, such as food or travel."
            ],
            [
                "Validating input before you save it",
                "Adding numbers that come from a list",
                "Filtering a list without deleting the other rows"
            ]),
        new(
            "campus-notice-board",
            "Campus Notice Board",
            "One page of college notices you can narrow by department.",
            "Mini",
            "Beginner",
            [Html, JavaScript],
            [
                "Write the page with a heading and a list of notices.",
                "Give each notice a department and a date.",
                "Add buttons that show only one department.",
                "Show a short message when a department has no notices."
            ],
            [
                "Structuring a page with HTML",
                "Showing and hiding items from a button",
                "Writing an empty state that tells the reader what to do"
            ]),
        new(
            "personal-portfolio",
            "Personal Portfolio",
            "A single page that introduces you and links to work you have finished.",
            "Mini",
            "Beginner",
            [Html],
            [
                "Write a short introduction in your own words.",
                "List two or three projects with one sentence each.",
                "Add links that open those projects.",
                "Check the page on a narrow phone screen and fix anything that overflows."
            ],
            [
                "Writing for a reader instead of filling a template",
                "Linking pages together",
                "Making a simple layout work on a phone"
            ]),
        new(
            "online-quiz",
            "Online Quiz",
            "A short quiz that asks a few questions and shows a score at the end.",
            "Mini",
            "Intermediate",
            [Csharp],
            [
                "Store the questions and the correct answers on the server.",
                "Show one question at a time with its choices.",
                "Remember the answers as the student moves forward.",
                "On the last step, show the score and which answers were wrong."
            ],
            [
                "Keeping track of progress across more than one request",
                "Comparing an answer with the correct one",
                "Deciding what the page should show at each step"
            ]),
        new(
            "library-desk",
            "Library Desk",
            "Track which books are on the shelf, who borrowed them, and when they are due.",
            "Major",
            "Intermediate",
            [Csharp, Sql],
            [
                "Make a book list with a title, an author, and a shelf status.",
                "Add a borrower name and a due date when a book goes out.",
                "Block a second borrow while the book is already out.",
                "Add a return action that puts the book back on the shelf."
            ],
            [
                "Records that point at other records",
                "Rules that protect data, such as one borrower at a time",
                "Updating a record instead of only adding new ones"
            ]),
        new(
            "team-matcher",
            "Project Team Matcher",
            "Students enter their skills, and the app suggests a small project team.",
            "Major",
            "Intermediate",
            [Csharp],
            [
                "Collect a name and a few skills from each student.",
                "Decide what a balanced team needs, such as one person who can build the page and one who can store data.",
                "Suggest a team of three when the skills cover those roles.",
                "Explain the suggestion in plain language on the page."
            ],
            [
                "Turning a vague idea into rules a program can follow",
                "Grouping people by what they can do",
                "Showing the reason behind a result"
            ]),
        new(
            "lab-booking",
            "Lab Equipment Booking",
            "Reserve a lab bench so two groups cannot take the same slot.",
            "Major",
            "Advanced",
            [Csharp, Sql],
            [
                "List the benches and the hours they can be booked.",
                "Let a group request one bench for one hour.",
                "Refuse the request when that hour is already taken.",
                "Show a day view so a student can see which hours are free."
            ],
            [
                "Checking for clashes before you save",
                "Times and dates in a form",
                "A page that answers a question: what is free at 2 pm?"
            ])
    ];

    public IReadOnlyList<ProjectProblem> Problems { get; } =
    [
        new(
            "build-failed",
            "The app will not start",
            "dotnet run stops with an error, and the browser has nothing to open.",
            "The first error is the one that matters. Later lines are often fallout from a missing package, a typo, or a project that targets a .NET version you do not have installed.",
            "Read the first error. It names a file and a line. Fix that, then run the app again. If it says the target framework was not found, install the .NET SDK named in the project file.",
            [Csharp]),
        new(
            "page-not-found",
            "The browser shows 404",
            "The site is running, but the address you opened is not a page.",
            "Razor Pages turn a file under Pages into an address. A file without @page, or a file in a folder the project excludes, never becomes an address.",
            "Confirm the file is under Pages and starts with @page. The address follows the folder and file name: Pages/Ideas/Index.cshtml is /Ideas.",
            [Csharp, Html]),
        new(
            "database-connection",
            "Saving or loading data crashes",
            "The page works until it tries to read or write the database, then it throws.",
            "The connection string points at a server that is not running, or at a file that is not where the app expects it.",
            "Open the connection string. For SQLite, check that the database file path is one the app can create. For SQL Server, check the server name and that the database exists.",
            [Csharp, Sql]),
        new(
            "form-does-nothing",
            "The form reloads and nothing is saved",
            "You fill in the form, submit it, and the fields come back empty.",
            "The form is sending a GET, or the input names do not match the properties on the page model, so the server never receives the values.",
            "Set the form method to post. Bind each input with asp-for. In the page model, read those properties in OnPost and then save them.",
            [Csharp, Html]),
        new(
            "styles-look-old",
            "The CSS change is not on the page",
            "You edited the stylesheet, refreshed, and the old design is still there.",
            "The browser kept the previous stylesheet. A second copy of the same styles, loaded later, can also hide the change.",
            "Hard-refresh the page. In this project, asp-append-version on the stylesheet link changes the address after a rebuild, so the browser fetches the new file.",
            [Html]),
        new(
            "null-on-page",
            "NullReferenceException on a page",
            "Opening the page throws, and the stack trace points at the .cshtml file.",
            "The view read a property that OnGet never set. A lookup that finds nothing and is then used as if it exists causes the same crash.",
            "Set every property the view reads before you return Page(). If a lookup can fail, return a not-found result instead of handing the view a null value.",
            [Csharp])
    ];

    public IReadOnlyList<TechnologyGuide> Technologies { get; } =
    [
        new(
            "csharp",
            "C# and ASP.NET Core",
            "Web applications with pages, forms, and saved data",
            "Choose this when the project needs to keep records: tasks, bookings, scores, borrowed books. Razor Pages is enough for a student project. You do not need a separate frontend framework to get started.",
            [
                "The project has forms that must be checked on the server",
                "You want one language for the page and the rules",
                "A teacher expects a .NET submission"
            ],
            [
                "A one-page poster or portfolio does not need a server",
                "Installing the SDK is part of the setup, not part of the project idea"
            ]),
        new(
            "html-css",
            "HTML and CSS",
            "Pages where the work is the layout and the words",
            "Choose this when the project is something a person reads or clicks through, and nothing has to be stored. A portfolio and a notice board both start here.",
            [
                "The page can work from files you open in a browser",
                "You are still learning how a page is structured",
                "The marking scheme is about presentation"
            ],
            [
                "HTML cannot remember a booking after the tab closes",
                "If you need saved records, add a server and a database later"
            ]),
        new(
            "sql",
            "SQL",
            "Structured records you need to keep",
            "Choose SQL when the project would be useless if the data disappeared on refresh. SQLite is the simplest place to start: one file, no separate server.",
            [
                "Rows have a clear shape, such as a book or an expense",
                "You need to ask questions, such as what is overdue",
                "Two people must not change the same record carelessly"
            ],
            [
                "A list of three notices does not need a database yet",
                "Design the columns before you write the page that edits them"
            ]),
        new(
            "python",
            "Python",
            "Scripts, data, and automation",
            "Choose Python when the useful part is a calculation or a script: cleaning a spreadsheet, scoring a survey, or training a small model. It is a poor first choice if the whole assignment is a multi-page website.",
            [
                "The input is a file and the output is an answer",
                "You are exploring data more than page layout",
                "The class is already using Python"
            ],
            [
                "A website still needs HTML, even if Python builds it",
                "Do not pick Python only because it is familiar if the brief asks for a web app"
            ]),
        new(
            "javascript",
            "JavaScript",
            "Behavior in the browser",
            "Choose JavaScript when the page should react without a full reload: filtering notices, opening a panel, checking a field before submit. In this app, the catalog itself is rendered by the server, so JavaScript is optional.",
            [
                "A click should change what is visible",
                "You want feedback before the form is sent",
                "The project is a browser page, not a script"
            ],
            [
                "Anything a user can turn off or edit in the browser is not a security check",
                "Do not hide the only copy of your content inside a script"
            ])
    ];

    public IReadOnlyList<Lesson> Lessons { get; } =
    [
        new(
            1,
            "Programming fundamentals",
            "Variables, decisions, and loops. Every later project is these three ideas with a page around them.",
            [
                "Store a name and a number.",
                "Print a different sentence when the number is above a limit.",
                "Walk through a list and count how many items match."
            ],
            ["personal-portfolio"]),
        new(
            2,
            "HTML and CSS",
            "A page is a document. HTML says what each part is. CSS says how it sits on the screen.",
            [
                "Build a page with one heading, one paragraph, and a list.",
                "Make the line length comfortable to read.",
                "Check it on a narrow window."
            ],
            ["personal-portfolio", "campus-notice-board"]),
        new(
            3,
            "C# fundamentals",
            "The same fundamentals, in the language this site is written in. Classes are just grouped data plus the actions you can take on it.",
            [
                "Write a class with a few properties.",
                "Make a list of those objects.",
                "Find one object by a name or a slug."
            ],
            ["student-task-manager", "expense-tracker"]),
        new(
            4,
            "ASP.NET Core Razor Pages",
            "Each page is a pair: a .cshtml file for what the person sees, and a page model for what happens when they open it or submit a form.",
            [
                "Add a new page under Pages and open its address.",
                "Show a value that OnGet set.",
                "Accept a form with OnPost."
            ],
            ["online-quiz", "student-task-manager"]),
        new(
            5,
            "Saving data",
            "A list that lives in code disappears when you stop the app. A database keeps the rows. Start with SQLite once a project needs memory.",
            [
                "Write down the columns before you create the table.",
                "Insert one row from a form.",
                "Read the rows back onto the page."
            ],
            ["library-desk", "lab-booking", "expense-tracker"])
    ];

    public ProjectIdea? FindIdea(string slug) =>
        Ideas.FirstOrDefault(idea => idea.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public TechnologyGuide? FindTechnology(string slug) =>
        Technologies.FirstOrDefault(tech => tech.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public IReadOnlyList<ProjectIdea> SearchIdeas(string? query, string? kind, string? difficulty, string? technologySlug)
    {
        IEnumerable<ProjectIdea> items = Ideas;

        if (!string.IsNullOrWhiteSpace(kind))
        {
            items = items.Where(idea => idea.Kind.Equals(kind, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(difficulty))
        {
            items = items.Where(idea => idea.Difficulty.Equals(difficulty, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(technologySlug))
        {
            items = items.Where(idea => idea.Technologies.Any(tech =>
                tech.Slug.Equals(technologySlug, StringComparison.OrdinalIgnoreCase)));
        }

        if (!string.IsNullOrWhiteSpace(query))
        {
            var term = query.Trim();
            items = items.Where(idea =>
                idea.Title.Contains(term, StringComparison.OrdinalIgnoreCase)
                || idea.Summary.Contains(term, StringComparison.OrdinalIgnoreCase)
                || idea.Kind.Contains(term, StringComparison.OrdinalIgnoreCase)
                || idea.Difficulty.Contains(term, StringComparison.OrdinalIgnoreCase)
                || idea.Technologies.Any(tech => tech.Name.Contains(term, StringComparison.OrdinalIgnoreCase))
                || idea.Steps.Any(step => step.Contains(term, StringComparison.OrdinalIgnoreCase)));
        }

        return items.ToList();
    }

    public IReadOnlyList<ProjectProblem> SearchProblems(string? query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return Problems.ToList();
        }

        var term = query.Trim();
        return Problems.Where(problem =>
                problem.Title.Contains(term, StringComparison.OrdinalIgnoreCase)
                || problem.Symptom.Contains(term, StringComparison.OrdinalIgnoreCase)
                || problem.Cause.Contains(term, StringComparison.OrdinalIgnoreCase)
                || problem.Fix.Contains(term, StringComparison.OrdinalIgnoreCase)
                || problem.Technologies.Any(tech => tech.Name.Contains(term, StringComparison.OrdinalIgnoreCase)))
            .ToList();
    }

    public IReadOnlyList<ProjectIdea> RelatedIdeas(ProjectIdea idea, int take = 2) =>
        Ideas.Where(other =>
                other.Slug != idea.Slug
                && other.Technologies.Any(tech => idea.Technologies.Any(own => own.Slug == tech.Slug)))
            .Take(take)
            .ToList();

    public IReadOnlyList<ProjectIdea> IdeasForSlugs(IReadOnlyList<string> slugs) =>
        slugs.Select(FindIdea).OfType<ProjectIdea>().ToList();
}
