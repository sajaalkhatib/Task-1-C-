namespace Task1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program for Circle Circumference

            //Console.Write("Enter the diameter of the circle: ");
            //double diameter = Convert.ToDouble(Console.ReadLine());
            //double circumference = Math.PI * diameter;
            //Console.WriteLine($"Circumference of the circle: {circumference}");


            //Console.Write("Enter time in hours: ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter distance in meters: ");
            //double distance = Convert.ToDouble(Console.ReadLine());

            //double speedMph = distance / time;
            //double speedKph = (distance / 1000) / time;

            //Console.WriteLine($"Speed in meters per hour: {speedMph}");
            //Console.WriteLine($"Speed in kilometers per hour: {speedKph}");


            //double number = 7.9;
            //double roundedNumber = Math.Round(number);
            //Console.WriteLine($"Rounded Number: {roundedNumber}");

            //double baseNum = 2;
            //double exponent = 3;
            //double result = Math.Pow(baseNum, exponent);
            //Console.WriteLine($"{baseNum} raised to the power of {exponent} is {result}");

            //Console.Write("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //    Console.WriteLine($"{year} is a leap year.");
            //else
            //    Console.WriteLine($"{year} is not a leap year.");


            //Console.Write("Enter an alphabet character: ");
            //char ch = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //if (char.IsUpper(ch))
            //    Console.WriteLine($"{ch} is an uppercase letter.");
            //else if (char.IsLower(ch))
            //    Console.WriteLine($"{ch} is a lowercase letter.");
            //else
            //    Console.WriteLine($"{ch} is not an alphabet character.");

            //Console.WriteLine("Select operation:");
            //Console.WriteLine("1. Add");
            //Console.WriteLine("2. Subtract");
            //Console.WriteLine("3. Multiply");
            //Console.WriteLine("4. Divide");

            //// Read user choice
            //Console.Write("Enter choice (1/2/3/4): ");
            //string choice = Console.ReadLine();

            //// Read two numbers
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //double result;

            //// Perform the operation based on user choice
            //switch (choice)
            //{
            //    case "1":
            //        result = num1 + num2;
            //        Console.WriteLine($"{num1} + {num2} = {result}");
            //        break;

            //    case "2":
            //        result = num1 - num2;
            //        Console.WriteLine($"{num1} - {num2} = {result}");
            //        break;

            //    case "3":
            //        result = num1 * num2;
            //        Console.WriteLine($"{num1} * {num2} = {result}");
            //        break;

            //    case "4":
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"{num1} / {num2} = {result}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid input");
            //        break;

            //}

            // Prompt the user for input
            //    Console.Write("Enter first number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter third number: ");
            //    double num3 = Convert.ToDouble(Console.ReadLine());

            //    // Find the maximum number using the ternary operator
            //    double max = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);

            //    // Display the result
            //    Console.WriteLine($"The maximum number is: {max}");



            // Prompt the user for input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is odd or even using the ternary operator
            string result = (number % 2 == 0) ? "even" : "odd";

            // Display the result
            Console.WriteLine($"The number {number} is {result}.");
        }

    }
}