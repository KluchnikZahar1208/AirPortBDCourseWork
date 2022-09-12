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
    public partial class Change_DepartureFlight : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public string ID, FlightNumber, NameAirPort, Time;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_AirPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form_AirPorts form_AirPorts = new Form_AirPorts();
            form_AirPorts.ShowDialog();
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);
        }

        private void dateTimePicker_DepartureTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_FlightNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"update DepartureFlight set FlightNumber = '{textBox_FlightNumber.Text}', IdAirPort = {comboBox_AirPorts.SelectedValue}, DepartureTime = '{dateTimePicker_DepartureTime.Value}' where ID = {ID}";
            SqlCommand sqlCommandChange = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandChange.ExecuteNonQuery();
            sqlConnection.Close();
            this.Close();
        }

        private void Change_DepartureFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.AirPorts' table. You can move, or remove it, as needed.
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);
            textBox_FlightNumber.Text = FlightNumber;
            comboBox_AirPorts.SelectedIndex = comboBox_AirPorts.FindString(NameAirPort);
            dateTimePicker_DepartureTime.Value = DateTime.Parse(Time);
        }

        public Change_DepartureFlight(string id, string flightNumber, string nameAirPort, string time)
        {
            InitializeComponent();
            ID = id;
            FlightNumber = flightNumber;
            NameAirPort = nameAirPort;
            Time = time;
        }
    }
}
