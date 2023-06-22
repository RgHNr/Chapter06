using static System.Console;

internal class Program
{

    private static void Main(string[] args)
    {
        
        Rectangle r = new(height: 3, width: 4.5f);
        //WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}"); 
        Square s = new(5);
        //WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area}"); 
        Circle c = new(rad: 2.5f);
        //WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}");

        

    }

    
}

struct Tree{

    public int age;

    public int CalculateSize(){

        return age * 3;
        
    }
}