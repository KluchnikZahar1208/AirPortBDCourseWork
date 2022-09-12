namespace AirPortBDCourseWork
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Departure_Change = new System.Windows.Forms.Button();
            this.button_Departure_Delete = new System.Windows.Forms.Button();
            this.button_Departure_Add = new System.Windows.Forms.Button();
            this.button_Departure_Next = new System.Windows.Forms.Button();
            this.button_Departure_Previous = new System.Windows.Forms.Button();
            this.button_Departure_Last = new System.Windows.Forms.Button();
            this.button_Departure_First = new System.Windows.Forms.Button();
            this.button_Departure_ViewDepartureFlight = new System.Windows.Forms.Button();
            this.view_DepartureBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_DepartureBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airPort2DataSet = new AirPortBDCourseWork.AirPort2DataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Arriaval_Change = new System.Windows.Forms.Button();
            this.button_Arriaval_Delete = new System.Windows.Forms.Button();
            this.button_Arrival_Add = new System.Windows.Forms.Button();
            this.button_Arriaval_Next = new System.Windows.Forms.Button();
            this.button_Arriaval_Previous = new System.Windows.Forms.Button();
            this.button_Arrival_Last = new System.Windows.Forms.Button();
            this.button_Arrival_First = new System.Windows.Forms.Button();
            this.button_Arrival_ViewArrivalFlights = new System.Windows.Forms.Button();
            this.view_ArrivalBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_ArrivalBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DepartureBoardTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.View_DepartureBoardTableAdapter();
            this.tableAdapterManager = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager();
            this.view_ArrivalBoardTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.View_ArrivalBoardTableAdapter();
            this.button_ReportArrival = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureBoardDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalBoardDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalBoardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button_Departure_Change);
            this.tabPage1.Controls.Add(this.button_Departure_Delete);
            this.tabPage1.Controls.Add(this.button_Departure_Add);
            this.tabPage1.Controls.Add(this.button_Departure_Next);
            this.tabPage1.Controls.Add(this.button_Departure_Previous);
            this.tabPage1.Controls.Add(this.button_Departure_Last);
            this.tabPage1.Controls.Add(this.button_Departure_First);
            this.tabPage1.Controls.Add(this.button_Departure_ViewDepartureFlight);
            this.tabPage1.Controls.Add(this.view_DepartureBoardDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Departure_Change
            // 
            this.button_Departure_Change.Location = new System.Drawing.Point(487, 269);
            this.button_Departure_Change.Name = "button_Departure_Change";
            this.button_Departure_Change.Size = new System.Drawing.Size(293, 35);
            this.button_Departure_Change.TabIndex = 18;
            this.button_Departure_Change.Text = "Change";
            this.button_Departure_Change.UseVisualStyleBackColor = true;
            this.button_Departure_Change.Click += new System.EventHandler(this.button_Departure_Change_Click);
            // 
            // button_Departure_Delete
            // 
            this.button_Departure_Delete.Location = new System.Drawing.Point(486, 228);
            this.button_Departure_Delete.Name = "button_Departure_Delete";
            this.button_Departure_Delete.Size = new System.Drawing.Size(293, 35);
            this.button_Departure_Delete.TabIndex = 17;
            this.button_Departure_Delete.Text = "Delete";
            this.button_Departure_Delete.UseVisualStyleBackColor = true;
            this.button_Departure_Delete.Click += new System.EventHandler(this.button_Departure_Delete_Click);
            // 
            // button_Departure_Add
            // 
            this.button_Departure_Add.Location = new System.Drawing.Point(486, 187);
            this.button_Departure_Add.Name = "button_Departure_Add";
            this.button_Departure_Add.Size = new System.Drawing.Size(293, 35);
            this.button_Departure_Add.TabIndex = 16;
            this.button_Departure_Add.Text = "Add";
            this.button_Departure_Add.UseVisualStyleBackColor = true;
            this.button_Departure_Add.Click += new System.EventHandler(this.button_Departure_Add_Click);
            // 
            // button_Departure_Next
            // 
            this.button_Departure_Next.Location = new System.Drawing.Point(649, 144);
            this.button_Departure_Next.Name = "button_Departure_Next";
            this.button_Departure_Next.Size = new System.Drawing.Size(129, 37);
            this.button_Departure_Next.TabIndex = 15;
            this.button_Departure_Next.Text = "Next";
            this.button_Departure_Next.UseVisualStyleBackColor = true;
            this.button_Departure_Next.Click += new System.EventHandler(this.button_Departure_Next_Click);
            // 
            // button_Departure_Previous
            // 
            this.button_Departure_Previous.Location = new System.Drawing.Point(486, 144);
            this.button_Departure_Previous.Name = "button_Departure_Previous";
            this.button_Departure_Previous.Size = new System.Drawing.Size(145, 37);
            this.button_Departure_Previous.TabIndex = 14;
            this.button_Departure_Previous.Text = "Previous";
            this.button_Departure_Previous.UseVisualStyleBackColor = true;
            this.button_Departure_Previous.Click += new System.EventHandler(this.button_Departure_Previous_Click);
            // 
            // button_Departure_Last
            // 
            this.button_Departure_Last.Location = new System.Drawing.Point(649, 101);
            this.button_Departure_Last.Name = "button_Departure_Last";
            this.button_Departure_Last.Size = new System.Drawing.Size(130, 37);
            this.button_Departure_Last.TabIndex = 13;
            this.button_Departure_Last.Text = "Last";
            this.button_Departure_Last.UseVisualStyleBackColor = true;
            this.button_Departure_Last.Click += new System.EventHandler(this.button_Departure_Last_Click);
            // 
            // button_Departure_First
            // 
            this.button_Departure_First.Location = new System.Drawing.Point(486, 101);
            this.button_Departure_First.Name = "button_Departure_First";
            this.button_Departure_First.Size = new System.Drawing.Size(145, 37);
            this.button_Departure_First.TabIndex = 12;
            this.button_Departure_First.Text = "First";
            this.button_Departure_First.UseVisualStyleBackColor = true;
            this.button_Departure_First.Click += new System.EventHandler(this.button_Departure_First_Click);
            // 
            // button_Departure_ViewDepartureFlight
            // 
            this.button_Departure_ViewDepartureFlight.Location = new System.Drawing.Point(487, 6);
            this.button_Departure_ViewDepartureFlight.Name = "button_Departure_ViewDepartureFlight";
            this.button_Departure_ViewDepartureFlight.Size = new System.Drawing.Size(292, 89);
            this.button_Departure_ViewDepartureFlight.TabIndex = 11;
            this.button_Departure_ViewDepartureFlight.Text = "View Departure Flight";
            this.button_Departure_ViewDepartureFlight.UseVisualStyleBackColor = true;
            this.button_Departure_ViewDepartureFlight.Click += new System.EventHandler(this.button_Departure_ViewDepartureFlight_Click);
            // 
            // view_DepartureBoardDataGridView
            // 
            this.view_DepartureBoardDataGridView.AutoGenerateColumns = false;
            this.view_DepartureBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_DepartureBoardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view_DepartureBoardDataGridView.DataSource = this.view_DepartureBoardBindingSource;
            this.view_DepartureBoardDataGridView.Location = new System.Drawing.Point(3, 6);
            this.view_DepartureBoardDataGridView.Name = "view_DepartureBoardDataGridView";
            this.view_DepartureBoardDataGridView.Size = new System.Drawing.Size(478, 388);
            this.view_DepartureBoardDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdFlight";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdFlight";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FlightNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "FlightNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NameAirPort";
            this.dataGridViewTextBoxColumn4.HeaderText = "NameAirPort";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdConditions";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdConditions";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Conditions";
            this.dataGridViewTextBoxColumn7.HeaderText = "Conditions";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // view_DepartureBoardBindingSource
            // 
            this.view_DepartureBoardBindingSource.DataMember = "View_DepartureBoard";
            this.view_DepartureBoardBindingSource.DataSource = this.airPort2DataSet;
            // 
            // airPort2DataSet
            // 
            this.airPort2DataSet.DataSetName = "AirPort2DataSet";
            this.airPort2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_ReportArrival);
            this.tabPage2.Controls.Add(this.button_Arriaval_Change);
            this.tabPage2.Controls.Add(this.button_Arriaval_Delete);
            this.tabPage2.Controls.Add(this.button_Arrival_Add);
            this.tabPage2.Controls.Add(this.button_Arriaval_Next);
            this.tabPage2.Controls.Add(this.button_Arriaval_Previous);
            this.tabPage2.Controls.Add(this.button_Arrival_Last);
            this.tabPage2.Controls.Add(this.button_Arrival_First);
            this.tabPage2.Controls.Add(this.button_Arrival_ViewArrivalFlights);
            this.tabPage2.Controls.Add(this.view_ArrivalBoardDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Arriaval_Change
            // 
            this.button_Arriaval_Change.Location = new System.Drawing.Point(490, 269);
            this.button_Arriaval_Change.Name = "button_Arriaval_Change";
            this.button_Arriaval_Change.Size = new System.Drawing.Size(293, 35);
            this.button_Arriaval_Change.TabIndex = 10;
            this.button_Arriaval_Change.Text = "Change";
            this.button_Arriaval_Change.UseVisualStyleBackColor = true;
            this.button_Arriaval_Change.Click += new System.EventHandler(this.button_Arriaval_Change_Click);
            // 
            // button_Arriaval_Delete
            // 
            this.button_Arriaval_Delete.Location = new System.Drawing.Point(489, 228);
            this.button_Arriaval_Delete.Name = "button_Arriaval_Delete";
            this.button_Arriaval_Delete.Size = new System.Drawing.Size(293, 35);
            this.button_Arriaval_Delete.TabIndex = 9;
            this.button_Arriaval_Delete.Text = "Delete";
            this.button_Arriaval_Delete.UseVisualStyleBackColor = true;
            this.button_Arriaval_Delete.Click += new System.EventHandler(this.button_Arriaval_Delete_Click);
            // 
            // button_Arrival_Add
            // 
            this.button_Arrival_Add.Location = new System.Drawing.Point(489, 187);
            this.button_Arrival_Add.Name = "button_Arrival_Add";
            this.button_Arrival_Add.Size = new System.Drawing.Size(293, 35);
            this.button_Arrival_Add.TabIndex = 8;
            this.button_Arrival_Add.Text = "Add";
            this.button_Arrival_Add.UseVisualStyleBackColor = true;
            this.button_Arrival_Add.Click += new System.EventHandler(this.button_Arrival_Add_Click);
            // 
            // button_Arriaval_Next
            // 
            this.button_Arriaval_Next.Location = new System.Drawing.Point(652, 144);
            this.button_Arriaval_Next.Name = "button_Arriaval_Next";
            this.button_Arriaval_Next.Size = new System.Drawing.Size(129, 37);
            this.button_Arriaval_Next.TabIndex = 7;
            this.button_Arriaval_Next.Text = "Next";
            this.button_Arriaval_Next.UseVisualStyleBackColor = true;
            this.button_Arriaval_Next.Click += new System.EventHandler(this.button_Arriaval_Next_Click);
            // 
            // button_Arriaval_Previous
            // 
            this.button_Arriaval_Previous.Location = new System.Drawing.Point(489, 144);
            this.button_Arriaval_Previous.Name = "button_Arriaval_Previous";
            this.button_Arriaval_Previous.Size = new System.Drawing.Size(145, 37);
            this.button_Arriaval_Previous.TabIndex = 6;
            this.button_Arriaval_Previous.Text = "Previous";
            this.button_Arriaval_Previous.UseVisualStyleBackColor = true;
            this.button_Arriaval_Previous.Click += new System.EventHandler(this.button_Arriaval_Previous_Click);
            // 
            // button_Arrival_Last
            // 
            this.button_Arrival_Last.Location = new System.Drawing.Point(652, 101);
            this.button_Arrival_Last.Name = "button_Arrival_Last";
            this.button_Arrival_Last.Size = new System.Drawing.Size(130, 37);
            this.button_Arrival_Last.TabIndex = 5;
            this.button_Arrival_Last.Text = "Last";
            this.button_Arrival_Last.UseVisualStyleBackColor = true;
            this.button_Arrival_Last.Click += new System.EventHandler(this.button_Arrival_Last_Click);
            // 
            // button_Arrival_First
            // 
            this.button_Arrival_First.Location = new System.Drawing.Point(489, 101);
            this.button_Arrival_First.Name = "button_Arrival_First";
            this.button_Arrival_First.Size = new System.Drawing.Size(145, 37);
            this.button_Arrival_First.TabIndex = 4;
            this.button_Arrival_First.Text = "First";
            this.button_Arrival_First.UseVisualStyleBackColor = true;
            this.button_Arrival_First.Click += new System.EventHandler(this.button_Arrival_First_Click);
            // 
            // button_Arrival_ViewArrivalFlights
            // 
            this.button_Arrival_ViewArrivalFlights.Location = new System.Drawing.Point(490, 6);
            this.button_Arrival_ViewArrivalFlights.Name = "button_Arrival_ViewArrivalFlights";
            this.button_Arrival_ViewArrivalFlights.Size = new System.Drawing.Size(292, 89);
            this.button_Arrival_ViewArrivalFlights.TabIndex = 3;
            this.button_Arrival_ViewArrivalFlights.Text = "View Arrival Flights";
            this.button_Arrival_ViewArrivalFlights.UseVisualStyleBackColor = true;
            this.button_Arrival_ViewArrivalFlights.Click += new System.EventHandler(this.button_Arrival_ViewArrivalFlights_Click);
            // 
            // view_ArrivalBoardDataGridView
            // 
            this.view_ArrivalBoardDataGridView.AutoGenerateColumns = false;
            this.view_ArrivalBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ArrivalBoardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.view_ArrivalBoardDataGridView.DataSource = this.view_ArrivalBoardBindingSource;
            this.view_ArrivalBoardDataGridView.Location = new System.Drawing.Point(6, 6);
            this.view_ArrivalBoardDataGridView.Name = "view_ArrivalBoardDataGridView";
            this.view_ArrivalBoardDataGridView.Size = new System.Drawing.Size(478, 388);
            this.view_ArrivalBoardDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdFlight";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdFlight";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FlightNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "FlightNumber";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NameAirPort";
            this.dataGridViewTextBoxColumn11.HeaderText = "NameAirPort";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ArrivalTime";
            this.dataGridViewTextBoxColumn12.HeaderText = "ArrivalTime";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IdConditions";
            this.dataGridViewTextBoxColumn13.HeaderText = "IdConditions";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Condition";
            this.dataGridViewTextBoxColumn14.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // view_ArrivalBoardBindingSource
            // 
            this.view_ArrivalBoardBindingSource.DataMember = "View_ArrivalBoard";
            this.view_ArrivalBoardBindingSource.DataSource = this.airPort2DataSet;
            // 
            // view_DepartureBoardTableAdapter
            // 
            this.view_DepartureBoardTableAdapter.ClearBeforeFill = true;
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
            // view_ArrivalBoardTableAdapter
            // 
            this.view_ArrivalBoardTableAdapter.ClearBeforeFill = true;
            // 
            // button_ReportArrival
            // 
            this.button_ReportArrival.Location = new System.Drawing.Point(490, 369);
            this.button_ReportArrival.Name = "button_ReportArrival";
            this.button_ReportArrival.Size = new System.Drawing.Size(293, 25);
            this.button_ReportArrival.TabIndex = 11;
            this.button_ReportArrival.Text = "Report";
            this.button_ReportArrival.UseVisualStyleBackColor = true;
            this.button_ReportArrival.Click += new System.EventHandler(this.button_ReportArrival_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureBoardDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DepartureBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalBoardDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ArrivalBoardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource view_DepartureBoardBindingSource;
        private AirPort2DataSetTableAdapters.View_DepartureBoardTableAdapter view_DepartureBoardTableAdapter;
        private AirPort2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource view_ArrivalBoardBindingSource;
        private AirPort2DataSetTableAdapters.View_ArrivalBoardTableAdapter view_ArrivalBoardTableAdapter;
        private System.Windows.Forms.DataGridView view_DepartureBoardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView view_ArrivalBoardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button button_Departure_Change;
        private System.Windows.Forms.Button button_Departure_Delete;
        private System.Windows.Forms.Button button_Departure_Add;
        private System.Windows.Forms.Button button_Departure_Next;
        private System.Windows.Forms.Button button_Departure_Previous;
        private System.Windows.Forms.Button button_Departure_Last;
        private System.Windows.Forms.Button button_Departure_First;
        private System.Windows.Forms.Button button_Departure_ViewDepartureFlight;
        private System.Windows.Forms.Button button_Arriaval_Change;
        private System.Windows.Forms.Button button_Arriaval_Delete;
        private System.Windows.Forms.Button button_Arrival_Add;
        private System.Windows.Forms.Button button_Arriaval_Next;
        private System.Windows.Forms.Button button_Arriaval_Previous;
        private System.Windows.Forms.Button button_Arrival_Last;
        private System.Windows.Forms.Button button_Arrival_First;
        private System.Windows.Forms.Button button_Arrival_ViewArrivalFlights;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ReportArrival;
    }
}

