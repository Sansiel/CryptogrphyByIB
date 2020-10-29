namespace IB1_main
{
    partial class FormUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(13, 415);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(141, 23);
            this.buttonChangePassword.TabIndex = 1;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(161, 415);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(713, 415);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAbout;
    }
}