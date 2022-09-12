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
    public partial class Form_DepartureFlights : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public Form_DepartureFlights()
        {
            InitializeComponent();
        }

        private void Form_DepartureFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.View_DepartureFlight' table. You can move, or remove it, as needed.
            this.view_DepartureFlightTableAdapter.Fill(this.airPort2DataSet.View_DepartureFlight);

        }
        public void SetNullCurrentRows()
        {
            foreach (DataGridViewRow dataRow in view_DepartureFlightDataGridView.Rows)
            {
                dataRow.Selected = false;
            }
        }
        public int FindSelectedRow()
        {
            int indexSelectedRow = -1;

            foreach (DataGridViewRow dataRow in view_DepartureFlightDataGridView.Rows)
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
            view_DepartureFlightDataGridView.Rows[0].Selected = true;
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows();
            view_DepartureFlightDataGridView.Rows[view_DepartureFlightDataGridView.RowCount - 2].Selected = true;
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
                view_DepartureFlightDataGridView.Rows[selectedRow - 1].Selected = true;
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow();
            if (selectedRow == view_DepartureFlightDataGridView.RowCount - 2)
            {
                MessageBox.Show("next row is out of table");
            }
            else
            {
                SetNullCurrentRows();
                view_DepartureFlightDataGridView.Rows[selectedRow + 1].Selected = true;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Add_DepartureFlight add_DepartureFlight = new Add_DepartureFlight();
            add_DepartureFlight.ShowDialog();
            this.view_DepartureFlightTableAdapter.Fill(this.airPort2DataSet.View_DepartureFlight);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"delete DepartureFlight where Id = {view_DepartureFlightDataGridView[0, view_DepartureFlightDataGridView.CurrentRow.Index].Value.ToString()}";
            SqlCommand sqlCommandAdd = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandAdd.ExecuteNonQuery();
            sqlConnection.Close();
            this.view_DepartureFlightTableAdapter.Fill(this.airPort2DataSet.View_DepartureFlight);
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = view_DepartureFlightDataGridView.CurrentRow.Index;
            string id = view_DepartureFlightDataGridView[0, indexCurrentRow].Value.ToString();
            string flightNumber = view_DepartureFlightDataGridView[1, indexCurrentRow].Value.ToString();
            string nameAirPort = view_DepartureFlightDataGridView[2, indexCurrentRow].Value.ToString();
            string time = view_DepartureFlightDataGridView[3, indexCurrentRow].Value.ToString();
            Change_DepartureFlight change_DepartureFlight = new Change_DepartureFlight(id, flightNumber, nameAirPort, time);
            change_DepartureFlight.ShowDialog();
            this.view_DepartureFlightTableAdapter.Fill(this.airPort2DataSet.View_DepartureFlight);
        }
    }
}
