using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPortBDCourseWork
{
    public partial class Report_DepartureBoard : Form
    {
        public Report_DepartureBoard()
        {
            InitializeComponent();
        }

        private void Report_DepartureBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToDateTime(dateTimePicker1.Value.ToString())> Convert.ToDateTime(dateTimePicker2.Value.ToString()))
            {
                MessageBox.Show("\"From\" time bigger than \"To\" time");
            }
            else
            {
                string fromDate = dateTimePicker1.Value.ToString();
                string toDate = dateTimePicker2.Value.ToString();
                // TODO: This line of code loads data into the 'airPort2DataSet.View_DepartureBoard1' table. You can move, or remove it, as needed.
                this.view_DepartureBoard1TableAdapter.Fill(this.airPort2DataSet.View_DepartureBoard1, Convert.ToDateTime(fromDate), Convert.ToDateTime(toDate));

                this.reportViewer1.RefreshReport();
            }


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
