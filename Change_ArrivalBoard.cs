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
    public partial class Change_ArrivalBoard : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public string ID, IDFlight, IDConditions;
        public Change_ArrivalBoard(string id, string idFlight, string idConditions)
        {
            InitializeComponent();
            ID = id;
            IDFlight = idFlight;
            IDConditions = idConditions;
        }

        private void Change_ArrivalBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.ArrivalConditions' table. You can move, or remove it, as needed.
            this.arrivalConditionsTableAdapter.Fill(this.airPort2DataSet.ArrivalConditions);
            // TODO: This line of code loads data into the 'airPort2DataSet.View_ArrivalFlight' table. You can move, or remove it, as needed.
            this.view_ArrivalFlightTableAdapter.Fill(this.airPort2DataSet.View_ArrivalFlight);
            FindInRows_ArrivalFlight(IDFlight);
            FindInRows_ArrivalConditions(IDConditions);
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = arrivalConditionsDataGridView.CurrentRow.Index;
            String idCondition = arrivalConditionsDataGridView[0, indexCurrentRow].Value.ToString();
            indexCurrentRow = view_ArrivalFlightDataGridView.CurrentRow.Index;
            String idFligth = view_ArrivalFlightDataGridView[0, indexCurrentRow].Value.ToString();

            string sqlQuery = $"update ArrivalBoard set IdConditions = {idCondition}, IdFlight = {idFligth} where ID = {ID}";
            SqlCommand sqlCommandChange = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandChange.ExecuteNonQuery();
            sqlConnection.Close();
            this.Close();
        }
        public void FindInRows_ArrivalFlight(string id)
        {
            for (int i = 0; i < view_ArrivalFlightDataGridView.RowCount; i++)
            {
                if (view_ArrivalFlightDataGridView[0, i].FormattedValue.ToString() == id)
                {
                    view_ArrivalFlightDataGridView.CurrentCell = view_ArrivalFlightDataGridView[1, i];
                    return;
                }
            }
        }
        public void FindInRows_ArrivalConditions(string id)
        {
            for (int i = 0; i < arrivalConditionsDataGridView.RowCount; i++)
            {
                if (arrivalConditionsDataGridView[0, i].FormattedValue.ToString() == id)
                {
                    arrivalConditionsDataGridView.CurrentCell = arrivalConditionsDataGridView[1, i];
                    return;
                }
            }
        }
    }
}
