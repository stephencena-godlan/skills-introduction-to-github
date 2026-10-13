using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var newString = String.Empty;

        if (String.IsNullOrWhiteSpace(identifier)) { return newString; }

        newString = identifier.Replace(' ','_');
        newString = newString.Replace("\0","CTRL");
        
        var newStringArray = newString.ToCharArray();
        
        for(int indexLetter=1; indexLetter<newStringArray.Length; indexLetter++)
        {
            if (newStringArray[indexLetter-1] == '-')
            {
                newStringArray[indexLetter] = char.ToUpper(newStringArray[indexLetter]);
            }
        }
        
        newString = new string(newStringArray);
        newString = newString.Replace("-","");

        
        
        var newStringBuilder = new StringBuilder();
        newStringArray = newString.ToCharArray();

        foreach(var letter in newStringArray)
        {
            if ((letter >= '\u0370') && (letter <= '\u03FF') && (char.IsLower(letter)))
            {
                continue;
            }
            
            if ((char.IsLetter(letter)) || (letter == '_'))
            {
                newStringBuilder.Append(letter);
            }
        }

        newString = newStringBuilder.ToString();
        
        return newString;
    }
}
