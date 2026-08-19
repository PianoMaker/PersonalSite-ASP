using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;

namespace PersonalSite.Pages.uk
{
    public class ResearchModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<MusicModel> _logger;

        public ResearchModel(IWebHostEnvironment environment, ILogger<MusicModel> logger)
        {
            _environment = environment;
            _logger = logger;
        }

        public List<Work> Works { get; set; } = new();

        public void OnGet()
        {
            var path = Path.Combine(
                _environment.ContentRootPath,
                "Data",
                "works.json"
            );

            var allWorks = Data.Data.GetDataFromJson(path);

            Works = allWorks
                .Where(w => w.Section == "research")
                .ToList();

            _logger.LogInformation(
    "Індексовано наукових статей: {Count}",
    Works.Count);
        }
    }
}