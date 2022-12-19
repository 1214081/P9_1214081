using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214081.view
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connectionString = "datasource=127.0.0.1;port=3307;username=root;password=;database=ulbi;";
        public void login()
        {
            string query = "SELECT * FROM user WHERE username='" + tbUsername.Text + "' AND password='" + tbPassword.Text + "'";
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username dan password tidak valid");
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
