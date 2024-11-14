using System;

namespace ClassWorkConsoleApp
{
    public class CoinFlip
    {
        private Random random = new Random(2);

        public string Flip()
        {
            int result = random.Next(2);

            return result == 1 
                ? "Heads" 
                : "Tails";
        }

        public void FlipMultipleCoins(int numFlips)
        {
            for (int i = 0; i < numFlips; ++i)
            {
                Console.WriteLine(Flip());
            }
        }
    }

    class Program
    {
        static void Main()
        {
            CoinFlip coinFlip = new CoinFlip();

            Console.Write("Enter the number of coin flips: ");
            int numFlips = int.Parse(Console.ReadLine());

            coinFlip.FlipMultipleCoins(numFlips);
        }
    }
}
