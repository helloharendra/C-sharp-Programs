using System;

namespace Harendra
{
    class Prajapati
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Please select from the following");
            Console.WriteLine("1.Red");
            Console.WriteLine("2.Green");
            Console.WriteLine("3.Yellow");
            Console.WriteLine("Enter your choice");
            int ch=Convert.ToInt16(Console.ReadLine());
            switch(ch){
                case 1: Console.WriteLine("You Selected : Red " );
                    break;
                case 2:
                    Console.WriteLine("You Selected : Greed");
                    break;
                case 3:
                    Console.WriteLine("You Selected : Yellow ");
                    break;
                default: Console.WriteLine("Wrong Selection Try again");
                    break;
            }
           
            }
        }
    }