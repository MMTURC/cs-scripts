string message = "Hello World!";

string upperCaseMessage = message.ToUpper(); // ToUpper function takes our message and prints all the characters in uppercase

Console.WriteLine(upperCaseMessage);


// Adding escape sequences to strings


string a = "This creates a tab\t";

Console.WriteLine(a);


string backslash = "\\\\ This is for back\\ slahes\\";

Console.WriteLine(backslash);

// We can also use @ to print verbatim string

string atSymbol = @"\\ This will print regardless and cant \ accept escape sequences\";

Console.WriteLine(atSymbol);

// Raw String literal

string raw = """<file path="C:/temp/local/attach.txt" """;

Console.WriteLine(raw);


// String concatination

// string ab = "Poop";

// string ac = "Smell";

// string message = ab + ac;

// We can also just do

// string smellPoop = "Smell" + "Poop";


string number = "a" + 7; // int is converted to a string using ToString()

Console.WriteLine(number);

