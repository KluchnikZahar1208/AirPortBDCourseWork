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
    public partial class Add_ArrivalBoard : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public Add_ArrivalBoard()
        {
            InitializeComponent();
        }

        private void arrivalConditionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.arrivalConditionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airPort2DataSet);

        }

        private void Add_ArrivalBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.View_ArrivalFlight' table. You can move, or remove it, as needed.
            this.view_ArrivalFlightTableAdapter.Fill(this.airPort2DataSet.View_ArrivalFlight);
            // TODO: This line of code loads data into the 'airPort2DataSet.ArrivalConditions' table. You can move, or remove it, as needed.
            this.arrivalConditionsTableAdapter.Fill(this.airPort2DataSet.ArrivalConditions);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = arrivalConditionsDataGridView.CurrentRow.Index;
            String idCondition = arrivalConditionsDataGridView[0, indexCurrentRow].Value.ToString();

            indexCurrentRow = view_ArrivalFlightDataGridView.CurrentRow.Index;
            String idFligth = view_ArrivalFlightDataGridView[0, indexCurrentRow].Value.ToString();

            string sqlQuery = $"insert ArrivalBoard Values ({idFligth},{idCondition})";
            SqlCommand sqlCommandAdd = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandAdd.ExecuteNonQuery();
            sqlConnection.Close();
            this.Close();
        }
    }
}
