using System.ComponentModel;

char[] hello = new char[5];

hello[0] = 'h';
hello[1] = 'e';
hello[2] = 'l';
hello[3] = 'l';
hello[4] = 'o';

Console.WriteLine(hello[0]); // prints h

for (int i = 0; i < hello.Length; i++)
{
    Console.WriteLine(hello[i]);
}


// we can also just use a one liner

foreach (char h in hello) Console.WriteLine(h);

// Multi-Dimensional arrays

// The following is how to decalre a rectangular array 

var rectMatrix = new[,]
{
    {0,1,2},
    {3,4,6},
    {10,11,3}
};

var jaggedMatrix = new int[][]{
    new[] {2,3,5},
    new[] {4,4,8},
    new[] {5,6,8},

};