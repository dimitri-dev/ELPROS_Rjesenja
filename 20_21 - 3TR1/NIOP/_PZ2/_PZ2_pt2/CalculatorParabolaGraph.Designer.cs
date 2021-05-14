
namespace NIOP
{
    partial class CalculatorParabolaGraph
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
            this.operation_Draw = new System.Windows.Forms.Button();
            this.placeholderLabel = new System.Windows.Forms.Label();
            this.graph_aVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.graph_bVal = new System.Windows.Forms.TextBox();
            this.graph_cVal = new System.Windows.Forms.TextBox();
            this.graphDraw = new System.Windows.Forms.Panel();
            this.parabolaPlotter = new OxyPlot.WindowsForms.PlotView();
            this.graphDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // operation_Draw
            // 
            this.operation_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
            this.operation_Draw.FlatAppearance.BorderSize = 0;
            this.operation_Draw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(112)))), ((int)(((byte)(198)))));
            this.operation_Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Draw.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Draw.ForeColor = System.Drawing.Color.White;
            this.operation_Draw.Location = new System.Drawing.Point(181, 624);
            this.operation_Draw.Name = "operation_Draw";
            this.operation_Draw.Size = new System.Drawing.Size(90, 39);
            this.operation_Draw.TabIndex = 5;
            this.operation_Draw.Text = "Graph";
            this.operation_Draw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.operation_Draw.UseVisualStyleBackColor = false;
            this.operation_Draw.Click += new System.EventHandler(this.Draw_Graph_Function);
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.AutoSize = true;
            this.placeholderLabel.Location = new System.Drawing.Point(44, -71);
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(0, 28);
            this.placeholderLabel.TabIndex = 27;
            // 
            // graph_aVal
            // 
            this.graph_aVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.graph_aVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graph_aVal.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.graph_aVal.ForeColor = System.Drawing.Color.White;
            this.graph_aVal.Location = new System.Drawing.Point(17, 669);
            this.graph_aVal.Name = "graph_aVal";
            this.graph_aVal.PlaceholderText = "a";
            this.graph_aVal.Size = new System.Drawing.Size(90, 32);
            this.graph_aVal.TabIndex = 28;
            this.graph_aVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 39);
            this.label2.TabIndex = 30;
            this.label2.Text = "x² +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(277, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "x + ";
            // 
            // graph_bVal
            // 
            this.graph_bVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.graph_bVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graph_bVal.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.graph_bVal.ForeColor = System.Drawing.Color.White;
            this.graph_bVal.Location = new System.Drawing.Point(181, 669);
            this.graph_bVal.Name = "graph_bVal";
            this.graph_bVal.PlaceholderText = "b";
            this.graph_bVal.Size = new System.Drawing.Size(90, 32);
            this.graph_bVal.TabIndex = 31;
            this.graph_bVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // graph_cVal
            // 
            this.graph_cVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.graph_cVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graph_cVal.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.graph_cVal.ForeColor = System.Drawing.Color.White;
            this.graph_cVal.Location = new System.Drawing.Point(343, 669);
            this.graph_cVal.Name = "graph_cVal";
            this.graph_cVal.PlaceholderText = "c";
            this.graph_cVal.Size = new System.Drawing.Size(90, 32);
            this.graph_cVal.TabIndex = 33;
            this.graph_cVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // graphDraw
            // 
            this.graphDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.graphDraw.Controls.Add(this.parabolaPlotter);
            this.graphDraw.Location = new System.Drawing.Point(12, 12);
            this.graphDraw.Name = "graphDraw";
            this.graphDraw.Size = new System.Drawing.Size(434, 606);
            this.graphDraw.TabIndex = 34;
            // 
            // parabolaPlotter
            // 
            this.parabolaPlotter.Location = new System.Drawing.Point(5, 1);
            this.parabolaPlotter.Name = "parabolaPlotter";
            this.parabolaPlotter.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.parabolaPlotter.Size = new System.Drawing.Size(429, 605);
            this.parabolaPlotter.TabIndex = 0;
            this.parabolaPlotter.Text = "plotView1";
            this.parabolaPlotter.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.parabolaPlotter.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.parabolaPlotter.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // CalculatorParabolaGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(458, 713);
            this.Controls.Add(this.graphDraw);
            this.Controls.Add(this.graph_cVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.graph_bVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.graph_aVal);
            this.Controls.Add(this.placeholderLabel);
            this.Controls.Add(this.operation_Draw);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculatorParabolaGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tooltips";
            this.TopMost = true;
            this.graphDraw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button operation_Draw;
        private System.Windows.Forms.Label placeholderLabel;
        private System.Windows.Forms.TextBox graph_aVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox graph_bVal;
        private System.Windows.Forms.TextBox graph_cVal;
        private System.Windows.Forms.Panel graphDraw;
        private OxyPlot.WindowsForms.PlotView parabolaPlotter;
    }
}

