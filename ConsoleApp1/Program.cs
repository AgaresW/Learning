using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum;
            sum = 0;
            int[] mas;
            Console.WriteLine("Введите количество элементов массива"); 
            n = int.Parse(Console.ReadLine());
            mas = new int[n];
            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Числа элементов массива в обратном порядке:");

            for (int i = 0;i < mas.Length; i++)
            {
               Console.WriteLine(mas[n-1]);
                n--;
            }

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                     sum = sum + mas[i];
                }
            }
            Console.WriteLine("Сумма четных чисел в массиве: "+sum);

            for (int i = 0; i < mas.Length; i++)
                for (int j = 1; j < mas.Length - i; j++)
                {
                    if (mas[j] < mas[j - 1])
                    {
                        int s = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = s;
                    }
                }          
            Console.WriteLine("Наименьшее число в массиве: "+mas[0]);

            Console.ReadKey();
        }
    }
}
