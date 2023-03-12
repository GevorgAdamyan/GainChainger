using Newtonsoft.Json;

namespace Gainchainger.Support
{
    public class Helpers
    {
        public static void GenerateJSONFile(Dictionary<string, object> dictionary)
        {
            var json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            var filePath = "../blogPostFields.json";
            File.WriteAllText(filePath, json);
        }
    }
}