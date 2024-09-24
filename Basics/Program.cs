namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myAge = 37;
            string myName = "Joakim";
            Console.WriteLine($"My name is {myName} and I'm {myAge} years old!");
            
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine("1. Mät upp 5,5 dl mjöl.\n2. Smula ner jästen.");

            float flo = 5.5f;
            decimal dec = 5.5m;

            Console.WriteLine("Ange pris exklusive moms:");
            int prisExMoms = int.Parse(Console.ReadLine());
            decimal prisMedMoms = prisExMoms + (prisExMoms * 0.06m);
            Console.WriteLine($"Pris inklusive moms: {prisMedMoms}");
            //Annan lösning
            /*decimal prisExMoms = decimal.Parse(Console.ReadLine());
            decimal prisMedMoms = prisExMoms + (prisExMoms * 0.06m);*/

            Console.WriteLine("Räkna ut omkretsen på en rektangel.\nLängd:");
            double langd = double.Parse(Console.ReadLine());
            Console.WriteLine("Bredd:");
            double bredd = double.Parse(Console.ReadLine());
            double omkrets = (langd + bredd) * 2;
            Console.WriteLine($"Omkrets: {omkrets}");
            double area = langd * bredd;
            Console.WriteLine($"Area: {area}");
        }
    }
}
