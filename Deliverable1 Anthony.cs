using System;

namespace Feed_the_neighborhood
{
    class MainClass
    {
        static void Main(string[] args)
        
        {
            string UserChoice = string.Empty;
            do
            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                string people = Console.ReadLine();
                int num1 = int.Parse(people);
                int slices = num1 * 2;
                Console.WriteLine("Total slices of bread needed is " + slices);

                int tbspb = num1 * 2;
                Console.WriteLine("Total tablespoons of peanut butter needed is " + tbspb);

                int tspjelly = num1 * 4;
                Console.WriteLine("Total teaspoons of jelly needed is " + tspjelly);

                Console.WriteLine("Which is...");

                decimal loaves = slices / 28M;

                decimal jarspb = tbspb / 32M;

                decimal jarsjelly = tspjelly / 48M;

                loaves = Math.Ceiling(loaves);
                Console.WriteLine("Total number of loaves needed " + loaves);

                jarspb = Math.Ceiling(jarspb);
                Console.WriteLine("Total jars of peanut butter is " + jarspb);

                jarsjelly = Math.Ceiling(jarsjelly);
                Console.WriteLine("Total jars of jelly is " + jarsjelly);


                do
                {
                    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (true);
                } while (UserChoice != "YES" && UserChoice != "Y");
                } while (true);
            do
            {
                Console.WriteLine("Goodbye!");
            } while (true);
                

        }

    }
}