namespace AirPortBDCourseWork
{
    partial class Form_AirPorts
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
            this.airPortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airPortsTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.AirPortsTableAdapter();
            this.tableAdapterManager = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager();
            this.airPortsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_First = new System.Windows.Forms.Button();
            this.textBox_Name_AirPort = new System.Windows.Forms.TextBox();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_AddAirPort = new System.Windows.Forms.Button();
            this.button_ChangeAirPort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airPort2DataSet
            // 
            this.airPort2DataSet.DataSetName = "AirPort2DataSet";
            this.airPort2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airPortsBindingSource
            // 
            this.airPortsBindingSource.DataMember = "AirPorts";
            this.airPortsBindingSource.DataSource = this.airPort2DataSet;
            // 
            // airPortsTableAdapter
            // 
            this.airPortsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirPortsTableAdapter = this.airPortsTableAdapter;
            this.tableAdapterManager.ArrivalBoardTableAdapter = null;
            this.tableAdapterManager.ArrivalConditionsTableAdapter = null;
            this.tableAdapterManager.ArrivalFlightTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartureBoardTableAdapter = null;
            this.tableAdapterManager.DepartureConditionsTableAdapter = null;
            this.tableAdapterManager.DepartureFlightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirPortBDCourseWork.AirPort2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airPortsDataGridView
            // 
            this.airPortsDataGridView.AutoGenerateColumns = false;
            this.airPortsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airPortsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.airPortsDataGridView.DataSource = this.airPortsBindingSource;
            this.airPortsDataGridView.Location = new System.Drawing.Point(2, 12);
            this.airPortsDataGridView.Name = "airPortsDataGridView";
            this.airPortsDataGridView.Size = new System.Drawing.Size(153, 255);
            this.airPortsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameAirPort";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameAirPort";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(177, 12);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(75, 23);
            this.button_First.TabIndex = 2;
            this.button_First.Text = "First";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // textBox_Name_AirPort
            // 
            this.textBox_Name_AirPort.Location = new System.Drawing.Point(177, 150);
            this.textBox_Name_AirPort.Multiline = true;
            this.textBox_Name_AirPort.Name = "textBox_Name_AirPort";
            this.textBox_Name_AirPort.Size = new System.Drawing.Size(318, 54);
            this.textBox_Name_AirPort.TabIndex = 3;
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(258, 12);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(75, 23);
            this.button_Last.TabIndex = 4;
            this.button_Last.Text = "Last";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(339, 12);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(75, 23);
            this.button_Previous.TabIndex = 5;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(420, 12);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 6;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(177, 70);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(98, 52);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(281, 70);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(104, 52);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(391, 70);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(104, 52);
            this.button_Change.TabIndex = 9;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_AddAirPort
            // 
            this.button_AddAirPort.Location = new System.Drawing.Point(188, 210);
            this.button_AddAirPort.Name = "button_AddAirPort";
            this.button_AddAirPort.Size = new System.Drawing.Size(120, 57);
            this.button_AddAirPort.TabIndex = 10;
            this.button_AddAirPort.Text = "Add";
            this.button_AddAirPort.UseVisualStyleBackColor = true;
            this.button_AddAirPort.Click += new System.EventHandler(this.button_AddAirPort_Click);
            // 
            // button_ChangeAirPort
            // 
            this.button_ChangeAirPort.Location = new System.Drawing.Point(362, 210);
            this.button_ChangeAirPort.Name = "button_ChangeAirPort";
            this.button_ChangeAirPort.Size = new System.Drawing.Size(120, 57);
            this.button_ChangeAirPort.TabIndex = 11;
            this.button_ChangeAirPort.Text = "Change";
            this.button_ChangeAirPort.UseVisualStyleBackColor = true;
            this.button_ChangeAirPort.Click += new System.EventHandler(this.button_ChangeAirPort_Click);
            // 
            // Form_AirPorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 285);
            this.Controls.Add(this.button_ChangeAirPort);
            this.Controls.Add(this.button_AddAirPort);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.textBox_Name_AirPort);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.airPortsDataGridView);
            this.Name = "Form_AirPorts";
            this.Text = "Form_AirPorts";
            this.Load += new System.EventHandler(this.Form_AirPorts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource airPortsBindingSource;
        private AirPort2DataSetTableAdapters.AirPortsTableAdapter airPortsTableAdapter;
        private AirPort2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView airPortsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.TextBox textBox_Name_AirPort;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_AddAirPort;
        private System.Windows.Forms.Button button_ChangeAirPort;
    }
}