namespace TableCreation_MVC.Models.Validation;

public static class ValidationColumns
{
    public static bool IsValid(string[] arr)
    {
        if (arr == null) return false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == null || arr[i] == "")
                return false;
            
            if (arr[i].Length > 30)
                return false;
            
            if (new[] {'#','$','*'}.Any(c => arr[i].Contains(c)))
                return false;
        }
        return true;
    }
}