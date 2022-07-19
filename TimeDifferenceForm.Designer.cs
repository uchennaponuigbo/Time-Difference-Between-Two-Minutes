namespace Time_Difference
{
    partial class TimeDifferenceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskTime1Line1 = new System.Windows.Forms.MaskedTextBox();
            this.maskTime2Line1 = new System.Windows.Forms.MaskedTextBox();
            this.txtDifference1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate2 = new System.Windows.Forms.Button();
            this.btnClear3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate3 = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTotalCalculation = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDifference2 = new System.Windows.Forms.TextBox();
            this.maskTime2Line2 = new System.Windows.Forms.MaskedTextBox();
            this.maskTime1Line2 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDifference3 = new System.Windows.Forms.TextBox();
            this.maskTime2Line3 = new System.Windows.Forms.MaskedTextBox();
            this.maskTime1Line3 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskTime1Line1
            // 
            this.maskTime1Line1.Location = new System.Drawing.Point(19, 33);
            this.maskTime1Line1.Mask = "99:99";
            this.maskTime1Line1.Name = "maskTime1Line1";
            this.maskTime1Line1.Size = new System.Drawing.Size(34, 23);
            this.maskTime1Line1.TabIndex = 0;
            // 
            // maskTime2Line1
            // 
            this.maskTime2Line1.Location = new System.Drawing.Point(85, 33);
            this.maskTime2Line1.Mask = "99:99";
            this.maskTime2Line1.Name = "maskTime2Line1";
            this.maskTime2Line1.Size = new System.Drawing.Size(34, 23);
            this.maskTime2Line1.TabIndex = 1;
            // 
            // txtDifference1
            // 
            this.txtDifference1.Location = new System.Drawing.Point(146, 34);
            this.txtDifference1.Name = "txtDifference1";
            this.txtDifference1.ReadOnly = true;
            this.txtDifference1.Size = new System.Drawing.Size(38, 23);
            this.txtDifference1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // btnCalculate1
            // 
            this.btnCalculate1.Location = new System.Drawing.Point(254, 32);
            this.btnCalculate1.Name = "btnCalculate1";
            this.btnCalculate1.Size = new System.Drawing.Size(66, 25);
            this.btnCalculate1.TabIndex = 4;
            this.btnCalculate1.Text = "Calculate";
            this.btnCalculate1.UseVisualStyleBackColor = true;
            this.btnCalculate1.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "second(s)";
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(326, 32);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(47, 25);
            this.btnClear1.TabIndex = 7;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(326, 63);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(47, 25);
            this.btnClear2.TabIndex = 10;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "second(s)";
            // 
            // btnCalculate2
            // 
            this.btnCalculate2.Location = new System.Drawing.Point(254, 63);
            this.btnCalculate2.Name = "btnCalculate2";
            this.btnCalculate2.Size = new System.Drawing.Size(66, 25);
            this.btnCalculate2.TabIndex = 8;
            this.btnCalculate2.Text = "Calculate";
            this.btnCalculate2.UseVisualStyleBackColor = true;
            this.btnCalculate2.Click += new System.EventHandler(this.btnCalculate2_Click);
            // 
            // btnClear3
            // 
            this.btnClear3.Location = new System.Drawing.Point(326, 94);
            this.btnClear3.Name = "btnClear3";
            this.btnClear3.Size = new System.Drawing.Size(47, 25);
            this.btnClear3.TabIndex = 13;
            this.btnClear3.Text = "Clear";
            this.btnClear3.UseVisualStyleBackColor = true;
            this.btnClear3.Click += new System.EventHandler(this.btnClear3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "second(s)";
            // 
            // btnCalculate3
            // 
            this.btnCalculate3.Location = new System.Drawing.Point(254, 94);
            this.btnCalculate3.Name = "btnCalculate3";
            this.btnCalculate3.Size = new System.Drawing.Size(66, 25);
            this.btnCalculate3.TabIndex = 11;
            this.btnCalculate3.Text = "Calculate";
            this.btnCalculate3.UseVisualStyleBackColor = true;
            this.btnCalculate3.Click += new System.EventHandler(this.btnCalculate3_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(301, 132);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(61, 25);
            this.btnClearAll.TabIndex = 16;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "total second(s)";
            // 
            // btnTotalCalculation
            // 
            this.btnTotalCalculation.Location = new System.Drawing.Point(19, 132);
            this.btnTotalCalculation.Name = "btnTotalCalculation";
            this.btnTotalCalculation.Size = new System.Drawing.Size(97, 25);
            this.btnTotalCalculation.TabIndex = 14;
            this.btnTotalCalculation.Text = "Calculate Sum";
            this.btnTotalCalculation.UseVisualStyleBackColor = true;
            this.btnTotalCalculation.Click += new System.EventHandler(this.btnTotalCalculation_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(142, 134);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(42, 23);
            this.txtSum.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(59, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "=";
            // 
            // txtDifference2
            // 
            this.txtDifference2.Location = new System.Drawing.Point(146, 66);
            this.txtDifference2.Name = "txtDifference2";
            this.txtDifference2.ReadOnly = true;
            this.txtDifference2.Size = new System.Drawing.Size(38, 23);
            this.txtDifference2.TabIndex = 20;
            // 
            // maskTime2Line2
            // 
            this.maskTime2Line2.Location = new System.Drawing.Point(85, 65);
            this.maskTime2Line2.Mask = "99:99";
            this.maskTime2Line2.Name = "maskTime2Line2";
            this.maskTime2Line2.Size = new System.Drawing.Size(34, 23);
            this.maskTime2Line2.TabIndex = 19;
            // 
            // maskTime1Line2
            // 
            this.maskTime1Line2.Location = new System.Drawing.Point(19, 65);
            this.maskTime1Line2.Mask = "99:99";
            this.maskTime1Line2.Name = "maskTime1Line2";
            this.maskTime1Line2.Size = new System.Drawing.Size(34, 23);
            this.maskTime1Line2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(59, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "=";
            // 
            // txtDifference3
            // 
            this.txtDifference3.Location = new System.Drawing.Point(146, 95);
            this.txtDifference3.Name = "txtDifference3";
            this.txtDifference3.ReadOnly = true;
            this.txtDifference3.Size = new System.Drawing.Size(38, 23);
            this.txtDifference3.TabIndex = 25;
            // 
            // maskTime2Line3
            // 
            this.maskTime2Line3.Location = new System.Drawing.Point(85, 94);
            this.maskTime2Line3.Mask = "99:99";
            this.maskTime2Line3.Name = "maskTime2Line3";
            this.maskTime2Line3.Size = new System.Drawing.Size(34, 23);
            this.maskTime2Line3.TabIndex = 24;
            // 
            // maskTime1Line3
            // 
            this.maskTime1Line3.Location = new System.Drawing.Point(19, 94);
            this.maskTime1Line3.Mask = "99:99";
            this.maskTime1Line3.Name = "maskTime1Line3";
            this.maskTime1Line3.Size = new System.Drawing.Size(34, 23);
            this.maskTime1Line3.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(372, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "A result is the Absolute Value of the difference between the two times";
            // 
            // TimeDifferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 174);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDifference3);
            this.Controls.Add(this.maskTime2Line3);
            this.Controls.Add(this.maskTime1Line3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDifference2);
            this.Controls.Add(this.maskTime2Line2);
            this.Controls.Add(this.maskTime1Line2);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTotalCalculation);
            this.Controls.Add(this.btnClear3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate3);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate2);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDifference1);
            this.Controls.Add(this.maskTime2Line1);
            this.Controls.Add(this.maskTime1Line1);
            this.MaximizeBox = false;
            this.Name = "TimeDifferenceForm";
            this.Text = "Temporal Difference Between Minutes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskTime1Line1;
        private System.Windows.Forms.MaskedTextBox maskTime2Line1;
        private System.Windows.Forms.TextBox txtDifference1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate2;
        private System.Windows.Forms.Button btnClear3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate3;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTotalCalculation;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDifference2;
        private System.Windows.Forms.MaskedTextBox maskTime2Line2;
        private System.Windows.Forms.MaskedTextBox maskTime1Line2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDifference3;
        private System.Windows.Forms.MaskedTextBox maskTime2Line3;
        private System.Windows.Forms.MaskedTextBox maskTime1Line3;
        private System.Windows.Forms.Label label11;
    }
}
