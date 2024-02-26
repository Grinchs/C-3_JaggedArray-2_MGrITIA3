using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3_JaggedArray_2_MGrITIA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet rindu skaitu:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet min vērtību:");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet max vērtību:");
            int max = int.Parse(Console.ReadLine());

            // Uztaisa Jagged masīvu, aizsūta funkcijai vertības :P
            int[][] jaggedArray = InitArray(x, min, max);

            Console.WriteLine("\nForeach");
            Console.WriteLine();
            PrintArrayForeach(jaggedArray);

            Console.WriteLine("\nFor");
            Console.WriteLine();
            PrintArrayFor(jaggedArray);
        }

        static int[][] InitArray(int x, int min, int max)
        {
            // Omnivas pasuutījums atnāca uz funkciju un dara visu pārējo ))
            Random rand = new Random();
            int[][] jaggedArray = new int[x][];

            for (int i = 0; i < x; i++)
            {
                int kolonnas = rand.Next(4, 11); // Kolonām
                jaggedArray[i] = new int[kolonnas];

                for (int j = 0; j < kolonnas; j++)
                {
                    jaggedArray[i][j] = rand.Next(min, max + 1); // Skaitļiem
                }
            }
            return jaggedArray;
        }

        static void PrintArrayForeach(int[][] mas)
        {
            foreach (int[] x in mas)
            {
                foreach (int skaitlis in x)
                {
                    Console.Write(skaitlis + "     ");
                }
                LineInfo(x);
                Console.WriteLine();
            }
        }

        static void PrintArrayFor(int[][] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    Console.Write(mas[i][j] + "     ");
                }
                LineInfo(mas[i]);
                Console.WriteLine();
            }
        }

        static void LineInfo(int[] x)
        {
            int cikSkaitlis = x.Length;
            int sum = 0;

            foreach (int num in x)
            {
                // Pieskaita kolonnas pie summas, jo vajag
                sum += num;
            }

            double vid = (double)sum / cikSkaitlis;
            Console.WriteLine($"Value count: {cikSkaitlis}; Line sum: {sum}; Line average: {vid:F2}");
        }
    }
}
