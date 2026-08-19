using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;

namespace PersonalSite.Pages.uk
{
    public class MusicModel : PageModel
    {

        private readonly IWebHostEnvironment _environment;

        public MusicModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public List<Work> MusicalWorks { get; set; } = new();

        public void OnGet()
        {
            var path = Path.Combine(
       _environment.ContentRootPath,
       "Data",
       "works.json"
   );
            MusicalWorks = Data.Data.Works;
            MusicalWorks = Data.Data.GetDataFromJson();
            Data.Data.WriteDataToJson(MusicalWorks, path);
        }
    }
}