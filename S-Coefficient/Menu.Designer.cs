namespace S_Coefficient
{
    partial class Menu
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
            this.CalcStart = new System.Windows.Forms.Button();
            this.AMbutton = new System.Windows.Forms.RadioButton();
            this.AFbutton = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.GroupBox();
            this.method = new System.Windows.Forms.GroupBox();
            this.PCHIP = new System.Windows.Forms.RadioButton();
            this.Interpolation = new System.Windows.Forms.RadioButton();
            this.gender.SuspendLayout();
            this.method.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcStart
            // 
            this.CalcStart.ForeColor = System.Drawing.Color.Black;
            this.CalcStart.Location = new System.Drawing.Point(90, 180);
            this.CalcStart.Name = "CalcStart";
            this.CalcStart.Size = new System.Drawing.Size(100, 40);
            this.CalcStart.TabIndex = 0;
            this.CalcStart.Text = "Run";
            this.CalcStart.UseVisualStyleBackColor = true;
            this.CalcStart.Click += new System.EventHandler(this.CalcStart_Click);
            // 
            // AMbutton
            // 
            this.AMbutton.AutoSize = true;
            this.AMbutton.Checked = true;
            this.AMbutton.Location = new System.Drawing.Point(15, 20);
            this.AMbutton.Name = "AMbutton";
            this.AMbutton.Size = new System.Drawing.Size(47, 16);
            this.AMbutton.TabIndex = 2;
            this.AMbutton.TabStop = true;
            this.AMbutton.Text = "Male";
            this.AMbutton.UseVisualStyleBackColor = true;
            // 
            // AFbutton
            // 
            this.AFbutton.AutoSize = true;
            this.AFbutton.Location = new System.Drawing.Point(75, 20);
            this.AFbutton.Name = "AFbutton";
            this.AFbutton.Size = new System.Drawing.Size(60, 16);
            this.AFbutton.TabIndex = 3;
            this.AFbutton.Text = "Female";
            this.AFbutton.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.Controls.Add(this.AMbutton);
            this.gender.Controls.Add(this.AFbutton);
            this.gender.Location = new System.Drawing.Point(65, 20);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(150, 50);
            this.gender.TabIndex = 4;
            this.gender.TabStop = false;
            // 
            // method
            // 
            this.method.Controls.Add(this.PCHIP);
            this.method.Controls.Add(this.Interpolation);
            this.method.Location = new System.Drawing.Point(40, 100);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(200, 50);
            this.method.TabIndex = 5;
            this.method.TabStop = false;
            this.method.Text = "SAF Interpolation Method";
            // 
            // PCHIP
            // 
            this.PCHIP.AutoSize = true;
            this.PCHIP.Checked = true;
            this.PCHIP.Location = new System.Drawing.Point(25, 20);
            this.PCHIP.Name = "PCHIP";
            this.PCHIP.Size = new System.Drawing.Size(56, 16);
            this.PCHIP.TabIndex = 2;
            this.PCHIP.TabStop = true;
            this.PCHIP.Text = "PCHIP";
            this.PCHIP.UseVisualStyleBackColor = true;
            // 
            // Interpolation
            // 
            this.Interpolation.AutoSize = true;
            this.Interpolation.Location = new System.Drawing.Point(120, 20);
            this.Interpolation.Name = "Interpolation";
            this.Interpolation.Size = new System.Drawing.Size(54, 16);
            this.Interpolation.TabIndex = 3;
            this.Interpolation.Text = "Linear";
            this.Interpolation.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 258);
            this.Controls.Add(this.method);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.CalcStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-Coefficient";
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.method.ResumeLayout(false);
            this.method.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalcStart;
        private System.Windows.Forms.RadioButton AMbutton;
        private System.Windows.Forms.RadioButton AFbutton;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.GroupBox method;
        private System.Windows.Forms.RadioButton PCHIP;
        private System.Windows.Forms.RadioButton Interpolation;
    }
}