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
    public partial class Form_AirPorts : Form
    {
        private static string connectionString = "Data Source=DESKTOP-IBTODF8;Initial Catalog = AirPort2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public Form_AirPorts()
        {
            InitializeComponent();
            textBox_Name_AirPort.Visible = false;
            button_ChangeAirPort.Visible = false;
            button_AddAirPort.Visible = false;  
        }

        private void airPortsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airPortsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airPort2DataSet);

        }

        private void Form_AirPorts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airPort2DataSet.AirPorts' table. You can move, or remove it, as needed.
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_Name_AirPort.Text = "";
            textBox_Name_AirPort.Visible = true;
            button_ChangeAirPort.Visible = true;
            int indexCurrentRow = airPortsDataGridView.CurrentRow.Index;
            textBox_Name_AirPort.Text = airPortsDataGridView[1, indexCurrentRow].Value.ToString();
        }
        public void SetNullCurrentRows_AirPort()
        {
            foreach (DataGridViewRow dataRow in airPortsDataGridView.Rows)
            {
                dataRow.Selected = false;
            }
        }
        public int FindSelectedRow_AirPort()
        {
            int indexSelectedRow = -1;

            foreach (DataGridViewRow dataRow in airPortsDataGridView.Rows)
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
            SetNullCurrentRows_AirPort();
            airPortsDataGridView.Rows[0].Selected = true;
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            SetNullCurrentRows_AirPort();
            airPortsDataGridView.Rows[airPortsDataGridView.RowCount - 2].Selected = true;
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow_AirPort();
            if (selectedRow == 0)
            {
                MessageBox.Show("previous row is out of table");
            }
            else
            {
                SetNullCurrentRows_AirPort();
                airPortsDataGridView.Rows[selectedRow - 1].Selected = true;
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            int selectedRow = FindSelectedRow_AirPort();
            if (selectedRow == airPortsDataGridView.RowCount - 2)
            {
                MessageBox.Show("next row is out of table");
            }
            else
            {
                SetNullCurrentRows_AirPort();
                airPortsDataGridView.Rows[selectedRow + 1].Selected = true;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            textBox_Name_AirPort.Visible = true;
            button_AddAirPort.Visible = true;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = airPortsDataGridView.CurrentRow.Index;
            String id = airPortsDataGridView[0, indexCurrentRow].Value.ToString();
            MessageBox.Show(id);

            string sqlQuery = $"delete AirPorts where ID = {id}";

            SqlCommand sqlCommandDelete = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandDelete.ExecuteNonQuery();
            sqlConnection.Close();
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);

        }

        private void button_AddAirPort_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"insert AirPorts Values ('{textBox_Name_AirPort.Text}')";
            SqlCommand sqlCommandAdd = new SqlCommand(sqlQuery, sqlConnection);

            sqlConnection.Open();
            sqlCommandAdd.ExecuteNonQuery();
            sqlConnection.Close();
            textBox_Name_AirPort.Visible = false;
            button_AddAirPort.Visible = false;
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);
            textBox_Name_AirPort.Text = "";
        }

        private void button_ChangeAirPort_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = airPortsDataGridView.CurrentRow.Index;
            string id = airPortsDataGridView[0, indexCurrentRow].Value.ToString();
            string airPortNamme = textBox_Name_AirPort.Text;

            string sqlQuery = $"update Airports  set nameAirPort = '{textBox_Name_AirPort.Text}' where ID = {id}";
            SqlCommand sqlCommandChange = new SqlCommand(sqlQuery, sqlConnection);

            MessageBox.Show(sqlQuery);

            sqlConnection.Open();
            sqlCommandChange.ExecuteNonQuery();
            sqlConnection.Close();
            this.airPortsTableAdapter.Fill(this.airPort2DataSet.AirPorts);
            textBox_Name_AirPort.Text = "";
            textBox_Name_AirPort.Visible = false;
            button_ChangeAirPort.Visible = false;
        }
    }
}
