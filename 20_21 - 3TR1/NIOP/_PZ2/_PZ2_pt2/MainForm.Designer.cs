
namespace NIOP
{
    partial class MainForm
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
            this.inputMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuSelector_Basic = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelector_Advanced = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.MenuSelector_ParabolaGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.inputMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputMenuStrip
            // 
            this.inputMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.inputMenuStrip.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSelector_Basic,
            this.MenuSelector_Advanced,
            this.MenuSelector_ParabolaGraph});
            this.inputMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.inputMenuStrip.Name = "inputMenuStrip";
            this.inputMenuStrip.Size = new System.Drawing.Size(458, 34);
            this.inputMenuStrip.TabIndex = 29;
            this.inputMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripRender_ItemClickedChange);
            // 
            // MenuSelector_Basic
            // 
            this.MenuSelector_Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.MenuSelector_Basic.Checked = true;
            this.MenuSelector_Basic.CheckOnClick = true;
            this.MenuSelector_Basic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuSelector_Basic.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuSelector_Basic.ForeColor = System.Drawing.Color.White;
            this.MenuSelector_Basic.Name = "MenuSelector_Basic";
            this.MenuSelector_Basic.Size = new System.Drawing.Size(64, 30);
            this.MenuSelector_Basic.Text = "Basic";
            // 
            // MenuSelector_Advanced
            // 
            this.MenuSelector_Advanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.MenuSelector_Advanced.CheckOnClick = true;
            this.MenuSelector_Advanced.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuSelector_Advanced.ForeColor = System.Drawing.Color.White;
            this.MenuSelector_Advanced.Name = "MenuSelector_Advanced";
            this.MenuSelector_Advanced.Size = new System.Drawing.Size(101, 30);
            this.MenuSelector_Advanced.Text = "Advanced";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(0, 37);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(458, 714);
            this.panelChildForm.TabIndex = 30;
            // 
            // MenuSelector_ParabolaGraph
            // 
            this.MenuSelector_ParabolaGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.MenuSelector_ParabolaGraph.CheckOnClick = true;
            this.MenuSelector_ParabolaGraph.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuSelector_ParabolaGraph.ForeColor = System.Drawing.Color.White;
            this.MenuSelector_ParabolaGraph.Name = "MenuSelector_ParabolaGraph";
            this.MenuSelector_ParabolaGraph.Size = new System.Drawing.Size(145, 30);
            this.MenuSelector_ParabolaGraph.Text = "Parabola Graph";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(458, 747);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.inputMenuStrip);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.inputMenuStrip.ResumeLayout(false);
            this.inputMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelChildForm;
        public System.Windows.Forms.MenuStrip inputMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem MenuSelector_Basic;
        public System.Windows.Forms.ToolStripMenuItem MenuSelector_Advanced;
        public System.Windows.Forms.ToolStripMenuItem MenuSelector_ParabolaGraph;
    }
}