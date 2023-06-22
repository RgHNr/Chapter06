namespace PacketLibrary;
using static System.Console;
public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine(" Dvd plaer is pausing");
    }

    public void Play()
    {
        WriteLine("DvD player is playing");
    }
}