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
    public partial class FormDB : Form
    {
        bool sidebarExpand;
        //public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=busstop.mdb;";
        //public OleDbConnection myConnection;
        public static string connectODBC = "Dsn=busstop;";
        // Создаем переменную класса ОдбсКоннекшен

        public OdbcConnection myOdbcConnection;
        public string userName; 
        public FormDB(string user)
        {
            InitializeComponent();
            panelData.Hide();
            panelStatus.Hide();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            myOdbcConnection = new OdbcConnection(connectODBC);
            //myConnection = new OleDbConnection(connect);
            myOdbcConnection.Open();
            userName = user;
        }



        private void siderTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                siderbarContainer.Width -= 10;
                dataGridView1.Width += 10;
                dataGridView1.Location = new Point(81, 65);
                panelData.Hide();
                panelStatus.Hide();
                if (siderbarContainer.Width == siderbarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    siderTimer.Stop();
                }
            
            }
            else
            {
                siderbarContainer.Width += 10;
                dataGridView1.Location = new Point(205, 65);
                dataGridView1.Width -= 10;


                panelData.Show();
                panelStatus.Show();
                if (siderbarContainer.Width == siderbarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    siderTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            siderTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            if (FormDB.ActiveForm.Size.Width == 1184)
            {
                this.WindowState = FormWindowState.Maximized;
                //siderbarContainer.Height = FormDB.ActiveForm.Size.Height;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
           
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
            
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet3.db_bus". При необходимости она может быть перемещена или удалена.
            this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.db_bus". При необходимости она может быть перемещена или удалена.
            //this.db_busTableAdapter3.Fill(this.dataSet1.db_bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busstopDataSet2.db_bus". При необходимости она может быть перемещена или удалена.
            //this.db_busTableAdapter2.Fill(this.busstopDataSet2.db_bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busstopDataSet1.db_bus". При необходимости она может быть перемещена или удалена.
           // this.db_busTableAdapter1.Fill(this.busstopDataSet1.db_bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busstopDataSet.db_bus". При необходимости она может быть перемещена или удалена.
           // this.db_busTableAdapter.Fill(this.busstopDataSet.db_bus);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd(userName);
            form.Owner = this;
            form.ShowDialog();
        }

        private void click_seach_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string kod = textBox_gosnumber.Text;
                string query = $"SELECT * FROM db_bus WHERE db_gosnumber LIKE '%{kod}%'";
                //OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
                OdbcDataAdapter command = new OdbcDataAdapter(query, myOdbcConnection);
                DataTable dt = new DataTable();
                command.Fill(dt);
                dataGridView1.DataSource = dt;
            }    

            else
            {
                string kod = textBox_fio.Text;
                string query = $"SELECT * FROM db_bus WHERE db_name LIKE '%{kod}%'";
                //OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
                OdbcDataAdapter command = new OdbcDataAdapter(query, myOdbcConnection);
                DataTable dt = new DataTable();
                command.Fill(dt);
                dataGridView1.DataSource = dt;

            }
              
        }

        public void gridUpdate()
        {
            this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
            MessageBox.Show("Данные загружены");
            this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //myOdbcConnection.Open();
                int kod = Convert.ToInt32(textBox1.Text);
                int addday = Convert.ToInt32(textBox10.Text);
                string addTime = null;
                int addSumdate = 0;
                int addSumcash = 0;

                string queryAddTime = $"SELECT * FROM db_bus WHERE Код={kod}";
                OdbcCommand cmdOdbc = new OdbcCommand(queryAddTime, myOdbcConnection);
                cmdOdbc.CommandText = queryAddTime;
                OdbcDataReader reader = cmdOdbc.ExecuteReader();
                while (reader.Read())
                {
                    //comboBox1.Items.Add(reader["db_tsname"].ToString());
                    addTime = reader["db_date_vv"].ToString();
                    addSumdate = Convert.ToInt32(reader["db_sumdate"].ToString());
                    addSumcash = Convert.ToInt32(reader["db_sumcash"].ToString());
                }

                DateTime dtTime = Convert.ToDateTime(addTime);
                DateTime objTime = dtTime.AddDays(addday);

                int recAddSumdate = addday + addSumdate;
                int recDaaSumcash = (addSumcash / addSumdate) * recAddSumdate;

                string query = $"UPDATE db_bus SET db_status = 'Продлено', db_date_vv = '{objTime.ToString()}', db_sumdate = '{recAddSumdate}', db_sumcash = '{recDaaSumcash}' WHERE Код={kod}";
                //OleDbCommand command = new OleDbCommand(query, myConnection);
                OdbcCommand command = new OdbcCommand(query, myOdbcConnection);
                command.ExecuteNonQuery();
                this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
                MessageBox.Show("Стоянка машины продлена");
                this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
            }
            catch
            {
                MessageBox.Show("Вы ввели неправильные данные");

            }
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";

        }




        private void textBox7_Click_1(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void siderbarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siderbarContainer_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Код";
            textBox7.Text = "Код";
            textBox10.Text = "Количество суток";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button_add_date_Click(object sender, EventArgs e)
        {
            
            string kodVV = null;

            try
            {
                //myOdbcConnection.Open(); Проверка открытости соединения
                int kod = Convert.ToInt32(textBox7.Text);
                // Получаем нужную дату для сравнения
                string queryTime = $"SELECT * FROM db_bus WHERE Код={kod}";
                OdbcCommand cmdOdbc = new OdbcCommand(queryTime, myOdbcConnection);
                cmdOdbc.CommandText = queryTime;
                OdbcDataReader reader = cmdOdbc.ExecuteReader();
                while (reader.Read())
                {
                    //comboBox1.Items.Add(reader["db_tsname"].ToString());
                    kodVV = reader["db_date_vv"].ToString();
                }

                DateTime dt1 = Convert.ToDateTime(kodVV);
                DateTime dt2 = this.dateTimePicker1.Value;

                if (dt2.DayOfYear <= dt1.DayOfYear)
                {
                    string query = $"UPDATE db_bus SET db_status = 'Вывезена' WHERE Код={kod}";
                    //OleDbCommand command = new OleDbCommand(query, myConnection);
                    OdbcCommand command = new OdbcCommand(query, myOdbcConnection);
                    command.ExecuteNonQuery();
                    this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
                    MessageBox.Show("Машина вывезена");
                    this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
                }

                else
                {

                    string query = $"UPDATE db_bus SET db_status = 'Долг' WHERE Код={kod}";
                    //OleDbCommand command = new OleDbCommand(query, myConnection);
                    OdbcCommand command = new OdbcCommand(query, myOdbcConnection);
                    command.ExecuteNonQuery();
                    this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
                    MessageBox.Show("Долг у машины");
                    this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);


                }
            }
            catch (Exception exception)
            {


                MessageBox.Show("Вы ввели неправильные символы");




            }
        }

        public void NewForm()
        {

            FormAdd form2 = new FormAdd(userName);
            form2.Owner = this;
            form2.ShowDialog();
        }

        object sender_cell;
        DataGridViewCellEventArgs b;
       

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cellone = null; 
            string celladress = null;
            string celltypets = null;
            string cellgosnumber = null;
            string cellmarka = null;
            string cellmodel = null;

            if (b.RowIndex >= 0)
            { 
                DataGridViewRow row = dataGridView1.Rows [b.RowIndex];
                cellone = row.Cells[1].Value.ToString();
                celladress = row.Cells[2].Value.ToString();
                celltypets = row.Cells[9].Value.ToString();
                cellgosnumber = row.Cells[3].Value.ToString();
                cellmarka = row.Cells[4].Value.ToString();
                cellmodel = row.Cells[5].Value.ToString();
                MessageBox.Show(cellone);
            
            }



            FormAdd form2 = new FormAdd(userName, cellone, celladress, celltypets, cellgosnumber, cellmarka, cellmodel);
            form2.Owner = this;
            form2.ShowDialog();


        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sender_cell = sender;
            b = e;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_fio.Enabled = false;
                textBox_gosnumber.Enabled = true;
            }

            else

            {
                textBox_fio.Enabled = true;
                textBox_gosnumber.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string queryTime = $"SELECT * FROM db_bus";
            OdbcCommand cmdOdbc = new OdbcCommand(queryTime, myOdbcConnection);
            cmdOdbc.CommandText = queryTime;
            OdbcDataReader reader = cmdOdbc.ExecuteReader();
            while (reader.Read())
            {
                
                string kodVV = reader["db_date_vv"].ToString();

                DateTime dt1 = Convert.ToDateTime(kodVV);
                DateTime dt2 = this.dateTimePicker1.Value;


                if (dt2.DayOfYear > dt1.DayOfYear)
                {
                    string queryA = $"UPDATE db_bus SET db_status = 'Долг' WHERE db_date_vv < Date()";
                    //OleDbCommand command = new OleDbCommand(query, myConnection);
                    OdbcCommand commandA = new OdbcCommand(queryA, myOdbcConnection);
                    commandA.ExecuteNonQuery();
                    this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
                    
                    this.db_busTableAdapter4.Fill(this.dataSet3.db_bus);
                }
                
            }
            MessageBox.Show("Обновлено");


        }
    }
}
