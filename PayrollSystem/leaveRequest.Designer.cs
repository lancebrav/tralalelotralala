namespace PayrollSystem
{
    partial class leaveRequest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mltnText = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLeaveType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.Label();
            this.timepickleave1 = new System.Windows.Forms.DateTimePicker();
            this.timepickleave2 = new System.Windows.Forms.DateTimePicker();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "why u wanna leave??!?!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "REASON:";
            // 
            // mltnText
            // 
            this.mltnText.Location = new System.Drawing.Point(19, 368);
            this.mltnText.Multiline = true;
            this.mltnText.Name = "mltnText";
            this.mltnText.Size = new System.Drawing.Size(459, 211);
            this.mltnText.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(161, 604);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 604);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblLeaveType
            // 
            this.lblLeaveType.AutoSize = true;
            this.lblLeaveType.Location = new System.Drawing.Point(24, 172);
            this.lblLeaveType.Name = "lblLeaveType";
            this.lblLeaveType.Size = new System.Drawing.Size(75, 13);
            this.lblLeaveType.TabIndex = 5;
            this.lblLeaveType.Text = "LEAVE TYPE:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(24, 208);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "START DATE:";
            // 
            // enddate
            // 
            this.enddate.AutoSize = true;
            this.enddate.Location = new System.Drawing.Point(24, 250);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(65, 13);
            this.enddate.TabIndex = 7;
            this.enddate.Text = "END DATE:";
            // 
            // timepickleave1
            // 
            this.timepickleave1.Location = new System.Drawing.Point(133, 208);
            this.timepickleave1.Name = "timepickleave1";
            this.timepickleave1.Size = new System.Drawing.Size(200, 20);
            this.timepickleave1.TabIndex = 8;
            // 
            // timepickleave2
            // 
            this.timepickleave2.Location = new System.Drawing.Point(133, 250);
            this.timepickleave2.Name = "timepickleave2";
            this.timepickleave2.Size = new System.Drawing.Size(200, 20);
            this.timepickleave2.TabIndex = 9;
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Location = new System.Drawing.Point(133, 169);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(121, 21);
            this.cmbLeaveType.TabIndex = 10;
            // 
            // leaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 650);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.timepickleave2);
            this.Controls.Add(this.timepickleave1);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLeaveType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.mltnText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "leaveRequest";
            this.Text = "leaveRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mltnText;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLeaveType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label enddate;
        private System.Windows.Forms.DateTimePicker timepickleave1;
        private System.Windows.Forms.DateTimePicker timepickleave2;
        private System.Windows.Forms.ComboBox cmbLeaveType;
    }
}