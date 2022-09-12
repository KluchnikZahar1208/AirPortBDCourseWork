namespace AirPortBDCourseWork
{
    partial class Change_DepartureFlight
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
            this.button_Change = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_AirPorts = new System.Windows.Forms.ComboBox();
            this.airPortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airPort2DataSet = new AirPortBDCourseWork.AirPort2DataSet();
            this.button_Edit = new System.Windows.Forms.Button();
            this.dateTimePicker_DepartureTime = new System.Windows.Forms.DateTimePicker();
            this.textBox_FlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.airPortsTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.AirPortsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(12, 168);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(208, 73);
            this.button_Change.TabIndex = 15;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name AirPort:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_AirPorts
            // 
            this.comboBox_AirPorts.DataSource = this.airPortsBindingSource;
            this.comboBox_AirPorts.DisplayMember = "NameAirPort";
            this.comboBox_AirPorts.FormattingEnabled = true;
            this.comboBox_AirPorts.Location = new System.Drawing.Point(12, 85);
            this.comboBox_AirPorts.Name = "comboBox_AirPorts";
            this.comboBox_AirPorts.Size = new System.Drawing.Size(144, 21);
            this.comboBox_AirPorts.TabIndex = 12;
            this.comboBox_AirPorts.ValueMember = "ID";
            this.comboBox_AirPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox_AirPorts_SelectedIndexChanged);
            // 
            // airPortsBindingSource
            // 
            this.airPortsBindingSource.DataMember = "AirPorts";
            this.airPortsBindingSource.DataSource = this.airPort2DataSet;
            // 
            // airPort2DataSet
            // 
            this.airPort2DataSet.DataSetName = "AirPort2DataSet";
            this.airPort2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(162, 86);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(58, 20);
            this.button_Edit.TabIndex = 11;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // dateTimePicker_DepartureTime
            // 
            this.dateTimePicker_DepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_DepartureTime.Location = new System.Drawing.Point(12, 131);
            this.dateTimePicker_DepartureTime.Name = "dateTimePicker_DepartureTime";
            this.dateTimePicker_DepartureTime.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker_DepartureTime.TabIndex = 10;
            this.dateTimePicker_DepartureTime.ValueChanged += new System.EventHandler(this.dateTimePicker_DepartureTime_ValueChanged);
            // 
            // textBox_FlightNumber
            // 
            this.textBox_FlightNumber.Location = new System.Drawing.Point(12, 24);
            this.textBox_FlightNumber.Multiline = true;
            this.textBox_FlightNumber.Name = "textBox_FlightNumber";
            this.textBox_FlightNumber.Size = new System.Drawing.Size(208, 42);
            this.textBox_FlightNumber.TabIndex = 9;
            this.textBox_FlightNumber.TextChanged += new System.EventHandler(this.textBox_FlightNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Flight Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // airPortsTableAdapter
            // 
            this.airPortsTableAdapter.ClearBeforeFill = true;
            // 
            // Change_DepartureFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 254);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_AirPorts);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.dateTimePicker_DepartureTime);
            this.Controls.Add(this.textBox_FlightNumber);
            this.Controls.Add(this.label1);
            this.Name = "Change_DepartureFlight";
            this.Text = "Change_DepartureFlight";
            this.Load += new System.EventHandler(this.Change_DepartureFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_AirPorts;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DepartureTime;
        private System.Windows.Forms.TextBox textBox_FlightNumber;
        private System.Windows.Forms.Label label1;
        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource airPortsBindingSource;
        private AirPort2DataSetTableAdapters.AirPortsTableAdapter airPortsTableAdapter;
    }
}