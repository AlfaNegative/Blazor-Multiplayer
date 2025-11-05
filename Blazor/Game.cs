using System.Timers;

public class Game
{
    public readonly Guid Id = Guid.NewGuid();
    public event Action? GameUpdated;
    public int TickNumber { get; set; }
    private System.Timers.Timer? tickTimer = null;
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public void DoTick(object sender, ElapsedEventArgs e)
    {
        TickNumber++;
        Console.WriteLine("Did Tick " + TickNumber);

        GameUpdated?.Invoke();
    }
    public void StartGame()
    {
        if (tickTimer != null) return;
        tickTimer = new System.Timers.Timer(1000);
        tickTimer.Elapsed += DoTick;
        tickTimer.AutoReset = true;
        tickTimer.Enabled = true;
    }


}