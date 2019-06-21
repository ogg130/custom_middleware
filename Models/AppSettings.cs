namespace Middleware
{
    public class AppSettings
    {

        public static string AcceptLanguage { get; set; } = string.Empty;

        public static string Language
        {
            get
            {
                switch (AcceptLanguage.ToUpper())
                {
                    case "EN-US": return $"This websites 'Accept-Language' header contains '{AcceptLanguage.ToUpper()}' which indicates US English.";
                    default: return $"This websites 'Accept-Language' header contains '{AcceptLanguage.ToUpper()}' which indicates a language other than US English.";
                }
            }
        }
    }
}
