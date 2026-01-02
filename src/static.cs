// This script displays instance vs static members

Panda p1 = new Panda("Pan dah");
Panda p2 = new Panda("Pan Duh");

Console.WriteLine(p1.Name); // Pan dah
Console.WriteLine(p2.Name); // Pan duh

Console.WriteLine(Panda.Population); // 2


public class Panda{

	public string name;  // Insance field

	public static int Population; // Static Field


	public Panda(string n){ // Method

		Name = n; // Instance field
		Population = Population + 1; // Static field

	}




}

/*

Instance members are particular data to that object
Static members are shared across all objects
So in this case Population field refers to ALL instances
While name is referred to each individual instance

By default members are instance members


**An instance member is like your name, a static member is like your country.


We can use instance members when the data is specific to that object
Use static members for shared logic or tracking across all objects


*/
