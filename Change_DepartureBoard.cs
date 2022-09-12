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
    public partial class Change_DepartureBoard : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public string ID, IDFlight, IDConditions;

        private void Change_DepartureBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.DepartureConditions' table. You can move, or remove it, as needed.
            this.departureConditionsTableAdapter.Fill(this.airPort2DataSet.DepartureConditions);
            // TODO: This line of code loads data into the 'airPort2DataSet.View_DepartureFlight' table. You can move, or remove it, as needed.
            this.view_DepartureFlightTableAdapter.Fill(this.airPort2DataSet.View_DepartureFlight);

            FindInRows_DepartureFlight(IDFlight);
            FindInRows_DepartureConditions(IDConditions);
        }

        public Change_DepartureBoard(string id, string idFlight, string idConditions)
        {
            InitializeComponent();
            ID = id;
            IDFlight = idFlight;
            IDConditions = idConditions;
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = departureConditionsDataGridView.CurrentRow.Index;
            String idCondition = departureConditionsDataGridView[0, indexCurrentRow].Value.ToString();
            indexCurrentRow = view_DepartureFlightDataGridView.CurrentRow.Index;
            String idFligth = view_DepartureFlightDataGridView[0, indexCurrentRow].Value.ToString();

            string sqlQuery = $"update DepartureBoard set IdConditions = {idCondition}, IdFlight = {idFligth} where ID = {ID}";
            SqlCommand sqlCommandChange = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandChange.ExecuteNonQuery();
            sqlConnection.Close();
            this.Close();
        }

        public void FindInRows_DepartureFlight(string id)
        {
            for (int i = 0; i < view_DepartureFlightDataGridView.RowCount; i++)
            {
                if (view_DepartureFlightDataGridView[0, i].FormattedValue.ToString() == id)
                {
                    view_DepartureFlightDataGridView.CurrentCell = view_DepartureFlightDataGridView[1, i];
                    return;
                }
            }
        }
        public void FindInRows_DepartureConditions(string id)
        {
            for (int i = 0; i < departureConditionsDataGridView.RowCount; i++)
            {
                if (departureConditionsDataGridView[0, i].FormattedValue.ToString() == id)
                {
                    departureConditionsDataGridView.CurrentCell = departureConditionsDataGridView[1, i];
                    return;
                }
            }
        }
    }
}
