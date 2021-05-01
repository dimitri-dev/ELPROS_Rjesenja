namespace WindowsFormsAppListBoxComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbHobiji = new System.Windows.Forms.ListBox();
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.cbKlikni = new System.Windows.Forms.CheckBox();
            this.rbPokaziSliku = new System.Windows.Forms.RadioButton();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.gbParent = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.gbParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHobiji
            // 
            this.lbHobiji.FormattingEnabled = true;
            this.lbHobiji.Location = new System.Drawing.Point(32, 121);
            this.lbHobiji.Name = "lbHobiji";
            this.lbHobiji.Size = new System.Drawing.Size(215, 95);
            this.lbHobiji.TabIndex = 0;
            this.lbHobiji.SelectedIndexChanged += new System.EventHandler(this.lbHobiji_SelectedIndexChanged);
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(32, 87);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(215, 21);
            this.cmbKorisnici.TabIndex = 1;
            this.cmbKorisnici.SelectedIndexChanged += new System.EventHandler(this.cmbKorisnici_SelectedIndexChanged);
            // 
            // cbKlikni
            // 
            this.cbKlikni.AutoSize = true;
            this.cbKlikni.Location = new System.Drawing.Point(32, 58);
            this.cbKlikni.Name = "cbKlikni";
            this.cbKlikni.Size = new System.Drawing.Size(67, 17);
            this.cbKlikni.TabIndex = 2;
            this.cbKlikni.Text = "klikni me";
            this.cbKlikni.UseVisualStyleBackColor = true;
            this.cbKlikni.CheckedChanged += new System.EventHandler(this.cbKlikni_CheckedChanged);
            // 
            // rbPokaziSliku
            // 
            this.rbPokaziSliku.AutoSize = true;
            this.rbPokaziSliku.Location = new System.Drawing.Point(32, 233);
            this.rbPokaziSliku.Name = "rbPokaziSliku";
            this.rbPokaziSliku.Size = new System.Drawing.Size(80, 17);
            this.rbPokaziSliku.TabIndex = 3;
            this.rbPokaziSliku.TabStop = true;
            this.rbPokaziSliku.Text = "Prikaži sliku";
            this.rbPokaziSliku.UseVisualStyleBackColor = true;
            this.rbPokaziSliku.CheckedChanged += new System.EventHandler(this.rbPokaziSliku_CheckedChanged);
            // 
            // pbSlika
            // 
            this.pbSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSlika.Image = ((System.Drawing.Image)(resources.GetObject("pbSlika.Image")));
            this.pbSlika.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSlika.InitialImage")));
            this.pbSlika.Location = new System.Drawing.Point(32, 267);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(215, 129);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 4;
            this.pbSlika.TabStop = false;
            // 
            // gbParent
            // 
            this.gbParent.Controls.Add(this.progressBar);
            this.gbParent.Controls.Add(this.btnReset);
            this.gbParent.Controls.Add(this.cbKlikni);
            this.gbParent.Controls.Add(this.pbSlika);
            this.gbParent.Controls.Add(this.cmbKorisnici);
            this.gbParent.Controls.Add(this.rbPokaziSliku);
            this.gbParent.Controls.Add(this.lbHobiji);
            this.gbParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParent.Location = new System.Drawing.Point(0, 0);
            this.gbParent.Name = "gbParent";
            this.gbParent.Size = new System.Drawing.Size(800, 450);
            this.gbParent.TabIndex = 5;
            this.gbParent.TabStop = false;
            this.gbParent.Text = "Parent kontrola";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(32, 19);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(215, 23);
            this.progressBar.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(32, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbParent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.gbParent.ResumeLayout(false);
            this.gbParent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHobiji;
        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.CheckBox cbKlikni;
        private System.Windows.Forms.RadioButton rbPokaziSliku;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.GroupBox gbParent;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnReset;
    }
}

