namespace PayrollSystem
{
    partial class PayrollProcessForm
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
            this.lblPayrollProcess = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bscSalary = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPayrollProcess);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 93);
            this.panel1.TabIndex = 0;
            // 
            // lblPayrollProcess
            // 
            this.lblPayrollProcess.AutoSize = true;
            this.lblPayrollProcess.BackColor = System.Drawing.Color.Green;
            this.lblPayrollProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayrollProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrollProcess.Location = new System.Drawing.Point(194, 31);
            this.lblPayrollProcess.Name = "lblPayrollProcess";
            this.lblPayrollProcess.Size = new System.Drawing.Size(216, 31);
            this.lblPayrollProcess.TabIndex = 0;
            this.lblPayrollProcess.Text = "Payroll Processing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(13, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 483);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCalculate);
            this.panel3.Location = new System.Drawing.Point(111, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 45);
            this.panel3.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE PAYROLL";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(17, 11);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 24);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.txtNetPay);
            this.panel4.Controls.Add(this.txtDeductions);
            this.panel4.Controls.Add(this.txtOvertime);
            this.panel4.Controls.Add(this.txtBaseSalary);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.bscSalary);
            this.panel4.Location = new System.Drawing.Point(111, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 212);
            this.panel4.TabIndex = 11;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(177, 170);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(176, 20);
            this.txtNetPay.TabIndex = 10;
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(177, 121);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(176, 20);
            this.txtDeductions.TabIndex = 9;
            // 
            // txtOvertime
            // 
            this.txtOvertime.Location = new System.Drawing.Point(177, 62);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(176, 20);
            this.txtOvertime.TabIndex = 8;
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.Location = new System.Drawing.Point(177, 9);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.ReadOnly = true;
            this.txtBaseSalary.Size = new System.Drawing.Size(176, 20);
            this.txtBaseSalary.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Net Pay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deductions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Overtime Hours:";
            // 
            // bscSalary
            // 
            this.bscSalary.AutoSize = true;
            this.bscSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bscSalary.Location = new System.Drawing.Point(7, 9);
            this.bscSalary.Name = "bscSalary";
            this.bscSalary.Size = new System.Drawing.Size(116, 24);
            this.bscSalary.TabIndex = 2;
            this.bscSalary.Text = "Basic Salary:";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(9, 13);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(158, 24);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select Employee:";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(13, 40);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(148, 21);
            this.cmbEmployees.TabIndex = 1;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.lblSelect);
            this.panel5.Controls.Add(this.cmbEmployees);
            this.panel5.Location = new System.Drawing.Point(619, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 477);
            this.panel5.TabIndex = 2;
            // 
            // PayrollProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PayrollSystem.Properties.Resources.svbldg23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 636);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "PayrollProcessForm";
            this.Text = "PayrollProcessForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPayrollProcess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bscSalary;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.TextBox txtOvertime;
        private System.Windows.Forms.TextBox txtBaseSalary;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalculate;
    }
}