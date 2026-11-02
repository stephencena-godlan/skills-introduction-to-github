public static class Languages
{
    public static bool Between(this int value, int min, int max) => ((value >= min) && (value <= max));
    
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages()
    {
        var _list = NewList();
        
        _list.Add("C#");
        _list.Add("Clojure");
        _list.Add("Elm");

        return _list;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
       languages.Add(language);
       return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages) 
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        var favoriteLanguage = "C#";
        
        if (languages.Count == 0) { return false; }
        if (languages[0] == favoriteLanguage) { return true; }
        if ((languages[1] == favoriteLanguage) && languages.Count.Between(2,3)) { return true; }

        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages) => (languages.Distinct().Count() == languages.Count);
}
