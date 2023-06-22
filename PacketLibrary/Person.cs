namespace PacketLibrary;

using static System.Console;
public class Person : Object , IComparable<Person>
{

    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Childern = new();

    public  event EventHandler? Shout;

    public int AngerLevel;

    public void Poke(){
        AngerLevel++;
        if(AngerLevel >=3){

            if(Shout!=null)
               Shout(this, EventArgs.Empty);
        }
    }
    public void TimeTravel(DateTime when){
        if(when <=DateOfBirth){
            throw new PersonException("if you travel back in time to a date earlier than your own birth, then the universe will explode");

        }
        else{
            WriteLine($"Welcome to {when:yyyy}");
        }
    
    }

    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}";
    }

    public void writeToConsole(){

        WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
    }

    public static Person ProCreate( Person p1,Person p2){

        Person baby = new(){
            Name=$"Baby of {p1.Name} and {p2.Name}"
        };
        p1.Childern.Add(baby);
        p2.Childern.Add(baby);
        return baby;
    }

    public Person ProCreateWith (Person partner){
        return ProCreate(this, partner);
    }

    public static Person operator *(Person p1, Person p2){
        return ProCreate(p1, p2);
    }

    public static int Factorial(int number){

        if(number <0){
            throw new ArgumentException($"{nameof(number) } cannot be less than zero");
        }
        return localFactorial(number);

        int localFactorial(int localNumber){

            if(localNumber <1)return 1;

            return localNumber * localFactorial(localNumber - 1);
        }
    }

    public int CompareTo(Person? obj)
    {
        if(Name is null)return 0;
        return Name.CompareTo(obj?.Name);
    }
}
