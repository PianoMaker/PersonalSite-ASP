using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;

namespace PersonalSite.Pages.uk
{
    public class MusicModel : PageModel
    {
        public List<MusicalWork> MusicalWorks { get; set; } = new();

        public void OnGet()
        {
            MusicalWorks = MusicData.Works;
        }
    }
}