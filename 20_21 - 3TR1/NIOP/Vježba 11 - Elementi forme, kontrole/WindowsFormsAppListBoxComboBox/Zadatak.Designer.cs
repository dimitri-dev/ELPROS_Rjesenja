namespace WindowsFormsAppListBoxComboBox
{
    partial class Zadatak
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
            this.input_userName = new System.Windows.Forms.TextBox();
            this.input_userLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_choiceMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.input_choiceFemale = new System.Windows.Forms.RadioButton();
            this.input_choiceOther = new System.Windows.Forms.RadioButton();
            this.input_choiceOther_txt = new System.Windows.Forms.TextBox();
            this.input_genderChoicePanel = new System.Windows.Forms.Panel();
            this.input_gradeChoicePanel = new System.Windows.Forms.Panel();
            this.input_choiceGrade4 = new System.Windows.Forms.RadioButton();
            this.input_choiceGrade1 = new System.Windows.Forms.RadioButton();
            this.input_choiceGrade2 = new System.Windows.Forms.RadioButton();
            this.input_choiceGrade3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.input_getPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.outputBtn = new System.Windows.Forms.Button();
            this.input_hobies = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hobiAdd = new System.Windows.Forms.Button();
            this.input_genderChoicePanel.SuspendLayout();
            this.input_gradeChoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi ime:";
            // 
            // input_userName
            // 
            this.input_userName.Location = new System.Drawing.Point(17, 51);
            this.input_userName.Name = "input_userName";
            this.input_userName.Size = new System.Drawing.Size(285, 27);
            this.input_userName.TabIndex = 1;
            this.input_userName.TextChanged += new System.EventHandler(this.input_userName_TextChanged);
            // 
            // input_userLastName
            // 
            this.input_userLastName.Location = new System.Drawing.Point(17, 114);
            this.input_userLastName.Name = "input_userLastName";
            this.input_userLastName.Size = new System.Drawing.Size(285, 27);
            this.input_userLastName.TabIndex = 3;
            this.input_userLastName.TextChanged += new System.EventHandler(this.input_userLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesi prezime:";
            // 
            // input_choiceMale
            // 
            this.input_choiceMale.AutoSize = true;
            this.input_choiceMale.Location = new System.Drawing.Point(3, 3);
            this.input_choiceMale.Name = "input_choiceMale";
            this.input_choiceMale.Size = new System.Drawing.Size(60, 24);
            this.input_choiceMale.TabIndex = 4;
            this.input_choiceMale.TabStop = true;
            this.input_choiceMale.Text = "Male";
            this.input_choiceMale.UseVisualStyleBackColor = true;
            this.input_choiceMale.CheckedChanged += new System.EventHandler(this.input_choiceMale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odaberi spol:";
            // 
            // input_choiceFemale
            // 
            this.input_choiceFemale.AutoSize = true;
            this.input_choiceFemale.Location = new System.Drawing.Point(103, 3);
            this.input_choiceFemale.Name = "input_choiceFemale";
            this.input_choiceFemale.Size = new System.Drawing.Size(75, 24);
            this.input_choiceFemale.TabIndex = 6;
            this.input_choiceFemale.TabStop = true;
            this.input_choiceFemale.Text = "Female";
            this.input_choiceFemale.UseVisualStyleBackColor = true;
            this.input_choiceFemale.CheckedChanged += new System.EventHandler(this.input_choiceFemale_CheckedChanged);
            // 
            // input_choiceOther
            // 
            this.input_choiceOther.AutoSize = true;
            this.input_choiceOther.Location = new System.Drawing.Point(213, 3);
            this.input_choiceOther.Name = "input_choiceOther";
            this.input_choiceOther.Size = new System.Drawing.Size(64, 24);
            this.input_choiceOther.TabIndex = 7;
            this.input_choiceOther.TabStop = true;
            this.input_choiceOther.Text = "Other";
            this.input_choiceOther.UseVisualStyleBackColor = true;
            this.input_choiceOther.CheckedChanged += new System.EventHandler(this.input_choiceOther_CheckedChanged);
            // 
            // input_choiceOther_txt
            // 
            this.input_choiceOther_txt.Location = new System.Drawing.Point(159, 33);
            this.input_choiceOther_txt.Name = "input_choiceOther_txt";
            this.input_choiceOther_txt.Size = new System.Drawing.Size(118, 27);
            this.input_choiceOther_txt.TabIndex = 8;
            // 
            // input_genderChoicePanel
            // 
            this.input_genderChoicePanel.Controls.Add(this.input_choiceMale);
            this.input_genderChoicePanel.Controls.Add(this.input_choiceOther_txt);
            this.input_genderChoicePanel.Controls.Add(this.input_choiceFemale);
            this.input_genderChoicePanel.Controls.Add(this.input_choiceOther);
            this.input_genderChoicePanel.Location = new System.Drawing.Point(18, 175);
            this.input_genderChoicePanel.Name = "input_genderChoicePanel";
            this.input_genderChoicePanel.Size = new System.Drawing.Size(284, 75);
            this.input_genderChoicePanel.TabIndex = 9;
            // 
            // input_gradeChoicePanel
            // 
            this.input_gradeChoicePanel.Controls.Add(this.input_choiceGrade4);
            this.input_gradeChoicePanel.Controls.Add(this.input_choiceGrade1);
            this.input_gradeChoicePanel.Controls.Add(this.input_choiceGrade2);
            this.input_gradeChoicePanel.Controls.Add(this.input_choiceGrade3);
            this.input_gradeChoicePanel.Location = new System.Drawing.Point(18, 279);
            this.input_gradeChoicePanel.Name = "input_gradeChoicePanel";
            this.input_gradeChoicePanel.Size = new System.Drawing.Size(284, 33);
            this.input_gradeChoicePanel.TabIndex = 11;
            // 
            // input_choiceGrade4
            // 
            this.input_choiceGrade4.AutoSize = true;
            this.input_choiceGrade4.Location = new System.Drawing.Point(208, 5);
            this.input_choiceGrade4.Name = "input_choiceGrade4";
            this.input_choiceGrade4.Size = new System.Drawing.Size(70, 24);
            this.input_choiceGrade4.TabIndex = 8;
            this.input_choiceGrade4.TabStop = true;
            this.input_choiceGrade4.Text = "Četvrti";
            this.input_choiceGrade4.UseVisualStyleBackColor = true;
            this.input_choiceGrade4.CheckedChanged += new System.EventHandler(this.input_choiceGrade4_CheckedChanged);
            // 
            // input_choiceGrade1
            // 
            this.input_choiceGrade1.AutoSize = true;
            this.input_choiceGrade1.Location = new System.Drawing.Point(4, 5);
            this.input_choiceGrade1.Name = "input_choiceGrade1";
            this.input_choiceGrade1.Size = new System.Drawing.Size(51, 24);
            this.input_choiceGrade1.TabIndex = 4;
            this.input_choiceGrade1.TabStop = true;
            this.input_choiceGrade1.Text = "Prvi";
            this.input_choiceGrade1.UseVisualStyleBackColor = true;
            this.input_choiceGrade1.CheckedChanged += new System.EventHandler(this.input_choiceGrade1_CheckedChanged);
            // 
            // input_choiceGrade2
            // 
            this.input_choiceGrade2.AutoSize = true;
            this.input_choiceGrade2.Location = new System.Drawing.Point(70, 5);
            this.input_choiceGrade2.Name = "input_choiceGrade2";
            this.input_choiceGrade2.Size = new System.Drawing.Size(64, 24);
            this.input_choiceGrade2.TabIndex = 6;
            this.input_choiceGrade2.TabStop = true;
            this.input_choiceGrade2.Text = "Drugi";
            this.input_choiceGrade2.UseVisualStyleBackColor = true;
            this.input_choiceGrade2.CheckedChanged += new System.EventHandler(this.input_choiceGrade2_CheckedChanged);
            // 
            // input_choiceGrade3
            // 
            this.input_choiceGrade3.AutoSize = true;
            this.input_choiceGrade3.Location = new System.Drawing.Point(140, 5);
            this.input_choiceGrade3.Name = "input_choiceGrade3";
            this.input_choiceGrade3.Size = new System.Drawing.Size(58, 24);
            this.input_choiceGrade3.TabIndex = 7;
            this.input_choiceGrade3.TabStop = true;
            this.input_choiceGrade3.Text = "Treći";
            this.input_choiceGrade3.UseVisualStyleBackColor = true;
            this.input_choiceGrade3.CheckedChanged += new System.EventHandler(this.input_choiceGrade3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Odaberi razred:";
            // 
            // input_getPhoto
            // 
            this.input_getPhoto.Location = new System.Drawing.Point(184, 436);
            this.input_getPhoto.Name = "input_getPhoto";
            this.input_getPhoto.Size = new System.Drawing.Size(118, 33);
            this.input_getPhoto.TabIndex = 12;
            this.input_getPhoto.Text = "Odaberi sliku";
            this.input_getPhoto.UseVisualStyleBackColor = true;
            this.input_getPhoto.Click += new System.EventHandler(this.input_getPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 596);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 144);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 572);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Output:";
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImage = global::WindowsFormsAppListBoxComboBoxAndOther.Properties.Resources.fb_standard;
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userPicture.Location = new System.Drawing.Point(17, 398);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(154, 171);
            this.userPicture.TabIndex = 15;
            this.userPicture.TabStop = false;
            // 
            // outputBtn
            // 
            this.outputBtn.Location = new System.Drawing.Point(184, 475);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(118, 49);
            this.outputBtn.TabIndex = 16;
            this.outputBtn.Text = "Generiraj output";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_hobies
            // 
            this.input_hobies.FormattingEnabled = true;
            this.input_hobies.Location = new System.Drawing.Point(18, 363);
            this.input_hobies.Name = "input_hobies";
            this.input_hobies.Size = new System.Drawing.Size(284, 28);
            this.input_hobies.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(17, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Unesi hobije:";
            // 
            // hobiAdd
            // 
            this.hobiAdd.Location = new System.Drawing.Point(184, 397);
            this.hobiAdd.Name = "hobiAdd";
            this.hobiAdd.Size = new System.Drawing.Size(118, 33);
            this.hobiAdd.TabIndex = 19;
            this.hobiAdd.Text = "Dodaj hobi";
            this.hobiAdd.UseVisualStyleBackColor = true;
            this.hobiAdd.Click += new System.EventHandler(this.hobiAdd_Click);
            // 
            // Zadatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(325, 746);
            this.Controls.Add(this.hobiAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_hobies);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.input_getPhoto);
            this.Controls.Add(this.input_gradeChoicePanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_genderChoicePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_userLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_userName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Zadatak";
            this.Text = "Zadatak";
            this.input_genderChoicePanel.ResumeLayout(false);
            this.input_genderChoicePanel.PerformLayout();
            this.input_gradeChoicePanel.ResumeLayout(false);
            this.input_gradeChoicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_userName;
        private System.Windows.Forms.TextBox input_userLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton input_choiceMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton input_choiceFemale;
        private System.Windows.Forms.RadioButton input_choiceOther;
        private System.Windows.Forms.TextBox input_choiceOther_txt;
        private System.Windows.Forms.Panel input_genderChoicePanel;
        private System.Windows.Forms.Panel input_gradeChoicePanel;
        private System.Windows.Forms.RadioButton input_choiceGrade4;
        private System.Windows.Forms.RadioButton input_choiceGrade1;
        private System.Windows.Forms.RadioButton input_choiceGrade2;
        private System.Windows.Forms.RadioButton input_choiceGrade3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button input_getPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.ComboBox input_hobies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button hobiAdd;
    }
}