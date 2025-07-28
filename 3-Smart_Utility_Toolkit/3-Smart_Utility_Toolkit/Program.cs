Console.WriteLine(" Welcome to the Smart Utility Toolkit!");

GreetUser("Dennis");

Console.WriteLine("\n Let's calculate a tip:");
double billAmount = 2500;
double tipPercentage = 10;
double tip = CalculateTip(billAmount, tipPercentage);
Console.WriteLine($"For a bill of KES {billAmount}, a {tipPercentage}% tip is: KES {tip}");

Console.WriteLine("\n Let's convert temperature:");
double celsius = 30;
double fahrenheit = ConvertToFahrenheit(celsius);
Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

Console.WriteLine("\n Let's find the max of two numbers:");
int max = GetMax(14, 27);
Console.WriteLine($"The larger number is: {max}");

Console.WriteLine("\n Let's use an optional greeting:");
GreetUser(); // Using default parameter

Console.WriteLine("\n Thanks for using the Toolkit!");
    

    // Method 1: Simple method with parameter
//    static void GreetUser(string name)
//{
//    Console.WriteLine($" Hello, {name}!");
//}

//Method 2: Method with default parameter (optional)
static void GreetUser(string name = "Code Explorer")
{
    Console.WriteLine($" Good day, {name}!");
}

// Method 3: Method with return type
static double CalculateTip(double amount, double percentage)
{
    return amount * (percentage / 100);
}

// Method 4: Temperature conversion
static double ConvertToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

// Method 5: Find max of two numbers
static int GetMax(int a, int b)
{
    return a > b ? a : b;
}
