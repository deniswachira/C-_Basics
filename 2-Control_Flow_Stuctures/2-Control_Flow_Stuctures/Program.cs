// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Control Stuctures!");

//conditional logic using if, else if and else

//The if Statement

int score = 80;

if (score > 75)
    Console.WriteLine("Excellent");

//The if else Statement

int age = 16;

if (age > 18)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Sorry, you must be 18+.");
}

//if...else if...else statemnt 

int marks = 80;

if (marks >= 90)
    Console.WriteLine("Your Grade is A ");
else if (marks >= 80)
    Console.WriteLine("Your Grade is B ");
else if (marks >= 70)
    Console.WriteLine("Your Grade is C ");
else
    Console.WriteLine("You have Failed ");

//switch Statement
//Use switch when checking one variable against many values

int day = 3;

switch(day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Any other day");
        break;
}

//Loops – Repetition with Logic
//for loop ==> Best when you know how many times to repeat
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Line " + i);
}

//while Loop ==> Checks condition before each run
int num = 1;

while (num <= 3)
{
    Console.WriteLine("Try " + num);
    num++;
}

//do...while ==> Always runs at least once
int count = 0;
do
{
    Console.WriteLine("I’ll run at least once!");
    count++;
} while (count < 1);


//foreach ==> Great for arrays, lists, or collections
string[] names = { "Jane", "Ali", "John" };

foreach(string name in names)
{
    Console.WriteLine(name);
}

//Real - World Mini App
//Bus Fare Calculator
int age1 = 14;
int fare;

if (age1 <= 5)
    fare = 0;
else if (age1 <= 18)
    fare = 30;
else
    fare = 50;

Console.WriteLine($"Your fare is: KES {fare} because your age is {age1}");

//Practice Challenges
//FizzBuzz: Print numbers 1–20. If divisible by 3 → “Fizz”, by 5 → “Buzz”, both → “FizzBuzz”.

//Even or Odd: Ask user for a number and display if it's even/odd.

//Login Simulator: Loop until the user enters the correct password.

//Student Grader: Accept a student’s score and print the grade using switch


