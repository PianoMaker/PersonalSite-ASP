using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;

namespace PersonalSite.Pages.en
{



    public class MusicModel : PageModel
    {

        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<MusicModel> _logger;

        public MusicModel(
            IWebHostEnvironment environment,
            ILogger<MusicModel> logger)
        {
            _environment = environment;
            _logger = logger;
        }
        public List<Work> MusicalWorks { get; set; } = new();

        public void OnGet()
        {
            var path = Path.Combine(
                _environment.ContentRootPath,
                "Data",
                "works.json"
            );
            //MusicalWorks = Data.Data.Works;
            var allWorks = Data.Data.GetDataFromJson(path);
            MusicalWorks = allWorks.Where((w) => w.Section != "research").ToList();

            Console.WriteLine("музичних" + MusicalWorks.Count);
            _logger.LogInformation(
                "Індексовано музичних творів: {Count}",
                MusicalWorks.Count);
        }
    }
}