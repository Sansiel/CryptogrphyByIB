namespace IB2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАлгоритмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCloseI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.buttonDH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCloseJ = new System.Windows.Forms.TextBox();
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxYj = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.обАлгоритмеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // обАлгоритмеToolStripMenuItem
            // 
            this.обАлгоритмеToolStripMenuItem.Name = "обАлгоритмеToolStripMenuItem";
            this.обАлгоритмеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.обАлгоритмеToolStripMenuItem.Text = "Об алгоритме";
            this.обАлгоритмеToolStripMenuItem.Click += new System.EventHandler(this.обАлгоритмеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Секретный ключ Xi";
            // 
            // textBoxCloseI
            // 
            this.textBoxCloseI.Location = new System.Drawing.Point(15, 62);
            this.textBoxCloseI.Name = "textBoxCloseI";
            this.textBoxCloseI.Size = new System.Drawing.Size(131, 22);
            this.textBoxCloseI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yi";
            // 
            // textBoxYi
            // 
            this.textBoxYi.Location = new System.Drawing.Point(15, 124);
            this.textBoxYi.Name = "textBoxYi";
            this.textBoxYi.Size = new System.Drawing.Size(131, 22);
            this.textBoxYi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Общий Ключ K";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(15, 221);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.ReadOnly = true;
            this.textBoxK.Size = new System.Drawing.Size(131, 22);
            this.textBoxK.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Q:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "A:";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(225, 144);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(198, 23);
            this.buttonRead.TabIndex = 9;
            this.buttonRead.Text = "Считать данные из файла";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(252, 61);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(171, 22);
            this.textBoxQ.TabIndex = 10;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(252, 104);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(171, 22);
            this.textBoxA.TabIndex = 11;
            // 
            // buttonDH
            // 
            this.buttonDH.Location = new System.Drawing.Point(15, 260);
            this.buttonDH.Name = "buttonDH";
            this.buttonDH.Size = new System.Drawing.Size(199, 23);
            this.buttonDH.TabIndex = 12;
            this.buttonDH.Text = "Вычислить общий ключ";
            this.buttonDH.UseVisualStyleBackColor = true;
            this.buttonDH.Click += new System.EventHandler(this.buttonDH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxYj);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonGeneration);
            this.groupBox1.Controls.Add(this.textBoxCloseJ);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(464, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сгенерировать открытый ключ для собеседника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Секретный ключ Xi";
            // 
            // textBoxCloseJ
            // 
            this.textBoxCloseJ.Location = new System.Drawing.Point(141, 82);
            this.textBoxCloseJ.Name = "textBoxCloseJ";
            this.textBoxCloseJ.Size = new System.Drawing.Size(131, 22);
            this.textBoxCloseJ.TabIndex = 15;
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Location = new System.Drawing.Point(141, 110);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(131, 23);
            this.buttonGeneration.TabIndex = 16;
            this.buttonGeneration.Text = "Сгенерировать";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yi";
            // 
            // textBoxYj
            // 
            this.textBoxYj.Location = new System.Drawing.Point(141, 188);
            this.textBoxYj.Name = "textBoxYj";
            this.textBoxYj.ReadOnly = true;
            this.textBoxYj.Size = new System.Drawing.Size(131, 22);
            this.textBoxYj.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDecode);
            this.groupBox2.Controls.Add(this.buttonEncode);
            this.groupBox2.Location = new System.Drawing.Point(286, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шифрование";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(32, 49);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(105, 23);
            this.buttonEncode.TabIndex = 0;
            this.buttonEncode.Text = "Шифровать";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(178, 49);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(128, 23);
            this.buttonDecode.TabIndex = 1;
            this.buttonDecode.Text = "Расшифровать";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDH);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCloseI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАлгоритмеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCloseI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Button buttonDH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCloseJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGeneration;
        private System.Windows.Forms.TextBox textBoxYj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonEncode;
    }
}

