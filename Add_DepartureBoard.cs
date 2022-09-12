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
    public partial class Add_DepartureBoard : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public Add_DepartureBoard()
        {
            InitializeComponent();
        }

        private void departureConditionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departureConditionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airPort2DataSet);

        }

        private void Add_DepartureFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.View_DepartureFlight' table. You can move, or remove it, as needed.
            this.view_DepartureFlightTableAdapter.Fill(this.airPort2DataSet.View_DepartureFlight);
            // TODO: This line of code loads data into the 'airPort2DataSet.DepartureConditions' table. You can move, or remove it, as needed.
            this.departureConditionsTableAdapter.Fill(this.airPort2DataSet.DepartureConditions);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = departureConditionsDataGridView.CurrentRow.Index;
            String idCondition = departureConditionsDataGridView[0, indexCurrentRow].Value.ToString();

            indexCurrentRow = view_DepartureFlightDataGridView.CurrentRow.Index;
            String idFligth = view_DepartureFlightDataGridView[0, indexCurrentRow].Value.ToString();

            string sqlQuery = $"insert DepartureBoard Values ({idFligth},{idCondition})";
            SqlCommand sqlCommandAdd = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandAdd.ExecuteNonQuery();
            sqlConnection.Close();
            this.Close();
        }
    }
}
