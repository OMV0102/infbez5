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
            string tmp = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Выбрать файл ..."; // Заголовок окна
            //Начальный путь в окне - папка проекта
            opf.InitialDirectory = Application.StartupPath;


            if (opf.ShowDialog() == DialogResult.OK)
            {
                // получаем путь С НАЗВАНИЕМ файла
                tmp = opf.FileName;
            }

            if(File.Exists(tmp) == true)
            {
                
            }
            else
            {
                MessageBox.Show("Выбранного файла \"" + tmp + "\" не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
