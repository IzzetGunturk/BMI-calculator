
namespace BMI_calculator
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
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.tBLength = new System.Windows.Forms.TextBox();
            this.tBWeight = new System.Windows.Forms.TextBox();
            this.rBAge = new System.Windows.Forms.RadioButton();
            this.rBAge2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Location = new System.Drawing.Point(330, 320);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(110, 23);
            this.buttonCalculator.TabIndex = 0;
            this.buttonCalculator.Text = "CALCULATE";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // tBLength
            // 
            this.tBLength.Location = new System.Drawing.Point(154, 208);
            this.tBLength.Name = "tBLength";
            this.tBLength.Size = new System.Drawing.Size(100, 22);
            this.tBLength.TabIndex = 1;
            // 
            // tBWeight
            // 
            this.tBWeight.Location = new System.Drawing.Point(330, 208);
            this.tBWeight.Name = "tBWeight";
            this.tBWeight.Size = new System.Drawing.Size(100, 22);
            this.tBWeight.TabIndex = 2;
            // 
            // rBAge
            // 
            this.rBAge.AutoSize = true;
            this.rBAge.Location = new System.Drawing.Point(516, 208);
            this.rBAge.Name = "rBAge";
            this.rBAge.Size = new System.Drawing.Size(66, 21);
            this.rBAge.TabIndex = 3;
            this.rBAge.TabStop = true;
            this.rBAge.Text = "16-69";
            this.rBAge.UseVisualStyleBackColor = true;
            // 
            // rBAge2
            // 
            this.rBAge2.AutoSize = true;
            this.rBAge2.Location = new System.Drawing.Point(516, 235);
            this.rBAge2.Name = "rBAge2";
            this.rBAge2.Size = new System.Drawing.Size(53, 21);
            this.rBAge2.TabIndex = 4;
            this.rBAge2.TabStop = true;
            this.rBAge2.Text = "70+";
            this.rBAge2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Length in cm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weight in kg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 72);
            this.label4.TabIndex = 8;
            this.label4.Text = "BMI-calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBAge2);
            this.Controls.Add(this.rBAge);
            this.Controls.Add(this.tBWeight);
            this.Controls.Add(this.tBLength);
            this.Controls.Add(this.buttonCalculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.TextBox tBLength;
        private System.Windows.Forms.TextBox tBWeight;
        private System.Windows.Forms.RadioButton rBAge;
        private System.Windows.Forms.RadioButton rBAge2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

