namespace Change_for_a_dollar_game
{
    partial class frmChangeForDollar
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.txtNickles = new System.Windows.Forms.TextBox();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.txtQuarter = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(248, 366);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(174, 37);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Pennies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Nickels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Dimes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Quarter";
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(278, 50);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.Size = new System.Drawing.Size(144, 31);
            this.txtPennies.TabIndex = 5;
            // 
            // txtNickles
            // 
            this.txtNickles.Location = new System.Drawing.Point(278, 135);
            this.txtNickles.Name = "txtNickles";
            this.txtNickles.Size = new System.Drawing.Size(144, 31);
            this.txtNickles.TabIndex = 6;
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(278, 207);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.Size = new System.Drawing.Size(144, 31);
            this.txtDimes.TabIndex = 7;
            // 
            // txtQuarter
            // 
            this.txtQuarter.Location = new System.Drawing.Point(278, 289);
            this.txtQuarter.Name = "txtQuarter";
            this.txtQuarter.Size = new System.Drawing.Size(144, 31);
            this.txtQuarter.TabIndex = 8;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(85, 422);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(337, 112);
            this.txtOutput.TabIndex = 9;
            // 
            // frmChangeForDollar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 555);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtQuarter);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.txtNickles);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmChangeForDollar";
            this.Text = "Change for a dollar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.TextBox txtNickles;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.TextBox txtQuarter;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

