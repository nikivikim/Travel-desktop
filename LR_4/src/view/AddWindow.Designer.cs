namespace LR_4.src.view
{
    partial class AddWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.IntNumBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IntSeriesBox = new System.Windows.Forms.TextBox();
            this.PasNumBox = new System.Windows.Forms.TextBox();
            this.PasSeriesBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.IntNumBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.IntSeriesBox);
            this.panel1.Controls.Add(this.PasNumBox);
            this.panel1.Controls.Add(this.PasSeriesBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FnameBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.SurnameBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 1241);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(168, 1127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(144, 947);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(712, 48);
            this.label9.TabIndex = 14;
            this.label9.Text = "Введите номер загранпаспорта туриста";
            // 
            // IntNumBox
            // 
            this.IntNumBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntNumBox.Location = new System.Drawing.Point(152, 1009);
            this.IntNumBox.Multiline = true;
            this.IntNumBox.Name = "IntNumBox";
            this.IntNumBox.Size = new System.Drawing.Size(753, 45);
            this.IntNumBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(144, 832);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(716, 48);
            this.label8.TabIndex = 12;
            this.label8.Text = "Введите серию загранпаспорта туриста";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(144, 700);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(663, 48);
            this.label7.TabIndex = 11;
            this.label7.Text = "Введите номер паспорта РФ туриста";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(144, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(667, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введите серию паспорта РФ туриста";
            // 
            // IntSeriesBox
            // 
            this.IntSeriesBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntSeriesBox.Location = new System.Drawing.Point(152, 883);
            this.IntSeriesBox.Multiline = true;
            this.IntSeriesBox.Name = "IntSeriesBox";
            this.IntSeriesBox.Size = new System.Drawing.Size(753, 45);
            this.IntSeriesBox.TabIndex = 9;
            // 
            // PasNumBox
            // 
            this.PasNumBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasNumBox.Location = new System.Drawing.Point(152, 760);
            this.PasNumBox.Multiline = true;
            this.PasNumBox.Name = "PasNumBox";
            this.PasNumBox.Size = new System.Drawing.Size(753, 45);
            this.PasNumBox.TabIndex = 8;
            // 
            // PasSeriesBox
            // 
            this.PasSeriesBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasSeriesBox.Location = new System.Drawing.Point(152, 641);
            this.PasSeriesBox.Multiline = true;
            this.PasSeriesBox.Name = "PasSeriesBox";
            this.PasSeriesBox.Size = new System.Drawing.Size(753, 45);
            this.PasSeriesBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(144, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(484, 48);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите Отчество туриста";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(144, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите Имя туриста";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(144, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите Фамилию туриста";
            // 
            // FnameBox
            // 
            this.FnameBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FnameBox.Location = new System.Drawing.Point(152, 508);
            this.FnameBox.Multiline = true;
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(753, 45);
            this.FnameBox.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(152, 385);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(753, 45);
            this.NameBox.TabIndex = 2;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.Location = new System.Drawing.Point(152, 258);
            this.SurnameBox.Multiline = true;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(753, 45);
            this.SurnameBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 178);
            this.panel2.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Close.Location = new System.Drawing.Point(1047, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(48, 48);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Humnst777 Cn BT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1095, 178);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить туриста";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 1241);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWindow";
            this.Text = "AddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IntSeriesBox;
        private System.Windows.Forms.TextBox PasNumBox;
        private System.Windows.Forms.TextBox PasSeriesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IntNumBox;
        private System.Windows.Forms.Label label8;
    }
}

