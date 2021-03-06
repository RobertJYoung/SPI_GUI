﻿namespace SPI_GUI_v2
{
    partial class Form1
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
            this.itextBox = new System.Windows.Forms.TextBox();
            this.transButton = new System.Windows.Forms.Button();
            this.otextBox = new System.Windows.Forms.TextBox();
            this.inLabel = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_label = new System.Windows.Forms.Label();
            this.devices = new System.Windows.Forms.ListBox();
            this.devInfo = new System.Windows.Forms.TextBox();
            this.device_label = new System.Windows.Forms.Label();
            this.devInfo_label = new System.Windows.Forms.Label();
            this.freq_label = new System.Windows.Forms.Label();
            this.freqbox = new System.Windows.Forms.TextBox();
            this.setFreq_button = new System.Windows.Forms.Button();
            this.delay_label = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.delayButton = new System.Windows.Forms.Button();
            this.loopBackCheckBox = new System.Windows.Forms.CheckBox();
            this.csvCheckBox = new System.Windows.Forms.CheckBox();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // itextBox
            // 
            this.itextBox.Location = new System.Drawing.Point(18, 322);
            this.itextBox.Multiline = true;
            this.itextBox.Name = "itextBox";
            this.itextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.itextBox.Size = new System.Drawing.Size(320, 73);
            this.itextBox.TabIndex = 0;
            this.itextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // transButton
            // 
            this.transButton.Location = new System.Drawing.Point(158, 26);
            this.transButton.Name = "transButton";
            this.transButton.Size = new System.Drawing.Size(180, 82);
            this.transButton.TabIndex = 2;
            this.transButton.Text = "Transmit";
            this.transButton.UseVisualStyleBackColor = true;
            this.transButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // otextBox
            // 
            this.otextBox.AcceptsReturn = true;
            this.otextBox.Location = new System.Drawing.Point(18, 414);
            this.otextBox.Multiline = true;
            this.otextBox.Name = "otextBox";
            this.otextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.otextBox.Size = new System.Drawing.Size(320, 83);
            this.otextBox.TabIndex = 4;
            this.otextBox.Text = "Output of transmission will appear here";
            this.otextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Location = new System.Drawing.Point(15, 306);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(37, 13);
            this.inLabel.TabIndex = 5;
            this.inLabel.Text = "Input :";
            this.inLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(19, 398);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(45, 13);
            this.outLabel.TabIndex = 6;
            this.outLabel.Text = "Output :";
            this.outLabel.Click += new System.EventHandler(this.outLabel_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Control;
            this.connectButton.Location = new System.Drawing.Point(18, 25);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(120, 83);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(15, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(112, 13);
            this.status_label.TabIndex = 8;
            this.status_label.Text = "Status: not connected";
            this.status_label.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ASCII,
            this.Hex,
            this.Voltage});
            this.table.Location = new System.Drawing.Point(354, 26);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(442, 471);
            this.table.TabIndex = 9;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ASCII
            // 
            this.ASCII.HeaderText = "Hex";
            this.ASCII.Name = "ASCII";
            this.ASCII.ReadOnly = true;
            // 
            // Hex
            // 
            this.Hex.HeaderText = "Byte";
            this.Hex.Name = "Hex";
            this.Hex.ReadOnly = true;
            // 
            // Voltage
            // 
            this.Voltage.HeaderText = "Voltage";
            this.Voltage.Name = "Voltage";
            this.Voltage.ReadOnly = true;
            // 
            // table_label
            // 
            this.table_label.AutoSize = true;
            this.table_label.Location = new System.Drawing.Point(351, 9);
            this.table_label.Name = "table_label";
            this.table_label.Size = new System.Drawing.Size(63, 13);
            this.table_label.TabIndex = 10;
            this.table_label.Text = "Data Table:";
            this.table_label.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // devices
            // 
            this.devices.FormattingEnabled = true;
            this.devices.Location = new System.Drawing.Point(18, 127);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(120, 69);
            this.devices.TabIndex = 11;
            this.devices.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // devInfo
            // 
            this.devInfo.Location = new System.Drawing.Point(158, 127);
            this.devInfo.Multiline = true;
            this.devInfo.Name = "devInfo";
            this.devInfo.ReadOnly = true;
            this.devInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.devInfo.Size = new System.Drawing.Size(180, 69);
            this.devInfo.TabIndex = 12;
            this.devInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // device_label
            // 
            this.device_label.AutoSize = true;
            this.device_label.Location = new System.Drawing.Point(15, 111);
            this.device_label.Name = "device_label";
            this.device_label.Size = new System.Drawing.Size(49, 13);
            this.device_label.TabIndex = 13;
            this.device_label.Text = "Devices:";
            // 
            // devInfo_label
            // 
            this.devInfo_label.AutoSize = true;
            this.devInfo_label.Location = new System.Drawing.Point(155, 111);
            this.devInfo_label.Name = "devInfo_label";
            this.devInfo_label.Size = new System.Drawing.Size(65, 13);
            this.devInfo_label.TabIndex = 14;
            this.devInfo_label.Text = "Device Info:";
            this.devInfo_label.Click += new System.EventHandler(this.devInfo_label_Click);
            // 
            // freq_label
            // 
            this.freq_label.AutoSize = true;
            this.freq_label.Location = new System.Drawing.Point(15, 199);
            this.freq_label.Name = "freq_label";
            this.freq_label.Size = new System.Drawing.Size(50, 13);
            this.freq_label.TabIndex = 15;
            this.freq_label.Text = "Freq(Hz):";
            this.freq_label.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // freqbox
            // 
            this.freqbox.Location = new System.Drawing.Point(18, 215);
            this.freqbox.Name = "freqbox";
            this.freqbox.Size = new System.Drawing.Size(120, 20);
            this.freqbox.TabIndex = 16;
            this.freqbox.TextChanged += new System.EventHandler(this.freqbox_TextChanged);
            // 
            // setFreq_button
            // 
            this.setFreq_button.Location = new System.Drawing.Point(158, 215);
            this.setFreq_button.Name = "setFreq_button";
            this.setFreq_button.Size = new System.Drawing.Size(180, 20);
            this.setFreq_button.TabIndex = 17;
            this.setFreq_button.Text = "Set Frequency";
            this.setFreq_button.UseVisualStyleBackColor = true;
            this.setFreq_button.Click += new System.EventHandler(this.setFreq_button_Click);
            // 
            // delay_label
            // 
            this.delay_label.AutoSize = true;
            this.delay_label.Location = new System.Drawing.Point(15, 238);
            this.delay_label.Name = "delay_label";
            this.delay_label.Size = new System.Drawing.Size(56, 13);
            this.delay_label.TabIndex = 18;
            this.delay_label.Text = "Delay(ms):";
            // 
            // delayBox
            // 
            this.delayBox.Location = new System.Drawing.Point(18, 254);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(120, 20);
            this.delayBox.TabIndex = 19;
            this.delayBox.TextChanged += new System.EventHandler(this.delayBox_TextChanged);
            // 
            // delayButton
            // 
            this.delayButton.Location = new System.Drawing.Point(158, 254);
            this.delayButton.Name = "delayButton";
            this.delayButton.Size = new System.Drawing.Size(180, 20);
            this.delayButton.TabIndex = 20;
            this.delayButton.Text = "Set Delay";
            this.delayButton.UseVisualStyleBackColor = true;
            this.delayButton.Click += new System.EventHandler(this.delayButton_Click);
            // 
            // loopBackCheckBox
            // 
            this.loopBackCheckBox.AutoSize = true;
            this.loopBackCheckBox.Location = new System.Drawing.Point(267, 286);
            this.loopBackCheckBox.Name = "loopBackCheckBox";
            this.loopBackCheckBox.Size = new System.Drawing.Size(71, 17);
            this.loopBackCheckBox.TabIndex = 21;
            this.loopBackCheckBox.Text = "loopBack";
            this.loopBackCheckBox.UseVisualStyleBackColor = true;
            this.loopBackCheckBox.CheckedChanged += new System.EventHandler(this.loopBackCheckBox_CheckedChanged);
            // 
            // csvCheckBox
            // 
            this.csvCheckBox.AutoSize = true;
            this.csvCheckBox.Location = new System.Drawing.Point(128, 286);
            this.csvCheckBox.Name = "csvCheckBox";
            this.csvCheckBox.Size = new System.Drawing.Size(92, 17);
            this.csvCheckBox.TabIndex = 22;
            this.csvCheckBox.Text = "generate CSV";
            this.csvCheckBox.UseVisualStyleBackColor = true;
            this.csvCheckBox.CheckedChanged += new System.EventHandler(this.csvCheckBox_CheckedChanged);
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.Location = new System.Drawing.Point(18, 286);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.Size = new System.Drawing.Size(56, 17);
            this.repeatCheckBox.TabIndex = 23;
            this.repeatCheckBox.Text = "repeat";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            this.repeatCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.repeatCheckBox);
            this.Controls.Add(this.csvCheckBox);
            this.Controls.Add(this.loopBackCheckBox);
            this.Controls.Add(this.delayButton);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.delay_label);
            this.Controls.Add(this.setFreq_button);
            this.Controls.Add(this.freqbox);
            this.Controls.Add(this.freq_label);
            this.Controls.Add(this.devInfo_label);
            this.Controls.Add(this.device_label);
            this.Controls.Add(this.devInfo);
            this.Controls.Add(this.devices);
            this.Controls.Add(this.table_label);
            this.Controls.Add(this.table);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.inLabel);
            this.Controls.Add(this.otextBox);
            this.Controls.Add(this.transButton);
            this.Controls.Add(this.itextBox);
            this.Name = "Form1";
            this.Text = "C232HM GUI";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itextBox;
        private System.Windows.Forms.Button transButton;
        private System.Windows.Forms.TextBox otextBox;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label table_label;
        private System.Windows.Forms.ListBox devices;
        private System.Windows.Forms.TextBox devInfo;
        private System.Windows.Forms.Label device_label;
        private System.Windows.Forms.Label devInfo_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASCII;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voltage;
        private System.Windows.Forms.Label freq_label;
        private System.Windows.Forms.TextBox freqbox;
        private System.Windows.Forms.Button setFreq_button;
        private System.Windows.Forms.Label delay_label;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.Button delayButton;
        private System.Windows.Forms.CheckBox loopBackCheckBox;
        private System.Windows.Forms.CheckBox csvCheckBox;
        private System.Windows.Forms.CheckBox repeatCheckBox;
    }
}

