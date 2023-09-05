/*
    Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
    длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
    либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
    лучше обойтись исключительно массивами.
   
*/

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int numStrings;

            while (!int.TryParse(Console.ReadLine(), out numStrings) || numStrings <= 0)
            {
                Console.Write("Некорректный ввод. Количество строк должно быть больше 0. Повторите попытку: ");
            }

            string[] inputArray = new string[numStrings];
            for (int i = 0; i < numStrings; i++)
            {
                Console.Write($"Введите строку {i + 1}: ");
                inputArray[i] = Console.ReadLine();
            }
            // Всё что закоментировано ниже необходимо использовать,
            // когда пользователь сам выбирает количество символов для сравнения строк.

            //Console.Write("Введите максимальное количество символов: ");
            //int maxLength;

            //while (!int.TryParse(Console.ReadLine(), out maxLength) || maxLength <= 0)
            //{
            //    Console.Write("Некорректный ввод. Введите положительное число: ");
            //}

            //string[] newArray = FilterStrings(inputArray, maxLength);
            string[] newArray = FilterStrings(inputArray);

            Console.WriteLine("Введенный массив:");
            PrintArray(inputArray);
            Console.WriteLine("");

            //Console.WriteLine("Новый массив (length <= " + maxLength + "):");
            Console.WriteLine("Новый массив :");
            PrintArray(newArray);
            Console.WriteLine("");        
        }

        //static string[] FilterStrings(string[] inputArray, int maxLength)
        static string[] FilterStrings(string[] inputArray)
        {
            int maxLength = 3; //данную строку необходимо удалить при использовании ввода количества строк пользователем.

            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= maxLength)
                {
                    count++;
                }

            }


            string[] resultArray = new string[count];
            int index = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= maxLength)
                {
                    resultArray[index] = inputArray[i];
                    index++;
                }

            }

            Console.WriteLine();
            
            return resultArray;
        }

        static void PrintArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }