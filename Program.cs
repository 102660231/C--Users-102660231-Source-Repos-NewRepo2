using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)


        {

            int rollnum = 0;
            int sum = 0;
            int averagesum = 0;
          

            string Answer = "Y";

            bool endroll = false;
            int counter = 0;
            int rollnum3 = 0;
            int rollnum4 = 0;
       
            while (endroll==false)
            {
                Random dies = new Random();
                int Number = dies.Next(1, 7);
                rollnum = Number;
                Random dies3 = new Random();
                int Number3 = dies3.Next(1, 7);
                rollnum3 = Number3;

                Console.WriteLine("  system rolled number is : " + Number + "  .  "+Number3);
                Console.WriteLine("  DO you want to roll your number  Y/N? ");
                Answer = Console.ReadLine();
                Answer = Answer.ToUpper();

                if (Answer == "Y")
                {

                    Random dies1 = new Random();
                    int Number1 = dies1.Next(1, 7);
                    Random dies4 = new Random();
                    int Number4 = dies4.Next(1, 7);

                    Console.WriteLine("          your rolled number is :" + Number1 + " + "+Number4);
                   
                    Console.ReadKey();
                    rollnum = Number1;
                    rollnum4 = Number4;
                }
                counter++;

                //x++;

                Console.Write("DO you want to continue to continue to  ? Y/N   ");
                Answer = Console.ReadLine();
                Answer = Answer.ToUpper();

                if (Answer=="N")
                {

                    sum = sum + rollnum;
                   
                    averagesum = sum / counter;
                    Console.WriteLine("sum : " + sum + "  " + "average: " + averagesum + " ");
                    Console.ReadKey();
                    endroll = true;              
                }
            }
          

        }   

    }
}
