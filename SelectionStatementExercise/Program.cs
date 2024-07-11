namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNum = 16;

            Console.WriteLine("Please guess my favorite number...");
            int guess = int.Parse(Console.ReadLine());

            if (guess == favNum)
            {
                Console.WriteLine("You guessed it!!!");
            }
            else if (guess < favNum)
            {
                Console.WriteLine("too low");  
            }
            else
            {
                Console.WriteLine("too high");
            }
        }
    }
}
