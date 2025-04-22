namespace PayrollSystem
{
    partial class EmployeeDashboard
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
            this.mainAdminPanel = new System.Windows.Forms.Panel();
            this.panel4Emp = new System.Windows.Forms.Panel();
            this.panel3Emp = new System.Windows.Forms.Panel();
            this.panel2Emp = new System.Windows.Forms.Panel();
            this.panel1Emp = new System.Windows.Forms.Panel();
            this.lblEmployeeDashboard = new System.Windows.Forms.Label();
            this.sideAdminPanel = new System.Windows.Forms.Panel();
            this.btnViewPayslip = new System.Windows.Forms.Button();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.btnLeaveRequest = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.mainAdminPanel.SuspendLayout();
            this.sideAdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainAdminPanel
            // 
            this.mainAdminPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainAdminPanel.Controls.Add(this.monthCalendar1);
            this.mainAdminPanel.Controls.Add(this.panel4Emp);
            this.mainAdminPanel.Controls.Add(this.panel3Emp);
            this.mainAdminPanel.Controls.Add(this.panel2Emp);
            this.mainAdminPanel.Controls.Add(this.panel1Emp);
            this.mainAdminPanel.Controls.Add(this.lblEmployeeDashboard);
            this.mainAdminPanel.Location = new System.Drawing.Point(233, 5);
            this.mainAdminPanel.Name = "mainAdminPanel";
            this.mainAdminPanel.Size = new System.Drawing.Size(906, 641);
            this.mainAdminPanel.TabIndex = 1;
            // 
            // panel4Emp
            // 
            this.panel4Emp.BackColor = System.Drawing.Color.Maroon;
            this.panel4Emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4Emp.Location = new System.Drawing.Point(27, 228);
            this.panel4Emp.Name = "panel4Emp";
            this.panel4Emp.Size = new System.Drawing.Size(197, 79);
            this.panel4Emp.TabIndex = 4;
            // 
            // panel3Emp
            // 
            this.panel3Emp.BackColor = System.Drawing.Color.Maroon;
            this.panel3Emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3Emp.Location = new System.Drawing.Point(249, 228);
            this.panel3Emp.Name = "panel3Emp";
            this.panel3Emp.Size = new System.Drawing.Size(197, 79);
            this.panel3Emp.TabIndex = 3;
            // 
            // panel2Emp
            // 
            this.panel2Emp.BackColor = System.Drawing.Color.Maroon;
            this.panel2Emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2Emp.Location = new System.Drawing.Point(249, 110);
            this.panel2Emp.Name = "panel2Emp";
            this.panel2Emp.Size = new System.Drawing.Size(197, 79);
            this.panel2Emp.TabIndex = 2;
            // 
            // panel1Emp
            // 
            this.panel1Emp.BackColor = System.Drawing.Color.Maroon;
            this.panel1Emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1Emp.Location = new System.Drawing.Point(27, 110);
            this.panel1Emp.Name = "panel1Emp";
            this.panel1Emp.Size = new System.Drawing.Size(197, 79);
            this.panel1Emp.TabIndex = 1;
            // 
            // lblEmployeeDashboard
            // 
            this.lblEmployeeDashboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDashboard.Location = new System.Drawing.Point(27, 38);
            this.lblEmployeeDashboard.Name = "lblEmployeeDashboard";
            this.lblEmployeeDashboard.Size = new System.Drawing.Size(159, 53);
            this.lblEmployeeDashboard.TabIndex = 0;
            this.lblEmployeeDashboard.Text = "EMPLOYEE DASHBOARD";
            this.lblEmployeeDashboard.Click += new System.EventHandler(this.lblAdminDashboard_Click);
            // 
            // sideAdminPanel
            // 
            this.sideAdminPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sideAdminPanel.Controls.Add(this.btnViewPayslip);
            this.sideAdminPanel.Controls.Add(this.btnPersonalInfo);
            this.sideAdminPanel.Controls.Add(this.btnLeaveRequest);
            this.sideAdminPanel.Controls.Add(this.btnLogout);
            this.sideAdminPanel.Controls.Add(this.lblWelcome);
            this.sideAdminPanel.Location = new System.Drawing.Point(12, 5);
            this.sideAdminPanel.Name = "sideAdminPanel";
            this.sideAdminPanel.Size = new System.Drawing.Size(200, 649);
            this.sideAdminPanel.TabIndex = 2;
            // 
            // btnViewPayslip
            // 
            this.btnViewPayslip.Location = new System.Drawing.Point(31, 258);
            this.btnViewPayslip.Name = "btnViewPayslip";
            this.btnViewPayslip.Size = new System.Drawing.Size(123, 59);
            this.btnViewPayslip.TabIndex = 9;
            this.btnViewPayslip.Text = "View Payslip";
            this.btnViewPayslip.UseVisualStyleBackColor = true;
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.Location = new System.Drawing.Point(31, 362);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(123, 59);
            this.btnPersonalInfo.TabIndex = 8;
            this.btnPersonalInfo.Text = "Personal Info";
            this.btnPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnLeaveRequest
            // 
            this.btnLeaveRequest.Location = new System.Drawing.Point(31, 455);
            this.btnLeaveRequest.Name = "btnLeaveRequest";
            this.btnLeaveRequest.Size = new System.Drawing.Size(123, 59);
            this.btnLeaveRequest.TabIndex = 7;
            this.btnLeaveRequest.Text = "Leave Req.";
            this.btnLeaveRequest.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(31, 558);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 59);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(17, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(159, 53);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome, [name!]";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(654, 38);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 658);
            this.Controls.Add(this.sideAdminPanel);
            this.Controls.Add(this.mainAdminPanel);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.mainAdminPanel.ResumeLayout(false);
            this.sideAdminPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainAdminPanel;
        private System.Windows.Forms.Panel panel4Emp;
        private System.Windows.Forms.Panel panel3Emp;
        private System.Windows.Forms.Panel panel2Emp;
        private System.Windows.Forms.Panel panel1Emp;
        private System.Windows.Forms.Label lblEmployeeDashboard;
        private System.Windows.Forms.Panel sideAdminPanel;
        private System.Windows.Forms.Button btnViewPayslip;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnLeaveRequest;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}