using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace LR_4.src.view
{
    public partial class AddWindow : Form
    {
        Db db = new Db();
        public AddWindow()
        {
            InitializeComponent();

        }


        private Boolean check()
        {
            var surname = SurnameBox.Text;
            var name = NameBox.Text;
            var fname = FnameBox.Text;
            var pasSeries = PasSeriesBox.Text;
            var pasNum = PasNumBox.Text;
            var IntPasSeries = IntSeriesBox.Text;
            var IntPasNum = IntNumBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select surname, name, fname, pasSeries, pasNum, IntPasSeries, IntPasNum from Tourist where surname='{surname}'and name='{name}' and fname='{fname}' and pasSeries='{pasSeries}' and pasNum='{pasNum}' and IntPasSeries= '{IntPasSeries}' and IntPasNum='{IntPasNum}'";
            SqlCommand command = new SqlCommand(query, db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь есть в базе данных");
                return true;
            }
            else
            {
                MessageBox.Show("Пользователя неееееееееееееет в базе данных");
                return false;
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (check())
            {
                return;
            }
            var surname = SurnameBox.Text;
            var name = NameBox.Text;
            var fname = FnameBox.Text;
            var pasSeries = PasSeriesBox.Text;
            var pasNum = PasNumBox.Text;
            var IntPasSeries = IntSeriesBox.Text;
            var IntPasNum = IntNumBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"Insert into Tourist(surname, name, fname, pasSeries, pasNum, IntPasSeries, IntPasNum) Values " +
                $"('{surname}', '{name}', '{fname}', '{pasSeries}', '{pasNum}', '{IntPasSeries}', '{IntPasNum}')";

            SqlCommand command = new SqlCommand(query, db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 2)
                MessageBox.Show("Пользователь добавлен");
            else
               MessageBox.Show("Пользователь не добавлен");


            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
