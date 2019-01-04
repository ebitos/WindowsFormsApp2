using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MySQLへの接続情報
            string server = "localhost";
            string user = "root";
            string pass = "password";
            string database = "mysql";

            string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3}", server, database, user, pass);
            MySqlConnection connection = new MySqlConnection(connectionString);

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from test_db.person where address = '東京都'", connection);

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
