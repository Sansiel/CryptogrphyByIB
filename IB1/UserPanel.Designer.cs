namespace IB1
{
    partial class UserPanel
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
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(40, 64);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Location = new System.Drawing.Point(156, 63);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(75, 23);
            this.buttonChangePass.TabIndex = 1;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.buttonLogout);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonChangePass;
    }
}