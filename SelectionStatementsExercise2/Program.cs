namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Excercise2();
        
                    
            
        
        }


        public static void Excercise2()
        {
            Console.WriteLine("What is your favorite subject: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "math":
                    Console.WriteLine("Math is cool");
                    break;
                case "english":
                    Console.WriteLine("Grammar is tricky");
                    break;
                case "p.e":
                    Console.WriteLine("Kickball is my favorite");
                    break;
                default:
                    Console.WriteLine($"{userInput} is Fascinating!");
                    break;
            }


        }

    }



}