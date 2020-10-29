namespace IB1.Panel
{
    partial class PasswordChangePanel
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxRepeatPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(624, 89);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxRepeatPass);
            this.groupBox1.Controls.Add(this.textBoxNewPass);
            this.groupBox1.Controls.Add(this.textBoxOldPass);
            this.groupBox1.Location = new System.Drawing.Point(52, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(472, 164);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxRepeatPass
            // 
            this.textBoxRepeatPass.Location = new System.Drawing.Point(270, 122);
            this.textBoxRepeatPass.Name = "textBoxRepeatPass";
            this.textBoxRepeatPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxRepeatPass.TabIndex = 2;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(270, 83);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewPass.TabIndex = 1;
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(270, 44);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxOldPass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Old";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "New";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat";
            // 
            // PasswordChangePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBack);
            this.Name = "PasswordChangePanel";
            this.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxRepeatPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}