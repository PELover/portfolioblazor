namespace portfolioblazor
{
    public class JsonLanguage
    {
        public static string language = "home_en";
        
        public static string filePath => Path.Combine("wwwroot", "json", $"{language}.json");
            
        public string? name { get; set; }
    }
}
