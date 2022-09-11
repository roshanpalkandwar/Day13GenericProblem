namespace Day13AssigimentGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" chooes number\n1. Find integer maximum number among 3 numbers\n2.using float number\n3.using string value");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    maxNNumber integerMaximumNumber = new maxNNumber();
                    int intValue = integerMaximumNumber.PrintIntegerMaximumNumber(70, 85, 60);
                    Console.WriteLine("Maximum number of integer is " + intValue);
                    break;
                        case 2:
                    FloatNumber floatMaximumNumber = new FloatNumber();
                    float floatValue = floatMaximumNumber.PrintFloatMaximumNumber(88.5f,100.9f, 125.07f);
                    Console.WriteLine("Maximum number of float is " + floatValue);
                    break;
                case 3:
                  StringValue maximumString = new StringValue();
                    string strvalue = maximumString.PrintMaximumString("Apple", "Banana", "Peach");
                    Console.WriteLine("Maximum string is " + strvalue);
                    break;
            }
        }
    }
}