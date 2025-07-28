// See https://aka.ms/new-console-template for more information

Console.WriteLine("Methods and Parameters");

//Why Use Methods?
//Organize code into logical blocks

//Avoid repetition (DRY principle)

//Improve readability and maintenance

//Enable code reuse across apps

//Declaring and Calling Methods

void GreetUser()
{
    Console.WriteLine("Hello Trainees");
}

//void means it returns nothing


GreetUser();

//Methods with Parameters
void SayHello(string name)
{
    Console.WriteLine($"Hello, {name}");
}


//calling
SayHello("John");
SayHello("Denis");

//Return Values

int addTwoNumbers(int num1,int num2){
    return num1 + num2;
}

int result = addTwoNumbers(1,2);
int result2 = addTwoNumbers(10, 50);
Console.WriteLine($"The addition of two numbers is: {result}");
Console.WriteLine($"The addition of two numbers is: {result2}");

//Method Overloading 
//Same method name, different parameter types or count

int Multiply(int x, int y) => x * y;
//double Multiply(double x, double y) => x * y;


int result3 = Multiply(1,2);
Console.WriteLine($"Multiplication is: {result3}");

double result4 = Multiply((int)10.00, (int)20.00);
Console.WriteLine($"Multiplication is: {result4}");

//Optional Parameters
void PrintMessage(string msg = "Hello from Trainer Wachira")
{
    Console.WriteLine(msg);
}

PrintMessage();            // Uses default
PrintMessage("Hi Denis!"); // Uses given value

