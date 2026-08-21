using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;
using System.IO;

namespace PersonalSite.Pages.en
{

    public class Results
    {
        public string Title { get; set; } = "";
        public string Section { get; set; } = "";
        public string Description { get; set; } = "";
        public string Url { get; set; } = "";

        public List<WorkLink> Links { get; set; } = new();
    }




    public class SearchModel : PageModel
    {
        public List<Results> Results { get; set; } = new();

        private readonly ILogger<SearchModel> _logger;
        private readonly IWebHostEnvironment _environment;

        public SearchModel(IWebHostEnvironment environment, ILogger<SearchModel> logger)
        {        
            _logger = logger;
            _environment = environment;
        }

        public void OnGet(string? search)
        {
            
            if (!string.IsNullOrWhiteSpace(search))
            {
                Results = Find(search);
            }
        }

        public void OnPost(string? search)
        {
            if (!string.IsNullOrWhiteSpace(search))
            {
                Results = Find(search);
            }
        }

        private List<Results> Find(string search)
        {
            var results = new List<Results>();

            search = search.Trim();

            var path = Path.Combine(
                _environment.ContentRootPath,
                "Data",
                "works.json"
            );

            var allWorks = Data.Data.GetDataFromJson(path);

            var videos = Path.Combine(
    _environment.ContentRootPath,
    "Data",
    "videos.json"
);

            var allvideos = Data.Data.GetDataFromJson(videos);


            _logger.LogInformation(
                "Початок пошуку '{Search}' серед {Count} записів",
                search,
                allWorks.Count);

            _logger.LogInformation(
    "Початок пошуку '{Search}' серед {Count} відео",
    search,
    allvideos.Count);

            foreach (var work in allWorks)
            {
                bool found =
                    work.UkTitle.Contains(search, StringComparison.OrdinalIgnoreCase)
                    ||
                    work.UkMeta.Contains(search, StringComparison.OrdinalIgnoreCase)
                    ||
                    work.EnMeta.Contains(search, StringComparison.OrdinalIgnoreCase)
                    ||
                    work.EnMeta.Contains(search, StringComparison.OrdinalIgnoreCase);
            

                if (found)
                {
                    results.Add(new Results
                    {
                        Title = work.EnTitle,
                        Section = work.Section,
                        Description = work.EnMeta,
                        Links = work.Links
                    });
                }
            }

            foreach (var video in allvideos)
            {
                bool found =
                    video.UkTitle.Contains(search, StringComparison.OrdinalIgnoreCase)
                    ||
                    video.UkMeta.Contains(search, StringComparison.OrdinalIgnoreCase);

                if (found)
                {
                    results.Add(new Results
                    {
                        Title = video.EnTitle,
                        Section = video.Section,
                        Description = video.EnMeta,
                        Links = video.Links
                    });
                }
            }

            return results;
        }

     
        
    }
}