using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


public class Task
{
    public string text { get; set; }
    public int answer { get; set; }

    public string tip { get; set; }
}


public class ParseJson
{
    public static List<Task> ReadFile()
    {
        const string filepath = @"Assets/Data/tasks.json";

        // Чтение файла
        var json = File.ReadAllText(filepath);
        List<Task> r = JsonConvert.DeserializeObject<List<Task>>(json);

        return r;
    }
    
}
