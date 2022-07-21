using ProfileAPI.Models;

namespace ProfileAPI.Services;

public class PingService
{
    public PingService()
    {

    }

    public static Ping ReturnPing()
    {
        Ping ping = new Ping();
        DateTime now = DateTime.Now;

        ping.Summary = $"Healthy ping was sent at {now}";
        ping.Successful = true;
        ping.Date = now;

        return ping;
    }
}
