namespace WorkingWithHashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> languages = new HashSet<string>();
            languages.Add("C#");
            languages.Add(".NET");
            languages.Add("Java");
            languages.Add("Python");

            HashSet<string> olderLanguages = new HashSet<string>();
            olderLanguages.Add("C");
            olderLanguages.Add("C++");
            olderLanguages.Add("PHP");

            HashSet<string> webLanguages = new HashSet<string>();
            webLanguages.Add("JavaScript");
            webLanguages.Add(".NET");
            webLanguages.Add("PHP");

            Console.WriteLine("Combined list of older and newer languages");
            languages.UnionWith(olderLanguages);
            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }
            Console.WriteLine();

            Console.WriteLine("Languages that are in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = languages;
            bothLists.IntersectWith(webLanguages);
            foreach (string language in bothLists)
            {
                Console.WriteLine(language);
            }
        }
    }
}