using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace infbez5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // кнопка ВЫБРАТЬ ФАЙЛ
        private void btn_file_Click(object sender, EventArgs e)
        {
            string path = "";
            string tmp = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Текстовые файлы|*.txt";
            opf.Title = "Выбрать файл ..."; // Заголовок окна
            //Начальный путь в окне - папка проекта
            opf.InitialDirectory = Application.StartupPath;


            if (opf.ShowDialog() == DialogResult.OK)
            {
                // получаем путь С НАЗВАНИЕМ файла
                path = opf.FileName;
            }

            Int64 chislo = 0;
            if(File.Exists(path) == true)
            {
                tmp = File.ReadAllText(path);
                if(tmp.Length > 0)
                {
                    if(Int64.TryParse(tmp, out chislo))
                    {
                        if (chislo >= txt_number.Minimum && chislo <= txt_number.Maximum)
                        {
                            txt_number.Value = chislo;
                            txt_file_in.Text = path;
                            // Запуск Алгоритма факторизации
                        }
                        else
                        {
                            MessageBox.Show("Считанное число не положительное или очень велико!\n Допустимый диапозон: от " + txt_number.Minimum + " до " + txt_number.Maximum +".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Число из файла {" + path + "}\nНЕ считалось!\nПроверьте данные в файле:\n\t* Число должно быть целым,\n\t* Без пробелов и разделителей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Файл {" + path + "} пуст!\nПроверьте данные в файле или выберите другой файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выбранного файла {" + path + "} НЕ существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка РАЗЛОЖИТЬ НА МНОЖИТЕЛИ
        private void btn_factor_Click(object sender, EventArgs e)
        {
            // фича против бага в NumericUpDown
            // на случай если ввели значение и стерли
            // оно опять появится
            String tmp = txt_file_in.Text;
            if (txt_number.Value == txt_number.Maximum)
            {
                txt_number.Value--;
                txt_number.Value++;
            }
            else
            {
                txt_number.Value++;
                txt_number.Value--;
            }
            txt_file_in.Text = tmp;
            
            Int64 n = (Int64)txt_number.Value;
            txt_factors.Text = "{ }";
            txt_iter.Text = "Итерации: 0";
            txt_time.Text = "Время: 0";

            // Отключаем форму на время факторизации и делаем ждущий курсор
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;

            DateTime start = DateTime.Now; // старт замера времени
            alg.factorization(n); // запускаем факторизацию
            DateTime end = DateTime.Now; // конец замера времени
            TimeSpan tm = end - start; // вычисляем разницу

            alg.SortList(alg.sortMode); // Cортировка по возрастанию
            txt_factors.Text = alg.listToString(); // выводим множители на форму
            txt_iter.Text = "Итерации: " + alg.iter; // выводим итерации
            if (tm.Hours == 0)
            {
                if (tm.Minutes == 0) // выводим время разложения
                {
                    if (tm.Seconds == 0)
                    {
                        if (tm.Milliseconds == 0)
                            txt_time.Text = "Время: < 1мс.";
                        else
                            txt_time.Text = "Время: " + tm.Milliseconds + "мс.";
                    }
                    else
                        txt_time.Text = "Время: " + tm.Seconds + "с. " + tm.Milliseconds + "мс.";
                }
                else
                    txt_time.Text = "Время: " + tm.Minutes + "м. " + tm.Seconds + "с. " + tm.Milliseconds + "мс.";
            }
            else
                txt_time.Text = "Время: " + tm.Hours + "ч. " + tm.Minutes + "м. " + tm.Seconds + "с. " + tm.Milliseconds + "мс.";

            // Включаем форму и делаем обычный курсор
            this.Cursor = Cursors.Arrow;
            this.Enabled = true;
        }

        // при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            alg.fact_list = new List<alg.factor>(); // выделяем память под список множетелей
            label_range.Text += txt_number.Minimum.ToString() + " до " + txt_number.Maximum.ToString("### ### ### ### ### ###") + ".";
            alg.sortMode = true; // по дефолту сортировка по возрастанию
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        // галочка По возрастанию
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (alg.fact_list.Count > 1)
            {
                alg.sortMode = true;
                alg.SortList(alg.sortMode); // Cортировка по возрастанию
                txt_factors.Text = alg.listToString(); // выводим множители на форму
            }
        }

        // галочка По убыванию
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (alg.fact_list.Count > 1)
            {
                alg.sortMode = false;
                alg.SortList(alg.sortMode); // Cортировка по возрастанию
                txt_factors.Text = alg.listToString(); // выводим множители на форму
            }
        }

        // при изменении значения
        private void txt_number_ValueChanged(object sender, EventArgs e)
        {
            alg.fact_list.Clear();
            txt_factors.Text = "{ }";
            txt_file_in.Text = "";
        }
    }
}
