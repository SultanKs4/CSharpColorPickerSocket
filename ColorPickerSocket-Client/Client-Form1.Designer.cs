namespace ColorPickerSocket_Client
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
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelColorSelected = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRedCode = new System.Windows.Forms.TextBox();
            this.textBoxGreenCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBlueCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSetColor = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(76, 9);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAddress.TabIndex = 1;
            this.textBoxIPAddress.Text = "192.168.40.8";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(225, 9);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "16385";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // panelColorSelected
            // 
            this.panelColorSelected.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelColorSelected.Location = new System.Drawing.Point(12, 35);
            this.panelColorSelected.Name = "panelColorSelected";
            this.panelColorSelected.Size = new System.Drawing.Size(312, 271);
            this.panelColorSelected.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Red";
            // 
            // textBoxRedCode
            // 
            this.textBoxRedCode.Enabled = false;
            this.textBoxRedCode.Location = new System.Drawing.Point(56, 325);
            this.textBoxRedCode.Name = "textBoxRedCode";
            this.textBoxRedCode.ReadOnly = true;
            this.textBoxRedCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxRedCode.TabIndex = 6;
            // 
            // textBoxGreenCode
            // 
            this.textBoxGreenCode.Enabled = false;
            this.textBoxGreenCode.Location = new System.Drawing.Point(56, 351);
            this.textBoxGreenCode.Name = "textBoxGreenCode";
            this.textBoxGreenCode.ReadOnly = true;
            this.textBoxGreenCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxGreenCode.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Green";
            // 
            // textBoxBlueCode
            // 
            this.textBoxBlueCode.Enabled = false;
            this.textBoxBlueCode.Location = new System.Drawing.Point(56, 377);
            this.textBoxBlueCode.Name = "textBoxBlueCode";
            this.textBoxBlueCode.ReadOnly = true;
            this.textBoxBlueCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlueCode.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blue";
            // 
            // buttonSetColor
            // 
            this.buttonSetColor.Location = new System.Drawing.Point(225, 328);
            this.buttonSetColor.Name = "buttonSetColor";
            this.buttonSetColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSetColor.TabIndex = 11;
            this.buttonSetColor.Text = "Set Color";
            this.buttonSetColor.UseVisualStyleBackColor = true;
            this.buttonSetColor.Click += new System.EventHandler(this.buttonSetColor_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(225, 370);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 12;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 409);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonSetColor);
            this.Controls.Add(this.textBoxBlueCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGreenCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRedCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelColorSelected);
            this.Name = "Form1";
            this.Text = "Color Picker Socket Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelColorSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRedCode;
        private System.Windows.Forms.TextBox textBoxGreenCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBlueCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSetColor;
        private System.Windows.Forms.Button buttonSend;
    }
}

