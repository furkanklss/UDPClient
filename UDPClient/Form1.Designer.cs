namespace UDPClient
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.btnCON = new System.Windows.Forms.Button();
            this.btnSEND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTO = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDIS = new System.Windows.Forms.Button();
            this.txtIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(136, 24);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(268, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "";
            // 
            // txtPORT
            // 
            this.txtPORT.Location = new System.Drawing.Point(136, 68);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(268, 20);
            this.txtPORT.TabIndex = 1;
            this.txtPORT.Text = "";
            // 
            // btnCON
            // 
            this.btnCON.Location = new System.Drawing.Point(37, 109);
            this.btnCON.Name = "btnCON";
            this.btnCON.Size = new System.Drawing.Size(180, 23);
            this.btnCON.TabIndex = 2;
            this.btnCON.Text = "CONNECT";
            this.btnCON.UseVisualStyleBackColor = true;
            this.btnCON.Click += new System.EventHandler(this.btnCON_Click_1);
            // 
            // btnSEND
            // 
            this.btnSEND.Location = new System.Drawing.Point(329, 401);
            this.btnSEND.Name = "btnSEND";
            this.btnSEND.Size = new System.Drawing.Size(75, 23);
            this.btnSEND.TabIndex = 3;
            this.btnSEND.Text = "SEND";
            this.btnSEND.UseVisualStyleBackColor = true;
            this.btnSEND.Click += new System.EventHandler(this.btnSEND_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP ADRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TO MESSAGE";
            // 
            // txtTO
            // 
            this.txtTO.Location = new System.Drawing.Point(37, 213);
            this.txtTO.Name = "txtTO";
            this.txtTO.Size = new System.Drawing.Size(367, 171);
            this.txtTO.TabIndex = 9;
            this.txtTO.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "INCOMING";
            // 
            // btnDIS
            // 
            this.btnDIS.Location = new System.Drawing.Point(224, 109);
            this.btnDIS.Name = "btnDIS";
            this.btnDIS.Size = new System.Drawing.Size(180, 23);
            this.btnDIS.TabIndex = 12;
            this.btnDIS.Text = "DISCONNECT";
            this.btnDIS.UseVisualStyleBackColor = true;
            this.btnDIS.Click += new System.EventHandler(this.btnDIS_Click_1);
            // 
            // txtIN
            // 
            this.txtIN.Location = new System.Drawing.Point(40, 490);
            this.txtIN.Multiline = true;
            this.txtIN.Name = "txtIN";
            this.txtIN.Size = new System.Drawing.Size(367, 172);
            this.txtIN.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 696);
            this.Controls.Add(this.txtIN);
            this.Controls.Add(this.btnDIS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSEND);
            this.Controls.Add(this.btnCON);
            this.Controls.Add(this.txtPORT);
            this.Controls.Add(this.txtIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.Button btnCON;
        private System.Windows.Forms.Button btnSEND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDIS;
        private System.Windows.Forms.TextBox txtIN;
    }
}

