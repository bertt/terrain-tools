
namespace terrain_tools;
public class Rootobject
{
    public string tilejson { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string version { get; set; }
    public string format { get; set; }
    public string attribution { get; set; }
    public string schema { get; set; }
    public string[] extensions { get; set; }
    public string[] tiles { get; set; }
    public string projection { get; set; }
    public float[] bounds { get; set; }
    public Available[][] available { get; set; }
}

public class Available
{
    public int startX { get; set; }
    public int startY { get; set; }
    public int endX { get; set; }
    public int endY { get; set; }
}
