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
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).BeginInit();
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
            this.btn_factor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_factor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_factor.Location = new System.Drawing.Point(279, 123);
            this.btn_factor.Name = "btn_factor";
            this.btn_factor.Size = new System.Drawing.Size(172, 64);
            this.btn_factor.TabIndex = 0;
            this.btn_factor.TabStop = false;
            this.btn_factor.Text = "Разложить\r\nна множители";
            this.btn_factor.UseVisualStyleBackColor = false;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_number.Location = new System.Drawing.Point(57, 134);
            this.txt_number.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txt_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(120, 38);
            this.txt_number.TabIndex = 1;
            this.txt_number.TabStop = false;
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.btn_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_file.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_file.FlatAppearance.BorderSize = 2;
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_file.Location = new System.Drawing.Point(390, 102);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(155, 53);
            this.btn_file.TabIndex = 3;
            this.btn_file.TabStop = false;
            this.btn_file.Text = "Выбрать файл\r\nи считать";
            this.btn_file.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(576, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.txt_file_in);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_factor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Факторизация числа";
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).EndInit();
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
    }
}

