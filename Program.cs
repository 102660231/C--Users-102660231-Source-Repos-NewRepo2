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
            int rollthrow = 0;

            // set initial length for array a
            int x = 0;
            string Answer = "Y";

            bool endroll = false;
            int counter = 0;
            //int rollcounter = 0;

       
            while (endroll==false)
            {
                Random dies = new Random();
                int Number = dies.Next(1, 7);
                rollnum = Number;

                Console.WriteLine("  system rolled number is : " + Number + "");
                Console.WriteLine("  DO you want to roll your number  Y/N? ");
                Answer = Console.ReadLine();
                Answer = Answer.ToUpper();
                if (Answer == "Y")
                {

                    Random dies1 = new Random();
                    int Number1 = dies1.Next(1, 7);
                    Console.WriteLine("          your rolled number is :" + Number1 + " ");
                   
                    Console.ReadKey();
                    rollnum = Number1;
                    
                }
                counter++;

                

                x++;

                Console.Write("DO you want to continue to continue to  ? Y/N   ");
                Answer = Console.ReadLine();
                Answer = Answer.ToUpper();

                if (Answer=="N")
                {

                    sum = sum + rollnum;

                    averagesum = (sum / counter);
                    Console.WriteLine("sum : " + sum + "  " + "average: " + averagesum + " ");
                    Console.ReadKey();
                    Console.WriteLine("End of roll !")
                    endroll = true;              
                }
            }
            int row1 = 0;
            int col1 = 0;

            int die1 = 0;
            int die2 = 0;
            int[,] sums = new int[row1, col1];
            Random num = new Random();

            

           // for (int i = 0; i < x; i++) 
           // {
            //    Console.Write("{0},value[i]");
              //  Console.ReadKey();
           // };

        }   

    }
}
