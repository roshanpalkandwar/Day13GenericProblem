namespace Day13AssigimentGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" chooes number\n1. Find integer maximum number among 3 numbers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    maxNNumber integerMaximumNumber = new maxNNumber();
                    int intValue = integerMaximumNumber.PrintIntegerMaximumNumber(70, 85, 60);
                    Console.WriteLine("Maximum number of integer is " + intValue);
                    break;
            }
        }
    }
}