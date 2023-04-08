//Grading ID: S0941
//CIS 199-02
//Lab 5
//Due: (3/7/21)
//The application continuously prompts the user for a series of daily high temperatures (as integers) until the user enters a sentinel value of 999. 
//Valid temperatures range from -20 through 130 Fahrenheit (inclusive)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double temp = 0; //stores temp as a number
            double sum = 0; //stores sum of the numbers input
            double average = 0; //stores average
            int count = 0; //stores count of numbers input
            string temperature = ""; //stores temp input string
            bool isNumeric; // tests if input is numeric

            WriteLine("Enter temperatures from -20 to 130(999 to stop)");
            while(true) //creates loop to keep running until sentinel number is entered
            {
                Write("Enter temperature: ");
                temperature = ReadLine(); //sets temperature input as the value for temperature

                isNumeric = double.TryParse(temperature, out temp); //parses temperature into temp if the value is numeric

                if(isNumeric) //tests for a number
                {
                    temp = Convert.ToDouble(temperature); //converts temperature strin input into a number

                    if (temp >= -20 && temp <= 130) // checks number to see if its in the valid range
                    {
                        sum = sum + temp; //adds the new number to the sum
                        count++; //add oen to the count
                    }
                    else if (temp == 999) //checks to see if sentinel value has been entered
                        break; // ends loop
                    else
                        WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                }
                else
                    WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");

            }
            average = sum / count; //calculates average of numbers entered

            average = Math.Round(average, 1); //displays average to one digit of precision

            WriteLine("You entered " + count + " valid temperatures.");
            WriteLine("The mean temperature is " + average + " degrees.");

            ReadKey();

        }
    }
}
