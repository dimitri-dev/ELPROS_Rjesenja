using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PZ2_pt2
{
    public partial class CalculatorButtonNumpad : Button
    {
        public CalculatorButtonNumpad() : base()
        {
            // Unified properties
            base.Name = "ButtonCalculator";
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            base.ForeColor = System.Drawing.Color.White;
            base.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            base.Text = "ButtonClick";
            base.Size = new System.Drawing.Size(108, 74);
            base.UseVisualStyleBackColor = false;

            base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
        }
    }

    public partial class CalculatorButtonOperation : Button
    {
        public CalculatorButtonOperation() : base()
        {
            // Unified properties
            base.Name = "ButtonCalculator";
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            base.ForeColor = System.Drawing.Color.White;
            base.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            base.Text = "ButtonClick";
            base.Size = new System.Drawing.Size(108, 74);
            base.UseVisualStyleBackColor = false;

            base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(105)))));
        }
    }

    public partial class CalculatorButtonEquals : Button
    {
        public CalculatorButtonEquals() : base()
        {
            // Unified properties
            base.Name = "ButtonCalculator";
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            base.ForeColor = System.Drawing.Color.White;
            base.Font = new System.Drawing.Font("Poppins Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            base.Text = "ButtonClick";
            base.Size = new System.Drawing.Size(108, 74);
            base.UseVisualStyleBackColor = false;

            base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
            base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(112)))), ((int)(((byte)(198)))));
        }
    }
}
