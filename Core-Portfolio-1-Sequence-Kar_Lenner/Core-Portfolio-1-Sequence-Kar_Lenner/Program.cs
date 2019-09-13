using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Portfolio_1_Sequence_Kar_Lenner
	/* 
	 * Purpose: To calculate the compound interest accumulated from a deposit, factoring in:
     * the inital ammount, Interest rate, Number of years and Frequency of Compouding. 
	 * Inputs: Initial ammount (IA), Interest rate (IR), number of years (YR) , frequency of compounding (FR)
     * Outputs: The money in the account after the specified number of years. (Total) PW=The power in the equation.
     * Author: Kar Lenner A06
	 * Last Modified: 
	 */
{
	class Program
	{
		static void Main(string[] args)
		{
            double IA, IR, YR, FR, Total;
            
            
            Console.WriteLine("Please enter the ammount of your initial deposit.");
            IA = double.Parse(Console.ReadLine());

            //ask about a way to allow the user to input a % and have the program accept it//
            //ask about that annoying thing where typing is deleting previous text and find out if youre just an idiot who cant figure it out//
            //also delete these notes so you dont embarass yourself lmaooo//
            //OKAY i know the issue, the use is inputting 2.5 and the program isnt converting it to the corect format? 0.025 is what it should be//
            Console.WriteLine($"Your initial investment ammount is {IA:c} Please enter your interest rate in percent.");
            IR = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of times per year (1-12) that your interest is compounded.");
            FR = double.Parse(Console.ReadLine());

            Console.WriteLine("For how many years?");
            YR = double.Parse(Console.ReadLine());

            

            Total = IA * (1+IR/FR) * Math.Pow(FR,YR);


            Console.WriteLine($"You are earning an interest of {IR:n2}% anually, paid out {FR} time per year, for {YR} years, on your initial investment of {IA:C}.");
            //and how to input breaks//
            Console.WriteLine($"The ammount of money in your account after {YR} years is, {Total:C}");



        }
    }

    internal class A
    {
    }
}
