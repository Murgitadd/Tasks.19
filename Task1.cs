using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

class Program
{
    private static List<string> names = new List<string>();

    static void Main(string[] args)
    {
        Add("Mrd /Kha");

        
        Console.WriteLine("Add");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

       
        Delete("John Doe");

        
        Console.WriteLine("RemovedList:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void Add(string name)
    {
        if (File.Exists("names.json"))
        {
            string json = File.ReadAllText("names.json");
            names = JsonSerializer.Deserialize<List<string>>(json);
        }

     
        names.Add(name);

 
        string updatedJson = JsonSerializer.Serialize(names);
        File.WriteAllText("names.json", updatedJson);
    }

    static void Delete(string name)
    {
      
        if (File.Exists("names.json"))
        {
            string json = File.ReadAllText("names.json");
            names = JsonSerializer.Deserialize<List<string>>(json);
        }

        
        names.Remove(name);

       
        string updatedJson = JsonSerializer.Serialize(names);
        File.WriteAllText("names.json", updatedJson);
    }
}
