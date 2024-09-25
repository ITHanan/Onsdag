namespace Onsdag
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Welcome this app can calculat sum of two number :) ");

            Console.WriteLine("Enter first number:");


            int firstNumber = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Enter secund number:");

            int secondNumber = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine($"The result is : {firstNumber + secondNumber}");


            //This app is for adding two numbers entered by the user.


            //Console.WriteLine("Welcome this app can calculat sum of two number :) ");

            // Console.WriteLine("Enter first number:");    
            // string firstNumbetSomString  = Console.ReadLine()!;
            // int firstNumber = Convert.ToInt32(firstNumbetSomString);

            // Console.WriteLine($"User entered this first number :{firstNumber}");

            // Console.WriteLine("Enter secund number:");

            // string secundNumbetSomString = Console.ReadLine()!;
            // int secundNumber = Convert.ToInt32(secundNumbetSomString);

            //Console.WriteLine($"User entered this secund number :{secundNumber}");

            //  var result = firstNumber + secundNumber;

            //  Console.WriteLine($"The resunt of those two numbers are:  {result} ");




        }
    }
}
