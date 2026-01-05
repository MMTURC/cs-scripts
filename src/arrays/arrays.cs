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
