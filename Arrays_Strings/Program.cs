namespace Arrays_Strings;

class Program
{
    private static int[]? _array;
    private static int[][]? _matrix;

    public Program(int[]? array, int[][]? matrix)
    {
        _array = array;
        _matrix = matrix;
    }
    static void Main(string[] args)
    {
        InputArray();
        DisplayMatrix();
        RotateMatrix();
        //DisplayArray();
        //RemoveDuplicates();
        //MultiplicationTable();
    }
    private static void InputArray()
    {
        Console.WriteLine("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int lengths = Convert.ToInt32(Console.ReadLine());
        //_array = new int[size];
        _matrix = new int[size][];
        Console.WriteLine("Enter the elements of the array: ");
        /*for (int i = 0; i < size; i++)
        {
            _array[i] = Convert.ToInt32(Console.ReadLine());
        }*/
        for (int i = 0; i < size; i++)
        {
            _matrix[i] = new int[lengths];
            for (int j = 0; j < lengths; j++)
            {
                _matrix[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    private static void DisplayArray()
    {
        Console.WriteLine("The elements of the array are: ");
        if (_array != null)
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
        Console.WriteLine();
    }
    private static void DisplayMatrix()
    {
        Console.WriteLine("The elements of the matrix are: ");
        if (_matrix != null)
        {
            for (int i = 0; i < _matrix.Length; i++)
            {
                for (int j = 0; j < _matrix[i].Length; j++)
                {
                    Console.Write(_matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    private static void LargestSmallest()
    {
        if (_array != null)
        {
            int largest = _array[0];
            int smallest = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > largest)
                {
                    largest = _array[i];
                }
                else if (_array[i] < smallest)
                {
                    smallest = _array[i];
                }
            }
            Console.WriteLine("The largest element is: " + largest);
            Console.WriteLine("The smallest element is: " + smallest);
        }
    }
    private static void SumAverage()
    {
        if (_array != null)
        {
            int sum = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                sum += _array[i];
            }
            Console.WriteLine("The sum of the elements is: " + sum);
            Console.WriteLine("The average of the elements is: " + (sum / _array.Length));
        }
    }
    private static void ReverseArray()
    {
        if (_array != null)
        {
            Console.WriteLine("The elements of the array in reverse are: ");
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();
        }
    }
    private static void isSorted()
    {
        if (_array != null)
        {
            bool ascending = true;
            bool descending = true;
            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (_array[i] > _array[i + 1])
                {
                    ascending = false;
                }

                if (_array[i] < _array[i + 1])
                {
                    descending = false;
                }
            }

            if (ascending)
            {
                Console.WriteLine("The array is sorted in ascending order.");
            }
            else if (descending)
            {
                Console.WriteLine("The array is sorted in descending order.");
            }
            else
            {
                Console.WriteLine("The array is not sorted.");
            }
        }
    }
    private static void BubbleSort()
    {
        if (_array != null)
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                for (int j = 0; j < _array.Length - i - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        (_array[j], _array[j + 1]) = (_array[j + 1], _array[j]);
                    }
                }
            }
            Console.WriteLine("The elements of the array after sorting are: ");
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    private static void SecondLargestSmallest()
    {
        if (_array != null)
        {
            int largest = _array[0];
            int secondLargest = _array[0];
            int smallest = _array[0];
            int secondSmallest = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > largest)
                {
                    secondLargest = largest;
                    largest = _array[i];
                }
                else if (_array[i] > secondLargest && _array[i] != largest)
                {
                    secondLargest = _array[i];
                }
                if (_array[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = _array[i];
                }
                else if (_array[i] < secondSmallest && _array[i] != smallest)
                {
                    secondSmallest = _array[i];
                }
            }
            Console.WriteLine("The second largest element is: " + secondLargest);
            Console.WriteLine("The second smallest element is: " + secondSmallest);
        }
    }
    private static void RemoveDuplicates()
    {
        if (_array != null)
        {
            int n = _array.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (_array[i] == _array[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            _array[k] = _array[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }
            int[] newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
            Console.WriteLine("The elements of the array after removing duplicates are: ");
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    private static void MultiplicationTable()
    {
        Console.WriteLine("Enter the number for which you want the multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the range: ");
        int range = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= range; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
    private static void RotateMatrix()
    {
        if (_matrix != null)
        {
            int rows = _matrix.Length;
            int columns = _matrix[0].Length;
            int[][] rotatedMatrix = new int[columns][];
            for (int i = 0; i < columns; i++)
            {
                rotatedMatrix[i] = new int[rows];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rotatedMatrix[j][rows - 1 - i] = _matrix[i][j];
                }
            }
            Console.WriteLine("The elements of the rotated matrix are: ");
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(rotatedMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}