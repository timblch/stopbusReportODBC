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
        public static string connectODBC = "Dns=busstop;";
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busstopDataSet2.db_bus". При необходимости она может быть перемещена или удалена.
            this.db_busTableAdapter2.Fill(this.busstopDataSet2.db_bus);
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
            string kod = textBox_fio.Text;
            string query = $"SELECT * FROM db_bus WHERE db_name LIKE '%{kod}%'";
            //OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            OdbcDataAdapter command = new OdbcDataAdapter(query, myOdbcConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void gridUpdate()
        {
            this.db_busTableAdapter2.Fill(this.busstopDataSet2.db_bus);
            MessageBox.Show("Данные загружены");
            this.db_busTableAdapter2.Fill(this.busstopDataSet2.db_bus);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myOdbcConnection.Open();
            }
            catch
            {
                int kod = Convert.ToInt32(textBox1.Text);
                string query = $"UPDATE db_bus SET db_status = 'Продлено' WHERE Код={kod}";

                //OleDbCommand command = new OleDbCommand(query, myConnection);
                OdbcCommand command = new OdbcCommand(query, myOdbcConnection);
                command.ExecuteNonQuery();
                this.db_busTableAdapter2.Fill(this.busstopDataSet2.db_bus);
                MessageBox.Show("Стоянка машины продлена");
                this.db_busTableAdapter2.Fill(this.busstopDataSet2.db_bus);

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

        }
    }
}
