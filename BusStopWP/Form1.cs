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
    public partial class Form1 : Form
    {
        //public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=busstop.mdb;";
        //public OleDbConnection myConnection;
        // создаем переменную и помещаем в нее ДНС ОДБС соединения
        public static string connectODBC = "Dsn=busstop;";
        // Создаем переменную класса ОдбсКоннекшен
  
        public OdbcConnection myOdbcConnection;

        public string user;
        public Form1()
        {
            InitializeComponent();
            //myConnection = new OleDbConnection(connect);
            //myConnection.Open();
            // Создаем объект класса майконешен одбс и передаем соединение в класс одсконнекшен
            myOdbcConnection = new OdbcConnection(connectODBC);
            // Открываем методом базу данных
            myOdbcConnection.Open();

        }

        //OleDbCommand cmd = new OleDbCommand();
        //OleDbCommand cmd2 = new OleDbCommand();
        //OleDbDataAdapter db = new OleDbDataAdapter();

        // создаем 3 объекта класса для выполнения склинструкции
        OdbcCommand cmdOdbc = new OdbcCommand();
        OdbcCommand cmdOdbc2 = new OdbcCommand();
        OdbcDataAdapter dbOdbc = new OdbcDataAdapter();

        private void label4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Hide();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM db_users WHERE id_user = '" + textUser.Text + "' AND id_password = '" + textPassword.Text + "'";
            //cmd = new OleDbCommand(query, myConnection);
            //cmd2 = new OleDbCommand(query, myConnection);

            // передаем в класс скл инсрукцию и имя соединения с базой
            cmdOdbc = new OdbcCommand(query, myOdbcConnection);
            cmdOdbc2 = new OdbcCommand(query, myOdbcConnection);
            //OleDbDataReader ole = cmd.ExecuteReader();
            //OleDbDataReader ole2 = cmd2.ExecuteReader();

            //создаем объекты для чтения из базы данных
            OdbcDataReader ole = cmdOdbc.ExecuteReader();
            OdbcDataReader ole2 = cmdOdbc2.ExecuteReader();
            string masteruser = "admin";
            user = textUser.Text;

            // читаем и проверяем условия совпадения
            if (ole.Read() == true & textUser.Text == masteruser)
            {
                new FormAdmin().Show();
                this.Hide();
            }

            else if (ole2.Read() == true)
            {
                
                new FormDB(user).Show();
                //new FormAdd();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Неправильный пользователь или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                textPassword.PasswordChar = '\0';
                

            }
            else
            {
                textPassword.PasswordChar = '*';
                
            }
        }
    }
}
