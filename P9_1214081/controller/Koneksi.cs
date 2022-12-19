using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P9_1214081.controller
{
    internal class Koneksi
    {
        string conectionstring = "Server=localhost;Port=3307;Database=ulbi;Uid=root;Pwd=;";//disini server local host saya ganti
        MySqlConnection kon;

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost;Port=3307;Database=ulbi;Uid=root;Pwd=;";
            return conn;
        }

        public void OpenConnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }
    }
}
