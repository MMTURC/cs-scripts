// We can define a custom value type using structs




Point p1 = new Point();
p1.X = 7;

Point p2 = p1;  // assignment causes copy

Console.WriteLine(p1.X);

Console.WriteLine(p2.X);


p1.X = 10;

Console.WriteLine(p1.X);


Console.WriteLine(p2.X); 

p2.X = 15;

Console.WriteLine(p2.X);

// Now p2.X will be 15 instead of 7


/*

    If we were to print this the output would be
    7
    7
    10
    7
    When we change the value of p1.X, p2.X stays the same due to it being a copy 
    We need to explicity change the value of p2.X in order for it carry

*/













public struct Point{ public int X, Y ;}




