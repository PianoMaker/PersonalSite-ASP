using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;

namespace PersonalSite.Pages.uk
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

        public void OnGet(string? search)
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

            foreach (var work in Data.Data.Works)
            {
                bool found =
                    work.UkTitle.Contains(search, StringComparison.OrdinalIgnoreCase)
                    ||
                    work.UkMeta.Contains(search, StringComparison.OrdinalIgnoreCase);

                if (found)
                {
                    results.Add(new Results
                    {
                        Title = work.UkTitle,
                        Section = work.Section,
                        Description = work.UkMeta,
                        Links = work.Links
                    });
                }
            }

            return results;
        }

     
        
    }
}