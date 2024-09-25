using System.Threading.Channels;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int myAge = 37;
            string myName = "Joakim";
            Console.WriteLine($"My name is {myName} and I'm {myAge} years old!");
            
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine("1. Mät upp 5,5 dl mjöl.\n2. Smula ner jästen.");

            float flo = 5.5f;
            decimal dec = 5.5m;

            Console.WriteLine("\nAnge pris exklusive moms:");
            int prisExMoms = int.Parse(Console.ReadLine());
            decimal prisMedMoms = prisExMoms + (prisExMoms * 0.06m);
            Console.WriteLine($"Pris inklusive moms: {prisMedMoms}");
            //Annan lösning
            *//*decimal prisExMoms = decimal.Parse(Console.ReadLine());
            decimal prisMedMoms = prisExMoms + (prisExMoms * 0.06m);*//*

            Console.WriteLine("\nRäkna ut omkretsen på en rektangel.\nLängd:");
            double langd = double.Parse(Console.ReadLine());
            Console.WriteLine("Bredd:");
            double bredd = double.Parse(Console.ReadLine());
            double omkrets = (langd + bredd) * 2;
            Console.WriteLine($"Omkrets: {omkrets}");
            double area = langd * bredd;
            Console.WriteLine($"Area: {area}");

            int number = 10;
            if(number > 10)
            {
                Console.WriteLine("Bigger then 10!");
            }
            else if(number < 10)
            {
                Console.WriteLine("Smaller then 10!");
            }
            else
            {
                Console.WriteLine("Equal to 10!");
            }

            int number2 = 20;
            switch(number2)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 15:
                    Console.WriteLine("15");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            int number3 = 5;
            string helloNumber = number3 > 5 ? "Bigger" : "Smaller";
            Console.WriteLine(helloNumber);

            string food1 = "Spagetti";
            string food2 = "Hamburger";
            string food3 = "Pancakes";
            Console.WriteLine($"\nWhat would you like to eat?\n1. {food1}\n2. {food2}\n3. {food3}");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"You picked {food1.ToLower()}!");
                    break;
                case "2":
                    Console.WriteLine($"You picked {food2.ToLower()}!");
                    break;
                case "3":
                    Console.WriteLine($"You picked {food3.ToLower()}!");
                    break;
                default:
                    Console.WriteLine("You didn't pick your food!");
                    break;
            }

            int loopNum = 0;
            while(loopNum < 10)
            {
                if(loopNum == 0)
                {
                    Console.WriteLine("\n");
                }

                loopNum++;
                Console.WriteLine(loopNum);
            }

            loopNum = 0;
            do
            {
                if (loopNum == 0)
                {
                    Console.WriteLine("\n");
                }

                loopNum++;
                Console.WriteLine(loopNum);
            }
            while (loopNum < 10);

            for(int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\n");
                }

                Console.WriteLine(i + 1);
            }*/

            /*Random random = new Random();
            int randomNum = random.Next(1, 10);
            while(true)
            {
                Console.WriteLine("Guess a number between 1 - 10!");
                int userGuess;                
                bool parseUserGuess = int.TryParse(Console.ReadLine(), out userGuess);

                if(parseUserGuess)
                {
                    if (userGuess == randomNum)
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong, guess again!");
                    }
                }
                else
                {
                    Console.WriteLine("Type a number!");
                }                
            }*/

            /*while (true)
            {
                Console.WriteLine("Type a number!");
                int userNumber;
                bool parseUserInput = int.TryParse(Console.ReadLine(), out userNumber);

                if (parseUserInput)
                {
                    if (userNumber > 0)
                    {
                        for(int i = 1; i < userNumber; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The number needs to be larger than 0!");
                    }
                }
            }*/

            /*Random random = new Random();
            int randomNum = random.Next(1, 50);
            int guessesLeft = 10;

            Console.WriteLine("Guess a number between 1 -50!");
            for(int i = guessesLeft; i > 0; i--)
            {
                int userNumber;
                bool parseUserInput = int.TryParse(Console.ReadLine(), out userNumber);

                if(parseUserInput)
                {
                    if(userNumber == randomNum)
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    else
                    {
                        if(i == 1)
                        {
                            Console.WriteLine($"Game Over!");
                            break;
                        }

                        Console.WriteLine($"Wrong! You have {i - 1} guess left!");
                    }
                }
            }*/

            /*double x = 1234.7;
            int a;
            a = Convert.ToInt32(x);
            Console.WriteLine(a);*/

            /*string firstNumber = "49";
            int converted = Int32.Parse(firstNumber);
            Console.WriteLine(converted + 1);*/

            /*string firstNumber = "49";
            string secondNumber = "51";
            int sum = int.Parse(firstNumber) + int.Parse(secondNumber);
            Console.WriteLine(sum + " " + sum.GetType());*/

            /*float gotgatan = 1.6f;
            int hornsgatan = 2;
            float sum = hornsgatan + gotgatan;
            Console.WriteLine($"Götgatan (antal km) + Hornsgatan (antal km) = {sum}");*/

            /*Console.WriteLine(
                "<!DOCTYPE html>\n" +
                "<html>\n" +
                "<body\n>" +
                "<h1>Välkomna!</h1>\n" +
                "<p>Kurs om C#</p>\n" +
                "<p>Kurs om Databaser</p>\n" +
                "<p>Kurs om Webbutveckling</p>\n" +
                "<p>Kurs om Clean code</p>\n" +
                "</body>\n" +
                "</html>"
           );*/

            string[,] personer = { { "Joakim", "37", "Student" }, { "Joline", "3", "Förskola" }, { "Oliver", "0.2", "Hemma" } };
            for(int i = 0; i < personer.GetLength(0); i++)
            {
                Console.WriteLine($"Person {i + 1}");
                for(int j = 0; j < personer.GetLength(1); j++)
                {
                    Console.WriteLine(personer[i,j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
