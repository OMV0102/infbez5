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
            alg.fact_list = new List<alg.factor>(); // выделяем память под список множетелей
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
                            txt_file_in.Text = path;
                            txt_number.Value = chislo;
                            // Запуск Алгоритма факторизации
                        }
                        else
                        {
                            MessageBox.Show("Считанное число не положительное или очень велико!\n Допустимый диапозон: от " + txt_number.Minimum + " до " + txt_number.Maximum +".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Число из файла {" + path + "} НЕ считалось!\nПроверьте данные в файле (число должно быть целым) или выберите другой файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Int64 n = (Int64)txt_number.Value;
            txt_factors.Text = "{ }";

            alg.factorization(n); // запускаем факторизацию
            
            txt_factors.Text = alg.listToString();
        }
    }
}
