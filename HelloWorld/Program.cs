namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice d = new Dice(new RandomDice());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(d.Roll());
            }
            Console.ReadLine();
        }
    }
}