using System.Text.Json;

namespace terrain_tools;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var layer0 = "fixtures/layer_0.json";
        var layer1 = "fixtures/layer_1.json";

        var f0 = File.ReadAllText(layer0);
        var f1 = File.ReadAllText(layer1);

        var r0 = JsonSerializer.Deserialize<Rootobject>(f0);
        var r1 = JsonSerializer.Deserialize<Rootobject>(f1);

        var levels = r0.available;

        for(var l= 0; l<levels.Count(); l++)
        {
            var level = levels[l][0];

            level.startX = r1.available[l][0].startX < level.startX? r1.available[l][0].startX : level.startX;
            level.startY = r1.available[l][0].startY < level.startY ? r1.available[l][0].startY : level.startY;
            level.endX = r1.available[l][0].endX > level.startX ? r1.available[l][0].endX : level.endX;
            level.endY = r1.available[l][0].endY > level.endY ? r1.available[l][0].endY : level.endY;
        }

        var options = new JsonSerializerOptions();
        options.WriteIndented = true;
        var res = JsonSerializer.Serialize(r0, options);
        File.WriteAllText("layer.json", res);
    }
}


