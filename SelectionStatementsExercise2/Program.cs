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
            //Exercise4();
            //Console.WriteLine();
            //Exercise5(0);
              Exercise6(0);
        
                    
            
        
        }

        public static void Excercise1()
        {

            


                int favNumber = 5;
                Console.WriteLine("Please guess my favorite number between 1 and 10: ");
                string userGuess = Console.ReadLine();
                int parsedUserGuess = int.Parse(userGuess);


                if (parsedUserGuess < favNumber)

                {
                    Console.WriteLine("To Low");
                }

                else if (parsedUserGuess > favNumber)

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
                case "wings":
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

        public static int Exercise5(int number)
        {
            int i = 0;
            int count;
            do
            {
                Console.WriteLine(i);
                count = i++;


            }
            while (i <= 14);
            Console.WriteLine(i);
            return count;
           
        }


        public static double Exercise6(double balance)
        {
            
            bool condition;
            do
            {
                Console.WriteLine("How much would you like to deposit?");
                string number = Console.ReadLine();
                double attemptedAnswer;

                if (double.TryParse(number, out attemptedAnswer))
                {
                    balance += attemptedAnswer;
                }

                Console.WriteLine("Would you like to make another deposit? Yes or No");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    condition = true;
                }
                else
                {
                    condition = false;
                }

            } while (condition);
            Console.WriteLine($"Your current balance is {balance.ToString("C")}");
            return balance;
            
        }
    }



}