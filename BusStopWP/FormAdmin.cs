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
    public partial class FormAdmin : Form
    {
        //public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=busstop.mdb;";
        //public OleDbConnection myConnection;
        public static string connectODBC = "Dsn=busstop;";
        // Создаем переменную класса ОдбсКоннекшен

        public OdbcConnection myOdbcConnection;
        public FormAdmin()
        {
            InitializeComponent();

            //myConnection = new OleDbConnection(connect);
            myOdbcConnection = new OdbcConnection(connectODBC);
            //myConnection.Open();
        }

        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter db = new OleDbDataAdapter();
        OdbcCommand cmdOdbc = new OdbcCommand();
        OdbcDataAdapter dbOdbc = new OdbcDataAdapter();
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "" && textPassword.Text == "" && textPassword1.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textPassword.Text == textPassword1.Text)
            {
                myOdbcConnection.Open();
                string query = "INSERT INTO db_users (id_user, id_password) VALUES ('" + textUser.Text + "', '" + textPassword.Text + "')";
                //cmd = new OleDbCommand(query, myConnection);
                cmdOdbc = new OdbcCommand(query, myOdbcConnection);
                cmdOdbc.ExecuteNonQuery();
                myOdbcConnection.Close();
                textUser.Text = "";
                textPassword.Text = "";
                textPassword1.Text = "";
                MessageBox.Show("Вы успешно добавили пользователя", "Добавление выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ошибка ввода пароля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUser.Text = "";
                textPassword.Text = "";
                textPassword1.Text = "";

            }


        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                textPassword.PasswordChar = '\0';
                textPassword1.PasswordChar = '\0';

            }
            else 
            {
                textPassword.PasswordChar = '*';
                textPassword1.PasswordChar = '*';
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textUser.Text = "";
            textPassword.Text = "";
            textPassword1.Text = "";
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet7.db_tipsts". При необходимости она может быть перемещена или удалена.
            this.db_tipstsTableAdapter.Fill(this.dataSet7.db_tipsts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet6.db_users". При необходимости она может быть перемещена или удалена.
            this.db_usersTableAdapter.Fill(this.dataSet6.db_users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet5.db_tarif". При необходимости она может быть перемещена или удалена.
            this.db_tarifTableAdapter.Fill(this.dataSet5.db_tarif);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet4.db_bus". При необходимости она может быть перемещена или удалена.
            this.db_busTableAdapter.Fill(this.dataSet4.db_bus);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportAll reportall = new ReportAll();
            reportall.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportTips reportTips = new ReportTips(); 
            reportTips.Show();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportCashDay reportCashDay = new ReportCashDay();  
            reportCashDay.Show();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportCashMonth reportCashMonth = new ReportCashMonth(); 
            reportCashMonth.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportCashDebt reportCashDebt = new ReportCashDebt();
            reportCashDebt.Show();
        }
    }
}
