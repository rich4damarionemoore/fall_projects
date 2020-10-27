namespace Color_Mixer
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
            this.radFirstRed = new System.Windows.Forms.RadioButton();
            this.radFirstBlue = new System.Windows.Forms.RadioButton();
            this.radFirstYellow = new System.Windows.Forms.RadioButton();
            this.radSecondRed = new System.Windows.Forms.RadioButton();
            this.radSecondBlue = new System.Windows.Forms.RadioButton();
            this.radSecondYellow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radFirstRed
            // 
            this.radFirstRed.AutoSize = true;
            this.radFirstRed.Location = new System.Drawing.Point(18, 75);
            this.radFirstRed.Name = "radFirstRed";
            this.radFirstRed.Size = new System.Drawing.Size(82, 29);
            this.radFirstRed.TabIndex = 1;
            this.radFirstRed.TabStop = true;
            this.radFirstRed.Text = "Red";
            this.radFirstRed.UseVisualStyleBackColor = true;
            // 
            // radFirstBlue
            // 
            this.radFirstBlue.AutoSize = true;
            this.radFirstBlue.Location = new System.Drawing.Point(18, 164);
            this.radFirstBlue.Name = "radFirstBlue";
            this.radFirstBlue.Size = new System.Drawing.Size(86, 29);
            this.radFirstBlue.TabIndex = 2;
            this.radFirstBlue.TabStop = true;
            this.radFirstBlue.Text = "Blue";
            this.radFirstBlue.UseVisualStyleBackColor = true;
            // 
            // radFirstYellow
            // 
            this.radFirstYellow.AutoSize = true;
            this.radFirstYellow.Location = new System.Drawing.Point(18, 251);
            this.radFirstYellow.Name = "radFirstYellow";
            this.radFirstYellow.Size = new System.Drawing.Size(107, 29);
            this.radFirstYellow.TabIndex = 3;
            this.radFirstYellow.TabStop = true;
            this.radFirstYellow.Text = "Yellow";
            this.radFirstYellow.UseVisualStyleBackColor = true;
            this.radFirstYellow.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radSecondRed
            // 
            this.radSecondRed.AutoSize = true;
            this.radSecondRed.Location = new System.Drawing.Point(25, 62);
            this.radSecondRed.Name = "radSecondRed";
            this.radSecondRed.Size = new System.Drawing.Size(82, 29);
            this.radSecondRed.TabIndex = 4;
            this.radSecondRed.TabStop = true;
            this.radSecondRed.Text = "Red";
            this.radSecondRed.UseVisualStyleBackColor = true;
            // 
            // radSecondBlue
            // 
            this.radSecondBlue.AutoSize = true;
            this.radSecondBlue.Location = new System.Drawing.Point(25, 150);
            this.radSecondBlue.Name = "radSecondBlue";
            this.radSecondBlue.Size = new System.Drawing.Size(86, 29);
            this.radSecondBlue.TabIndex = 5;
            this.radSecondBlue.TabStop = true;
            this.radSecondBlue.Text = "Blue";
            this.radSecondBlue.UseVisualStyleBackColor = true;
            this.radSecondBlue.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radSecondYellow
            // 
            this.radSecondYellow.AutoSize = true;
            this.radSecondYellow.Location = new System.Drawing.Point(25, 251);
            this.radSecondYellow.Name = "radSecondYellow";
            this.radSecondYellow.Size = new System.Drawing.Size(107, 29);
            this.radSecondYellow.TabIndex = 6;
            this.radSecondYellow.TabStop = true;
            this.radSecondYellow.Text = "Yellow";
            this.radSecondYellow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFirstRed);
            this.groupBox1.Controls.Add(this.radFirstBlue);
            this.groupBox1.Controls.Add(this.radFirstYellow);
            this.groupBox1.Location = new System.Drawing.Point(32, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Color";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSecondBlue);
            this.groupBox2.Controls.Add(this.radSecondYellow);
            this.groupBox2.Controls.Add(this.radSecondRed);
            this.groupBox2.Location = new System.Drawing.Point(391, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 337);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(391, 529);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(146, 34);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 633);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radFirstRed;
        private System.Windows.Forms.RadioButton radFirstBlue;
        private System.Windows.Forms.RadioButton radFirstYellow;
        private System.Windows.Forms.RadioButton radSecondRed;
        private System.Windows.Forms.RadioButton radSecondBlue;
        private System.Windows.Forms.RadioButton radSecondYellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
    }
}

