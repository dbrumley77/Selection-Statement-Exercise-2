namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Excercise1();
            //Excercise2();
            //Console.WriteLine();
            //Exercise3();
            //Console.WriteLine();
            Exercise4();
        
                    
            
        
        }

        public static void Excercise1()
        {


            int favNumber = 260;
            Console.WriteLine("Please guess my favorite number between 1 and 1000: ");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)

            {
                Console.WriteLine("To Low");
            }

            else if (userGuess > favNumber)

            {
                Console.WriteLine("To High");
            }

            else

            {
                Console.WriteLine("Just Right!");
            }


        }




        public static void Excercise2()
        {
            Console.WriteLine("What is your favorite subject: ");
            string userInput = Console.ReadLine();
            string userInput2 = userInput.ToLower();

            switch (userInput2)
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

        public static void Exercise3()
        {
            Console.WriteLine("Please enter you fav number (1 thru 5)");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("1 is a lonely number");
                    break;
                case 2:
                    Console.WriteLine("2 is a couple");
                    break;
                case 3:
                    Console.WriteLine("3 is for triples");
                    break;
                case 4:
                    Console.WriteLine("4 sides to a square");
                    break;
                case 5:
                    Console.WriteLine("5 is a handfull");
                    break;
                default:
                    Console.WriteLine("Please pick a number between 1 thru 5");
                    break;
            }


        }


        public static void Exercise4()
        {
            Console.WriteLine("Please enter your favorite tv show");
            string userInput = Console.ReadLine();
            string userInput2 = userInput.ToLower();

            switch (userInput2)
            {
                case "seinfield":
                    Console.WriteLine("Pretty funny guy");
                    break;
                case "WINGS":
                    Console.WriteLine("Roy Biggins is the best");
                    break;
                case "espn":
                    Console.WriteLine("A lot of sports betting");
                    break;
                default:
                    Console.WriteLine("Not familiar with that show");
                    break;

            }
        }

    }



}