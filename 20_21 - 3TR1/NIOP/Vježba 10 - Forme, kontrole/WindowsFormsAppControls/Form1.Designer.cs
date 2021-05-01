namespace WindowsFormsAppControls
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
            this.btnLog = new System.Windows.Forms.Button();
            this.input_grp1 = new System.Windows.Forms.GroupBox();
            this.label_OIB = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.label_lName = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label_fName = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.input_grp2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.logFile = new System.Windows.Forms.Button();
            this.input_grp1.SuspendLayout();
            this.input_grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(12, 415);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // input_grp1
            // 
            this.input_grp1.Controls.Add(this.label_OIB);
            this.input_grp1.Controls.Add(this.txtOIB);
            this.input_grp1.Controls.Add(this.label_lName);
            this.input_grp1.Controls.Add(this.txtPrezime);
            this.input_grp1.Controls.Add(this.label_fName);
            this.input_grp1.Controls.Add(this.txtIme);
            this.input_grp1.ForeColor = System.Drawing.Color.Black;
            this.input_grp1.Location = new System.Drawing.Point(12, 12);
            this.input_grp1.Name = "input_grp1";
            this.input_grp1.Size = new System.Drawing.Size(776, 116);
            this.input_grp1.TabIndex = 1;
            this.input_grp1.TabStop = false;
            this.input_grp1.Text = "Prva grupa";
            // 
            // label_OIB
            // 
            this.label_OIB.AutoSize = true;
            this.label_OIB.Location = new System.Drawing.Point(7, 77);
            this.label_OIB.Name = "label_OIB";
            this.label_OIB.Size = new System.Drawing.Size(25, 13);
            this.label_OIB.TabIndex = 9;
            this.label_OIB.Text = "OIB";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(100, 74);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(278, 20);
            this.txtOIB.TabIndex = 8;
            // 
            // label_lName
            // 
            this.label_lName.AutoSize = true;
            this.label_lName.Location = new System.Drawing.Point(7, 51);
            this.label_lName.Name = "label_lName";
            this.label_lName.Size = new System.Drawing.Size(44, 13);
            this.label_lName.TabIndex = 7;
            this.label_lName.Text = "Prezime";
            this.label_lName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(100, 48);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(278, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // label_fName
            // 
            this.label_fName.AutoSize = true;
            this.label_fName.Location = new System.Drawing.Point(7, 25);
            this.label_fName.Name = "label_fName";
            this.label_fName.Size = new System.Drawing.Size(24, 13);
            this.label_fName.TabIndex = 5;
            this.label_fName.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(100, 22);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(278, 20);
            this.txtIme.TabIndex = 4;
            // 
            // input_grp2
            // 
            this.input_grp2.Controls.Add(this.label2);
            this.input_grp2.Controls.Add(this.txtAdresa);
            this.input_grp2.Controls.Add(this.txtTelefon);
            this.input_grp2.Controls.Add(this.label1);
            this.input_grp2.ForeColor = System.Drawing.Color.Black;
            this.input_grp2.Location = new System.Drawing.Point(12, 134);
            this.input_grp2.Name = "input_grp2";
            this.input_grp2.Size = new System.Drawing.Size(776, 116);
            this.input_grp2.TabIndex = 2;
            this.input_grp2.TabStop = false;
            this.input_grp2.Text = "Druga grupa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj telefona";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(100, 23);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(278, 20);
            this.txtAdresa.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(100, 49);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(278, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adresa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(18, 257);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(770, 141);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(174, 415);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 5;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // logFile
            // 
            this.logFile.Location = new System.Drawing.Point(713, 415);
            this.logFile.Name = "logFile";
            this.logFile.Size = new System.Drawing.Size(75, 23);
            this.logFile.TabIndex = 6;
            this.logFile.Text = "Log To File";
            this.logFile.UseVisualStyleBackColor = true;
            this.logFile.Click += new System.EventHandler(this.logFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logFile);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.input_grp2);
            this.Controls.Add(this.input_grp1);
            this.Controls.Add(this.btnLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.input_grp1.ResumeLayout(false);
            this.input_grp1.PerformLayout();
            this.input_grp2.ResumeLayout(false);
            this.input_grp2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.GroupBox input_grp1;
        private System.Windows.Forms.Label label_fName;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.GroupBox input_grp2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Label label_OIB;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label label_lName;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logFile;
    }
}

