// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

// OOP Class
public class HelloWorld
{
    string color;  // private
    string model;  // private

    private string year;
    // getter and setter for private year field
    public string Year
    { set; get; } // shorthand for get and set
                  // constructor
    public HelloWorld(string c, string m)
    {
        color = c;
        model = m;
    }

    // method
    public void MyMethod(string model, string color)
    {
        Console.WriteLine("I just got executed! " + model + " " + color);
    }
    public static void Main(string[] args)
    {
        MyMethod(age: 23, name: "Bilal");
        MyMethod("Bilal");
        int age = 23;
        const double pi = 3.14;
        type casting
        double avg = 9.4;
        int newAvg = Convert.ToInt32(avg);
        string name = Console.ReadLine();
        string firstName = "John";
        string lastName = "Doe";
        string fullName = string.Concat(firstName, lastName);
        string fullName = $"My full name is: {firstName} {lastName} ";
        string subname = fullName.Substring(10);
        string result = (age > 20) ? "Above 20" : "Below 20";
        Console.WriteLine(result);
        while (age > 0)
        {
            Console.WriteLine(age);
            age--;
        }
        string[] names = { "Bilal", "Ahmed" };
        Array.Sort(names);
        string[] ages = new string[1];
        foreach (string i in names)
        {
            Console.WriteLine(i);
            ages[0] = "23";
            Console.WriteLine(ages.Length);
        }
        int[,] numbers = { { 1, 4, 2, 3 }, { 3, 6, 8, 4 } };
        Console.WriteLine(numbers[0, 2]);
        Console.WriteLine(numbers.GetLength(0));

        // OOP
        HelloWorld red = new HelloWorld("Red", "2023"); // class object
        HelloWorld blue = new HelloWorld("Blue", "1999"); // class object

        // without constructor
        red.color = "red";
        red.model = "2023";
        blue.color = "blue";
        blue.model = "2021";

        red.Year = "202";

        Console.WriteLine(red.color);
        Console.WriteLine(red.Year);
        Console.WriteLine(blue.model);
        Obj.MyMethod("Red", "2021");
    }
}

class Hello : HelloWorld  // derived class (child)
{
    public string modelName = "Mustang";  // Hello field
}
// If you don't want other classes to inherit from a class, use the sealed keyword:

// polymorphism
class Animal  // Base class (parent) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
class Dog : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Dog myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myDog.animalSound();

        // this is the maximum value we store in int data type
        int num = 2147483647;
        Console.WriteLine(num + 1);
    }
}