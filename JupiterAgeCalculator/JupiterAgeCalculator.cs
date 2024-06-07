using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterAgeCalculator
{
    internal class JupiterAgeCalculator
    {
        static void Main(string[] args)
        {
            //Introduces the user to the program
            Console.WriteLine("Ever wondered what age you would be on Jupiter?  Here's your chance! \nEnter your age on Earth: ");
            
            //Assigning User input to variable
            int earthAge = Convert.ToInt32(Console.ReadLine());
            
            //Assigning length of time in Earth years for Jupiter years
            double jupiterYears = 12.0;

            //Forumula for converting age on Earth to age on Jupiter.  Also rounding the age to the nearest 100th decimal.
            double jupiterFormula = Math.Round((earthAge / jupiterYears), 2);

            //Outputting Results to the user
            Console.WriteLine("You are " + jupiterFormula + " years old on jupiter!");

            //Keeps cmd prompt open till the user presses any key to exit.
            Console.ReadLine();

            
            

        }
    }
}
