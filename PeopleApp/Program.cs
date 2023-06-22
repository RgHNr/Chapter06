using PacketLibrary;

using static System.Console;

Person harry = new() { Name = "harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

Person baby1 = mary.ProCreateWith(harry);
WriteLine(baby1.Name);
baby1.Name = "Gary";
Person baby2 = Person.ProCreate(harry, jill);

Person baby3 = harry * jill;

WriteLine($"{harry.Name} has {harry.Childern.Count} chiildren");
WriteLine($"{mary.Name} has {mary.Childern.Count} children");
WriteLine($"{jill.Name} has {jill.Childern.Count} children");
WriteLine("{0}'s first child is named {1}",arg0:harry.Name,arg1:harry.Childern[0].Name);

WriteLine($"5! is {Person.Factorial(5)}");

static void Harry_Shout(object? sender, EventArgs e){

    if(sender is null)return;
    Person p = (Person)sender;
    //WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
}

harry.Shout += Harry_Shout;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

System.Collections.Hashtable lookUpObject = new();

Dictionary<int, string> lookUpString = new();


lookUpString.Add(key: 1, value: "Alpha");
lookUpString.Add(key: 2, value: "Beta");
lookUpString.Add(key: 3, value: "Gamma");
lookUpString.Add(key: 4, value: "Delta");
int key = 3;
WriteLine(format: "key {0} has the value of {1}", arg0: key, arg1: lookUpString[key]);

Person[] people = {
    new(){Name="Simon"},
    new (){Name="Jenny"},
    new (){Name="Adam"},
    new Person(){
        Name="Richard"
    }
};

WriteLine("Intial list of people");
foreach(var p in people){
    WriteLine(p.Name);
}

WriteLine("Use Peson's IComparer implementation to sort:");
Array.Sort(people,new PersonComparer());

foreach(var p in people){
    WriteLine(p.Name);
}

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);

DisplacementVector dv3 = dv1 + dv2;

WriteLine($"({dv1.x} , {dv1.y}) + ({dv2.x} , {dv2.y}) = ({dv3.x},{dv3.y})");

Employee john = new()
{
    Name = "John",
    DateOfBirth = new(year: 1990, month: 4, day: 5)

};

john.writeToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2023, month: 5, day: 1);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/mm/yy}");
WriteLine(john.ToString());
//you can only seal an overridden method

Employee AliceEmployee = new Employee()
{

    Name = "Alic",
    EmployeeCode = "AA123"

};
Person AliceInPerson = AliceEmployee;
AliceEmployee.writeToConsole();
AliceInPerson.writeToConsole();
WriteLine(AliceEmployee.ToString());
WriteLine(AliceInPerson.ToString());

if(AliceInPerson is Employee){

    WriteLine($"{nameof(AliceInPerson) } IS an Employee");
    Employee explicitAlic = (Employee)AliceInPerson;

}


try{
    john.TimeTravel(when: new(1999, 12, 31));
    john.TimeTravel(when: new(1950, 12, 23));
}
catch(PersonException ex){
    WriteLine(ex.Message);
}

string email1 = "plamela@test.com";
string email2 = "ian&test.com";

WriteLine("{0} is a valid e-mail address: {1}",arg0:email1,arg1:email1.IsValidEmail());

WriteLine("{0} is a valid e-mail address: {1}", arg0: email2, arg1: email2.IsValidEmail());

//a delegate is pointer to a method or a group of methods in case of multicast delegate

// is special type delegage that allows methods appending using +=

//the derived class inherits all base class parameters and methods unless prevented using access 
//modifeyers , for constructors it should be explcitly adding : base() beside the constructors

//is checks type only, as checks and sets

//sealed keyword

//static class

//virtual

//destuctor is called  when getting rid of an instance of a class, deconstuct is used to divide instance paratemter into pair values

//: base() 

//extension method is like an addon method for a class you define it using a static method that takes this instance 
//as a paramater and is usually in a static class
