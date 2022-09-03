using System;

namespace IterationExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thousand();

            ByThree();

            //EqualOrNot method
            Console.WriteLine("This will be for the EqualOrNot method");
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            EqualOrNot(num1, num2);

            //EvenOrOdd method
            Console.WriteLine("This will be for the EvenOrOdd method");
            Console.WriteLine("Enter a number:");
            int digit = int.Parse(Console.ReadLine());
            EvenOrOdd(digit);

            //PositiveOrNegative method
            Console.WriteLine("This will be for the PositiveOrNegative method");
            Console.WriteLine("Enter a number:");
            int bit = int.Parse(Console.ReadLine());
            PositiveOrNegative(bit);

            //Voting method
            Console.WriteLine("This will be for the Voting method");
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Voting(age);

            //Range method
            Console.WriteLine("This will be for the Range method");
            Console.WriteLine("Pick a number between 10 and -10:");
            int integer = int.Parse(Console.ReadLine());
            Range(integer);

            MultiTable();
        }

        static void Thousand()
        {
            for (int i = 1000; i >= -1000; --i)
            {
                Console.WriteLine(i);
            }
        }

        static void ByThree()
        {
            for (int i = 1; i <= 999; ++i)
            {
                ++i;
                ++i;
                Console.WriteLine(i);
            }
        }

        static int EqualOrNot(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("They are equal numbers");
                return num1;
            }
            else
            {
                Console.WriteLine("they are not equal");
                return num2;
            }

        }

        static int EvenOrOdd(int digit)
        {
            if (digit % 2 == 0)
            {
                Console.WriteLine("Entered number is an even number");
            }
            else
            {
                Console.WriteLine("Entered number is an odd number");
            }
            return digit;
        }

        static int PositiveOrNegative(int bit)
        {
            if (bit < 0)
            {
                Console.WriteLine("Entered number is a negative");
            }
            else
            {
                Console.WriteLine("Entered number is a positive");
            }
            return bit;
        }

        static int Voting(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You cant vote yet");
            }
            return age;
        }

        static int Range(int integer)
        {
            if (integer >= -10 && integer <= 10)
            {
                Console.WriteLine("Number is in range");
            }
            else
            {
                Console.WriteLine("Number is not in range");
            }
            return integer;
        }

        static void MultiTable()
        {
            Console.WriteLine("This will be for the Multiplication Table method");
            Console.WriteLine("Pick a number between 1 and 12:");
            int MultiNum = int.Parse(Console.ReadLine());

            switch (MultiNum)
            {
                case 1:
                    Console.WriteLine("|*|1|2|3|4|5|6|7|8|9|10|11|12|");
                    Console.WriteLine("|1|1|2|3|4|5|6|7|8|9|10|11|12|");
                    break;
                case 2:
                    Console.WriteLine("|*|1|2|3|4|5 |6 |7 |8 |9 |10|11|12|");
                    Console.WriteLine("|2|2|4|6|8|10|12|14|16|18|20|22|24|");
                    break;
                case 3:
                    Console.WriteLine("|*|1|2|3|4 |5 |6 |7 |8 |9 |10|11|12|");
                    Console.WriteLine("|3|3|6|9|12|15|18|21|24|27|30|33|36|");
                    break;
                case 4:
                    Console.WriteLine("|*|1|2|3 |4 |5 |6 |7 |8 |9 |10|11|12|");
                    Console.WriteLine("|4|4|8|12|16|20|24|28|32|36|40|44|48|");
                    break;
                case 5:
                    Console.WriteLine("|*|1|2 |3 |4 |5 |6 |7 |8 |9 |10|11|12|");
                    Console.WriteLine("|5|5|10|15|20|25|30|35|40|45|50|55|60|");
                    break;
                case 6:
                    Console.WriteLine("|*|1|2 |3 |4 |5 |6 |7 |8 |9 |10|11|12|");
                    Console.WriteLine("|6|6|12|18|24|30|36|42|48|54|60|66|72|");
                    break;
                case 7:
                    Console.WriteLine("|*|1|2 |3 |4 |5 |6 |7 |8 |9 |10|11|12|");
                    Console.WriteLine("|7|7|14|21|28|35|42|49|56|63|70|77|84|");
                    break;
                case 8:
                    Console.WriteLine("|*|1|2 |3 |4 |5 |6 |7 |8 |9 |10|11|12|");
                    Console.WriteLine("|8|8|16|24|32|40|48|56|64|72|80|88|96|");
                    break;
                case 9:
                    Console.WriteLine("|*|1|2 |3 |4 |5 |6 |7 |8 |9 |10|11|12 |");
                    Console.WriteLine("|9|9|18|27|36|45|54|63|72|81|90|99|180|");
                    break;
                case 10:
                    Console.WriteLine("|* |1 |2 |3 |4 |5 |6 |7 |8 |9 |10 |11 |12 |");
                    Console.WriteLine("|10|10|20|30|40|50|60|70|80|90|100|110|120|");
                    break;
                case 11:
                    Console.WriteLine("|* |1 |2 |3 |4 |5 |6 |7 |8 |9 |10 |11 |12 |");
                    Console.WriteLine("|11|11|22|33|44|55|66|77|88|99|110|121|132|");
                    break;
                case 12:
                    Console.WriteLine("|* |1 |2 |3 |4 |5 |6 |7 |8 |9  |10 |11 |12 |");
                    Console.WriteLine("|12|12|24|36|48|60|72|84|96|108|120|132|144|");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 and 12.");
                    break;
            }

        }
    }
}
