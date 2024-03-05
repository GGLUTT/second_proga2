using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
       
        var dic = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object> {{"id", 1}, {"success", true}, {"name", "Oleh"}},
            new Dictionary<string, object> {{"id", 2}, {"success", false}, {"name", "Roma"}},
            new Dictionary<string, object> {{"id", 3}, {"success", true}, {"name", "Sasha"}}
        };

     
        var successCount = dic.Count(d => d.ContainsKey("success") && d["success"] is true);   // Виконуємо пошук і підрахунок словників, де success == True

        Console.WriteLine($"Кількість словників з 'success == True': {successCount}");
    }
}
