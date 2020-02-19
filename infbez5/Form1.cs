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
                            txt_file_in.Text = path;
                            txt_number.Value = chislo;
                            // Запуск Алгоритма факторизации
                        }
                        else
                        {
                            MessageBox.Show("Считанное число должно быть в границах от " + txt_number.Minimum + " до " + txt_number.Maximum +"!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Число из файла \"" + path + "\" не считалось!\nПроверьте данные в файле или выберите другой файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Файл \"" + path + "\" пуст!\nПроверьте данные в файле или выберите другой файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выбранного файла \"" + path + "\" не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_factor_Click(object sender, EventArgs e)
        {
            alg.find_factor(21);

        }
    }
}
