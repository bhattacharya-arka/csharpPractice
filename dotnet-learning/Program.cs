//this program will contain the 40 basic programs in 40 functions

namespace dotnet_learning
{
    internal class Program
    {
        static int _firstNumber = 0, _secondNumber = 0;
        static string? _inputString = "";
        public static void Main(String[] args)
        {
            InputAll();
            CountVowels();
        }

        //the first method for the first problem statement
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        //shared function
        private static void InputAll()
        {
            //Console.WriteLine("Enter the numbers :-");
            //_firstNumber = Convert.ToInt32(Console.ReadLine());
            //_secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the string :-");
            _inputString = Console.ReadLine();
        }
        //the second method for the second problem statement
        private static void AddNumbers()
        {
            int sum = _firstNumber + _secondNumber;
            Console.WriteLine("The sum of the numbers is :- " + sum);
        }
        //the third method for the third problem statement
        private static void MaxNumber()
        {
            int max = _firstNumber > _secondNumber ? _firstNumber : _secondNumber;
            Console.WriteLine("The maximum number is :- " + max);
        }
        //the fourth method for the fourth problem statement
        private static void SwapWithoutTemp()
        {
            Console.WriteLine("The numbers before swapping are :- " + _firstNumber + " " + _secondNumber);
            _firstNumber += _secondNumber;
            _secondNumber = _firstNumber - _secondNumber;
            _firstNumber -= _secondNumber;
            Console.WriteLine("The numbers after swapping are :- " + _firstNumber + " " + _secondNumber);
        }

        private static void EvenOdd()
        {
            Console.WriteLine((_firstNumber % 2 == 0) ? "The number is even" : "The number is odd");
        }
        private static void sumOfDigits()
        {
            int sum = 0;
            int copy = _firstNumber;
            while (copy != 0)
            {
                sum += copy % 10;
                copy /= 10;
            }
            Console.WriteLine("The sum of the digits is :- " + sum);
        }

        private static bool ReverseString()
        {
            String _reversedString = "";
            if (_inputString != null)
                for (int i = _inputString.Length - 1; i >= 0; i--)
                {
                    Console.Write(_inputString[i]);
                    _reversedString += _inputString[i];
                }

            Console.WriteLine();
            return _reversedString == _inputString;
        }
        private static void CountVowels()
        {
            int count = 0;
            if (_inputString != null)
                foreach (char c in _inputString)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        count++;
                }
            Console.WriteLine("The number of vowels in the string is :- " + count);
        }
        
    }
}