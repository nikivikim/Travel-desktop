using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace LR_4
{
    public partial class Form3 : Form
    {
        Db db = new Db();
        int selectedRow;
        public Form3()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_Booking", "id_Бронирования");
            dataGridView1.Columns.Add("id_Meneger", "Фамилия Менеджера");
            dataGridView1.Columns.Add("num", "Номер договора");
            dataGridView1.Columns.Add("DepartureDate", "Дата отправления");
            dataGridView1.Columns.Add("ConcDate", "Дата заключения договора");
            dataGridView1.Columns.Add("Country", "Страна");
            dataGridView1.Columns.Add("HotelName", "Название отеля");
            dataGridView1.Columns.Add("HotelCategory", "Категория отеля");
            dataGridView1.Columns.Add("Type", "Тип размещения");
            dataGridView1.Columns.Add("Insurance", "Наличие страховки");
            dataGridView1.Columns.Add("Sum", "Сумма");
            dataGridView1.Columns.Add("Prepayment", "Предоплата ");
            dataGridView1.Columns.Add("surname", "Фамилия туриста ");
            dataGridView1.Columns.Add("Days", "Количество дней");
            ;
        }

                private void ReadSingleRow(DataGridView dgv, IDataRecord record)
                {
                    dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetDateTime(3),record.GetDateTime(4), record.GetString(5), 
                        record.GetString(6),  record.GetInt32(7), record.GetString(8), record.GetInt32(9), record.GetInt32(10), record.GetInt32(11), record.GetString(12),
                        record.GetInt32(13),
                         RowState.ModifiedNew);
               }

                private void RefreshDataGrid(DataGridView dgv)
               {
                    dgv.Rows.Clear();
            string query = $"select Booking.id_Booking,m.surname, Booking.num, Booking.DepartureDate, Booking.ConcDate, Booking.Country, Booking.HotelName, Booking.HotelCategory, Booking.Type, Booking.Insurance, Booking.Sum, Booking.Prepayment," +
        $"t.surname, Booking.Days from Booking , Meneger m, Tourist t, Tourist_Booking tb   where(t.id_Tourist = tb.id_Tourist) and (Booking.id_Booking = tb.id_Booking) and(Booking.surname = t.surname) and (m.meneger_id=Booking.id_Meneger) ";

                    SqlCommand command = new SqlCommand(query,db.getConnection());
                    db.openConnection();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingleRow(dgv, reader);

                    }
                    reader.Close();
                }

        private void Form3_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void RefreshD(DataGridView dgv)
        {

            dgv.Rows.Clear();
            string query = $"select Booking.id_Booking,m.surname, Booking.num, Booking.DepartureDate, Booking.ConcDate, Booking.Country, Booking.HotelName, Booking.HotelCategory, Booking.Type, Booking.Insurance, Booking.Sum, Booking.Prepayment," +
        $"t.surname, Booking.Days from Booking , Meneger m, Tourist t, Tourist_Booking tb   where(t.id_Tourist = tb.id_Tourist) and (Booking.id_Booking = tb.id_Booking) and(Booking.surname = t.surname) and (m.meneger_id=Booking.id_Meneger) and (tb.Status = '1')";
            SqlCommand command = new SqlCommand(query, db.getConnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);

            }
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshD(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
