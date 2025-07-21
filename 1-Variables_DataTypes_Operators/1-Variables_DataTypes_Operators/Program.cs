// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Data Types in C#
//Value Types
//int, float, double, char, bool, decimal

//Reference Types
//string, object, arrays, classes

//Declaring Variables
//Declaration: type variableName = value;

//Example

int age = 25;
double price = 20.57;
string name = "Denis";

//Use meaningful names (camelCase/PascalCase for variables)
string firstName = "Denis";
string lastName = "Wachira";
string FirstName = "John";

Console.WriteLine($"My fullname is {firstName} {lastName}");
Console.WriteLine("My fullname is " + firstName + " " + lastName);

//Use const for constants

const double pi = 3.142;

//Operators

//Arithmetic Operators
//Operators: +, -, *, /, %

int number1 = 10; int number2 = 20;

Console.WriteLine(number1 + number2);
// Fix for CA2241: Provide correct arguments to formatting methods
// The issue is that Console.WriteLine("Sum is", number1 + number2) does not use a proper format string.

// Corrected line with proper format string
Console.WriteLine("Sum is {0}", number1 + number2);
Console.WriteLine("Subraction is {0}", number2 - number1);
Console.WriteLine("Multiplication is {0}",number2 * number1);
Console.WriteLine("Modulous is {0}",number2 % number1);

//Relational Operators 
//Operators: ==, !=, >, <, >=, <=
int marks = 70;
bool isPass = marks >= 50;
Console.WriteLine("Passed: " + isPass);

//Logical Operators
//Operators: && (AND), || (OR), !(NOT)

bool isAdult = true;
bool hasID = false;
bool canEnter = isAdult && hasID;

Console.WriteLine("Allowed: " + canEnter);


//Coffee Order App
string customer = "Ali";
int cupsOrdered = 3;
double pricePerCup = 2.5;
double total = cupsOrdered * pricePerCup;

Console.WriteLine($"{customer} ordered {cupsOrdered} cups. Total: ${total}");

