using System.Text.Encodings.Web;
using System.Text.Json;


namespace PersonalSite.Data
{

    public class Work
    {
        public string Section { get; set; } = "";
        public string Subsection { get; set; } = "";

        public string UkTitle { get; set; } = "";
        public string EnTitle { get; set; } = "";

        public string UkMeta { get; set; } = "";
        public string EnMeta { get; set; } = "";

        public List<WorkLink> Links { get; set; } = new();
    }

    public class WorkLink
    {
        public string Type { get; set; } = "";
        public string UkText { get; set; } = "";
        public string EnText { get; set; } = "";
        public string Url { get; set; } = "";
    }

    
    public static class Data
    {


        public static List<Work> GetDataFromJson(string path)
        {
            var json = File.ReadAllText(path);

            var works = JsonSerializer.Deserialize<List<Work>>(json);

            return works ?? new List<Work>();
        }

        public static void WriteDataToJson(List<Work> works, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var json = JsonSerializer.Serialize(works, options);

            File.WriteAllText(path, json);
        }


        public static List<Work> Works { get; } = new();
                            
            
    }
}