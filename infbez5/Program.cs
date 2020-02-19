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
            Int64 sqrt_n = (Int64)Math.Sqrt(Convert.ToDouble(n));
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

        public struct factor // Структруа для хранения одного множителя
        {
            public static Int64 num;
            public static Int64 deg;
        }

        static public Int64 find_factor (Int64 n)
        {
            




            return 1; 
        }
    }
}
