namespace Data_Storage_Conversion
{
    partial class frmDataStorageConversion
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
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.lblEnterFrom = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpFrom = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblConvertTo = new System.Windows.Forms.Label();
            this.lblEnterTo = new System.Windows.Forms.Label();
            this.rbFromByte = new System.Windows.Forms.RadioButton();
            this.rbFromKilobit = new System.Windows.Forms.RadioButton();
            this.rbFromMegabit = new System.Windows.Forms.RadioButton();
            this.rbFromGigabit = new System.Windows.Forms.RadioButton();
            this.rbFromTerabit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbToTerabit = new System.Windows.Forms.RadioButton();
            this.rbToGigabit = new System.Windows.Forms.RadioButton();
            this.rbToMegabit = new System.Windows.Forms.RadioButton();
            this.rbToKilobit = new System.Windows.Forms.RadioButton();
            this.rbToByte = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpFrom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.AutoSize = true;
            this.lblConvertFrom.Location = new System.Drawing.Point(13, 13);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(70, 13);
            this.lblConvertFrom.TabIndex = 0;
            this.lblConvertFrom.Text = "Convert From";
            // 
            // lblEnterFrom
            // 
            this.lblEnterFrom.AutoSize = true;
            this.lblEnterFrom.Location = new System.Drawing.Point(13, 41);
            this.lblEnterFrom.Name = "lblEnterFrom";
            this.lblEnterFrom.Size = new System.Drawing.Size(208, 26);
            this.lblEnterFrom.TabIndex = 1;
            this.lblEnterFrom.Text = "Enter the value to convert from then select\r\nthe data size:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(230, 41);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // grpFrom
            // 
            this.grpFrom.Controls.Add(this.rbFromTerabit);
            this.grpFrom.Controls.Add(this.rbFromGigabit);
            this.grpFrom.Controls.Add(this.rbFromMegabit);
            this.grpFrom.Controls.Add(this.rbFromKilobit);
            this.grpFrom.Controls.Add(this.rbFromByte);
            this.grpFrom.Location = new System.Drawing.Point(21, 75);
            this.grpFrom.Name = "grpFrom";
            this.grpFrom.Size = new System.Drawing.Size(115, 210);
            this.grpFrom.TabIndex = 3;
            this.grpFrom.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(415, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConvertTo
            // 
            this.lblConvertTo.AutoSize = true;
            this.lblConvertTo.Location = new System.Drawing.Point(529, 13);
            this.lblConvertTo.Name = "lblConvertTo";
            this.lblConvertTo.Size = new System.Drawing.Size(60, 13);
            this.lblConvertTo.TabIndex = 6;
            this.lblConvertTo.Text = "Convert To";
            // 
            // lblEnterTo
            // 
            this.lblEnterTo.AutoSize = true;
            this.lblEnterTo.Location = new System.Drawing.Point(529, 41);
            this.lblEnterTo.Name = "lblEnterTo";
            this.lblEnterTo.Size = new System.Drawing.Size(166, 13);
            this.lblEnterTo.TabIndex = 7;
            this.lblEnterTo.Text = "Select the data size to convert to:";
            // 
            // rbFromByte
            // 
            this.rbFromByte.AutoSize = true;
            this.rbFromByte.Location = new System.Drawing.Point(6, 19);
            this.rbFromByte.Name = "rbFromByte";
            this.rbFromByte.Size = new System.Drawing.Size(62, 17);
            this.rbFromByte.TabIndex = 0;
            this.rbFromByte.TabStop = true;
            this.rbFromByte.Text = "Byte (B)";
            this.rbFromByte.UseVisualStyleBackColor = true;
            // 
            // rbFromKilobit
            // 
            this.rbFromKilobit.AutoSize = true;
            this.rbFromKilobit.Location = new System.Drawing.Point(6, 53);
            this.rbFromKilobit.Name = "rbFromKilobit";
            this.rbFromKilobit.Size = new System.Drawing.Size(75, 17);
            this.rbFromKilobit.TabIndex = 1;
            this.rbFromKilobit.TabStop = true;
            this.rbFromKilobit.Text = "Kilobit (Kb)";
            this.rbFromKilobit.UseVisualStyleBackColor = true;
            // 
            // rbFromMegabit
            // 
            this.rbFromMegabit.AutoSize = true;
            this.rbFromMegabit.Location = new System.Drawing.Point(6, 90);
            this.rbFromMegabit.Name = "rbFromMegabit";
            this.rbFromMegabit.Size = new System.Drawing.Size(87, 17);
            this.rbFromMegabit.TabIndex = 2;
            this.rbFromMegabit.TabStop = true;
            this.rbFromMegabit.Text = "Megabit (Mb)";
            this.rbFromMegabit.UseVisualStyleBackColor = true;
            // 
            // rbFromGigabit
            // 
            this.rbFromGigabit.AutoSize = true;
            this.rbFromGigabit.Location = new System.Drawing.Point(6, 129);
            this.rbFromGigabit.Name = "rbFromGigabit";
            this.rbFromGigabit.Size = new System.Drawing.Size(81, 17);
            this.rbFromGigabit.TabIndex = 3;
            this.rbFromGigabit.TabStop = true;
            this.rbFromGigabit.Text = "Gigabit (Gb)";
            this.rbFromGigabit.UseVisualStyleBackColor = true;
            // 
            // rbFromTerabit
            // 
            this.rbFromTerabit.AutoSize = true;
            this.rbFromTerabit.Location = new System.Drawing.Point(6, 169);
            this.rbFromTerabit.Name = "rbFromTerabit";
            this.rbFromTerabit.Size = new System.Drawing.Size(80, 17);
            this.rbFromTerabit.TabIndex = 4;
            this.rbFromTerabit.TabStop = true;
            this.rbFromTerabit.Text = "Terabit (Tb)";
            this.rbFromTerabit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbToTerabit);
            this.groupBox1.Controls.Add(this.rbToGigabit);
            this.groupBox1.Controls.Add(this.rbToMegabit);
            this.groupBox1.Controls.Add(this.rbToKilobit);
            this.groupBox1.Controls.Add(this.rbToByte);
            this.groupBox1.Location = new System.Drawing.Point(532, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbToTerabit
            // 
            this.rbToTerabit.AutoSize = true;
            this.rbToTerabit.Location = new System.Drawing.Point(6, 169);
            this.rbToTerabit.Name = "rbToTerabit";
            this.rbToTerabit.Size = new System.Drawing.Size(80, 17);
            this.rbToTerabit.TabIndex = 4;
            this.rbToTerabit.TabStop = true;
            this.rbToTerabit.Text = "Terabit (Tb)";
            this.rbToTerabit.UseVisualStyleBackColor = true;
            // 
            // rbToGigabit
            // 
            this.rbToGigabit.AutoSize = true;
            this.rbToGigabit.Location = new System.Drawing.Point(6, 129);
            this.rbToGigabit.Name = "rbToGigabit";
            this.rbToGigabit.Size = new System.Drawing.Size(81, 17);
            this.rbToGigabit.TabIndex = 3;
            this.rbToGigabit.TabStop = true;
            this.rbToGigabit.Text = "Gigabit (Gb)";
            this.rbToGigabit.UseVisualStyleBackColor = true;
            // 
            // rbToMegabit
            // 
            this.rbToMegabit.AutoSize = true;
            this.rbToMegabit.Location = new System.Drawing.Point(6, 90);
            this.rbToMegabit.Name = "rbToMegabit";
            this.rbToMegabit.Size = new System.Drawing.Size(87, 17);
            this.rbToMegabit.TabIndex = 2;
            this.rbToMegabit.TabStop = true;
            this.rbToMegabit.Text = "Megabit (Mb)";
            this.rbToMegabit.UseVisualStyleBackColor = true;
            // 
            // rbToKilobit
            // 
            this.rbToKilobit.AutoSize = true;
            this.rbToKilobit.Location = new System.Drawing.Point(6, 53);
            this.rbToKilobit.Name = "rbToKilobit";
            this.rbToKilobit.Size = new System.Drawing.Size(75, 17);
            this.rbToKilobit.TabIndex = 1;
            this.rbToKilobit.TabStop = true;
            this.rbToKilobit.Text = "Kilobit (Kb)";
            this.rbToKilobit.UseVisualStyleBackColor = true;
            // 
            // rbToByte
            // 
            this.rbToByte.AutoSize = true;
            this.rbToByte.Location = new System.Drawing.Point(6, 19);
            this.rbToByte.Name = "rbToByte";
            this.rbToByte.Size = new System.Drawing.Size(62, 17);
            this.rbToByte.TabIndex = 0;
            this.rbToByte.TabStop = true;
            this.rbToByte.Text = "Byte (B)";
            this.rbToByte.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConvert.Location = new System.Drawing.Point(716, 107);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(660, 153);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(200, 20);
            this.txtOutput.TabIndex = 9;
            // 
            // frmDataStorageConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEnterTo);
            this.Controls.Add(this.lblConvertTo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpFrom);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblEnterFrom);
            this.Controls.Add(this.lblConvertFrom);
            this.Name = "frmDataStorageConversion";
            this.Text = "Data Storage Conversion";
            this.grpFrom.ResumeLayout(false);
            this.grpFrom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.Label lblEnterFrom;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpFrom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblConvertTo;
        private System.Windows.Forms.Label lblEnterTo;
        private System.Windows.Forms.RadioButton rbFromTerabit;
        private System.Windows.Forms.RadioButton rbFromGigabit;
        private System.Windows.Forms.RadioButton rbFromMegabit;
        private System.Windows.Forms.RadioButton rbFromKilobit;
        private System.Windows.Forms.RadioButton rbFromByte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbToTerabit;
        private System.Windows.Forms.RadioButton rbToGigabit;
        private System.Windows.Forms.RadioButton rbToMegabit;
        private System.Windows.Forms.RadioButton rbToKilobit;
        private System.Windows.Forms.RadioButton rbToByte;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

