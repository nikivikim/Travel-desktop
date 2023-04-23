using LR_4.src.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace LR_4
{
    enum RowState
    {
        Existed, 
        New, 
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {

        Db db = new Db();
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
        }

//        private void Create()
//        {
//            dataGridView2.Columns.Add("id_Tourist", "id_Туриста");
//            dataGridView2.Columns.Add("id_Booking", "id_Бронирования");
//            dataGridView2.Columns.Add("status", "Статус");
//            dataGridView2.Columns.Add("Visa", "Виза");

//        }

//        private void ReadRow(DataGridView dgv, IDataRecord record)
//        {
//            dgv.Rows.Add(record.GetString(0), record.GetInt32(1),  record.GetInt32(2),  record.GetInt32(3), RowState.ModifiedNew);
//        }

//        private void RefreshData(DataGridView dgv)
//        {
//            dgv.Rows.Clear();
//            string query = $"select distinct c.surname, o.num, m.status, m.Visa from Tourist c, Booking o, Tourist_Booking m   where(c.id_Tourist = m.id_Tourist) and(o.id_Booking = m.id_Booking) and(c.surname = o.surname) ";
//            SqlCommand command = new SqlCommand(query, db.getConnection());
//            db.openConnection();
//            SqlDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                ReadRow(dgv, reader);

//            }
//            reader.Close();
//        }

//        private void CreateColumns()
//        {
//            dataGridView1.Columns.Add("id_Tourist", "id_Туриста");
//            dataGridView1.Columns.Add("surname", "Фамилия туриста");
//            dataGridView1.Columns.Add("name", "Имя туриста");
//            dataGridView1.Columns.Add("fname", "Фамилия туриста");
//            dataGridView1.Columns.Add("pasSeries", "Серия паспорта");
//            dataGridView1.Columns.Add("pasNum", "Номер паспорта");
//            dataGridView1.Columns.Add("IntPasSeries", "Серия загранпаспорта");
//            dataGridView1.Columns.Add("IntPasNum", "Номер загранпаспорта");
//;
//        }

//        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
//        {
//            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), record.GetInt32(7),  RowState.ModifiedNew);
//        }

//        private void RefreshDataGrid(DataGridView dgv)
//        {
//            dgv.Rows.Clear();
//            string query = $"Select * from tourist";
//            SqlCommand command = new SqlCommand(query,db.getConnection());
//            db.openConnection();
//            SqlDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                ReadSingleRow(dgv, reader);

//            }
//            reader.Close();
//        }


//        private void Form1_Load(object sender, EventArgs e)
//        {
//            CreateColumns();
//            RefreshDataGrid(dataGridView1);
//            Create();
//            RefreshData(dataGridView2);

//        }

//        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            selectedRow = e.RowIndex;
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = dataGridView1.Rows[selectedRow];
//                //textBoxNum.Text = row.Cells[0].Value.ToString();
//                //textBoxDepartureDate.Text = row.Cells[1].Value.ToString();
//                //textBoxConcDate.Text = row.Cells[2].Value.ToString();
//                //textBoxCountry.Text = row.Cells[3].Value.ToString();
//                //textBoxHotelName.Text = row.Cells[4].Value.ToString();
//                //textBoxHotelCategory.Text = row.Cells[5].Value.ToString();
//                //textBoxType.Text = row.Cells[6].Value.ToString();
//                //textBoxInsurance.Text = row.Cells[7].Value.ToString();
//                //textBoxSum.Text = row.Cells[8].Value.ToString();
//                //textBoxPrepayment.Text = row.Cells[9].Value.ToString();
//                textBoxSurname.Text = row.Cells[1].Value.ToString();
//                textBoxVisa.Text = row.Cells[0].Value.ToString();
//                //textBoxDays.Text = row.Cells[11].Value.ToString();


//            }
//        }
        private Boolean check()
        {
            var num = textBoxNum.Text;
            var departureDate = dateTimePicker2.Text;
            var concDate = dateTimePicker1.Text;
            var country = textBoxCountry.Text;
            var hotelName = textBoxHotelName.Text;
            var hotelCategory = textBoxHotelCategory.Text;
            var type = textBoxType.Text;
            var insurance = textBoxInsurance.Text;
            var sum = textBoxSum.Text;
            var prepayment = textBoxPrepayment.Text;
            var surname = textBoxSurname.Text;
            var days = textBoxDays.Text;
            var secsur = textBoxSecSurname.Text;
            var id_Tourist = textBoxVisa.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select num, departureDate, concDate, country, hotelName, hotelCategory, type, insurance, sum, prepayment, surname, days" +
                $" from Booking where num='{num}'and departureDate='{departureDate}' and concDate='{concDate}' and country='{country}' and hotelName='{hotelName}' and hotelCategory = '{hotelCategory}'" +
                $"and type= '{type}' and insurance='{insurance}'and sum='{sum}'and prepayment = '{prepayment}' and surname = '{surname}' and days = '{days}'";
            SqlCommand command = new SqlCommand(query, db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Бронирование есть в базе данных");
                return true;
            }
            else
            {
                MessageBox.Show("Бронирования неееееееееееееет в базе данных");
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query =
                "INSERT INTO booking (id_Meneger, num, departureDate, concDate, country, hotelName, hotelCategory, type, insurance, sum, prepayment, surname, days) " +
                    "VALUES ((select meneger_id from meneger where (@meneger=surname)), @num, @departureDate, @concDate, @country, @hotelName, @hotelCategory, @type, @insurance, @sum, @prepayment, @surname, @days)" +
                    "insert into Tourist_Booking(id_Tourist, id_Booking, status, visa) SELECT t.id_Tourist, b.id_Booking, '1' , '" + textBoxVisa.Text + "' from Tourist t, booking b where (T.surname='" + textBoxSurname.Text + "') and ( B.surname ='" + textBoxSurname.Text + "') AND  (T.surname=B.surname)";
                   



            try
            {
                SqlCommand command = new SqlCommand(query, db.getConnection());

                db.openConnection();

                command.Parameters.AddWithValue("@num", textBoxNum.Text);
                command.Parameters.AddWithValue("@meneger", textBoxMeneger.Text);
                command.Parameters.AddWithValue("@departureDate", dateTimePicker2.Text);
                command.Parameters.AddWithValue("@concDate", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@country", textBoxCountry.Text);
                command.Parameters.AddWithValue("@hotelName", textBoxHotelName.Text);
                command.Parameters.AddWithValue("@hotelCategory", textBoxHotelCategory.Text);
                command.Parameters.AddWithValue("@type", textBoxType.Text);
                command.Parameters.AddWithValue("@insurance", textBoxInsurance.Text);
                command.Parameters.AddWithValue("@sum", textBoxSum.Text);
                command.Parameters.AddWithValue("@prepayment", textBoxPrepayment.Text);
                command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                command.Parameters.AddWithValue("@days", textBoxDays.Text);
                command.Parameters.AddWithValue("@secsurname", textBoxSecSurname.Text);


                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Бронирование добавлено");
                else
                    MessageBox.Show("Бронирование  добавлено");

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        
    }

        //private void refresh_Click(object sender, EventArgs e)
        //{
        //    RefreshDataGrid(dataGridView1);
        //    RefreshData(dataGridView2);
        //}

        private void add_Click(object sender, EventArgs e)
        {
            AddWindow addform = new AddWindow();
            addform.Show();
        }


        //private void Search(DataGridView dgv)
        //{
        //    dgv.Rows.Clear();
        //    string query = $"select * from tourist where concat (surname, name, fname, pasSeries, pasNum, IntPasSeries, IntPasNum) like '%" + SearchTextBox.Text+"%'";
        //    SqlCommand command = new SqlCommand(query, db.getConnection());
        //    db.openConnection();
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        ReadSingleRow(dgv, reader);
        //    }
        //    reader.Close();
        //}

        //private void SearchTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    Search(dataGridView1);
        //}

        //private void deleterow() { 

        //int index = dataGridView1.CurrentCell.RowIndex;
        //    dataGridView1.Rows[index].Visible = false;
        //    if(dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
        //    {
        //        dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
        //        return;
        //    }
        //}

        //private void update()
        //{
            
        //    db.openConnection(); 
        //    for (int index = 0; index < dataGridView1.Rows.Count; index++)
        //    {
        //        var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

        //        if (rowState == RowState.Existed)

        //            continue;
        //        if (rowState == RowState.Deleted)
        //        {
        //            var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
        //            var query = $"delete from tourist where id = {id}";
        //            var comm = new SqlCommand(query, db.getConnection());
        //            comm.ExecuteNonQuery();
        //        }
        //    }
        //    db.closeConnection();
        //}


    //private void delete_Click(object sender, EventArgs e)
    //    {
    //        deleterow();
    //    }

    //    private void Save_Click(object sender, EventArgs e)
    //    {
    //        update();
    //    }

        private void button3_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("dogovor.doc.docx");

            var items = new Dictionary<string, string>
            {

                {"<DateF>", dateTimePicker2.Text},
                {"<date>", dateTimePicker1.Text },
                {"<country>", textBoxCountry.Text },
                {"<HotelName>", textBoxHotelName.Text },
                {"<Cat>", textBoxHotelCategory.Text },
                { "<type>", textBoxType.Text },
                {"<In>" ,textBoxInsurance.Text },
                { "<Sum>" ,textBoxSum.Text },
                {"<prep>", textBoxPrepayment.Text },
                {"<Surname>" ,textBoxSurname.Text },
                {"<Days>",  textBoxDays.Text },
                {"<Visa>",  textBoxVisa.Text },
                {"<Secsur>",  textBoxSecSurname.Text },

            };
            helper.Process(items);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "insert into  booking(id_Meneger,num, departureDate, concDate, country, hotelName, hotelCategory, type, insurance, sum, prepayment, surname, days) " +
                    "VALUES ((select meneger_id from meneger where (@meneger=surname)), @num, @departureDate, @concDate, @country, @hotelName, @hotelCategory, @type, @insurance, @sum, @prepayment, @secsurname, @days)" +
                    "insert into Tourist_Booking(id_Tourist, id_Booking, status, visa) SELECT t.id_Tourist, b.id_Booking, '0' , '" + textBoxVisa.Text + "' from Tourist t, booking b where(T.surname = '" + textBoxSecSurname.Text + "') and(B.surname = '" + textBoxSecSurname.Text + "') AND(T.surname = B.surname)";

            try
            {
                SqlCommand command = new SqlCommand(query, db.getConnection());

                db.openConnection();

                command.Parameters.AddWithValue("@num", textBoxNum.Text);
                command.Parameters.AddWithValue("@meneger", textBoxMeneger.Text);
                command.Parameters.AddWithValue("@departureDate", dateTimePicker2.Text);
                command.Parameters.AddWithValue("@concDate", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@country", textBoxCountry.Text);
                command.Parameters.AddWithValue("@hotelName", textBoxHotelName.Text);
                command.Parameters.AddWithValue("@hotelCategory", textBoxHotelCategory.Text);
                command.Parameters.AddWithValue("@type", textBoxType.Text);
                command.Parameters.AddWithValue("@insurance", textBoxInsurance.Text);
                command.Parameters.AddWithValue("@sum", textBoxSum.Text);
                command.Parameters.AddWithValue("@prepayment", textBoxPrepayment.Text);

                command.Parameters.AddWithValue("@visa", textBoxVisa.Text);
                command.Parameters.AddWithValue("@days", textBoxDays.Text);
                command.Parameters.AddWithValue("@secsurname", textBoxSecSurname.Text);


                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Бронирование добавлено");
                else
                    MessageBox.Show("Бронирование  добавлено");

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SqlConnectWithComboBox(string query)
        {
            try
            {
                SqlConnection sconn = new SqlConnection(textBoxConnectDB.Text);
                SqlCommand scomm = new SqlCommand(query, sconn);
                DataTable tableCity = new DataTable();
                SqlDataAdapter adapterCity = new SqlDataAdapter(scomm);
                adapterCity.Fill(tableCity);
                comboBox1.DataSource = tableCity;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";

                sconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            string cquery =
            "SELECT o.name as name, o.id FROM Operators o, contract c where c.EndDate < getdate() UNION ALL (SELECT '' AS name, 0 AS id)";
            SqlConnectWithComboBox(cquery);

        }
    }
}
