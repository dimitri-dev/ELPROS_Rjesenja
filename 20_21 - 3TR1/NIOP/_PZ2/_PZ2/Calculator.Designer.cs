
namespace NIOP
{
    partial class Calculator
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
            this.input_Main = new System.Windows.Forms.RichTextBox();
            this.operator_Sign = new System.Windows.Forms.Button();
            this.number_0 = new System.Windows.Forms.Button();
            this.number_Comma = new System.Windows.Forms.Button();
            this.operation_Equal = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_9 = new System.Windows.Forms.Button();
            this.number_8 = new System.Windows.Forms.Button();
            this.number_7 = new System.Windows.Forms.Button();
            this.operation_Add = new System.Windows.Forms.Button();
            this.operation_Subtract = new System.Windows.Forms.Button();
            this.operation_Multiply = new System.Windows.Forms.Button();
            this.operation_Division = new System.Windows.Forms.Button();
            this.input_Backspace = new System.Windows.Forms.Button();
            this.operation_SquareRoot = new System.Windows.Forms.Button();
            this.operation_Square = new System.Windows.Forms.Button();
            this.operation_Inverse = new System.Windows.Forms.Button();
            this.result_Percentage = new System.Windows.Forms.Button();
            this.result_Clear = new System.Windows.Forms.Button();
            this.result_ClearEverything = new System.Windows.Forms.Button();
            this.input_Equation = new System.Windows.Forms.RichTextBox();
            this.placeholderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_Main
            // 
            this.input_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.input_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_Main.Font = new System.Drawing.Font("Poppins Medium", 66F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.input_Main.ForeColor = System.Drawing.Color.White;
            this.input_Main.Location = new System.Drawing.Point(12, 76);
            this.input_Main.Multiline = false;
            this.input_Main.Name = "input_Main";
            this.input_Main.ReadOnly = true;
            this.input_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_Main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.input_Main.Size = new System.Drawing.Size(430, 135);
            this.input_Main.TabIndex = 0;
            this.input_Main.Text = "0";
            this.input_Main.WordWrap = false;
            // 
            // operator_Sign
            // 
            this.operator_Sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.operator_Sign.FlatAppearance.BorderSize = 0;
            this.operator_Sign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operator_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operator_Sign.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operator_Sign.ForeColor = System.Drawing.Color.White;
            this.operator_Sign.Location = new System.Drawing.Point(3, 633);
            this.operator_Sign.Name = "operator_Sign";
            this.operator_Sign.Size = new System.Drawing.Size(108, 74);
            this.operator_Sign.TabIndex = 2;
            this.operator_Sign.Text = "+/-";
            this.operator_Sign.UseVisualStyleBackColor = false;
            this.operator_Sign.Click += new System.EventHandler(this.Operator_ChangeSign);
            // 
            // number_0
            // 
            this.number_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_0.FlatAppearance.BorderSize = 0;
            this.number_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_0.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_0.ForeColor = System.Drawing.Color.White;
            this.number_0.Location = new System.Drawing.Point(117, 633);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(108, 74);
            this.number_0.TabIndex = 3;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = false;
            this.number_0.Click += new System.EventHandler(this.AddNumber_0);
            // 
            // number_Comma
            // 
            this.number_Comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_Comma.FlatAppearance.BorderSize = 0;
            this.number_Comma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_Comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_Comma.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_Comma.ForeColor = System.Drawing.Color.White;
            this.number_Comma.Location = new System.Drawing.Point(231, 633);
            this.number_Comma.Name = "number_Comma";
            this.number_Comma.Size = new System.Drawing.Size(108, 74);
            this.number_Comma.TabIndex = 4;
            this.number_Comma.Text = ",";
            this.number_Comma.UseVisualStyleBackColor = false;
            this.number_Comma.Click += new System.EventHandler(this.Number_AddDecimals);
            // 
            // operation_Equal
            // 
            this.operation_Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
            this.operation_Equal.FlatAppearance.BorderSize = 0;
            this.operation_Equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(112)))), ((int)(((byte)(198)))));
            this.operation_Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Equal.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Equal.ForeColor = System.Drawing.Color.White;
            this.operation_Equal.Location = new System.Drawing.Point(345, 633);
            this.operation_Equal.Name = "operation_Equal";
            this.operation_Equal.Size = new System.Drawing.Size(108, 74);
            this.operation_Equal.TabIndex = 5;
            this.operation_Equal.Text = "=";
            this.operation_Equal.UseVisualStyleBackColor = false;
            this.operation_Equal.Click += new System.EventHandler(this.Calculator_Calculate);
            // 
            // number_3
            // 
            this.number_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_3.FlatAppearance.BorderSize = 0;
            this.number_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_3.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_3.ForeColor = System.Drawing.Color.White;
            this.number_3.Location = new System.Drawing.Point(231, 553);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(108, 74);
            this.number_3.TabIndex = 8;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = false;
            this.number_3.Click += new System.EventHandler(this.AddNumber_3);
            // 
            // number_2
            // 
            this.number_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_2.FlatAppearance.BorderSize = 0;
            this.number_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_2.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_2.ForeColor = System.Drawing.Color.White;
            this.number_2.Location = new System.Drawing.Point(117, 553);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(108, 74);
            this.number_2.TabIndex = 7;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = false;
            this.number_2.Click += new System.EventHandler(this.AddNumber_2);
            // 
            // number_1
            // 
            this.number_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_1.FlatAppearance.BorderSize = 0;
            this.number_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_1.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_1.ForeColor = System.Drawing.Color.White;
            this.number_1.Location = new System.Drawing.Point(3, 553);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(108, 74);
            this.number_1.TabIndex = 6;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = false;
            this.number_1.Click += new System.EventHandler(this.AddNumber_1);
            // 
            // number_6
            // 
            this.number_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_6.FlatAppearance.BorderSize = 0;
            this.number_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_6.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_6.ForeColor = System.Drawing.Color.White;
            this.number_6.Location = new System.Drawing.Point(231, 473);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(108, 74);
            this.number_6.TabIndex = 11;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = false;
            this.number_6.Click += new System.EventHandler(this.AddNumber_6);
            // 
            // number_5
            // 
            this.number_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_5.FlatAppearance.BorderSize = 0;
            this.number_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_5.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_5.ForeColor = System.Drawing.Color.White;
            this.number_5.Location = new System.Drawing.Point(117, 473);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(108, 74);
            this.number_5.TabIndex = 10;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = false;
            this.number_5.Click += new System.EventHandler(this.AddNumber_5);
            // 
            // number_4
            // 
            this.number_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_4.FlatAppearance.BorderSize = 0;
            this.number_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_4.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_4.ForeColor = System.Drawing.Color.White;
            this.number_4.Location = new System.Drawing.Point(3, 473);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(108, 74);
            this.number_4.TabIndex = 9;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = false;
            this.number_4.Click += new System.EventHandler(this.AddNumber_4);
            // 
            // number_9
            // 
            this.number_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_9.FlatAppearance.BorderSize = 0;
            this.number_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_9.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_9.ForeColor = System.Drawing.Color.White;
            this.number_9.Location = new System.Drawing.Point(231, 393);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(108, 74);
            this.number_9.TabIndex = 14;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = false;
            this.number_9.Click += new System.EventHandler(this.AddNumber_9);
            // 
            // number_8
            // 
            this.number_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_8.FlatAppearance.BorderSize = 0;
            this.number_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_8.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_8.ForeColor = System.Drawing.Color.White;
            this.number_8.Location = new System.Drawing.Point(117, 393);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(108, 74);
            this.number_8.TabIndex = 13;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = false;
            this.number_8.Click += new System.EventHandler(this.AddNumber_8);
            // 
            // number_7
            // 
            this.number_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.number_7.FlatAppearance.BorderSize = 0;
            this.number_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.number_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_7.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_7.ForeColor = System.Drawing.Color.White;
            this.number_7.Location = new System.Drawing.Point(3, 393);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(108, 74);
            this.number_7.TabIndex = 12;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = false;
            this.number_7.Click += new System.EventHandler(this.AddNumber_7);
            // 
            // operation_Add
            // 
            this.operation_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.operation_Add.FlatAppearance.BorderSize = 0;
            this.operation_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operation_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Add.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Add.ForeColor = System.Drawing.Color.White;
            this.operation_Add.Location = new System.Drawing.Point(345, 553);
            this.operation_Add.Name = "operation_Add";
            this.operation_Add.Size = new System.Drawing.Size(108, 74);
            this.operation_Add.TabIndex = 15;
            this.operation_Add.Text = "+";
            this.operation_Add.UseVisualStyleBackColor = false;
            this.operation_Add.Click += new System.EventHandler(this.Operator_Addition);
            // 
            // operation_Subtract
            // 
            this.operation_Subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.operation_Subtract.FlatAppearance.BorderSize = 0;
            this.operation_Subtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operation_Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Subtract.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Subtract.ForeColor = System.Drawing.Color.White;
            this.operation_Subtract.Location = new System.Drawing.Point(345, 473);
            this.operation_Subtract.Name = "operation_Subtract";
            this.operation_Subtract.Size = new System.Drawing.Size(108, 74);
            this.operation_Subtract.TabIndex = 16;
            this.operation_Subtract.Text = "-";
            this.operation_Subtract.UseVisualStyleBackColor = false;
            this.operation_Subtract.Click += new System.EventHandler(this.Operator_Subtraction);
            // 
            // operation_Multiply
            // 
            this.operation_Multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.operation_Multiply.FlatAppearance.BorderSize = 0;
            this.operation_Multiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operation_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Multiply.Font = new System.Drawing.Font("Poppins Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Multiply.ForeColor = System.Drawing.Color.White;
            this.operation_Multiply.Location = new System.Drawing.Point(345, 393);
            this.operation_Multiply.Name = "operation_Multiply";
            this.operation_Multiply.Size = new System.Drawing.Size(108, 74);
            this.operation_Multiply.TabIndex = 17;
            this.operation_Multiply.Text = "✕";
            this.operation_Multiply.UseVisualStyleBackColor = false;
            this.operation_Multiply.Click += new System.EventHandler(this.Operator_Multiplication);
            // 
            // operation_Division
            // 
            this.operation_Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.operation_Division.FlatAppearance.BorderSize = 0;
            this.operation_Division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operation_Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Division.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Division.ForeColor = System.Drawing.Color.White;
            this.operation_Division.Location = new System.Drawing.Point(345, 313);
            this.operation_Division.Name = "operation_Division";
            this.operation_Division.Size = new System.Drawing.Size(108, 74);
            this.operation_Division.TabIndex = 18;
            this.operation_Division.Text = "÷";
            this.operation_Division.UseVisualStyleBackColor = false;
            this.operation_Division.Click += new System.EventHandler(this.Operator_Division);
            // 
            // input_Backspace
            // 
            this.input_Backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.input_Backspace.FlatAppearance.BorderSize = 0;
            this.input_Backspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.input_Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_Backspace.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_Backspace.ForeColor = System.Drawing.Color.White;
            this.input_Backspace.Location = new System.Drawing.Point(345, 233);
            this.input_Backspace.Name = "input_Backspace";
            this.input_Backspace.Size = new System.Drawing.Size(108, 74);
            this.input_Backspace.TabIndex = 19;
            this.input_Backspace.Text = "⌫";
            this.input_Backspace.UseVisualStyleBackColor = false;
            this.input_Backspace.Click += new System.EventHandler(this.Calculator_RemoveLastDigit);
            // 
            // operation_SquareRoot
            // 
            this.operation_SquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.operation_SquareRoot.FlatAppearance.BorderSize = 0;
            this.operation_SquareRoot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operation_SquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_SquareRoot.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_SquareRoot.ForeColor = System.Drawing.Color.White;
            this.operation_SquareRoot.Location = new System.Drawing.Point(231, 313);
            this.operation_SquareRoot.Name = "operation_SquareRoot";
            this.operation_SquareRoot.Size = new System.Drawing.Size(108, 74);
            this.operation_SquareRoot.TabIndex = 20;
            this.operation_SquareRoot.Text = "²√x";
            this.operation_SquareRoot.UseVisualStyleBackColor = false;
            this.operation_SquareRoot.Click += new System.EventHandler(this.Operator_SquareRoot);
            // 
            // operation_Square
            // 
            this.operation_Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.operation_Square.FlatAppearance.BorderSize = 0;
            this.operation_Square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operation_Square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Square.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Square.ForeColor = System.Drawing.Color.White;
            this.operation_Square.Location = new System.Drawing.Point(117, 313);
            this.operation_Square.Name = "operation_Square";
            this.operation_Square.Size = new System.Drawing.Size(108, 74);
            this.operation_Square.TabIndex = 21;
            this.operation_Square.Text = "x²";
            this.operation_Square.UseVisualStyleBackColor = false;
            this.operation_Square.Click += new System.EventHandler(this.Operator_Square);
            // 
            // operation_Inverse
            // 
            this.operation_Inverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.operation_Inverse.FlatAppearance.BorderSize = 0;
            this.operation_Inverse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.operation_Inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operation_Inverse.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation_Inverse.ForeColor = System.Drawing.Color.White;
            this.operation_Inverse.Location = new System.Drawing.Point(3, 313);
            this.operation_Inverse.Name = "operation_Inverse";
            this.operation_Inverse.Size = new System.Drawing.Size(108, 74);
            this.operation_Inverse.TabIndex = 22;
            this.operation_Inverse.Text = "¹/ₓ";
            this.operation_Inverse.UseVisualStyleBackColor = false;
            this.operation_Inverse.Click += new System.EventHandler(this.Operator_Inverse);
            // 
            // result_Percentage
            // 
            this.result_Percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.result_Percentage.FlatAppearance.BorderSize = 0;
            this.result_Percentage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.result_Percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result_Percentage.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_Percentage.ForeColor = System.Drawing.Color.White;
            this.result_Percentage.Location = new System.Drawing.Point(3, 233);
            this.result_Percentage.Name = "result_Percentage";
            this.result_Percentage.Size = new System.Drawing.Size(108, 74);
            this.result_Percentage.TabIndex = 23;
            this.result_Percentage.Text = "%";
            this.result_Percentage.UseVisualStyleBackColor = false;
            this.result_Percentage.Click += new System.EventHandler(this.Operator_MakeResultPercentage);
            // 
            // result_Clear
            // 
            this.result_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.result_Clear.FlatAppearance.BorderSize = 0;
            this.result_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.result_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result_Clear.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_Clear.ForeColor = System.Drawing.Color.White;
            this.result_Clear.Location = new System.Drawing.Point(231, 233);
            this.result_Clear.Name = "result_Clear";
            this.result_Clear.Size = new System.Drawing.Size(108, 74);
            this.result_Clear.TabIndex = 24;
            this.result_Clear.Text = "C";
            this.result_Clear.UseVisualStyleBackColor = false;
            this.result_Clear.Click += new System.EventHandler(this.Calculator_ResetCurrentInput);
            // 
            // result_ClearEverything
            // 
            this.result_ClearEverything.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.result_ClearEverything.FlatAppearance.BorderSize = 0;
            this.result_ClearEverything.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
            this.result_ClearEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result_ClearEverything.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_ClearEverything.ForeColor = System.Drawing.Color.White;
            this.result_ClearEverything.Location = new System.Drawing.Point(117, 233);
            this.result_ClearEverything.Name = "result_ClearEverything";
            this.result_ClearEverything.Size = new System.Drawing.Size(108, 74);
            this.result_ClearEverything.TabIndex = 25;
            this.result_ClearEverything.Text = "CE";
            this.result_ClearEverything.UseVisualStyleBackColor = false;
            this.result_ClearEverything.Click += new System.EventHandler(this.Calculator_ResetEverything);
            // 
            // input_Equation
            // 
            this.input_Equation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.input_Equation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_Equation.Font = new System.Drawing.Font("Poppins Medium", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.input_Equation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.input_Equation.Location = new System.Drawing.Point(12, 34);
            this.input_Equation.Multiline = false;
            this.input_Equation.Name = "input_Equation";
            this.input_Equation.ReadOnly = true;
            this.input_Equation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_Equation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.input_Equation.Size = new System.Drawing.Size(430, 58);
            this.input_Equation.TabIndex = 26;
            this.input_Equation.Text = "";
            this.input_Equation.WordWrap = false;
            this.input_Equation.SelectionChanged += new System.EventHandler(this.Handle_UI_EquationSelectionChange);
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.AutoSize = true;
            this.placeholderLabel.Location = new System.Drawing.Point(44, -71);
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(0, 28);
            this.placeholderLabel.TabIndex = 27;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(458, 713);
            this.Controls.Add(this.placeholderLabel);
            this.Controls.Add(this.input_Equation);
            this.Controls.Add(this.result_ClearEverything);
            this.Controls.Add(this.result_Clear);
            this.Controls.Add(this.result_Percentage);
            this.Controls.Add(this.operation_Inverse);
            this.Controls.Add(this.operation_Square);
            this.Controls.Add(this.operation_SquareRoot);
            this.Controls.Add(this.input_Backspace);
            this.Controls.Add(this.operation_Division);
            this.Controls.Add(this.operation_Multiply);
            this.Controls.Add(this.operation_Subtract);
            this.Controls.Add(this.operation_Add);
            this.Controls.Add(this.number_9);
            this.Controls.Add(this.number_8);
            this.Controls.Add(this.number_7);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.operation_Equal);
            this.Controls.Add(this.number_Comma);
            this.Controls.Add(this.number_0);
            this.Controls.Add(this.operator_Sign);
            this.Controls.Add(this.input_Main);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_Main;
        private System.Windows.Forms.RichTextBox input_Equation;
        private System.Windows.Forms.Button operator_Sign;
        private System.Windows.Forms.Button number_Comma;
        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.Button number_6;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button number_9;
        private System.Windows.Forms.Button number_8;
        private System.Windows.Forms.Button number_7;
        private System.Windows.Forms.Button input_Backspace;
        private System.Windows.Forms.Button operation_Equal;
        private System.Windows.Forms.Button operation_Add;
        private System.Windows.Forms.Button operation_Subtract;
        private System.Windows.Forms.Button operation_Multiply;
        private System.Windows.Forms.Button operation_Division;
        private System.Windows.Forms.Button operation_SquareRoot;
        private System.Windows.Forms.Button operation_Square;
        private System.Windows.Forms.Button operation_Inverse;
        private System.Windows.Forms.Button result_Percentage;
        private System.Windows.Forms.Button result_Clear;
        private System.Windows.Forms.Button result_ClearEverything;
        private System.Windows.Forms.Label placeholderLabel;
    }
}

