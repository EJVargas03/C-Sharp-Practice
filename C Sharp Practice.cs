Console.WriteLine("Hello");
Console.Write.Line(" World");
//Items printed out with .WriteLine will prints the -
// - output on the existing line and appends a new line after it.

//WriteLine() part is called a method. because it has a set of parentheses after it. 

Console.Write("Hello");
Console.Write(" World");
//Items printed out with .WriteLine will print on the same Line

Console.WriteLine('b');
//char varaible
// - single character ex. a, A, b, B, and so on
// - single quotation

//Note: double quotation " " create a string data type

//Console.WriteLine('Hello World');
//will promp an error since it is not a single character
//error CS1012: Too many characters in character literal

Console.WriteLine(123);
//int literal or "integer" data type
//requires no other operators like the string or char.

Console.WriteLine(0.25F);
//Created a float literal, append the letter F. 
//F tells the compiler you wish to work with a value of float
//best used for fixed fractions

Console.WriteLine(2.625);
//Create a double literal, aka decimal number.

Console.WriteLine(12.39816m);
//Create a decimal literal, append the letter m
//m tells the compiler you wish to work with a value of decimal type.

//Float Type    Precision
//----------------------------
//float         ~6-9 digits
//double        ~15-17 digits
//decimal        28-29 digits

//string for words, phrases, or any alphanumeric data for presentation, not calculation
//char for a single alphanumeric character
//int for a whole number
//decimal for a number with a fractional component
//bool for a true/false value

//string firstName;
//creating a new variable of type string called firstName
//firstName = "Bob";
//Giving the variable the value of "Bob"
//Console.WriteLine(firstName);
//Printing out/calling the variable firstName

string firstName = "Bob";
Console.WriteLine(firstName);
//you can perform both the declaration and setting the value of the variable in one line of code.

firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
//You can reuse and reassign the variable as many times as you want.

char userOpition;
int gamescore;
decimal particlesPerMillion;
bool processedCustomer;
//Creating variable using different data types

var message = "Hello World!";
Console.WriteLine(message);
//message is immediately set to the string value

