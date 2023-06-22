using static System.Console;

//int thisCannotBeNull = 4;
//thisCannotBeNull = null;

int? thisCanbeNull = null;

WriteLine(thisCanbeNull);
WriteLine(thisCanbeNull.GetValueOrDefault());

thisCanbeNull = 9;
WriteLine(thisCanbeNull);

Address address = new();
address.Building = null;
address.street = null;
address.City = "London";
address.Region = null;




class Address{

    public string? Building;
    public string street=string.Empty;
    public string City=string.Empty;
    public string Region=string.Empty;
}




