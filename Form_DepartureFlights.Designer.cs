namespace AirPortBDCourseWork
{
    partial class Form_DepartureFlights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.airPort2DataSet = new AirPortBDCourseWork.AirPort2DataSet();
            this.view_DepartureFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DepartureFlightTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.View_DepartureFlightTableAdapter();
            this.tableAdapterManager = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager();
            this.view_DepartureFlightDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_First = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airPort2DataSet
            // 
            this.airPort2DataSet.DataSetName = "AirPort2DataSet";
            this.airPort2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_DepartureFlightBindingSource
            // 
            this.view_DepartureFlightBindingSource.DataMember = "View_DepartureFlight";
            this.view_DepartureFlightBindingSource.DataSource = this.airPort2DataSet;
            // 
            // view_DepartureFlightTableAdapter
            // 
            this.view_DepartureFlightTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirPortsTableAdapter = null;
            this.tableAdapterManager.ArrivalBoardTableAdapter = null;
            this.tableAdapterManager.ArrivalConditionsTableAdapter = null;
            this.tableAdapterManager.ArrivalFlightTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DepartureBoardTableAdapter = null;
            this.tableAdapterManager.DepartureConditionsTableAdapter = null;
            this.tableAdapterManager.DepartureFlightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_DepartureFlightDataGridView
            // 
            this.view_DepartureFlightDataGridView.AutoGenerateColumns = false;
            this.view_DepartureFlightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_DepartureFlightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.view_DepartureFlightDataGridView.DataSource = this.view_DepartureFlightBindingSource;
            this.view_DepartureFlightDataGridView.Location = new System.Drawing.Point(12, 12);
            this.view_DepartureFlightDataGridView.Name = "view_DepartureFlightDataGridView";
            this.view_DepartureFlightDataGridView.Size = new System.Drawing.Size(348, 426);
            this.view_DepartureFlightDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FlightNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "FlightNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameAirPort";
            this.dataGridViewTextBoxColumn3.HeaderText = "NameAirPort";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(366, 12);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(101, 58);
            this.button_First.TabIndex = 2;
            this.button_First.Text = "First";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(473, 12);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(101, 58);
            this.button_Last.TabIndex = 3;
            this.button_Last.Text = "Last";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(580, 12);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(101, 58);
            this.button_Previous.TabIndex = 4;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(687, 12);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(101, 58);
            this.button_Next.TabIndex = 5;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(366, 185);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(138, 76);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(654, 185);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(138, 76);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(510, 185);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(138, 76);
            this.button_Change.TabIndex = 7;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // Form_DepartureFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.view_DepartureFlightDataGridView);
            this.Name = "Form_DepartureFlights";
            this.Text = "Form_DepartureFlights";
            this.Load += new System.EventHandler(this.Form_DepartureFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource view_DepartureFlightBindingSource;
        private AirPort2DataSetTableAdapters.View_DepartureFlightTableAdapter view_DepartureFlightTableAdapter;
        private AirPort2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_DepartureFlightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Change;
    }
}