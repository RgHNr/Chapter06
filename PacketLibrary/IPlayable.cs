namespace PacketLibrary;
using static System.Console;
public interface IPlayable{

    void Play();
    void Pause();
    void Stop(){
        WriteLine("Default implementation of stop");
    }
}