using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infbez5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    static public class alg
    {
        // Проверка числа на простоту методом пробных делений и решета эратосфена
        static public bool is_simple(Int64 n)
        {
            Int64 sqrt_n = (Int64)Math.Sqrt(n);
            List<Int64> d_list = new List<Int64>();

            // Заполнили список числами от 2 до корня из n
            for (Int64 i = 2; i <= sqrt_n; i++)
            {
                d_list.Add(i);
            }
            
            // Оставили в списке только просто числа от 2 до корня из n
            for(int i = 0; i < d_list.Count; i++)
            {
                for(int k = i+1; k < d_list.Count; k++)
                {
                    if(d_list[k] % d_list[i] == 0)
                    {
                        d_list.RemoveAt(k);
                    }
                }
            }

            bool prostoe = true;

            for(int j = 0; prostoe == true && j < d_list.Count; j++)
            {
                if(n % d_list[j] == 0)
                {
                    prostoe = false;
                }
            }

            return prostoe;
        }

        public struct factor // Структура для хранения одного множителя
        {
            public static Int64 num;
            public static Int64 deg;
        }

        static public void factorization(Int64 n)
        {

        }

        static public Int64 find_factor (Int64 n)
        {
            // программный алгоритм на псевдокоде взят с 
            // https://ru.wikipedia.org/wiki/Метод_Лемана#Псевдокод
            // и переделан под C#

            Int64 sqrt_n = (Int64)Math.Pow(n,1.0/3.0); // [n^1/3]
            for (Int64 a = 2; a <= sqrt_n+2; a++)
            {
                if(n % a == 0)
                {
                    return a;
                }
            }

            for (Int64 k = 1; k <= sqrt_n; k++)
            {
                Int64 M = (Int64)(Math.Pow(n, 1.0 / 6.0) / (4.0 * Math.Sqrt(k)));
                for(Int64 d = 0; d <= M; d++)
                {
                    double kn = Math.Pow(((Int64)(Math.Sqrt(4.0 * k * n))) + d, 2.0) - (4.0 * k * n);
                    if(alg.isSquare(kn) == true)
                    {
                        Int64 A = ((Int64)Math.Sqrt(4.0 * k * n)) + d;
                        Int64 B = (Int64)Math.Sqrt(Math.Pow(A, 2.0) - 4.0 * k * n);
                        Int64 nod_plus = alg.GCD(A + B, n);
                        Int64 nod_minus = alg.GCD(A - B, n);
                        if (1 < nod_minus && nod_minus < n)
                        {
                            return nod_minus;
                        }
                        else if (1 < nod_plus && nod_plus < n)
                        {
                            return nod_plus;
                        }
                    }
                }
            }
            return -1;
        }

        // Проверяет является ли число x полным квадратом натурального числа
        public static bool isSquare (double x)
        {
            double x_sqrt = Math.Sqrt(x);
            Int64 x_int = (Int64)x;
            if (x_int < x && x < (x_int + 1))
            {
                return false;
            }
            else return true;
        }

        // Поиск НОД у двух чисел
        static public Int64 GCD(Int64 a, Int64 b)
        {
            while (b != 0)
            {
                Int64 t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

    }
}
