using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymNa_15._10
{
    enum months
    {
        январь = 1,
        февраль,
        март = 3,
        апрель = 4,
        май = 5,
        июнь = 6,
        июль = 7,
        август = 8,
        сентябрь = 9,
        октябрь = 10,
        ноябрь = 11,
        декабрь = 12
    }
    internal class Program
    {
        public static void Number_6_1(string arg) //считаем гласные/согласные буквы
        {
            try
            {
                Console.WriteLine("Упражнение 6.1 (считаем гласные/согласные буквы)");
                int glasCount = 0, sogCount = 0;
                char[] str = File.ReadAllText(arg).ToArray<char>();
                string glas = "eyuioa";
                string sog = "qwrtpsdfghjklzxcvbnm";
                foreach (char a in str)
                {
                    if (glas.Contains(a))
                    {
                        glasCount++;
                    }
                    else if (sog.Contains(a))
                    {
                        sogCount++;
                    }
                }
                Console.WriteLine($"Гласные: {glasCount}\n" + $"Согласные: {sogCount}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("На этом все");
            }
        }
        public static void Number_6_2() //задание с матрицами(печать,перемножение)
        {
            Console.WriteLine("Упражнение 6.2 (матрицы: печать,перемножение)");
            int[,] A = new int[2, 2];
            int[,] B = new int[2, 2];
            Console.WriteLine("Первая матрица:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Введите элемент матрицы: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    A[i, j] = a;
                }
            }
            Console.WriteLine("Вторая матрица:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Введите элемент матрицы: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    B[i, j] = a;
                }
            }
            Print(A);
            Print(B);
            int[,] C = Multiplication(A, B);
            Print(C);
        }
        public static void Print(int[,] ar) //печать матрицы
        {
            Console.WriteLine("матрица: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
        public static int[,] Multiplication(int[,] A, int[,] B) //умножение матриц
        {
            Console.WriteLine("Результат перемножения матриц: ");
            int[,] C = new int[2, 2];
            int k = 0;
            int l = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    C[i, j] = A[i, k] * B[k, j] + A[i, l] * B[l, j];
                }
            }
            return C;
        }
        static void AVETEM(int[,] temra) //средняя темпа
        {
            int sum = 0;
            int sr_arif = 1;
            int[] averageMas = new int[12];

            for (int i = 0; i < temra.GetLength(0); i++)
            {

                for (int j = 0; j < temra.GetLength(1); j++)
                {
                    sum += temra[i, j];
                    sr_arif = sum / 30;
                }
                averageMas[i] = sr_arif;
                Console.WriteLine($"Средняя температура в {i + 1} месяце - {sr_arif}");
            }
            Array.Sort(averageMas);
            Console.WriteLine("Средние значения температур в месяцах по возрастанию: ");
            foreach (int i in averageMas)
                Console.Write(i + " ");
        }
        public static void DZ_6_1(string arg) //гласные согласные дз
        {
            try
            {
                Console.WriteLine("ДЗ 6.1 (считаем гласные/согласные буквы)");
                int glasCount = 0, sogCount = 0;
                List<char> list = File.ReadAllText(arg).ToList<char>();
                string glas = "eyuioa";
                string sog = "qwrtpsdfghjklzxcvbnm";
                foreach (char a in list)
                {
                    if (glas.Contains(a))
                    {
                        glasCount++;
                    }
                    else if (sog.Contains(a))
                    {
                        sogCount++;
                    }
                }
                Console.WriteLine($"Гласные: {glasCount}\n" + $"Согласные: {sogCount}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void MatrixMulti(LinkedList<LinkedList<int>> mat1, LinkedList<LinkedList<int>> mat2, ref LinkedList<LinkedList<int>> multi) //матрица дз
        {
            LinkedList<int> m1 = new LinkedList<int>();
            LinkedList<int> m2 = new LinkedList<int>();
            LinkedList<int> mult = new LinkedList<int>();
            m1.AddFirst(6); m1.AddLast(5); m1.AddLast(9); m1.AddLast(4);
            m2.AddFirst(8); m2.AddLast(1); m2.AddLast(6); m2.AddLast(9);
            mat1.AddFirst(m1);
            mat2.AddFirst(m2);
            var a1 = m1.First; var a2 = a1.Next; var a3 = a2.Next; var a4 = a3.Next;
            var b1 = m2.First; var b2 = b1.Next; var b3 = b2.Next; var b4 = b3.Next;
            var c0 = a1.Value * b1.Value + a2.Value * b3.Value;
            var c1 = a1.Value * b2.Value + a2.Value * b4.Value;
            var c2 = a3.Value * b1.Value + a4.Value * b3.Value;
            var c3 = a3.Value * b2.Value + a4.Value * b4.Value;
            mult.AddFirst(c0); mult.AddLast(c1); mult.AddLast(c2); mult.AddLast(c3);
            multi.AddFirst(mult);
            var item = mult.First;
            int i = 0;
            Console.WriteLine("Произведение матриц:");
            while (item != null)
            {
                Console.Write(item.Value + " ");
                item = item.Next;
                i++;
                if (i == 2)
                {
                    Console.WriteLine();
                }
            }
        }
        static int AVTE(int[] array, ref int[] sr_znach) //темпа дз
        {
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum = ++array[i];
            }
            Array.Sort(sr_znach);
            return (int)Math.Round(sum / 12);
        }
        static void Main(string[] args)
        {
            Number_6_1("D:\\for hw\\hww.txt");

            Number_6_2();

            Console.WriteLine("Упражнение 6.3");
            Random rand = new Random();
            int[,] temra = new int[12, 30];
            for (int j = 0; j < 30; j++)
                for (int i = 0; i < 12; i++)
                    temra[i, j] = rand.Next(-30, 30);
            AVETEM(temra);
            Console.WriteLine();

            DZ_6_1("D:\\for hw\\hww.txt");

            Console.WriteLine("ДЗ 6.2");
            LinkedList<LinkedList<int>> mat1 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> mat2 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> multimatrix = new LinkedList<LinkedList<int>>();
            MatrixMulti(mat1, mat2, ref multimatrix);
            Console.WriteLine();

            Console.WriteLine("ДЗ 6.3");
            Random temp = new Random();
            int[] temper = new int[30];
            int[] AllTemps = new int[12];
            Dictionary<months, int[]> weather = new Dictionary<months, int[]>();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temper[j] = temp.Next(-30, 30);
                }
                Console.WriteLine($"Средняя температура в {(months)(i + 1)} - {AVTE(temper, ref AllTemps)}");
                weather.Add((months)(i + 1), temper);
                AllTemps[i] = AVTE(temper, ref AllTemps);
            }
            Console.WriteLine("Отсортированный массив средних температур: ");
            foreach (int a in AllTemps)
            {
                Console.Write(a + " ");
            }
        }
    }
}
