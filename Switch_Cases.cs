using System;

namespace witch_Case
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");

            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1: Console.WriteLine("it is : "+num);
                    break;
                case 2: Console.WriteLine("it is : "+num);
                    break;
                case 3: Console.WriteLine("it is : "+num);
                    break;
                default:Console.WriteLine("not a  number in option please enter 1,2 or 3 ");
                    break;
            }
        }
    }
}
