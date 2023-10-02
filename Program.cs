namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if else 
           
            //1
            //    Console.WriteLine("Enter the first integer: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the second integer: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    if (num1 == num2)
            //    {
            //        Console.WriteLine("The two integers are equal.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The two integers are not equal.");
            //    }

           
            //2
            //    Console.WriteLine("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("The number is even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is odd.");
            //    }

            
            //3
            //     Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("You are eligible to cast your vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to cast your vote.");
            //}


            
            //if elseif else
            
            //1
            //Console.WriteLine("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number: ");
            //double num3 = double.Parse(Console.ReadLine());

            //double largest;

            //if (num1 >= num2 && num1 >= num3)
            //{
            //    largest = num1;
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    largest = num2;
            //}
            //else
            //{
            //    largest = num3;
            //}

            //Console.WriteLine("The largest number is: " + largest);


            //2
            //Console.WriteLine("Input the marks obtained in Physics: ");
            //int physicsMarks = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input the marks obtained in Chemistry: ");
            //int chemistryMarks = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input the marks obtained in Mathematics: ");
            //int mathMarks = int.Parse(Console.ReadLine());

            //if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && (mathMarks + physicsMarks + chemistryMarks) >= 180)
            //{
            //    Console.WriteLine("The candidate is eligible for admission.");
            //}
            //else if (mathMarks >= 65 && (physicsMarks >= 55 || chemistryMarks >= 50) && (mathMarks + (physicsMarks >= 55 ? physicsMarks : chemistryMarks)) >= 140)
            //{
            //    Console.WriteLine("The candidate is eligible for admission.");
            //}
            //else
            //{
            //    Console.WriteLine("The candidate is not eligible for admission.");
            //}



            //switch case
            
            //1
            //Console.WriteLine("Enter a weekday number (1 for Sunday, 2 for Monday, ..., 7 for Saturday): ");
            //int weekdayNumber = int.Parse(Console.ReadLine());

            //string weekdayName;

            //switch (weekdayNumber)
            //{
            //    case 1:
            //        weekdayName = "Sunday";
            //        break;
            //    case 2:
            //        weekdayName = "Monday";
            //        break;
            //    case 3:
            //        weekdayName = "Tuesday";
            //        break;
            //    case 4:
            //        weekdayName = "Wednesday";
            //        break;
            //    case 5:
            //        weekdayName = "Thursday";
            //        break;
            //    case 6:
            //        weekdayName = "Friday";
            //        break;
            //    case 7:
            //        weekdayName = "Saturday";
            //        break;
            //    default:
            //        weekdayName = "Invalid weekday number";
            //        break;
            //}

            //Console.WriteLine("The corresponding weekday name is: " + weekdayName);

            
            //2
            //Console.WriteLine("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Choose an arithmetic operation:");
            //Console.WriteLine("1. Addition");
            //Console.WriteLine("2. Subtraction");
            //Console.WriteLine("3. Multiplication");
            //Console.WriteLine("4. Division");
            //Console.Write("Enter your choice (1/2/3/4): ");

            //int choice = int.Parse(Console.ReadLine());
            //double result = 0;

            //switch (choice)
            //{
            //    case 1:
            //        result = num1 + num2;
            //        Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //        break;
            //    case 2:
            //        result = num1 - num2;
            //        Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //        break;
            //    case 3:
            //        result = num1 * num2;
            //        Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //        break;
            //    case 4:
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice.");
            //        break;
            //}



            //for loop 
           
            //1
            //Console.WriteLine("Enter a value for n: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Powers of 2 less than or equal to 2^n:");

            //for (int i = 0; i <= n; i++)
            //{
            //    double powerOf2 = Math.Pow(2, i);
            //    if (powerOf2 <= Math.Pow(2, n))
            //    {
            //        Console.WriteLine($"2^{i} = {powerOf2}");
            //    }
            //    else
            //    {
            //        break; 
            //    }
            //}

            
            //2
            //Console.WriteLine("Enter a number N: ");
            //int N = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= N; i++)
            //{
            //    int square = i * i;
            //    sum += square;
            //}

            //Console.WriteLine($"The sum of squares of the first {N} numbers is: {sum}");

            
            //3
            //Console.WriteLine("Enter a number to calculate its factorial: ");
            //int number = int.Parse(Console.ReadLine());

            //long factorial = 1; 

            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i; 
            //}

            //Console.WriteLine($"{number}! = {factorial}");



            //while loop
            
            //1
            int headsCount = 0;
            int tailsCount = 0;
            Random random = new Random();

            while (headsCount < 20 && tailsCount < 20)
            {
                int result = random.Next(2); // 0 for Heads, 1 for Tails

                if (result == 0)
                {
                    headsCount++;
                    Console.WriteLine("Heads!");
                }
                else
                {
                    tailsCount++;
                    Console.WriteLine("Tails!");
                }
            }

            if (headsCount == 20)
            {
                Console.WriteLine("Heads won 20 times!");
            }
            else
            {
                Console.WriteLine("Tails won 20 times!");
            }

            //2
            Console.WriteLine("Enter a word: ");
            string inputWord = Console.ReadLine();
            string reversedWord = "";

            for (int i = inputWord.Length - 1; i >= 0; i--)
            {
                reversedWord += inputWord[i];
            }

            Console.WriteLine("Reversed word: " + reversedWord);

            //3
            int n = 5; 
            int sum = 0;
            int m = 1;

            while (m <= n)
            {
                sum += m;
                m++;
            }

            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");


        }
    }
}
