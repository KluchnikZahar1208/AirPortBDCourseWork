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
    public partial class Form_ArrivalFlights : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public Form_ArrivalFlights()
        {
            InitializeComponent();
        }

        private void Form_ArrivalFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.View_ArrivalFlight' table. You can move, or remove it, as needed.
            this.view_ArrivalFlightTableAdapter.Fill(this.airPort2DataSet.View_ArrivalFlight);

        }
        public void SetNullCurrentRows()
        {
            foreach (DataGridViewRow dataRow in view_ArrivalFlightDataGridView.Rows)
            {
                dataRow.Selected = false;
            }
        }
        public int FindSelectedRow()
        {
            int indexSelectedRow = -1;

            foreach (DataGridViewRow dataRow in view_ArrivalFlightDataGridView.Rows)
            {
                if (dataRow.Selected == true)
                {
                    indexSelectedRow = dataRow.Index;
                    break;
                }
            }
            return indexSelectedRow;
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows();
            view_ArrivalFlightDataGridView.Rows[0].Selected = true;
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows();
            view_ArrivalFlightDataGridView.Rows[view_ArrivalFlightDataGridView.RowCount - 2].Selected = true;
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow();
            if (selectedRow == 0)
            {
                MessageBox.Show("previous row is out of table");
            }
            else
            {
                SetNullCurrentRows();
                view_ArrivalFlightDataGridView.Rows[selectedRow - 1].Selected = true;
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow();
            if (selectedRow == view_ArrivalFlightDataGridView.RowCount - 2)
            {
                MessageBox.Show("next row is out of table");
            }
            else
            {
                SetNullCurrentRows();
                view_ArrivalFlightDataGridView.Rows[selectedRow + 1].Selected = true;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Add_ArrivalFlight add_ArrivalFlight = new Add_ArrivalFlight();
            add_ArrivalFlight.ShowDialog();
            this.view_ArrivalFlightTableAdapter.Fill(this.airPort2DataSet.View_ArrivalFlight);
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = view_ArrivalFlightDataGridView.CurrentRow.Index;
            string id = view_ArrivalFlightDataGridView[0, indexCurrentRow].Value.ToString();
            string flightNumber = view_ArrivalFlightDataGridView[1, indexCurrentRow].Value.ToString();
            string nameAirPort = view_ArrivalFlightDataGridView[2, indexCurrentRow].Value.ToString();
            string time = view_ArrivalFlightDataGridView[3, indexCurrentRow].Value.ToString();
            Change_ArrivalFlight change_ArrivalFlight = new Change_ArrivalFlight(id, flightNumber, nameAirPort, time);
            change_ArrivalFlight.ShowDialog();
            this.view_ArrivalFlightTableAdapter.Fill(this.airPort2DataSet.View_ArrivalFlight);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"delete ArrivalFlight where Id = {view_ArrivalFlightDataGridView[0, view_ArrivalFlightDataGridView.CurrentRow.Index].Value.ToString()}";
            SqlCommand sqlCommandAdd = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandAdd.ExecuteNonQuery();
            sqlConnection.Close();
            this.view_ArrivalFlightTableAdapter.Fill(this.airPort2DataSet.View_ArrivalFlight);

        }
    }
}
