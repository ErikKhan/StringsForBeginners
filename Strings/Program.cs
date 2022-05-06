using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// To output values or print text in C#, you can use the WriteLine() method:
            //Console.WriteLine("Hello World");
            //Console.WriteLine("What is your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("What is your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //// You have already learned that Console.WriteLine() is used to output(print) values.Now we will use Console.ReadLine() to get user input.

            //Console.WriteLine("Hello, Good Morning MR " + name + " and your age is: " + age);
            //Console.WriteLine($"Hello Good Morning Mr {name} and your age is {age}");


            //Console.ReadLine();

            // True of False
            // Console.WriteLine("Enter a number: ");
            // int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("The number is: " + num);
            // bool isTrue = (num < 5 || num > 10 && num == 10);
            // Console.WriteLine(isTrue);

            //string userName = "James";
            //int phoneNumber = 1234;
            //Console.WriteLine("Enter the username: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your Phone Number: ");
            //int phone = Convert.ToInt32(Console.ReadLine());
            //bool isTrue = (name == userName || phone == phoneNumber);
            //Console.WriteLine(isTrue);

            // String Methods:
            string name = "    Hello World ";
            Console.WriteLine(name);
            Console.WriteLine($"The length of this string is: {name.Length}"); // Length of a string
            Console.WriteLine(name.ToUpper()); // To Upper
            Console.WriteLine(name.ToLower()); // To Lower
            Console.WriteLine(name[0]); // index of
            Console.WriteLine(name.IndexOf("W")); // index position
            Console.WriteLine(name.Substring(0,7)); // new string Hello w
            Console.WriteLine(name.Substring(8, 3)); 
            Console.WriteLine(name.Remove(8)); // removing at index 8
            Console.WriteLine(name.Replace("World", "Universe")); // Replacing all old word with the new word
            Console.WriteLine(name.Trim()); // Trim all the white spaces

            


            Console.ReadLine();








        }
    }
}