using System;

namespace GuessingGameInfininte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int correctNumber = rnd.Next(1, 10);
           // int guess = 0;
          //  Console.WriteLine("Guess a number between 1 and 10");



           // while (guess != correctNumber)
            {
               // string input = Console.ReadLine();
               // if (!int.TryParse(input, out guess))
                    //Console.WriteLine("Please write a number");


               // if (guess != correctNumber)
                {
                  //  Console.WriteLine("Wrong number");

                }


                

            }

            // Console.WriteLine("You Win");
            Random random = new Random();
            int correctNumber = random.Next(1, 10);
            bool loopactive = true;
            while (loopactive)
            {
                Console.WriteLine("vali number 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne oled võitnud");
                }
            



            }
            
        
        }

    }
}
