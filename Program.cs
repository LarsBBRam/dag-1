using System.Globalization;

namespace dag_1;

class Program
{
    static void Main(string[] args)
    {
        string helloText = "Hello, World";
        Console.WriteLine(helloText);

        int wholeNumber = 42;
        Console.WriteLine(wholeNumber);

        string binaryOfWholeNumber = Convert.ToString(wholeNumber, 2).PadLeft(32, '0');
        Console.WriteLine(binaryOfWholeNumber);

        int maxValue = int.MaxValue;
        Console.WriteLine(maxValue);

        string maxValueAsBinary = Convert.ToString(maxValue, 2).PadLeft(32, '0');
        Console.WriteLine(maxValueAsBinary);

        int negativeNumber = -42;
        Console.WriteLine(negativeNumber);

        string negativeNumberAsBinary = Convert.ToString(negativeNumber, 2).PadLeft(32, '0');
        Console.WriteLine(negativeNumberAsBinary);

        double doubleNumber = 42.42;
        Console.WriteLine(doubleNumber);

        decimal decimalNumber = 42.4242424242424242M;
        Console.WriteLine(decimalNumber);


        float floatBreakPoint = 0.9999999f;
        Console.WriteLine(floatBreakPoint);

        double doubleBreakPoint = 0.9999999999999999;

        Console.WriteLine(doubleBreakPoint);

        decimal deciBreakPoint = 0.9999999999999999999999999999m;

        Console.WriteLine(deciBreakPoint);

        char myChar = 'a';
        Console.WriteLine(myChar);

        char secondChar = 'B';
        char addedChar = (char)(myChar + secondChar);
        Console.WriteLine(addedChar);

        string numberAsText = "42";
        bool numberFromText = int.TryParse(numberAsText, out int result);
        Console.WriteLine(result);


        int myAge = 31;

        myAge += 10;
        myAge -= 5;
        myAge *= 10;
        myAge /= 4;

        myAge %= 2;

        Console.WriteLine(myAge);

        int num1 = 2;
        int num2 = 4;

        bool isEqual = num1 == num2;
        Console.WriteLine(isEqual);

        bool isNotEqual = num1 != num2;
        Console.WriteLine(isNotEqual);

        bool isLarger = num1 > num2;
        Console.WriteLine(isLarger);

        bool isSmaller = num1 < num2;
        Console.WriteLine(isSmaller);

        bool isNotEqualAndIsSmaller = isNotEqual && isSmaller;
        Console.WriteLine(isNotEqualAndIsSmaller);




    }
}
