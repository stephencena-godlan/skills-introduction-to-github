public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();
    //===============================================================================================================
    public static Dictionary<int, string> GetExistingDictionary()
    {
        var prepopulatedDictionary = AddCountryToEmptyDictionary(1,"United States of America");
        prepopulatedDictionary = AddCountryToExistingDictionary(prepopulatedDictionary,55,"Brazil");
        prepopulatedDictionary = AddCountryToExistingDictionary(prepopulatedDictionary,91,"India");

        return prepopulatedDictionary;
    }
    //===============================================================================================================
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var customDictionary = GetEmptyDictionary();
        customDictionary[countryCode] = countryName;
        return customDictionary; 
    }
    //===============================================================================================================
    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }
    //===============================================================================================================
    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode) => (CheckCodeExists(existingDictionary,countryCode)) ? existingDictionary[countryCode] : String.Empty;
    //===============================================================================================================
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.ContainsKey(countryCode);
    //===============================================================================================================
    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (CheckCodeExists(existingDictionary,countryCode)) { existingDictionary[countryCode] = countryName; };
        return existingDictionary;
    }
    //===============================================================================================================
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);

        return existingDictionary;
    }
    //===============================================================================================================
    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        var longestCountry = String.Empty;
        
        foreach(var key in existingDictionary.Keys)
        {
            var currentCountry = existingDictionary[key];
            if (currentCountry.Length > longestCountry.Length)
            {
                longestCountry = currentCountry;   
            }
        }

        return longestCountry;
    }
}