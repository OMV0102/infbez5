﻿using System;
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
        // Структура для хранения одного множителя
        public struct factor 
        {
            public Int64 num; // множитель (показатель)
            public Int64 deg; // степень  
        }

        public static List<factor> fact_list; // Список , содержащий множители
        public static bool sortMode; // Тип сортировки
        public static int iter;


        // Проверка числа на простоту методом пробных делений и решета эратосфена
        static public bool is_simple(Int64 n)
        {
            // быстрая и простая проверочка на простоту
            if (n == 1 || n == 2 || n == 3 || n == 5 || n == 7 || n == 11 || n == 13 || n == 17 || n == 19 || n == 23 || n==29 || n == 31)
            {
                alg.iter++; // кол-во итерация + 1
                return true;
            }

            Int64 sqrt_n = (Int64)Math.Sqrt(n);
            List<Int64> d_list = new List<Int64>();

            // Заполнили список числами от 2 до корня из n
            for (Int64 i = 2; i <= sqrt_n+2; i++)
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
                        k--;
                    }
                }
                alg.iter++; // кол-во итерация + 1
            }

            bool prostoe = true;

            // ищем какое простое число является множителем
            // если не нашли, значит само число является простым множителем
            for(int j = 0; prostoe == true && j < d_list.Count; j++)
            {
                if(n % d_list[j] == 0)
                {
                    prostoe = false;
                }
                alg.iter++; // кол-во итерация + 1
            }

            return prostoe;
        }
        
        // Функция разложения на множители (в список)
        static public void factorization(Int64 n) 
        {
            Int64 mnoj = 1;
            bool one_add = false;
            alg.fact_list.Clear(); // отчищаем от предыдущих множетелей
            alg.iter = 0;

            do
            {
                if (is_simple(n) == true) // Если число простое
                {
                    mnoj = n;
                    alg.addFactToList(mnoj); // Добавить в список
                    n /= mnoj;
                    if (mnoj == 1)
                        one_add = true;
                }
                else // число не простое
                {
                    if (n % 2.0 == 0.0) // число не простое, но четное
                    { 
                        while (n % 2.0 == 0.0) // избавляемся от четности
                        {
                            mnoj = 2;
                            alg.addFactToList(mnoj);
                            n /= mnoj;
                        }
                    }
                    else if( n % 2.0 != 0.0 && n > 8)
                    {
                        mnoj = alg.find_factor(n);
                        alg.addFactToList(mnoj);
                        n /= mnoj;
                    }
                }
                
            } while (n != 1);

            if (one_add == false)
                alg.addFactToList(1);
        }

        // Добавление найденного множителя в список
        static public void addFactToList(Int64 num)
        {
            bool isAdd = false;
            int N = alg.fact_list.Count;
            alg.factor f;

            // Просматриваем уже имеющиеся множители 
            // Если нашли увеличиваем степень у него
            for (int i = 0; isAdd == false && i < N; i++)
            {
                if(alg.fact_list[i].num == num)
                {
                    f = alg.fact_list[i];
                    f.deg++;
                    alg.fact_list[i] = f;
                    isAdd = true;
                }
            }

            if (isAdd == false) // Если просмотрели множители и не нашли, то добавляем в конец новый
            {
                f.num = num;
                f.deg = 1;
                alg.fact_list.Add(f);
            }
        }

        // Поиск одного множителя числа n
        static public Int64 find_factor (Int64 n)
        {
            // Псевдокод алгоритма: 
            // https://ru.wikipedia.org/wiki/Метод_Лемана#Псевдокод
            // Словесное описание в методичке по ИБ

            Int64 sqrt_n = (Int64)Math.Sqrt(n); 
            for (Int64 a = 2; a <= sqrt_n; a++)
            {
                if(n % a == 0)
                {
                    return a;
                }
                alg.iter++; // кол-во итерация + 1
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
                alg.iter++; // кол-во итерация + 1
            }

            return 1;
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

        // Вывод множителей в строку
        static public string listToString()
        {
            string result = "{";
            int N = alg.fact_list.Count();

            if (N == 1)
            {
                result += " " + alg.fact_list[0].num + " ";
            }
            else
            {
                for (int i = 0; i < N-1; i++)
                {
                    result += alg.fact_list[i].num; // само число записали
                    if (alg.fact_list[i].deg > 1)
                    {
                        result += "^" + fact_list[i].deg;
                    }
                    result += ", ";
                }
                // отдельно выводим последний
                result += alg.fact_list[N-1].num; // само число записали
                if (alg.fact_list[N-1].deg > 1)
                {
                    result += "^" + fact_list[N-1].deg;
                }
            }

            result += "}";
            return result;
        }

        // Сортировка списка с множителями по показателю по возрастанию/убыванию
        // Параметр: true - по возрастанию, false - по убыванию
        static public  void SortList(bool mode)
        {
            // Алгоритм сортировки с сайта  https://metanit.com/sharp/tutorial/2.7.php
            // Код С# написан по алгоритму
            alg.factor temp;
            int N = alg.fact_list.Count;

            if (N > 1 && mode == true) // Сортировка по возрастанию
            {
                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (alg.fact_list[i].num > alg.fact_list[j].num)
                        {
                            temp = alg.fact_list[i];
                            alg.fact_list[i] = alg.fact_list[j];
                            alg.fact_list[j] = temp;
                        }
                    }
                }
            }
            else if (N > 1 && mode == false) // Сортировка по убыванию
            {
                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (alg.fact_list[i].num < alg.fact_list[j].num)
                        {
                            temp = alg.fact_list[i];
                            alg.fact_list[i] = alg.fact_list[j];
                            alg.fact_list[j] = temp;
                        }
                    }
                }
            }
            

        }
    }
}
