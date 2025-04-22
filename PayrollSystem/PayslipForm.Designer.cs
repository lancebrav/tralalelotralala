namespace PayrollSystem
{
    partial class PayslipForm
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
            this.txtPayslip = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.lblNetpay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtPayslip);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 59);
            this.panel1.TabIndex = 0;
            // 
            // txtPayslip
            // 
            this.txtPayslip.AutoSize = true;
            this.txtPayslip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayslip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPayslip.Location = new System.Drawing.Point(222, 14);
            this.txtPayslip.Name = "txtPayslip";
            this.txtPayslip.Size = new System.Drawing.Size(118, 29);
            this.txtPayslip.TabIndex = 0;
            this.txtPayslip.Text = "PAYSLIP";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.lblNetpay);
            this.pnlDetails.Controls.Add(this.lblDeductions);
            this.pnlDetails.Controls.Add(this.lblOvertime);
            this.pnlDetails.Controls.Add(this.lblBasicSalary);
            this.pnlDetails.Location = new System.Drawing.Point(18, 247);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(582, 301);
            this.pnlDetails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(36, 179);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(40, 13);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "Period:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(208, 579);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(314, 579);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSalary.Location = new System.Drawing.Point(78, 45);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(131, 20);
            this.lblBasicSalary.TabIndex = 6;
            this.lblBasicSalary.Text = "BASIC SALARY:";
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertime.Location = new System.Drawing.Point(78, 87);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(97, 20);
            this.lblOvertime.TabIndex = 7;
            this.lblOvertime.Text = "OVERTIME:";
            // 
            // lblDeductions
            // 
            this.lblDeductions.AutoSize = true;
            this.lblDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductions.Location = new System.Drawing.Point(78, 127);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(119, 20);
            this.lblDeductions.TabIndex = 8;
            this.lblDeductions.Text = "DEDUCTIONS:";
            // 
            // lblNetpay
            // 
            this.lblNetpay.AutoSize = true;
            this.lblNetpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetpay.Location = new System.Drawing.Point(78, 169);
            this.lblNetpay.Name = "lblNetpay";
            this.lblNetpay.Size = new System.Drawing.Size(80, 20);
            this.lblNetpay.TabIndex = 9;
            this.lblNetpay.Text = "NET PAY:";
            // 
            // PayslipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 636);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.panel1);
            this.Name = "PayslipForm";
            this.Text = "PayslipForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtPayslip;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNetpay;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.Label lblBasicSalary;
    }
}