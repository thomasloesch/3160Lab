namespace WindowsFormsApplication1
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
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxNumber = new System.Windows.Forms.TextBox();
            this.txtBxRate = new System.Windows.Forms.TextBox();
            this.txtBxHours = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstBxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp. Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp. #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pay Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours Worked";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(99, 33);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 4;
            // 
            // txtBxNumber
            // 
            this.txtBxNumber.Location = new System.Drawing.Point(99, 62);
            this.txtBxNumber.Name = "txtBxNumber";
            this.txtBxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBxNumber.TabIndex = 6;
            // 
            // txtBxRate
            // 
            this.txtBxRate.Location = new System.Drawing.Point(99, 91);
            this.txtBxRate.Name = "txtBxRate";
            this.txtBxRate.Size = new System.Drawing.Size(100, 20);
            this.txtBxRate.TabIndex = 8;
            // 
            // txtBxHours
            // 
            this.txtBxHours.Location = new System.Drawing.Point(99, 120);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(100, 20);
            this.txtBxHours.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(75, 155);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstBxOutput
            // 
            this.lstBxOutput.FormattingEnabled = true;
            this.lstBxOutput.Location = new System.Drawing.Point(216, 16);
            this.lstBxOutput.Name = "lstBxOutput";
            this.lstBxOutput.Size = new System.Drawing.Size(404, 160);
            this.lstBxOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 192);
            this.Controls.Add(this.lstBxOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBxHours);
            this.Controls.Add(this.txtBxRate);
            this.Controls.Add(this.txtBxNumber);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Example 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxNumber;
        private System.Windows.Forms.TextBox txtBxRate;
        private System.Windows.Forms.TextBox txtBxHours;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstBxOutput;
    }
}

