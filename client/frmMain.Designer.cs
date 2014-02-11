namespace cit448_finallab_client
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.panLogin = new System.Windows.Forms.GroupBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panRegular = new System.Windows.Forms.Panel();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panAdmin = new System.Windows.Forms.Panel();
            this.cmdChange = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panLogin.SuspendLayout();
            this.panRegular.SuspendLayout();
            this.panAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(59, 6);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(161, 20);
            this.txtServer.TabIndex = 1;
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.cmdLogin);
            this.panLogin.Controls.Add(this.label4);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.txtUsername);
            this.panLogin.Controls.Add(this.label3);
            this.panLogin.Controls.Add(this.label2);
            this.panLogin.Location = new System.Drawing.Point(15, 32);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(205, 148);
            this.panLogin.TabIndex = 2;
            this.panLogin.TabStop = false;
            this.panLogin.Text = "Credentials";
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(9, 118);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(190, 23);
            this.cmdLogin.TabIndex = 6;
            this.cmdLogin.Text = "Login!";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "A note to TAs: Use the student\'s admin password to submit grade changes";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(67, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(67, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // panRegular
            // 
            this.panRegular.Controls.Add(this.lblGrade);
            this.panRegular.Controls.Add(this.label5);
            this.panRegular.Location = new System.Drawing.Point(15, 186);
            this.panRegular.Name = "panRegular";
            this.panRegular.Size = new System.Drawing.Size(205, 39);
            this.panRegular.TabIndex = 3;
            this.panRegular.Visible = false;
            this.panRegular.Paint += new System.Windows.Forms.PaintEventHandler(this.panRegular_Paint);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(120, 13);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(25, 13);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "2.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your current grade is:";
            // 
            // panAdmin
            // 
            this.panAdmin.Controls.Add(this.cmdChange);
            this.panAdmin.Controls.Add(this.txtGrade);
            this.panAdmin.Controls.Add(this.label6);
            this.panAdmin.Location = new System.Drawing.Point(15, 231);
            this.panAdmin.Name = "panAdmin";
            this.panAdmin.Size = new System.Drawing.Size(205, 69);
            this.panAdmin.TabIndex = 4;
            this.panAdmin.Visible = false;
            // 
            // cmdChange
            // 
            this.cmdChange.Location = new System.Drawing.Point(9, 36);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(190, 23);
            this.cmdChange.TabIndex = 7;
            this.cmdChange.Text = "Submit changes";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(162, 10);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(37, 20);
            this.txtGrade.TabIndex = 2;
            this.txtGrade.Text = "2.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "The student\'s current grade is:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 334);
            this.Controls.Add(this.panAdmin);
            this.Controls.Add(this.panRegular);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Grade Checker 1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panRegular.ResumeLayout(false);
            this.panRegular.PerformLayout();
            this.panAdmin.ResumeLayout(false);
            this.panAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox panLogin;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panRegular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Panel panAdmin;
        private System.Windows.Forms.Button cmdChange;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label6;
    }
}

