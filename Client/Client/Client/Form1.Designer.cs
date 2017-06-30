﻿namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pSignUp = new System.Windows.Forms.Panel();
            this.pLogin = new System.Windows.Forms.Panel();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.pSignUp.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fullname:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(95, 7);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(95, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 23);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(95, 41);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(189, 23);
            this.txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // pSignUp
            // 
            this.pSignUp.Controls.Add(this.chkAdmin);
            this.pSignUp.Controls.Add(this.label4);
            this.pSignUp.Controls.Add(this.txtEmail);
            this.pSignUp.Controls.Add(this.label5);
            this.pSignUp.Controls.Add(this.txtFullName);
            this.pSignUp.Controls.Add(this.label3);
            this.pSignUp.Location = new System.Drawing.Point(165, 189);
            this.pSignUp.Name = "pSignUp";
            this.pSignUp.Size = new System.Drawing.Size(307, 100);
            this.pSignUp.TabIndex = 9;
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.label1);
            this.pLogin.Controls.Add(this.label2);
            this.pLogin.Controls.Add(this.txtPassword);
            this.pLogin.Controls.Add(this.txtUsername);
            this.pLogin.Location = new System.Drawing.Point(165, 100);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(307, 83);
            this.pLogin.TabIndex = 10;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(95, 16);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(15, 14);
            this.chkAdmin.TabIndex = 9;
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(275, 314);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 37);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(389, 314);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(83, 37);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Done";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnListUsers
            // 
            this.btnListUsers.Location = new System.Drawing.Point(505, 43);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(142, 38);
            this.btnListUsers.TabIndex = 13;
            this.btnListUsers.Text = "Find all users";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Visible = false;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(505, 100);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(142, 39);
            this.btnNewUser.TabIndex = 14;
            this.btnNewUser.Text = "Add new user";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // lvUsers
            // 
            this.lvUsers.Location = new System.Drawing.Point(38, 43);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(448, 198);
            this.lvUsers.TabIndex = 15;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 378);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnListUsers);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.pSignUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Authorization and authentication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pSignUp.ResumeLayout(false);
            this.pSignUp.PerformLayout();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pSignUp;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.ListView lvUsers;
    }
}

