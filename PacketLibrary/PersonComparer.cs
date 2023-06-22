namespace PacketLibrary;
public class PersonComparer: IComparer<Person>
{

    public int Compare(Person? x, Person? y){

        if(x == null || y == null) 
            return 0;

        int result = x.Name.Length.CompareTo(value: y.Name.Length);

        if (result==0)
            return x.Name.CompareTo(y.Name);

        else
            return result;

    }

    
}