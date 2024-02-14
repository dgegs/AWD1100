namespace LoginExample
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPinNumber = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserText = new System.Windows.Forms.Label();
            this.lblPinText = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(216, 91);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPinNumber
            // 
            this.txtPinNumber.Location = new System.Drawing.Point(216, 140);
            this.txtPinNumber.Name = "txtPinNumber";
            this.txtPinNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPinNumber.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(216, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUserText
            // 
            this.lblUserText.AutoSize = true;
            this.lblUserText.Location = new System.Drawing.Point(118, 94);
            this.lblUserText.Name = "lblUserText";
            this.lblUserText.Size = new System.Drawing.Size(91, 13);
            this.lblUserText.TabIndex = 3;
            this.lblUserText.Text = "Enter User Name:";
            // 
            // lblPinText
            // 
            this.lblPinText.AutoSize = true;
            this.lblPinText.Location = new System.Drawing.Point(118, 143);
            this.lblPinText.Name = "lblPinText";
            this.lblPinText.Size = new System.Drawing.Size(93, 13);
            this.lblPinText.TabIndex = 4;
            this.lblPinText.Text = "Enter Pin Number:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(216, 299);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPinText);
            this.Controls.Add(this.lblUserText);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPinNumber);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPinNumber;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserText;
        private System.Windows.Forms.Label lblPinText;
        private System.Windows.Forms.Label lblResult;
    }
}

