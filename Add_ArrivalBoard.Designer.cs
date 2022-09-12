namespace AirPortBDCourseWork
{
    partial class Add_ArrivalBoard
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
            this.arrivalConditionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arrivalConditionsTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.ArrivalConditionsTableAdapter();
            this.tableAdapterManager = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager();
            this.arrivalConditionsDataGridView = new System.Windows.Forms.DataGridView();
            this.view_ArrivalBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ArrivalBoardTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.View_ArrivalBoardTableAdapter();
            this.view_ArrivalFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ArrivalFlightTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.View_ArrivalFlightTableAdapter();
            this.view_ArrivalFlightDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airPort2DataSet
            // 
            this.airPort2DataSet.DataSetName = "AirPort2DataSet";
            this.airPort2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arrivalConditionsBindingSource
            // 
            this.arrivalConditionsBindingSource.DataMember = "ArrivalConditions";
            this.arrivalConditionsBindingSource.DataSource = this.airPort2DataSet;
            // 
            // arrivalConditionsTableAdapter
            // 
            this.arrivalConditionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirPortsTableAdapter = null;
            this.tableAdapterManager.ArrivalBoardTableAdapter = null;
            this.tableAdapterManager.ArrivalConditionsTableAdapter = this.arrivalConditionsTableAdapter;
            this.tableAdapterManager.ArrivalFlightTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartureBoardTableAdapter = null;
            this.tableAdapterManager.DepartureConditionsTableAdapter = null;
            this.tableAdapterManager.DepartureFlightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // arrivalConditionsDataGridView
            // 
            this.arrivalConditionsDataGridView.AutoGenerateColumns = false;
            this.arrivalConditionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrivalConditionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.arrivalConditionsDataGridView.DataSource = this.arrivalConditionsBindingSource;
            this.arrivalConditionsDataGridView.Location = new System.Drawing.Point(358, 2);
            this.arrivalConditionsDataGridView.Name = "arrivalConditionsDataGridView";
            this.arrivalConditionsDataGridView.Size = new System.Drawing.Size(151, 342);
            this.arrivalConditionsDataGridView.TabIndex = 1;
            // 
            // view_ArrivalBoardBindingSource
            // 
            this.view_ArrivalBoardBindingSource.DataMember = "View_ArrivalBoard";
            this.view_ArrivalBoardBindingSource.DataSource = this.airPort2DataSet;
            // 
            // view_ArrivalBoardTableAdapter
            // 
            this.view_ArrivalBoardTableAdapter.ClearBeforeFill = true;
            // 
            // view_ArrivalFlightBindingSource
            // 
            this.view_ArrivalFlightBindingSource.DataMember = "View_ArrivalFlight";
            this.view_ArrivalFlightBindingSource.DataSource = this.airPort2DataSet;
            // 
            // view_ArrivalFlightTableAdapter
            // 
            this.view_ArrivalFlightTableAdapter.ClearBeforeFill = true;
            // 
            // view_ArrivalFlightDataGridView
            // 
            this.view_ArrivalFlightDataGridView.AutoGenerateColumns = false;
            this.view_ArrivalFlightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ArrivalFlightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.view_ArrivalFlightDataGridView.DataSource = this.view_ArrivalFlightBindingSource;
            this.view_ArrivalFlightDataGridView.Location = new System.Drawing.Point(2, 2);
            this.view_ArrivalFlightDataGridView.Name = "view_ArrivalFlightDataGridView";
            this.view_ArrivalFlightDataGridView.Size = new System.Drawing.Size(350, 342);
            this.view_ArrivalFlightDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ArrivalTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "ArrivalTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn2.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(2, 350);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(504, 99);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Add_ArrivalBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.view_ArrivalFlightDataGridView);
            this.Controls.Add(this.arrivalConditionsDataGridView);
            this.Name = "Add_ArrivalBoard";
            this.Text = "Add_ArrivalBoard";
            this.Load += new System.EventHandler(this.Add_ArrivalBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource arrivalConditionsBindingSource;
        private AirPort2DataSetTableAdapters.ArrivalConditionsTableAdapter arrivalConditionsTableAdapter;
        private AirPort2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView arrivalConditionsDataGridView;
        private System.Windows.Forms.BindingSource view_ArrivalBoardBindingSource;
        private AirPort2DataSetTableAdapters.View_ArrivalBoardTableAdapter view_ArrivalBoardTableAdapter;
        private System.Windows.Forms.BindingSource view_ArrivalFlightBindingSource;
        private AirPort2DataSetTableAdapters.View_ArrivalFlightTableAdapter view_ArrivalFlightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView view_ArrivalFlightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_Add;
    }
}