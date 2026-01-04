using System;

UnitConverter feetToInches = new UnitConverter(12);

UnitConverter milesToFeet = new UnitConverter(4030);


Console.WriteLine(feetToInches.Convert(30));

Console.WriteLine(feetToInches.Convert(100));

Console.WriteLine(milesToFeet.Convert(3000));




public class UnitConverter{

	int ratio; // field


	// Constructor
	public UnitConverter (int unitRatio){

		ratio = unitRatio;
	}




	public int Convert(int unit) // method
	{
		return unit * ratio;
	}

}

// Example of class + Constructor

public class Foo {

	int poop;
	double values;

	// Constructor
	public Foo(int choose)
	{
		choose = poop;

	}

}


// Note:
/*

When we create a new instance of a class, the constructor initializes the object



*/
