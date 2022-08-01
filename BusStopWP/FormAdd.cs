using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Odbc;

namespace BusStopWP
{
    public partial class FormAdd : Form
    {
        //public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=busstop.mdb;";
        //public OleDbConnection myConnection;
        public static string connectODBC = "Dsn=busstop;";
        // Создаем переменную класса ОдбсКоннекшен

        public OdbcConnection myOdbcConnection;

        public string userIn;
        public int tarifOut;
        public int sumOut;
        public int sumCashOut;
        public string onecellbx;


        public FormAdd(string user)
        {
            InitializeComponent();
            //myConnection = new OleDbConnection(connect);
            //myConnection.Open();
            myOdbcConnection = new OdbcConnection(connectODBC);
            // Открываем методом базу данных
            myOdbcConnection.Open();
            userIn = user;
        }

        public FormAdd(string user, string onecell, string celladress, string celltypets, string cellgosnumber, string cellmarka, string cellmodel)
        {
            InitializeComponent();
            //myConnection = new OleDbConnection(connect);
            //myConnection.Open();
            myOdbcConnection = new OdbcConnection(connectODBC);
            // Открываем методом базу данных
            myOdbcConnection.Open();
            userIn = user;
            onecellbx = onecell;
            textBox1.Text = onecellbx.ToString();
            comboBox1.Text = celltypets.ToString();
            textBox6.Text = celladress.ToString();
            textBox2.Text = cellgosnumber.ToString();
            comboBox2.Text = cellmarka.ToString();
            textBox4.Text = cellmodel.ToString();

        }
        /// ///////Вывод из списка

        private void comboBox2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM db_car";
            //OleDbCommand command = new OleDbCommand(query, myConnection);
            OdbcCommand cmdOdbc = new OdbcCommand(query, myOdbcConnection);
            //command.CommandText = query;
            cmdOdbc.CommandText = query;

            //OleDbDataReader reader = command.ExecuteReader();
            OdbcDataReader reader = cmdOdbc.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["db_car_en"].ToString());
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM db_tipsts";
            //OleDbCommand command = new OleDbCommand(query, myConnection);
            OdbcCommand cmdOdbc = new OdbcCommand(query, myOdbcConnection);
            //command.CommandText = query;
            cmdOdbc.CommandText = query;

            OdbcDataReader reader = cmdOdbc.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["db_tsname"].ToString());
                //label10.Text = reader["db_tarif"].ToString();
            }

        }

        public void Sum()
        {


        }

        private void button_add_auto_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //string user = form1.user;
            string name = textBox1.Text;
            string gosnumber = textBox2.Text;
            string markaAuto = comboBox2.Text;
            string modelAuto = textBox4.Text;
            string adress = textBox6.Text;
            string mesto = textBox7.Text;
            string tsname = comboBox1.Text;
            
            
            // Добавление к дате количества суток
            int sumday = Convert.ToInt32(textBox5.Text);
            DateTime mdate = this.dateTimePicker1.Value;
            DateTime addd = mdate.AddDays(sumday);
            //label9.Text = addd.ToString();

            sumOut = sumday;



            //string b = "Mazda";
            string query = $"INSERT INTO db_bus (db_name, db_gosnumber, db_marka, db_model, db_sumdate, db_status, db_date_v, db_date_vv, db_adress, db_mesto, db_user, db_tipsts, db_sumcash) VALUES ('{name}', '{gosnumber}', '{markaAuto}', '{modelAuto}', '{sumday}', 'Стоит', '{this.dateTimePicker1.Text}', '{addd.ToString()}', '{adress}', '{mesto}', '{userIn}', '{tsname}', '{sumCashOut}')";

            //OleDbCommand command = new OleDbCommand(query, myConnection);
            OdbcCommand cmdOdbc = new OdbcCommand(query, myOdbcConnection);

            cmdOdbc.ExecuteNonQuery();
        }

        private void button_add_auto_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            FormDB form = this.Owner as FormDB;

            form.gridUpdate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM db_tipsts WHERE db_tsname='" + comboBox1.Text + "'";
            //OleDbCommand command = new OleDbCommand(query, myConnection);
            OdbcCommand cmdOdbc = new OdbcCommand(query, myOdbcConnection);
            cmdOdbc.CommandText = query;

            OdbcDataReader reader = cmdOdbc.ExecuteReader();
            while (reader.Read())
            {

                string tarif;
                tarif = reader["db_tarif"].ToString();
                label10.Text = tarif;
                //tarifOut = tarif;
                tarifOut = int.Parse(tarif);


            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            try
            {
                sumOut = Convert.ToInt32(textBox5.Text);
                int sumcash = tarifOut * sumOut;
                label13.Text = sumcash.ToString();
                sumCashOut = sumcash;
            }
            catch (Exception)
            {

                MessageBox.Show("Введите цифры в поле - Количестов суток");
            }
            
            

        }

        private void textBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
