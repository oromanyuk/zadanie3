using System;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int le = 10;
            int[] str = new int[le];
            for (int i = 0; i < le; i++)
            {
                str[i] = rnd.Next(-20, 20);
            }
            Console.WriteLine("Массив чисел:");
            for (int i = 0; i < le; i++)
            {
                Console.Write(str[i] + "\t");
            }

            Console.WriteLine("№1");
            int index = 0;
            int m = int.MaxValue;
            for(int i = 0; i < le; i++)
            {
                int q = Math.Abs(str[i]);
                if(m > q)
                {
                    m = q;
                    index = i;
                }
            }
            Console.WriteLine("Индекс минимального по модулю числа: " + index);

            Console.WriteLine("№2");
            int p = 1;
            Console.WriteLine("Уникальные элементы массива: ");
            for (int i = 0; i < le; i++)
            {
                for(int j = 0; j < le; j++)
                {
                    if(str[i] == str[j] && i != j)
                    {
                        p = 0;
                        break;
                    }
                }
                if (p == 1)
                    Console.Write(str[i] + "\t");
            }

            Console.WriteLine("\n№3");
            int g = 0;
            int l = le;
            while(g < l)
            {
                if(str[g] < 0)
                {
                    l = l - 1;
                    for(int d = g; d < l; d++)
                    {
                        str[d] = str[d + 1];
                    }
                }
                else
                    g++;
            }
            Console.WriteLine("Массив чисел без отрицательных значений:");
            for (int i = 0; i < l; i++)
            {
                Console.Write(str[i] + "\t");
            }



        }
    }
}
