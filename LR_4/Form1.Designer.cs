namespace LR_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxConnectDB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxSecSurname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxVisa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.textBoxPrepayment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxInsurance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHotelCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxMeneger = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 100);
            this.panel1.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(21, 51);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(307, 43);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить туриста";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.textBoxConnectDB);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 1400);
            this.panel2.TabIndex = 1;
            // 
            // textBoxConnectDB
            // 
            this.textBoxConnectDB.Location = new System.Drawing.Point(0, 1384);
            this.textBoxConnectDB.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxConnectDB.Multiline = true;
            this.textBoxConnectDB.Name = "textBoxConnectDB";
            this.textBoxConnectDB.Size = new System.Drawing.Size(10, 10);
            this.textBoxConnectDB.TabIndex = 5;
            this.textBoxConnectDB.Text = "Data Source=VIKA-PC; Initial catalog=TravelAgency;Integrated Security=true";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxMeneger);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.textBoxSecSurname);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.textBoxVisa);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBoxSurname);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBoxType);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxDays);
            this.panel3.Controls.Add(this.textBoxPrepayment);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxSum);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxInsurance);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxHotelCategory);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxHotelName);
            this.panel3.Controls.Add(this.textBoxCountry);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxNum);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 1371);
            this.panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 1155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 32);
            this.comboBox1.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 1156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 33);
            this.label15.TabIndex = 36;
            this.label15.Text = "Туроператор";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 1298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(336, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Напечатать лист бронирования";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 1298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 46);
            this.button4.TabIndex = 35;
            this.button4.Text = "Создать запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxSecSurname
            // 
            this.textBoxSecSurname.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecSurname.Location = new System.Drawing.Point(523, 925);
            this.textBoxSecSurname.Multiline = true;
            this.textBoxSecSurname.Name = "textBoxSecSurname";
            this.textBoxSecSurname.Size = new System.Drawing.Size(218, 55);
            this.textBoxSecSurname.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 925);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(242, 33);
            this.label14.TabIndex = 33;
            this.label14.Text = "Фамилия 2 туриста";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(538, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // textBoxVisa
            // 
            this.textBoxVisa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVisa.Location = new System.Drawing.Point(523, 1091);
            this.textBoxVisa.Multiline = true;
            this.textBoxVisa.Name = "textBoxVisa";
            this.textBoxVisa.Size = new System.Drawing.Size(218, 45);
            this.textBoxVisa.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 1091);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 33);
            this.label13.TabIndex = 29;
            this.label13.Text = "Виза в страну";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 1298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(523, 854);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(218, 45);
            this.textBoxSurname.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 847);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 33);
            this.label12.TabIndex = 27;
            this.label12.Text = "Фамилия главного туриста";
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(523, 525);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(218, 45);
            this.textBoxType.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(312, 33);
            this.label11.TabIndex = 25;
            this.label11.Text = "Введите тип размещения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 1012);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 33);
            this.label10.TabIndex = 24;
            this.label10.Text = "Количество дней";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDays.Location = new System.Drawing.Point(523, 1012);
            this.textBoxDays.Multiline = true;
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(218, 45);
            this.textBoxDays.TabIndex = 23;
            // 
            // textBoxPrepayment
            // 
            this.textBoxPrepayment.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrepayment.Location = new System.Drawing.Point(523, 764);
            this.textBoxPrepayment.Multiline = true;
            this.textBoxPrepayment.Name = "textBoxPrepayment";
            this.textBoxPrepayment.Size = new System.Drawing.Size(218, 45);
            this.textBoxPrepayment.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 764);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 33);
            this.label9.TabIndex = 21;
            this.label9.Text = "Сумма предоплаты (в рублях)";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(523, 687);
            this.textBoxSum.Multiline = true;
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(218, 45);
            this.textBoxSum.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 687);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "Сумма (в рублях)";
            // 
            // textBoxInsurance
            // 
            this.textBoxInsurance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInsurance.Location = new System.Drawing.Point(523, 612);
            this.textBoxInsurance.Multiline = true;
            this.textBoxInsurance.Name = "textBoxInsurance";
            this.textBoxInsurance.Size = new System.Drawing.Size(218, 45);
            this.textBoxInsurance.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Страховка (да/нет)";
            // 
            // textBoxHotelCategory
            // 
            this.textBoxHotelCategory.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHotelCategory.Location = new System.Drawing.Point(523, 434);
            this.textBoxHotelCategory.Multiline = true;
            this.textBoxHotelCategory.Name = "textBoxHotelCategory";
            this.textBoxHotelCategory.Size = new System.Drawing.Size(218, 45);
            this.textBoxHotelCategory.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите категорию отеля";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите название отеля";
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHotelName.Location = new System.Drawing.Point(523, 349);
            this.textBoxHotelName.Multiline = true;
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(218, 45);
            this.textBoxHotelName.TabIndex = 13;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountry.Location = new System.Drawing.Point(523, 269);
            this.textBoxCountry.Multiline = true;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(218, 45);
            this.textBoxCountry.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите Страну";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите дату закючения бронирования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите даты отправления";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNum.Location = new System.Drawing.Point(523, 29);
            this.textBoxNum.Multiline = true;
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(218, 45);
            this.textBoxNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите номер листа бронирования";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(8, 1225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(259, 33);
            this.label16.TabIndex = 38;
            this.label16.Text = "Фамилия менеджера";
            // 
            // textBoxMeneger
            // 
            this.textBoxMeneger.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMeneger.Location = new System.Drawing.Point(520, 1216);
            this.textBoxMeneger.Multiline = true;
            this.textBoxMeneger.Name = "textBoxMeneger";
            this.textBoxMeneger.Size = new System.Drawing.Size(218, 45);
            this.textBoxMeneger.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 1500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Лист бронирования";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHotelName;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxInsurance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHotelCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.TextBox textBoxPrepayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVisa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSecSurname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxConnectDB;
        private System.Windows.Forms.TextBox textBoxMeneger;
        private System.Windows.Forms.Label label16;
    }
}