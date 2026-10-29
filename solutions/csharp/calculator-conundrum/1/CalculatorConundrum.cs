public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        var result = String.Empty;
        var validOperators = new string[] {"+","*","/"}; 

        if (operation == null) 
        {
            throw new ArgumentNullException();
        }

        if (operation.Length == 0)
        {
            throw new ArgumentException();
        }
        
        if (!validOperators.Contains(operation))
        {
            throw new ArgumentOutOfRangeException("operand","Illegal operator");
        }

        if ((operand2 == 0) && (operation == "/"))
        {
            return "Division by zero is not allowed.";
        }
        
        switch (operation)
        {
            case "+" : result = $"{operand1} + {operand2} = {operand1 + operand2}"; break;
            case "*" : result = $"{operand1} * {operand2} = {operand1 * operand2}"; break;
            case "/" : result = $"{operand1} / {operand2} = {operand1 / operand2}"; break;
        }

        return result;
        //throw new NotImplementedException("Please implement the SimpleCalculator.Calculate() method");
    }
}
