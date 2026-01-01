using System;

Console.WriteLine(FeetToInches(12));

Console.WriteLine(FeetToInches(24));


int FeetToInches(int feet){

    int inches = feet * 12;
    return inches;


}

// When we don't need a method to return anything we can just use the void keyword before our method

void Hello(){
    Console.WriteLine("Hello World!");
}
