namespace AirPortBDCourseWork
{
    partial class Change_ArrivalFlight
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
            this.dateTimePicker_ArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.textBox_FlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.airPortsTableAdapter = new AirPortBDCourseWork.AirPort2DataSetTableAdapters.AirPortsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPort2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(12, 167);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(208, 73);
            this.button_Change.TabIndex = 23;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name AirPort:";
            // 
            // comboBox_AirPorts
            // 
            this.comboBox_AirPorts.DataSource = this.airPortsBindingSource;
            this.comboBox_AirPorts.DisplayMember = "NameAirPort";
            this.comboBox_AirPorts.FormattingEnabled = true;
            this.comboBox_AirPorts.Location = new System.Drawing.Point(12, 84);
            this.comboBox_AirPorts.Name = "comboBox_AirPorts";
            this.comboBox_AirPorts.Size = new System.Drawing.Size(144, 21);
            this.comboBox_AirPorts.TabIndex = 20;
            this.comboBox_AirPorts.ValueMember = "ID";
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
            this.button_Edit.Location = new System.Drawing.Point(162, 85);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(58, 20);
            this.button_Edit.TabIndex = 19;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // dateTimePicker_ArrivalTime
            // 
            this.dateTimePicker_ArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_ArrivalTime.Location = new System.Drawing.Point(12, 130);
            this.dateTimePicker_ArrivalTime.Name = "dateTimePicker_ArrivalTime";
            this.dateTimePicker_ArrivalTime.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker_ArrivalTime.TabIndex = 18;
            // 
            // textBox_FlightNumber
            // 
            this.textBox_FlightNumber.Location = new System.Drawing.Point(12, 23);
            this.textBox_FlightNumber.Multiline = true;
            this.textBox_FlightNumber.Name = "textBox_FlightNumber";
            this.textBox_FlightNumber.Size = new System.Drawing.Size(208, 42);
            this.textBox_FlightNumber.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Flight Number:";
            // 
            // airPortsTableAdapter
            // 
            this.airPortsTableAdapter.ClearBeforeFill = true;
            // 
            // Change_ArrivalFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 257);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_AirPorts);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.dateTimePicker_ArrivalTime);
            this.Controls.Add(this.textBox_FlightNumber);
            this.Controls.Add(this.label1);
            this.Name = "Change_ArrivalFlight";
            this.Text = "Change_ArrivalFlight";
            this.Load += new System.EventHandler(this.Change_ArrivalFlight_Load);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker_ArrivalTime;
        private System.Windows.Forms.TextBox textBox_FlightNumber;
        private System.Windows.Forms.Label label1;
        private AirPort2DataSet airPort2DataSet;
        private System.Windows.Forms.BindingSource airPortsBindingSource;
        private AirPort2DataSetTableAdapters.AirPortsTableAdapter airPortsTableAdapter;
    }
}