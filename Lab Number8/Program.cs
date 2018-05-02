using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class.");

            string[] numbersArray = { "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20" };

            string[] names =
            {
                "Angela",
                "Bob",
                "Cathy",
                "Daryl",
                "Erica",
                "Frank",
                "Gayle",
                "Harry",
                "Ilene",
                "Jack",
                "Karyn",
                "Larry",
                "Mary",
                "Nick",
                "Ola",
                "Patrick",
                "Qiara",
                "Ronald",
                "Samantha",
                "Travis"
            };

            string[] towns =
            {
                "Appleton",
                "Broderick",
                "Castleton",
                "Detroit",
                "Easton",
                "Fullerton",
                "Georgetown",
                "Hockey",
                "Illinois",
                "Jackson",
                "Keaton",
                "Lansing",
                "Minneapolis",
                "Nickelson",
                "Ottowa",
                "Persian",
                "Quebec",
                "Rosedale",
                "Sarasota",
                "Townsville",
            };

            string[] foods =
            {
                "Apricots",
                "Blueberries",
                "Cherries",
                "Durian",
                "Elderberries",
                "Figs",
                "Grapes",
                "Honeydew",
                "Imbe",
                "Java Apple",
                "Kiwi",
                "Lime",
                "Orange",
                "Pear",
                "Quince",
                "Raspberries",
                "Strawberries",
                "Tangerine",
            };
            while (true)
            {


            Console.WriteLine("Which student would you like to learn more about?(enter a number 1-20)");
            string input = Console.ReadLine();



                int index;
                int.TryParse(input, out index);

                index--;

                if (index >= 0 && index < names.Length)
                {

                    Console.WriteLine($" What would you like to know about {names[index]}? (enter hometown or food)");
                    string responseOne = Console.ReadLine();
                    while (responseOne != "hometown" && responseOne != "food")
                    {
                        Console.WriteLine("The data does not exist. Please try again. (enter \"hometown\" or \"food\"");
                        responseOne = Console.ReadLine();
                    }
                    if (responseOne == "hometown")
                    {
                        Console.WriteLine($"{names[index]} is from { towns[index]}. Would you like to know more? (Y/N)");
                        if (Console.ReadLine() == "Y")
                        {
                            Console.WriteLine($"{names[index]} favorite food is { foods[index]}");
                            Console.ReadLine();
                     
                        }
                    }
                    else if (responseOne == "food")
                    {
                        Console.WriteLine($"{names[index]} favorite food is { foods[index]}Would you like to know more? (Y/N)");
                        if (Console.ReadLine() == "Y")
                        {
                            Console.WriteLine($"{names[index]} hometown is {towns[index]}");
                            Console.ReadLine();

                        }

                    }

                }
                else
                {
                    Console.WriteLine("Sorry, your input is invalid.");
                    continue;
                }
                Console.WriteLine("Would you like to enter another number? (Y/N)?");
                string response = Console.ReadLine();
                {
                    if (response.ToLower() == "n")
                    {
                        Console.WriteLine("Thanks!");
                    }
                    
                }
            }

        }
    }
}
