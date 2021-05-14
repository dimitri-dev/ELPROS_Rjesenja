
namespace NIOP
{
    partial class CalculatorAdv
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
            this.operation_Equal = new System.Windows.Forms.Button();
            this.placeholderLabel = new System.Windows.Forms.Label();
            this.input_Equation = new System.Windows.Forms.RichTextBox();
            this.expressionInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availableFunctionsTips = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // operation_Equal
            // 
            this.operation_Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
            this.operation_Equal.FlatAppearance.BorderSize = 0;
            this.operation_Equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(112)))), ((int)(((byte)(198)))));
            this.operation_Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Equal.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Equal.ForeColor = System.Drawing.Color.White;
            this.operation_Equal.Location = new System.Drawing.Point(356, 78);
            this.operation_Equal.Name = "operation_Equal";
            this.operation_Equal.Size = new System.Drawing.Size(86, 42);
            this.operation_Equal.TabIndex = 5;
            this.operation_Equal.Text = "=";
            this.operation_Equal.UseVisualStyleBackColor = false;
            this.operation_Equal.Click += new System.EventHandler(this.Calculator_Calculate);
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.AutoSize = true;
            this.placeholderLabel.Location = new System.Drawing.Point(44, -71);
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(0, 28);
            this.placeholderLabel.TabIndex = 27;
            // 
            // input_Equation
            // 
            this.input_Equation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.input_Equation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_Equation.Font = new System.Drawing.Font("Poppins Medium", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.input_Equation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.input_Equation.Location = new System.Drawing.Point(12, 126);
            this.input_Equation.Multiline = false;
            this.input_Equation.Name = "input_Equation";
            this.input_Equation.ReadOnly = true;
            this.input_Equation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_Equation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.input_Equation.Size = new System.Drawing.Size(430, 58);
            this.input_Equation.TabIndex = 26;
            this.input_Equation.Text = "0";
            this.input_Equation.WordWrap = false;
            this.input_Equation.SelectionChanged += new System.EventHandler(this.Handle_UI_EquationSelectionChange);
            // 
            // expressionInput
            // 
            this.expressionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.expressionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expressionInput.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expressionInput.ForeColor = System.Drawing.Color.White;
            this.expressionInput.Location = new System.Drawing.Point(12, 40);
            this.expressionInput.Name = "expressionInput";
            this.expressionInput.PlaceholderText = "example: 2*2";
            this.expressionInput.Size = new System.Drawing.Size(430, 32);
            this.expressionInput.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Enter Mathematical Expression:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tooltips";
            // 
            // availableFunctionsTips
            // 
            this.availableFunctionsTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.availableFunctionsTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableFunctionsTips.ForeColor = System.Drawing.Color.White;
            this.availableFunctionsTips.Location = new System.Drawing.Point(12, 218);
            this.availableFunctionsTips.Name = "availableFunctionsTips";
            this.availableFunctionsTips.ReadOnly = true;
            this.availableFunctionsTips.Size = new System.Drawing.Size(430, 483);
            this.availableFunctionsTips.TabIndex = 32;
            this.availableFunctionsTips.Text = "Things you can use: \n> +\n> -\n> *\n> /\n> ^ (power)\n> (\n> )";
            // 
            // CalculatorAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(458, 713);
            this.Controls.Add(this.availableFunctionsTips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expressionInput);
            this.Controls.Add(this.placeholderLabel);
            this.Controls.Add(this.input_Equation);
            this.Controls.Add(this.operation_Equal);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculatorAdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tooltips";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button operation_Equal;
        private System.Windows.Forms.Label placeholderLabel;
        private System.Windows.Forms.RichTextBox input_Equation;
        private System.Windows.Forms.TextBox expressionInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox availableFunctionsTips;
    }
}

