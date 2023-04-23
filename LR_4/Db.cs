using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4
{
    class Db
    {
        SqlConnection sqlConection = new SqlConnection(@"Data Source=VIKA-PC; Initial catalog=TravelAgency;Integrated Security=true");
        public void openConnection()
        {
            if (sqlConection.State == System.Data.ConnectionState.Closed)
                sqlConection.Open();
        }
        public void closeConnection()
        {
            if (sqlConection.State == System.Data.ConnectionState.Open)
                sqlConection.Close();
        }

        public SqlConnection getConnection()
        {
            return sqlConection;
        }
    }
}
