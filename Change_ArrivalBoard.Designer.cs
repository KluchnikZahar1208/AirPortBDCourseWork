namespace AirPortBDCourseWork
{
    partial class Change_ArrivalBoard
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
            this.view_ArrivalFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ArrivalFlightTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.View_ArrivalFlightTableAdapter();
            this.tableAdapterManager = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager();
            this.view_ArrivalFlightDataGridView = new System.Windows.Forms.DataGridView();
            this.arrivalConditionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arrivalConditionsTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.ArrivalConditionsTableAdapter();
            this.arrivalConditionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airPort2DataSet
            // 
            this.airPort2DataSet.DataSetName = "AirPort2DataSet";
            this.airPort2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // view_ArrivalFlightDataGridView
            // 
            this.view_ArrivalFlightDataGridView.AutoGenerateColumns = false;
            this.view_ArrivalFlightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ArrivalFlightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.view_ArrivalFlightDataGridView.DataSource = this.view_ArrivalFlightBindingSource;
            this.view_ArrivalFlightDataGridView.Location = new System.Drawing.Point(3, 2);
            this.view_ArrivalFlightDataGridView.Name = "view_ArrivalFlightDataGridView";
            this.view_ArrivalFlightDataGridView.Size = new System.Drawing.Size(347, 354);
            this.view_ArrivalFlightDataGridView.TabIndex = 1;
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
            // arrivalConditionsDataGridView
            // 
            this.arrivalConditionsDataGridView.AutoGenerateColumns = false;
            this.arrivalConditionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrivalConditionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.arrivalConditionsDataGridView.DataSource = this.arrivalConditionsBindingSource;
            this.arrivalConditionsDataGridView.Location = new System.Drawing.Point(356, 2);
            this.arrivalConditionsDataGridView.Name = "arrivalConditionsDataGridView";
            this.arrivalConditionsDataGridView.Size = new System.Drawing.Size(150, 354);
            this.arrivalConditionsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ArrivalTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "ArrivalTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn6.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(3, 362);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(503, 85);
            this.button_Change.TabIndex = 3;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // Change_ArrivalBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.arrivalConditionsDataGridView);
            this.Controls.Add(this.view_ArrivalFlightDataGridView);
            this.Name = "Change_ArrivalBoard";
            this.Text = "Change_ArrivalBoard";
            this.Load += new System.EventHandler(this.Change_ArrivalBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalFlightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalConditionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource view_ArrivalFlightBindingSource;
        private AirPort2DataSetTableAdapters.View_ArrivalFlightTableAdapter view_ArrivalFlightTableAdapter;
        private AirPort2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_ArrivalFlightDataGridView;
        private AirPort2DataSetTableAdapters.ArrivalConditionsTableAdapter arrivalConditionsTableAdapter;
        private System.Windows.Forms.BindingSource arrivalConditionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView arrivalConditionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_Change;
    }
}