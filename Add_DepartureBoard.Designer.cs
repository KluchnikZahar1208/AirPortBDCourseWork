namespace AirPortBDCourseWork
{
    partial class Add_DepartureBoard
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
            this.departureConditionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureConditionsTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.DepartureConditionsTableAdapter();
            this.tableAdapterManager = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager();
            this.departureFlightTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.DepartureFlightTableAdapter();
            this.departureConditionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DepartureFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DepartureFlightTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.View_DepartureFlightTableAdapter();
            this.view_DepartureFlightDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureConditionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureConditionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airPort2DataSet
            // 
            this.airPort2DataSet.DataSetName = "AirPort2DataSet";
            this.airPort2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departureConditionsBindingSource
            // 
            this.departureConditionsBindingSource.DataMember = "DepartureConditions";
            this.departureConditionsBindingSource.DataSource = this.airPort2DataSet;
            // 
            // departureConditionsTableAdapter
            // 
            this.departureConditionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirPortsTableAdapter = null;
            this.tableAdapterManager.ArrivalBoardTableAdapter = null;
            this.tableAdapterManager.ArrivalConditionsTableAdapter = null;
            this.tableAdapterManager.ArrivalFlightTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartureBoardTableAdapter = null;
            this.tableAdapterManager.DepartureConditionsTableAdapter = this.departureConditionsTableAdapter;
            this.tableAdapterManager.DepartureFlightTableAdapter = this.departureFlightTableAdapter;
            this.tableAdapterManager.UpdateOrder = AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departureFlightTableAdapter
            // 
            this.departureFlightTableAdapter.ClearBeforeFill = true;
            // 
            // departureConditionsDataGridView
            // 
            this.departureConditionsDataGridView.AutoGenerateColumns = false;
            this.departureConditionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departureConditionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.departureConditionsDataGridView.DataSource = this.departureConditionsBindingSource;
            this.departureConditionsDataGridView.Location = new System.Drawing.Point(355, 1);
            this.departureConditionsDataGridView.Name = "departureConditionsDataGridView";
            this.departureConditionsDataGridView.Size = new System.Drawing.Size(161, 340);
            this.departureConditionsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Conditions";
            this.dataGridViewTextBoxColumn2.HeaderText = "Conditions";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // departureFlightBindingSource
            // 
            this.departureFlightBindingSource.DataMember = "DepartureFlight";
            this.departureFlightBindingSource.DataSource = this.airPort2DataSet;
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
            // view_DepartureFlightDataGridView
            // 
            this.view_DepartureFlightDataGridView.AutoGenerateColumns = false;
            this.view_DepartureFlightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_DepartureFlightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.view_DepartureFlightDataGridView.DataSource = this.view_DepartureFlightBindingSource;
            this.view_DepartureFlightDataGridView.Location = new System.Drawing.Point(2, 1);
            this.view_DepartureFlightDataGridView.Name = "view_DepartureFlightDataGridView";
            this.view_DepartureFlightDataGridView.Size = new System.Drawing.Size(347, 340);
            this.view_DepartureFlightDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FlightNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "FlightNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NameAirPort";
            this.dataGridViewTextBoxColumn5.HeaderText = "NameAirPort";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 347);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(504, 99);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Add_DepartureBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.view_DepartureFlightDataGridView);
            this.Controls.Add(this.departureConditionsDataGridView);
            this.Name = "Add_DepartureBoard";
            this.Text = "Add_DepartureBoard";
            this.Load += new System.EventHandler(this.Add_DepartureFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureConditionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureConditionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureFlightDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource departureConditionsBindingSource;
        private AirPort2DataSetTableAdapters.DepartureConditionsTableAdapter departureConditionsTableAdapter;
        private AirPort2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView departureConditionsDataGridView;
        private AirPort2DataSetTableAdapters.DepartureFlightTableAdapter departureFlightTableAdapter;
        private System.Windows.Forms.BindingSource departureFlightBindingSource;
        private System.Windows.Forms.BindingSource view_DepartureFlightBindingSource;
        private AirPort2DataSetTableAdapters.View_DepartureFlightTableAdapter view_DepartureFlightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView view_DepartureFlightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_Add;
    }
}