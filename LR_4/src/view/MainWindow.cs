using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LR_4.src.view
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Point lastPoint;

        Db db = new Db();
        int selectedRow;




        private void CreateColumns()
       {            dataGridView1.Columns.Add("contract_id", "id_Договора");
            dataGridView1.Columns.Add("surname", "Фамилия менеджера");
            dataGridView1.Columns.Add("name", "Название туроператора");
            dataGridView1.Columns.Add("num", "Номер договора");
            dataGridView1.Columns.Add("DateConclusion", "Дата заключения договора");
            dataGridView1.Columns.Add("EndDate", "Дата окончания договора");

;
        }

               private void ReadSingleRow(DataGridView dgv, IDataRecord record)
               {
                   dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3),record.GetDateTime(4), record.GetDateTime(5),   RowState.ModifiedNew);
               }

               private void RefreshDataGrid(DataGridView dgv)
               {
                   dgv.Rows.Clear();
                   string query = $"select c.contract_id as [id_договора], m.surname as [Фамилия менеджера] , o.name as [Наименование турператора] ,c.num as [Номер договора]," +
                $" c.DateConclusion as [Дата заключения договора], c.EndDate as [Дата окончния договора] from contract c, operators o, meneger m" +
                           " where(c.Operatorname = o.id) and(c.meneger_id = m.meneger_id)";
                   SqlCommand command = new SqlCommand(query,db.getConnection());
                   db.openConnection();
                   SqlDataReader reader = command.ExecuteReader();
                     while (reader.Read())
                    {
                        ReadSingleRow(dgv, reader);

                    }
                    reader.Close();
                }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"select c.contract_id as [id_договора], m.surname as [Фамилия менеджера] , o.name as [Наименование турператора] ,c.num as [Номер договора]," +
                $" c.DateConclusion as [Дата заключения договора], c.EndDate as [Дата окончния договора] from contract c, operators o, meneger m" +
                "  where (c.Operatorname = o.id) and(c.meneger_id = m.meneger_id) and (concat (m.surname,o.name, c.num, c.DateConclusion, EndDate) like '%" + SearchTextBox.Text+"%')";
            SqlCommand command = new SqlCommand(query, db.getConnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
             
                Search(dataGridView1);
            
        }

        private void btn_Add(object sender, EventArgs e)
        {
            this.Hide();
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }



        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_MouseEnter_1(object sender, EventArgs e)
        {
            Close.ForeColor = System.Drawing.Color.Red;
        }

        private void Close_MouseLeave_1(object sender, EventArgs e)
        {
            Close.ForeColor = System.Drawing.Color.Black;
        }



        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
             RefreshDataGrid(dataGridView1);


        }
        private void RefreshData(DataGridView dgv)
        {

            dgv.Rows.Clear();
            string query = $"select c.contract_id as [id_договора], m.surname as [Фамилия менеджера] , o.name as [Наименование турператора] ,c.num as [Номер договора]," +
         $" c.DateConclusion as [Дата заключения договора], c.EndDate as [Дата окончния договора] from contract c, operators o, meneger m" +
                    " where(c.Operatorname = o.id) and(c.meneger_id = m.meneger_id) and (c.DateConclusion >= DATEADD(MONTH, DATEDIFF(MONTH, 0, CURRENT_TIMESTAMP), 0)) AND(c.DateConclusion < DATEADD(MONTH, DATEDIFF(MONTH, 0, CURRENT_TIMESTAMP) + 1, 0))"; 
            SqlCommand command = new SqlCommand(query, db.getConnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);

            }
            reader.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RefreshData(dataGridView1);
        }





























        //private void SqlConnectWithDataGrid(string query)
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(textBoxConnectDB.Text);
        //        SqlCommand comm = new SqlCommand(query, conn);
        //        DataTable table = new DataTable();
        //        SqlDataAdapter adapter = new SqlDataAdapter(comm);
        //        adapter.Fill(table);
        //        dataGridView1.DataSource = table;
        //        dataGridView1.Columns[0].Visible = false;

        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void MainWindow_Shown(object sender, System.EventArgs e)
        //{


        //    string query = "select c.contract_id as [id_договора], m.surname as [Фамилия менеджера] , o.name as [Наименование турператора] ,c.num as [Номер договора], c.DateConclusion as [Дата заключения договора], c.EndDate as [Дата окончния договора] from contract c, operators o, meneger m" +
        //        " where(c.Operatorname = o.id) and(c.meneger_id = m.meneger_id)";

        //    SqlConnectWithDataGrid(query);
        //}

        ////private void ComboBoxCity_TextChanged(object sender, EventArgs e)
        ////{
        ////    string query;
        ////    if (comboBoxCity.Text == "")
        ////        query = "select c.contract_id as [id_договора],m.surname as [Фамилия менеджера] , o.name as [Наименование турператора] ,c.num as [Номер договора], c.DateConclusion as [Дата заключения договора], c.EndDate as [Дата окончния договора]from contract c, operators o, " +
        ////            "meneger m where(c.Operatorname = o.id) and(c.meneger_id = m.meneger_id)";
        ////    else
        ////        query = "select c.contract_id as [id_договора], m.surname as [Фамилия менеджера] , o.name as [Наименование турператора] ,c.num as [Номер договора], c.DateConclusion as [Дата заключения договора], c.EndDate as [Дата окончния договора] from contract c, operators o, " +
        ////                            "meneger m where(c.Operatorname = o.id) and(c.meneger_id = m.meneger_id) and (c.EndDate LIKE '" + comboBoxCity.Text + "%')";

        ////    SqlConnectWithDataGrid(query);
        ////}




    }
}
