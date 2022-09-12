using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPortBDCourseWork
{
    public partial class Add_ArrivalFlight : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public Add_ArrivalFlight()
        {
            InitializeComponent();
        }

        private void Add_ArrivalFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.AirPorts' table. You can move, or remove it, as needed.
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_FlightNumber.Text != "")
            {
                string sqlQuery = $"insert ArrivalFlight Values ('{textBox_FlightNumber.Text}',{comboBox_AirPorts.SelectedValue},'{dateTimePicker_ArrivalTime.Value.ToString()}')";
                SqlCommand sqlCommandAdd = new SqlCommand(sqlQuery, sqlConnection);

                sqlConnection.Open();
                sqlCommandAdd.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter Flight Number");
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form_AirPorts form_AirPorts = new Form_AirPorts();
            form_AirPorts.ShowDialog();
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);
        }
    }
}
