namespace ReturnSumExample
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.lbl1Text = new System.Windows.Forms.Label();
            this.lbl2Text = new System.Windows.Forms.Label();
            this.lbl3Text = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSumText = new System.Windows.Forms.Label();
            this.lblAverageText = new System.Windows.Forms.Label();
            this.lblSumDisplay = new System.Windows.Forms.Label();
            this.lblAvgDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(232, 62);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(232, 103);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(232, 151);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(100, 20);
            this.txtNumber3.TabIndex = 2;
            // 
            // lbl1Text
            // 
            this.lbl1Text.AutoSize = true;
            this.lbl1Text.Location = new System.Drawing.Point(125, 69);
            this.lbl1Text.Name = "lbl1Text";
            this.lbl1Text.Size = new System.Drawing.Size(84, 13);
            this.lbl1Text.TabIndex = 3;
            this.lbl1Text.Text = "Enter Number 1:";
            // 
            // lbl2Text
            // 
            this.lbl2Text.AutoSize = true;
            this.lbl2Text.Location = new System.Drawing.Point(125, 110);
            this.lbl2Text.Name = "lbl2Text";
            this.lbl2Text.Size = new System.Drawing.Size(84, 13);
            this.lbl2Text.TabIndex = 4;
            this.lbl2Text.Text = "Enter Number 2:";
            // 
            // lbl3Text
            // 
            this.lbl3Text.AutoSize = true;
            this.lbl3Text.Location = new System.Drawing.Point(125, 158);
            this.lbl3Text.Name = "lbl3Text";
            this.lbl3Text.Size = new System.Drawing.Size(84, 13);
            this.lbl3Text.TabIndex = 5;
            this.lbl3Text.Text = "Enter Number 3:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(232, 242);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSumText
            // 
            this.lblSumText.AutoSize = true;
            this.lblSumText.Location = new System.Drawing.Point(125, 284);
            this.lblSumText.Name = "lblSumText";
            this.lblSumText.Size = new System.Drawing.Size(53, 13);
            this.lblSumText.TabIndex = 7;
            this.lblSumText.Text = "The Sum:";
            // 
            // lblAverageText
            // 
            this.lblAverageText.AutoSize = true;
            this.lblAverageText.Location = new System.Drawing.Point(125, 324);
            this.lblAverageText.Name = "lblAverageText";
            this.lblAverageText.Size = new System.Drawing.Size(69, 13);
            this.lblAverageText.TabIndex = 8;
            this.lblAverageText.Text = "The Average";
            // 
            // lblSumDisplay
            // 
            this.lblSumDisplay.AutoSize = true;
            this.lblSumDisplay.Location = new System.Drawing.Point(229, 284);
            this.lblSumDisplay.Name = "lblSumDisplay";
            this.lblSumDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblSumDisplay.TabIndex = 9;
            // 
            // lblAvgDisplay
            // 
            this.lblAvgDisplay.AutoSize = true;
            this.lblAvgDisplay.Location = new System.Drawing.Point(229, 324);
            this.lblAvgDisplay.Name = "lblAvgDisplay";
            this.lblAvgDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblAvgDisplay.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAvgDisplay);
            this.Controls.Add(this.lblSumDisplay);
            this.Controls.Add(this.lblAverageText);
            this.Controls.Add(this.lblSumText);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbl3Text);
            this.Controls.Add(this.lbl2Text);
            this.Controls.Add(this.lbl1Text);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.Label lbl1Text;
        private System.Windows.Forms.Label lbl2Text;
        private System.Windows.Forms.Label lbl3Text;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSumText;
        private System.Windows.Forms.Label lblAverageText;
        private System.Windows.Forms.Label lblSumDisplay;
        private System.Windows.Forms.Label lblAvgDisplay;
    }
}

