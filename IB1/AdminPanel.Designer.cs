namespace IB1
{
    partial class AdminPanel
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonOneUser = new System.Windows.Forms.Button();
            this.buttonAllUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsHardPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxIsBlock = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRightRight = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonLeftLeft = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBlock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isHardPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxUser.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(64, 77);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Location = new System.Drawing.Point(176, 77);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(129, 23);
            this.buttonChangePass.TabIndex = 1;
            this.buttonChangePass.Text = "Change password";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(648, 77);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddUser);
            this.groupBox1.Controls.Add(this.buttonOneUser);
            this.groupBox1.Controls.Add(this.buttonAllUser);
            this.groupBox1.Location = new System.Drawing.Point(204, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(224, 21);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "AddUser";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonOneUser
            // 
            this.buttonOneUser.Location = new System.Drawing.Point(122, 22);
            this.buttonOneUser.Name = "buttonOneUser";
            this.buttonOneUser.Size = new System.Drawing.Size(75, 23);
            this.buttonOneUser.TabIndex = 1;
            this.buttonOneUser.Text = "OneUser";
            this.buttonOneUser.UseVisualStyleBackColor = true;
            this.buttonOneUser.Click += new System.EventHandler(this.buttonOneUser_Click);
            // 
            // buttonAllUser
            // 
            this.buttonAllUser.Location = new System.Drawing.Point(21, 22);
            this.buttonAllUser.Name = "buttonAllUser";
            this.buttonAllUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAllUser.TabIndex = 0;
            this.buttonAllUser.Text = "AllUser";
            this.buttonAllUser.UseVisualStyleBackColor = true;
            this.buttonAllUser.Click += new System.EventHandler(this.buttonAllUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.isBlock,
            this.isHardPassword});
            this.dataGridView1.Location = new System.Drawing.Point(64, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 217);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(122, 36);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.groupBox4);
            this.groupBoxUser.Controls.Add(this.groupBox3);
            this.groupBoxUser.Controls.Add(this.textBoxLogin);
            this.groupBoxUser.Controls.Add(this.buttonSave);
            this.groupBoxUser.Location = new System.Drawing.Point(204, 198);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(377, 217);
            this.groupBoxUser.TabIndex = 6;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxIsHardPassword);
            this.groupBox4.Controls.Add(this.checkBoxIsBlock);
            this.groupBox4.Location = new System.Drawing.Point(122, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 77);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // checkBoxIsHardPassword
            // 
            this.checkBoxIsHardPassword.AutoSize = true;
            this.checkBoxIsHardPassword.Location = new System.Drawing.Point(7, 39);
            this.checkBoxIsHardPassword.Name = "checkBoxIsHardPassword";
            this.checkBoxIsHardPassword.Size = new System.Drawing.Size(132, 21);
            this.checkBoxIsHardPassword.TabIndex = 1;
            this.checkBoxIsHardPassword.Text = "isHardPassword";
            this.checkBoxIsHardPassword.UseVisualStyleBackColor = true;
            this.checkBoxIsHardPassword.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxIsBlock
            // 
            this.checkBoxIsBlock.AutoSize = true;
            this.checkBoxIsBlock.Location = new System.Drawing.Point(7, 11);
            this.checkBoxIsBlock.Name = "checkBoxIsBlock";
            this.checkBoxIsBlock.Size = new System.Drawing.Size(74, 21);
            this.checkBoxIsBlock.TabIndex = 0;
            this.checkBoxIsBlock.Text = "isBlock";
            this.checkBoxIsBlock.UseVisualStyleBackColor = true;
            this.checkBoxIsBlock.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRightRight);
            this.groupBox3.Controls.Add(this.buttonRight);
            this.groupBox3.Controls.Add(this.buttonLeft);
            this.groupBox3.Controls.Add(this.buttonLeftLeft);
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // buttonRightRight
            // 
            this.buttonRightRight.Location = new System.Drawing.Point(279, 22);
            this.buttonRightRight.Name = "buttonRightRight";
            this.buttonRightRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRightRight.TabIndex = 3;
            this.buttonRightRight.Text = ">>";
            this.buttonRightRight.UseVisualStyleBackColor = true;
            this.buttonRightRight.Click += new System.EventHandler(this.buttonRightRight_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(197, 21);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(96, 22);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonLeftLeft
            // 
            this.buttonLeftLeft.Location = new System.Drawing.Point(14, 22);
            this.buttonLeftLeft.Name = "buttonLeftLeft";
            this.buttonLeftLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftLeft.TabIndex = 0;
            this.buttonLeftLeft.Text = "<<";
            this.buttonLeftLeft.UseVisualStyleBackColor = true;
            this.buttonLeftLeft.Click += new System.EventHandler(this.buttonLeftLeft_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(122, 102);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(139, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // isBlock
            // 
            this.isBlock.HeaderText = "isBlock";
            this.isBlock.Name = "isBlock";
            // 
            // isHardPassword
            // 
            this.isHardPassword.HeaderText = "isHardPassword";
            this.isHardPassword.Name = "isHardPassword";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.buttonLogout);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonOneUser;
        private System.Windows.Forms.Button buttonAllUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxIsHardPassword;
        private System.Windows.Forms.CheckBox checkBoxIsBlock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRightRight;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonLeftLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn isHardPassword;
    }
}