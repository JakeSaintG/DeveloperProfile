namespace ProfileAPI.Models;

public class Ping
{
    public DateTime Date { get; set; }

    public bool Successful { get; set; }

    public string? Summary { get; set; }
}