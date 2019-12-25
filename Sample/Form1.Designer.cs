namespace Sample
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.GrpLogin = new System.Windows.Forms.GroupBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.btnRefreshHistoryList = new System.Windows.Forms.Button();
            this.btnClearHistoryList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdUserList = new System.Windows.Forms.DataGridView();
            this.btnClearUserList = new System.Windows.Forms.Button();
            this.btnRefreshUserList = new System.Windows.Forms.Button();
            this.txtEditUsername = new System.Windows.Forms.TextBox();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditMobile = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditUsername = new System.Windows.Forms.Label();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.lblEditMobile = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.GrpLogin.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(56, 91);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(46, 39);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsername.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(46, 65);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(56, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GrpLogin
            // 
            this.GrpLogin.Controls.Add(this.txtLoginUsername);
            this.GrpLogin.Controls.Add(this.btnClose);
            this.GrpLogin.Controls.Add(this.btnEnter);
            this.GrpLogin.Controls.Add(this.txtLoginPassword);
            this.GrpLogin.Location = new System.Drawing.Point(201, 74);
            this.GrpLogin.Name = "GrpLogin";
            this.GrpLogin.Size = new System.Drawing.Size(200, 184);
            this.GrpLogin.TabIndex = 4;
            this.GrpLogin.TabStop = false;
            this.GrpLogin.Text = "groupBox1";
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(3, 3);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(233, 329);
            this.lstHistory.TabIndex = 5;
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.btnClearHistoryList);
            this.pnlHistory.Controls.Add(this.btnRefreshHistoryList);
            this.pnlHistory.Controls.Add(this.lstHistory);
            this.pnlHistory.Location = new System.Drawing.Point(12, 12);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(239, 361);
            this.pnlHistory.TabIndex = 6;
            this.pnlHistory.Visible = false;
            // 
            // btnRefreshHistoryList
            // 
            this.btnRefreshHistoryList.Location = new System.Drawing.Point(3, 335);
            this.btnRefreshHistoryList.Name = "btnRefreshHistoryList";
            this.btnRefreshHistoryList.Size = new System.Drawing.Size(124, 23);
            this.btnRefreshHistoryList.TabIndex = 6;
            this.btnRefreshHistoryList.Text = "Refresh";
            this.btnRefreshHistoryList.UseVisualStyleBackColor = true;
            this.btnRefreshHistoryList.Click += new System.EventHandler(this.btnRefreshHistoryList_Click);
            // 
            // btnClearHistoryList
            // 
            this.btnClearHistoryList.Location = new System.Drawing.Point(133, 335);
            this.btnClearHistoryList.Name = "btnClearHistoryList";
            this.btnClearHistoryList.Size = new System.Drawing.Size(103, 23);
            this.btnClearHistoryList.TabIndex = 7;
            this.btnClearHistoryList.Text = "Clear";
            this.btnClearHistoryList.UseVisualStyleBackColor = true;
            this.btnClearHistoryList.Click += new System.EventHandler(this.btnClearHistoryList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnEditUser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnNewUser);
            this.panel1.Controls.Add(this.btnClearUserList);
            this.panel1.Controls.Add(this.btnRefreshUserList);
            this.panel1.Controls.Add(this.grdUserList);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 358);
            this.panel1.TabIndex = 7;
            // 
            // grdUserList
            // 
            this.grdUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUserList.Location = new System.Drawing.Point(3, 3);
            this.grdUserList.Name = "grdUserList";
            this.grdUserList.Size = new System.Drawing.Size(562, 234);
            this.grdUserList.TabIndex = 0;
            // 
            // btnClearUserList
            // 
            this.btnClearUserList.Location = new System.Drawing.Point(463, 324);
            this.btnClearUserList.Name = "btnClearUserList";
            this.btnClearUserList.Size = new System.Drawing.Size(89, 23);
            this.btnClearUserList.TabIndex = 9;
            this.btnClearUserList.Text = "Clear";
            this.btnClearUserList.UseVisualStyleBackColor = true;
            // 
            // btnRefreshUserList
            // 
            this.btnRefreshUserList.Location = new System.Drawing.Point(358, 325);
            this.btnRefreshUserList.Name = "btnRefreshUserList";
            this.btnRefreshUserList.Size = new System.Drawing.Size(99, 23);
            this.btnRefreshUserList.TabIndex = 8;
            this.btnRefreshUserList.Text = "Refresh";
            this.btnRefreshUserList.UseVisualStyleBackColor = true;
            this.btnRefreshUserList.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEditUsername
            // 
            this.txtEditUsername.Location = new System.Drawing.Point(94, 6);
            this.txtEditUsername.Name = "txtEditUsername";
            this.txtEditUsername.Size = new System.Drawing.Size(100, 20);
            this.txtEditUsername.TabIndex = 10;
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(94, 26);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(100, 20);
            this.txtEditPassword.TabIndex = 11;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(94, 46);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(100, 20);
            this.txtEditName.TabIndex = 12;
            // 
            // txtEditMobile
            // 
            this.txtEditMobile.Location = new System.Drawing.Point(94, 66);
            this.txtEditMobile.Name = "txtEditMobile";
            this.txtEditMobile.Size = new System.Drawing.Size(100, 20);
            this.txtEditMobile.TabIndex = 13;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(94, 86);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEditEmail.TabIndex = 14;
            // 
            // lblEditUsername
            // 
            this.lblEditUsername.AutoSize = true;
            this.lblEditUsername.Location = new System.Drawing.Point(19, 7);
            this.lblEditUsername.Name = "lblEditUsername";
            this.lblEditUsername.Size = new System.Drawing.Size(55, 13);
            this.lblEditUsername.TabIndex = 15;
            this.lblEditUsername.Text = "Username";
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.Location = new System.Drawing.Point(21, 28);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(53, 13);
            this.lblEditPassword.TabIndex = 16;
            this.lblEditPassword.Text = "Password";
            // 
            // lblEditMobile
            // 
            this.lblEditMobile.AutoSize = true;
            this.lblEditMobile.Location = new System.Drawing.Point(21, 70);
            this.lblEditMobile.Name = "lblEditMobile";
            this.lblEditMobile.Size = new System.Drawing.Size(38, 13);
            this.lblEditMobile.TabIndex = 17;
            this.lblEditMobile.Text = "Mobile";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(21, 49);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(35, 13);
            this.lblEditName.TabIndex = 18;
            this.lblEditName.Text = "Name";
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Location = new System.Drawing.Point(24, 91);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEditEmail.TabIndex = 19;
            this.lblEditEmail.Text = "Email";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(194, 28);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(99, 23);
            this.btnSaveUser.TabIndex = 20;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(316, 247);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(99, 23);
            this.btnNewUser.TabIndex = 21;
            this.btnNewUser.Text = "New";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Location = new System.Drawing.Point(194, 66);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(99, 23);
            this.btnCancelUser.TabIndex = 22;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEditPassword);
            this.panel2.Controls.Add(this.btnCancelUser);
            this.panel2.Controls.Add(this.txtEditUsername);
            this.panel2.Controls.Add(this.txtEditPassword);
            this.panel2.Controls.Add(this.btnSaveUser);
            this.panel2.Controls.Add(this.txtEditName);
            this.panel2.Controls.Add(this.lblEditEmail);
            this.panel2.Controls.Add(this.txtEditMobile);
            this.panel2.Controls.Add(this.lblEditName);
            this.panel2.Controls.Add(this.txtEditEmail);
            this.panel2.Controls.Add(this.lblEditMobile);
            this.panel2.Controls.Add(this.lblEditUsername);
            this.panel2.Location = new System.Drawing.Point(5, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 110);
            this.panel2.TabIndex = 23;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(439, 247);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(99, 23);
            this.btnEditUser.TabIndex = 24;
            this.btnEditUser.Text = "Update";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(316, 282);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteUser.TabIndex = 25;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.GrpLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrpLogin.ResumeLayout(false);
            this.GrpLogin.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUserList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox GrpLogin;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Button btnClearHistoryList;
        private System.Windows.Forms.Button btnRefreshHistoryList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearUserList;
        private System.Windows.Forms.Button btnRefreshUserList;
        private System.Windows.Forms.DataGridView grdUserList;
        private System.Windows.Forms.Label lblEditUsername;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditMobile;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.TextBox txtEditUsername;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditMobile;
        private System.Windows.Forms.Label lblEditPassword;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnNewUser;
    }
}

