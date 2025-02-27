//this program will contain the 40 basic programs in 40 functions

namespace dotnet_learning
{
    internal class Program
    {
        private static int _firstNumber = 0,_secondNumber = 0;
        //static string? _inputString = "";
        private static char _firstChar = ' ';
        public static void Main(String[] args)
        {
            InputAll();
            OddEvenInRange();
        }

        //the first method for the first problem statement
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        //shared function
        private static void InputAll()
        {
            Console.WriteLine("Enter the numbers :-");
            _firstNumber = Convert.ToInt32(Console.ReadLine());
            //_secondNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the string :-");
            //_inputString = Console.ReadLine();
            //Console.WriteLine("Enter the character :-");
            //_firstChar = Convert.ToChar(Console.ReadLine() ?? throw new InvalidOperationException());
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

        /*private static bool ReverseString()
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
        }*/
        private static void Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= _firstNumber; i++)
            {
                fact *= i;
            }
            Console.WriteLine("The factorial of the number is :- " + fact);
        }
        private static void Fibonacci()
        {
            int a = 0, b = 1, c = 0;
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < _firstNumber; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }

        private static void Prime()
        {
            bool isPrime = _firstNumber > 1;
            for (int i = 2; i <= (int)Math.Sqrt(_firstNumber); i++)
            {
                if (_firstNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "The number is prime" : "The number is not prime");
        }

        private static void GCD()
        {
            int gcd = 1;
            for (int i = 1; i <= _firstNumber && i <= _secondNumber; i++)
            {
                if (_firstNumber % i == 0 && _secondNumber % i == 0)
                    gcd = i;
            }
            Console.WriteLine("The GCD of the numbers is :- " + gcd);
        }
        private static void LCM()
        {
            int lcm = _firstNumber > _secondNumber ? _firstNumber : _secondNumber;
            while (true)
            {
                if (lcm % _firstNumber == 0 && lcm % _secondNumber == 0)
                {
                    Console.WriteLine("The LCM of the numbers is :- " + lcm);
                    break;
                }
                lcm++;
            }
        }
        private static void CelsiusToFahrenheit()
        {
            int fahrenheit = (_firstNumber * 9 / 5) + 32;
            Console.WriteLine("The temperature in Fahrenheit is :- " + fahrenheit);
        }
        private static void charToAscii()
        {
            Console.WriteLine("The ASCII value of the character is :- " + (int)_firstChar);
        }
        private static void OddEvenInRange()
        {
            Console.WriteLine("The even numbers in the range are :- ");
            for (int i = 0; i <= _firstNumber; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\nThe odd numbers in the range are :- ");
            for (int i = 0; i <= _firstNumber; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }
    }
}