namespace AppForm
{
    partial class ApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.textBoxTermsandConditions = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmailAddr = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelFBId = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddr = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxFBId = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbAgree = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTermsandConditions
            // 
            this.textBoxTermsandConditions.BackColor = System.Drawing.Color.White;
            this.textBoxTermsandConditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTermsandConditions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTermsandConditions.Location = new System.Drawing.Point(39, 54);
            this.textBoxTermsandConditions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTermsandConditions.Multiline = true;
            this.textBoxTermsandConditions.Name = "textBoxTermsandConditions";
            this.textBoxTermsandConditions.ReadOnly = true;
            this.textBoxTermsandConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTermsandConditions.Size = new System.Drawing.Size(372, 387);
            this.textBoxTermsandConditions.TabIndex = 0;
            this.textBoxTermsandConditions.TabStop = false;
            this.textBoxTermsandConditions.Text = resources.GetString("textBoxTermsandConditions.Text");
            this.textBoxTermsandConditions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(26, 64);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(88, 20);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name :";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmailAddr
            // 
            this.labelEmailAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEmailAddr.AutoSize = true;
            this.labelEmailAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailAddr.Location = new System.Drawing.Point(26, 250);
            this.labelEmailAddr.Name = "labelEmailAddr";
            this.labelEmailAddr.Size = new System.Drawing.Size(119, 20);
            this.labelEmailAddr.TabIndex = 0;
            this.labelEmailAddr.Text = "Email Address :";
            this.labelEmailAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmailAddr.Click += new System.EventHandler(this.labelEmailAddr_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(26, 188);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(123, 20);
            this.labelPhoneNumber.TabIndex = 0;
            this.labelPhoneNumber.Text = "Phone Number :";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFBId
            // 
            this.labelFBId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFBId.AutoSize = true;
            this.labelFBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFBId.Location = new System.Drawing.Point(26, 126);
            this.labelFBId.Name = "labelFBId";
            this.labelFBId.Size = new System.Drawing.Size(109, 20);
            this.labelFBId.TabIndex = 0;
            this.labelFBId.Text = "Facebook ID :";
            this.labelFBId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(26, 312);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(76, 20);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address :";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFullName.Location = new System.Drawing.Point(0, 0);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(313, 19);
            this.textBoxFullName.TabIndex = 1;
            // 
            // textBoxEmailAddr
            // 
            this.textBoxEmailAddr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmailAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailAddr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxEmailAddr.Location = new System.Drawing.Point(0, 0);
            this.textBoxEmailAddr.Name = "textBoxEmailAddr";
            this.textBoxEmailAddr.Size = new System.Drawing.Size(313, 19);
            this.textBoxEmailAddr.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(313, 19);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxFBId
            // 
            this.textBoxFBId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFBId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFBId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFBId.Location = new System.Drawing.Point(0, 0);
            this.textBoxFBId.Name = "textBoxFBId";
            this.textBoxFBId.Size = new System.Drawing.Size(313, 19);
            this.textBoxFBId.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAddress.Location = new System.Drawing.Point(0, 0);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(313, 19);
            this.textBoxAddress.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(30, 395);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(313, 37);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(268, 466);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 39);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbAgree
            // 
            this.cbAgree.AutoSize = true;
            this.cbAgree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgree.Location = new System.Drawing.Point(39, 475);
            this.cbAgree.Name = "cbAgree";
            this.cbAgree.Size = new System.Drawing.Size(219, 23);
            this.cbAgree.TabIndex = 2;
            this.cbAgree.Text = "I agree to the terms of service";
            this.cbAgree.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelFullName);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.labelFBId);
            this.panel1.Controls.Add(this.labelEmailAddr);
            this.panel1.Controls.Add(this.labelPhoneNumber);
            this.panel1.Location = new System.Drawing.Point(39, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 451);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.textBoxFullName);
            this.panel2.Location = new System.Drawing.Point(30, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 20);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.textBoxFBId);
            this.panel3.Location = new System.Drawing.Point(30, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 20);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.textBoxPhoneNumber);
            this.panel4.Location = new System.Drawing.Point(30, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 20);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Controls.Add(this.textBoxEmailAddr);
            this.panel5.Location = new System.Drawing.Point(30, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 20);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel6.Controls.Add(this.textBoxAddress);
            this.panel6.Location = new System.Drawing.Point(30, 343);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(313, 20);
            this.panel6.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(99, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registration Form";
            // 
            // ApplicationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(448, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbAgree);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textBoxTermsandConditions);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplicationForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTermsandConditions;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelEmailAddr;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelFBId;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxEmailAddr;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxFBId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox cbAgree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

