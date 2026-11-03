static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var idText = (id == null) ? String.Empty : $"[{id}] - ";
        department = department ?? "owner";
        department = department.ToUpper();

        return $"{idText}{name} - {department}";
    }
}