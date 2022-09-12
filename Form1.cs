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
    public partial class MainForm : Form
    {

        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public MainForm()
        {
            InitializeComponent();
            tabPage1.Text = "Departure Flight";
            tabPage2.Text = "Arrival Flight";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.View_ArrivalBoard' table. You can move, or remove it, as needed.
            this.view_ArrivalBoardTableAdapter.Fill(this.airPort2DataSet.View_ArrivalBoard);
            // TODO: This line of code loads data into the 'airPort2DataSet.View_DepartureBoard' table. You can move, or remove it, as needed.
            this.view_DepartureBoardTableAdapter.Fill(this.airPort2DataSet.View_DepartureBoard);
            this.view_ArrivalBoardDataGridView.Columns[0].Visible = false;
        }
        public void SetNullCurrentRows()
        {
            foreach (DataGridViewRow dataRow in view_DepartureBoardDataGridView.Rows)
            {
                dataRow.Selected = false;
            }
            foreach (DataGridViewRow dataRow in view_ArrivalBoardDataGridView.Rows)
            {
                dataRow.Selected = false;
            }
        }
        private void button_Departure_First_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows();
            view_DepartureBoardDataGridView.Rows[0].Selected = true;
        }
        private void button_Departure_Last_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows();
            view_DepartureBoardDataGridView.Rows[view_DepartureBoardDataGridView.Rows.Count-2].Selected = true;
        }
        private void button_Arrival_First_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows();
            view_ArrivalBoardDataGridView.Rows[0].Selected = true;
        }
        private void button_Arrival_Last_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows();
            view_ArrivalBoardDataGridView.Rows[view_ArrivalBoardDataGridView.Rows.Count-2].Selected = true;
        }
        public int FindSelectedRow_ArrivalBoard()
        {
            int indexSelectedRow = -1;

            foreach (DataGridViewRow dataRow in view_ArrivalBoardDataGridView.Rows)
            {
                if (dataRow.Selected == true)
                {
                    indexSelectedRow = dataRow.Index;
                    break;
                }
            }
            return indexSelectedRow;
        }
        private void button_Arriaval_Previous_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow_ArrivalBoard();
            if (selectedRow == 0)
            {
                MessageBox.Show("previous row is out of table");
            }
            else
            {
                SetNullCurrentRows();
                view_ArrivalBoardDataGridView.Rows[selectedRow - 1].Selected = true;
            }
        }
        private void button_Arriaval_Next_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow_ArrivalBoard();
            if (selectedRow == view_ArrivalBoardDataGridView.RowCount - 2)
            {
                MessageBox.Show("next row is out of table");
            }
            else
            {
                SetNullCurrentRows();
                view_ArrivalBoardDataGridView.Rows[selectedRow + 1].Selected = true;
            }
        }
        public int FindSelectedRow_DepartureBoard()
        {
            int indexSelectedRow = -1;

            foreach (DataGridViewRow dataRow in view_DepartureBoardDataGridView.Rows)
            {
                if (dataRow.Selected == true)
                {
                    indexSelectedRow = dataRow.Index;
                    break;
                }
            }
            return indexSelectedRow;
        }
        private void button_Departure_Previous_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow_DepartureBoard();
            if (selectedRow == 0)
            {
                MessageBox.Show("previous row is out of table");
            }
            else
            {
                SetNullCurrentRows();
                view_DepartureBoardDataGridView.Rows[selectedRow - 1].Selected = true;
            }
        }
        private void button_Departure_Next_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow_DepartureBoard();
            if (selectedRow == view_DepartureBoardDataGridView.RowCount - 2)
            {
                MessageBox.Show("next row is out of table");
            }
            else
            {
                SetNullCurrentRows();
                view_DepartureBoardDataGridView.Rows[selectedRow + 1].Selected = true;
            }
        }

        private void button_Departure_Add_Click(object sender, EventArgs e)
        {
            Add_DepartureBoard add_DepartureBoard = new Add_DepartureBoard();
            add_DepartureBoard.ShowDialog();
            this.view_DepartureBoardTableAdapter.Fill(this.airPort2DataSet.View_DepartureBoard);

        }
        private void button_Departure_ViewDepartureFlight_Click(object sender, EventArgs e)
        {
            Form_DepartureFlights form_DepartureFlights = new Form_DepartureFlights();
            form_DepartureFlights.ShowDialog();
        }
        private void button_Departure_Delete_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = view_DepartureBoardDataGridView.CurrentRow.Index;
            String id = view_DepartureBoardDataGridView[0, indexCurrentRow].Value.ToString();

            string sqlQuery = $"delete DepartureBoard where ID = {id}";

            SqlCommand sqlCommandDelete = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandDelete.ExecuteNonQuery();
            sqlConnection.Close();
            this.view_DepartureBoardTableAdapter.Fill(this.airPort2DataSet.View_DepartureBoard);

        }
        private void button_Departure_Change_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = view_DepartureBoardDataGridView.CurrentRow.Index;
            string id = view_DepartureBoardDataGridView[0, indexCurrentRow].Value.ToString();
            string idFlight = view_DepartureBoardDataGridView[1, indexCurrentRow].Value.ToString();
            string idCondition = view_DepartureBoardDataGridView[5, indexCurrentRow].Value.ToString();
            Change_DepartureBoard change_DepartureBoard = new Change_DepartureBoard(id, idFlight, idCondition);
            change_DepartureBoard.ShowDialog();
            this.view_DepartureBoardTableAdapter.Fill(this.airPort2DataSet.View_DepartureBoard);

        }

        private void button_Arrival_Add_Click(object sender, EventArgs e)
        {
            Add_ArrivalBoard add_ArrivalBoard = new Add_ArrivalBoard();
            add_ArrivalBoard.ShowDialog();
            this.view_ArrivalBoardTableAdapter.Fill(this.airPort2DataSet.View_ArrivalBoard);
        }
        private void button_Arrival_ViewArrivalFlights_Click(object sender, EventArgs e)
        {
            Form_ArrivalFlights form_ArrivalFlights = new Form_ArrivalFlights();
            form_ArrivalFlights.ShowDialog();
        }
        private void button_Arriaval_Delete_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = view_ArrivalBoardDataGridView.CurrentRow.Index;
            String id = view_ArrivalBoardDataGridView[0, indexCurrentRow].Value.ToString();

            string sqlQuery = $"delete ArrivalBoard where ID = {id}";

            SqlCommand sqlCommandDelete = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandDelete.ExecuteNonQuery();
            sqlConnection.Close();
            this.view_ArrivalBoardTableAdapter.Fill(this.airPort2DataSet.View_ArrivalBoard);

        }
        private void button_Arriaval_Change_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = view_ArrivalBoardDataGridView.CurrentRow.Index;
            string id = view_ArrivalBoardDataGridView[0, indexCurrentRow].Value.ToString();
            string idFlight = view_ArrivalBoardDataGridView[1, indexCurrentRow].Value.ToString();
            string idCondition = view_ArrivalBoardDataGridView[5, indexCurrentRow].Value.ToString();
            Change_ArrivalBoard change_ArrivalBoard = new Change_ArrivalBoard(id, idFlight, idCondition);
            change_ArrivalBoard.ShowDialog();   
            this.view_ArrivalBoardTableAdapter.Fill(this.airPort2DataSet.View_ArrivalBoard);
        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_DepartureBoard report_DepartureBoard = new Report_DepartureBoard();
            report_DepartureBoard.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_ArrivalBoard report_ArrivalBoard = new Report_ArrivalBoard();    
            report_ArrivalBoard.ShowDialog();
        }

        private void button_ReportArrival_Click(object sender, EventArgs e)
        {
            Report_ArrivalBoard report_ArrivalBoard = new Report_ArrivalBoard();
            report_ArrivalBoard.ShowDialog();
        }
    }
}
