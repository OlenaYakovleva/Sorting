using System;

namespace Sorting
{
    class Program
    {
        // Сортировка вставками
        static void Main(string[] arr)
        {

            int[] a = { 7, 0, -4, 3, 1, -2, 5 };

            Console.WriteLine("Chose sorting order: 1 - acending, 2 - descending");


            int Choice = Convert.ToInt32(Console. ReadLine());

            bool up = true;
            if (Choice == 2)
            {
                up = false;
                }


        
            for(int i=1; i < a.Length; i++)
            {
                int k = a[i];
                int j = i - 1;

                while(j>=0 && (up ? a[j] > k : a[j]<k))
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = k;
            }

            // Распечатываем массив.
            Console.WriteLine(up ? "Sorting by ascending " : "Sorting by descending");
            for(int i=0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadLine();

        }
    }
}