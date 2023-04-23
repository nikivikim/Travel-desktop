namespace LR_4.src.view
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnectDB = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            // 
            // textBoxConnectDB
            // 
            this.textBoxConnectDB.Location = new System.Drawing.Point(15, 722);
            this.textBoxConnectDB.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxConnectDB.Multiline = true;
            this.textBoxConnectDB.Name = "textBoxConnectDB";
            this.textBoxConnectDB.Size = new System.Drawing.Size(10, 10);
            this.textBoxConnectDB.TabIndex = 4;
            this.textBoxConnectDB.Text = "Data Source=VIKA-PC; Initial catalog=TravelAgency;Integrated Security=true";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.SystemColors.Info;
            this.Close.Location = new System.Drawing.Point(1480, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 25);
            this.Close.TabIndex = 6;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter_1);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.textBoxConnectDB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1607, 859);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1602, 726);
            this.dataGridView1.TabIndex = 8;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(935, 58);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(299, 29);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1272, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(485, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Договора за месяц";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1605, 855);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по туроператорам";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnectDB;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}