namespace infbez5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_factor = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.NumericUpDown();
            this.txt_file_in = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_factors = new System.Windows.Forms.Label();
            this.label_factors = new System.Windows.Forms.Label();
            this.label_range = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.Label();
            this.txt_iter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_factor
            // 
            this.btn_factor.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_factor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_factor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_factor.FlatAppearance.BorderSize = 2;
            this.btn_factor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_factor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_factor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_factor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_factor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_factor.Location = new System.Drawing.Point(189, 235);
            this.btn_factor.Name = "btn_factor";
            this.btn_factor.Size = new System.Drawing.Size(172, 64);
            this.btn_factor.TabIndex = 0;
            this.btn_factor.TabStop = false;
            this.btn_factor.Text = "Разложить\r\nна множители";
            this.btn_factor.UseVisualStyleBackColor = false;
            this.btn_factor.Click += new System.EventHandler(this.btn_factor_Click);
            // 
            // txt_number
            // 
            this.txt_number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_number.Location = new System.Drawing.Point(105, 184);
            this.txt_number.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txt_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(345, 44);
            this.txt_number.TabIndex = 1;
            this.txt_number.TabStop = false;
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_number.ThousandsSeparator = true;
            this.txt_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_number.ValueChanged += new System.EventHandler(this.txt_number_ValueChanged);
            // 
            // txt_file_in
            // 
            this.txt_file_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_file_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_in.Location = new System.Drawing.Point(73, 49);
            this.txt_file_in.Name = "txt_file_in";
            this.txt_file_in.ReadOnly = true;
            this.txt_file_in.Size = new System.Drawing.Size(484, 29);
            this.txt_file_in.TabIndex = 2;
            this.txt_file_in.TabStop = false;
            // 
            // btn_file
            // 
            this.btn_file.BackColor = System.Drawing.Color.LightGray;
            this.btn_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_file.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_file.FlatAppearance.BorderSize = 2;
            this.btn_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_file.Location = new System.Drawing.Point(211, 84);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(155, 53);
            this.btn_file.TabIndex = 3;
            this.btn_file.TabStop = false;
            this.btn_file.Text = "Выбрать файл\r\nи считать";
            this.btn_file.UseVisualStyleBackColor = false;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(153, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Считывание числа из файла";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Файл:";
            // 
            // txt_factors
            // 
            this.txt_factors.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_factors.Location = new System.Drawing.Point(10, 428);
            this.txt_factors.Name = "txt_factors";
            this.txt_factors.Size = new System.Drawing.Size(549, 78);
            this.txt_factors.TabIndex = 6;
            this.txt_factors.Text = "{ 1 }";
            this.txt_factors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_factors
            // 
            this.label_factors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_factors.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_factors.Location = new System.Drawing.Point(9, 394);
            this.label_factors.Name = "label_factors";
            this.label_factors.Size = new System.Drawing.Size(381, 35);
            this.label_factors.TabIndex = 7;
            this.label_factors.Text = "Множители числа";
            this.label_factors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_range
            // 
            this.label_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_range.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_range.Location = new System.Drawing.Point(12, 157);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(545, 28);
            this.label_range.TabIndex = 8;
            this.label_range.Text = "Диапозон ввода: от ";
            this.label_range.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(555, 137);
            this.label3.TabIndex = 9;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(555, 160);
            this.label4.TabIndex = 10;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(9, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(555, 194);
            this.label5.TabIndex = 11;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(389, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 112);
            this.label6.TabIndex = 13;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-1, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сортировка:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_time.Location = new System.Drawing.Point(48, 324);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(338, 30);
            this.txt_time.TabIndex = 16;
            this.txt_time.Text = "Время: 0";
            // 
            // txt_iter
            // 
            this.txt_iter.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_iter.Location = new System.Drawing.Point(15, 354);
            this.txt_iter.Name = "txt_iter";
            this.txt_iter.Size = new System.Drawing.Size(368, 30);
            this.txt_iter.TabIndex = 17;
            this.txt_iter.Text = "Итерации: 0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(389, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 112);
            this.panel1.TabIndex = 18;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(11, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 22);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "По убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(11, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(155, 22);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_factor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(576, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_iter);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_factors);
            this.Controls.Add(this.txt_file_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_factor);
            this.Controls.Add(this.label_range);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_factors);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Факторизация числа";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_factor;
        private System.Windows.Forms.NumericUpDown txt_number;
        private System.Windows.Forms.TextBox txt_file_in;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_factors;
        public System.Windows.Forms.Label txt_factors;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.Label txt_iter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

