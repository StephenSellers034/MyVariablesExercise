namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int age = 23;
        string name = "Bob";
        char gender = 'M';
        bool overAge = true;
        double price = 59.99;
        decimal tax = 4.5m;


        Console.WriteLine(
            $"{name} is {age} years old. {name} is a {gender}. {name} will have to pay {price} with a tax percentage of {tax} if he wants to preorder the newest GTA. But today is special if {name} is over 21 which is {overAge} everything in store is half off with proof of age.");

        Console.Write("Enter your name: ");

        string userName = Console.ReadLine();

        Console.WriteLine("Hello, " + userName + "! Did you enjoy the story of Bob going shopping?");

        Console.Write("Enter your answer: ");
        
        string userAnswer = Console.ReadLine();
        
        Console.WriteLine(userName +  " answered " + userAnswer +"!");
    }
}
