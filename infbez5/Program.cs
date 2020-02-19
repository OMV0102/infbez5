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
            for(int j = 0; j < d_list.Count; j++)
            {
                for(int k = j; k < d_list.Count; k++)
                {
                    if(d_list[k] % d_list[j] == 0)
                    {
                        d_list.RemoveAt(k);
                    }
                }
            }

            Int64[] d_array = new Int64[n - 2];
            for(Int64 d = 0; d <= sqrt_n; d++)
            {

            }

            //UInt64 d = 2;


            return false;
        }
    }
}
