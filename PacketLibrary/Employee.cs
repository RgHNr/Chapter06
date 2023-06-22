using static System.Console;

namespace PacketLibrary;

public class Employee : Person
{

    public string? EmployeeCode { get; set; }

    public DateTime HireDate { get; set; }

    public new void writeToConsole(){

        WriteLine("{0}, was born on {1:dd/mm/yy} and hired on {2:dd/mm/yy}",


        arg0:Name, arg1:DateOfBirth,arg2: HireDate);
    }

    public override string ToString()
    {
        return $"{Name}'s code is {EmployeeCode}";
    }
}