using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;

namespace PersonalSite.Pages.en
{
    public class VideoModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<MusicModel> _logger;

        public VideoModel(IWebHostEnvironment environment, ILogger<MusicModel> logger)
        {
            _environment = environment;
            _logger = logger;
        }

        public List<Work> Music { get; set; } = new();
        public List<Work> Tutorial { get; set; } = new();
        public List<Work> Other { get; set; } = new();

        public void OnGet()
        {
            var path = Path.Combine(
                _environment.ContentRootPath,
                "Data",
                "videos.json"
            );

            var allWorks = Data.Data.GetDataFromJson(path);

            Music = allWorks
                .Where(w => w.Subsection == "music")
                .ToList();

            Tutorial = allWorks
    .Where(w => w.Subsection == "tutorial")
    .ToList();

            Other = allWorks
    .Where(w => w.Subsection == "other")
    .ToList();


            _logger.LogInformation(
    "Індексовано музичних відео: {Music}",
    Music.Count);
            _logger.LogInformation(
    "Індексовано навчальних відео: {Tutorial}",
    Tutorial.Count);



        }
    }
}
