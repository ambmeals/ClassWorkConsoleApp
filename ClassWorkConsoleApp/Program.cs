Random random = new Random(2);

Console.Write("Enter the number of coin flips: ");
int numFlips = int.Parse(Console.ReadLine());

for (int i = 0; i < numFlips; ++i)
    Console.WriteLine(CoinFlip(random));

string CoinFlip(Random random)
{
    int result = random.Next(2);

    return (result == 1) 
        ? "Heads" 
        : "Tails";
}