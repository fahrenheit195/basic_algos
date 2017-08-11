using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        /*Сортировка пузырьком
         * Возвращает отсортированный массив
         */
        static int[] Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        // Вывод значений массива
        static void wrt(int[] arr)
        {
            Console.WriteLine("––––––––––––");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        /* Сортировка вставками через цикл while
        * Возвращает отсортированный массив
        */
        static int[] whileInsertion(int[] arr)
        {
            int j;
            for (int i = 0; i < arr.Length-1; i++)
            {
                j = i+1;
                while (j > 0 || arr[j-1] > arr[j])
                {
                    int temp = arr[j-1];
                    arr[j-1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
            return arr;
        }

        /*Сортировка вставками через цикл for
        * Возвращает отсортированный массив
        */
        static int[] forInsertion(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        /* Сортировка выбором
         * Возвращает отсортированный массив
         * 
         * peak - индекс минимального/максимального эл-та массива
         * temp - хранит значение текущего эл-та массива
         */
        static int[] Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int peak = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[peak])
                    {
                        peak = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[peak];
                arr[peak] = temp;
            }
            return arr;
        }

        /* Числа Фибоначчи
         * Возвращает перове число из последовательности чисел Фибоначчи
         * 
         * temp - хранит значение текущего числа
         * a - текущее число
         * b - следующее число
         */
        static int Fibonacchi(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b += temp;
            }
            return a;
        }

        // Вывод чисел Фибоначчи
        static void fibOut()
        {
            Console.WriteLine();
            Console.WriteLine("Числа Фибоначчи");
            Console.WriteLine();
            Console.WriteLine("Сколько чисел вывести?");
            Console.WriteLine();
            int j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.Write(Fibonacchi(i)+" ");
            }
        }

        // Вывод результата сортировки пузырьком
        static void bubbleSort()
        {
            Random rnd = new Random();
            int o;
            Console.WriteLine("Сортировка пузырьком");
            Console.Write("Укажите длинну массива: ");
            o = int.Parse(Console.ReadLine());

            int[] arr = new int[o];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 6);
            }
            Console.WriteLine("Исходный массив: ");
            wrt(arr);
            Bubble(arr);
            Console.WriteLine("Отсортиванный массив: ");
            wrt(arr);
        }

        // Вывод результата сортировки вставками
        static void insertionSort()
        {
            Random rnd = new Random();
            int o;

            Console.Write("Укажите длинну массива: ");
            o = int.Parse(Console.ReadLine());

            int[] arr = new int[o];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 6);
            }
            Console.WriteLine("Исходный массив: ");
            wrt(arr);
            whileInsertion(arr);
            Console.WriteLine("Отсортиванный массив: ");
            wrt(arr);
        }

        // Факториал числа
        static int factorial()
        {
            Console.Write("Факториал какого числа искать: ");
            int f = 1;
            int o = int.Parse(Console.ReadLine());

            for (int i = 1; i <= o; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
            return f;
        }

        /* Двоичный поиск
         * Возвращает результат поиска
         * 
         * 
         */
        static int? binSearch(int[] arr, int sElem)
        {
            if (arr.Length == 0 || sElem < arr[0] || sElem > arr[arr.Length - 1])
            {
                Console.Write("Искомый элемент не найден");
                Console.Beep();
                return null;
            }

            int first = 0;
            int last = arr.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;
                if (sElem <= arr[mid])
                    last = mid;
                else
                    first = mid + 1;
            }
            if (arr[last] == sElem)
            {
                Console.Write(last + 1);
                return last + 1;
            }
            else
            {
                return null;
            }
        }

        static int? linSearch(int[] arr, int sElem)
        {
            if (arr.Length == 0)
            {
                Console.Write("Пустой массив");
                return -1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == sElem)
                {
                    Console.Write(i + 1);
                    return i + 1;
                }
            }
            Console.Write("Искомый элемент не найден");
            Console.Beep();
            return -1;
        }

        static void strReverse()
        {
            string s = "Пирожок";
            Console.WriteLine(s);
            char[] sArr = s.ToCharArray();
            Array.Reverse(sArr);
            string rS = new string(sArr);
            Console.Write(rS);
        }

        static string shifter(string str, int shift)
        {
            string UserOutput = null;
            char[] A = null;
            A = str.ToCharArray();
            int temp;

            for (int i = 0; i < str.Length; i++)
            {
                temp = A[i] + shift;
                UserOutput += (char)temp;
            }
            return UserOutput;
        }

        static void caesarShift()
        {
            string UserString;
            int shift;
            Console.WriteLine("type a string to encrypt:");
           // Console.ForegroundColor = ConsoleColor.Yellow;
            UserString = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("How many chars would you like to shift?: :");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            shift = int.Parse(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Your encrypted string is: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(shifter(UserString, shift));
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Список действий:");
            Console.WriteLine("1. Соритровка пузырьком");
            Console.WriteLine("2. Сортировка вставками");
            Console.WriteLine("3. Числа Фибоначчи");
            Console.WriteLine("4. Факториал числа");
            Console.WriteLine("5. Реверс строки");
            Console.WriteLine("6. Шифр Цезаря");
            Console.Write("Укажите номер действия: ");
            int i = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (i)
            {
                case 1:
                    bubbleSort();
                    break;
                case 2:
                    insertionSort();
                    break;
                case 3:
                    fibOut();
                    break;
                case 4:
                    factorial();
                    break;
                case 5:
                    strReverse();
                    break;
                case 6:
                    caesarShift();
                    break;        
            }
            Console.ReadKey();
        }
    }
}
