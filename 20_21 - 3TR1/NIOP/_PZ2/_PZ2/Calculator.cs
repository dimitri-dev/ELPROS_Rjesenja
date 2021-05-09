using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOP
{
    public partial class Calculator : Form
    {
        #region Constructor
        public Calculator()
        {
            InitializeComponent();
            Handle_UI_RemoveFirstFocus();
            Handle_UpdateCurrentStack();
            Handle_UpdateEquationStack();

            // @dimitri-dev => This is a surprise tool that will help us later :)
            _FontOffset = (int)(input_Main.Font.Size * 0.15);
            _FontScript = new Font(input_Equation.Font.FontFamily, (float)(input_Equation.Font.Size * 0.7), FontStyle.Bold);
        }
        #endregion

        #region Fields
        private string _Equation = "";
        private double _Result = 0.0f;

        private double _SignOp = 1;
        private string _CurrentStack = "0";

        private bool _CommaUsed = false;
        private char _Operation = '$';

        private int _FontOffset;
        private Font _FontScript;
        #endregion

        #region Handling UI tricks
        private void Handle_UpdateCurrentStack()
        {
            input_Main.Text = _CurrentStack;
            input_Main.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Handle_UpdateEquationStack()
        {
            input_Equation.Text = _Equation;
            input_Equation.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Handle_UpdateEquationStackSubscript()
        {
            input_Equation.Text = _Equation;
            input_Equation.SelectionChanged -= new EventHandler(Handle_UI_EquationSelectionChange);

            input_Equation.Select(0, 1);
            input_Equation.SelectionCharOffset = 2 * _FontOffset;
            input_Equation.SelectionFont = _FontScript;

            input_Equation.Select(2, _Equation.Length - 2);
            input_Equation.SelectionCharOffset = -_FontOffset;
            input_Equation.SelectionFont = _FontScript;

            input_Equation.SelectionChanged += new EventHandler(Handle_UI_EquationSelectionChange);
            input_Equation.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Handle_UI_RemoveFirstFocus() => this.ActiveControl = placeholderLabel;

        // design choice @dimitri-dev => Event Handler to make user unable to copy current equation. 
        private void Handle_UI_EquationSelectionChange(object sender, EventArgs e) => input_Equation.SelectionLength = 0;
        #endregion

        #region The Numpad - Numbers [0-9]+[,]
        private void AddNumber_Handle(char num)
        {
            // This is also a design choice @dimitri-dev => Make the Add Number handler unreadable to anyone but the professional coders :-)
            // Short Explaination: Checks if len == 1 or if the number is negative and len == 2 --- Then takes the "Last" char and looks if it's 0, which would be the first number here and then modifies the _CurrentStack accordingly.
            _CurrentStack = ((_CurrentStack.Length == 1 || (_SignOp == -1 && _CurrentStack.Length == 2)) && _CurrentStack.Last() == '0') ? _CurrentStack[..^1] + num : _CurrentStack + num + "";

            Handle_UpdateCurrentStack();
        }

        private void AddNumber_0(object sender, EventArgs e)
        {
            if (_CommaUsed || _CurrentStack[0] != '0') _CurrentStack += "0";
            Handle_UpdateCurrentStack();
        }

        private void AddNumber_1(object sender, EventArgs e) => AddNumber_Handle('1');

        private void AddNumber_2(object sender, EventArgs e) => AddNumber_Handle('2');

        private void AddNumber_3(object sender, EventArgs e) => AddNumber_Handle('3');

        private void AddNumber_4(object sender, EventArgs e) => AddNumber_Handle('4');

        private void AddNumber_5(object sender, EventArgs e) => AddNumber_Handle('5');

        private void AddNumber_6(object sender, EventArgs e) => AddNumber_Handle('6');

        private void AddNumber_7(object sender, EventArgs e) => AddNumber_Handle('7');

        private void AddNumber_8(object sender, EventArgs e) => AddNumber_Handle('8');

        private void AddNumber_9(object sender, EventArgs e) => AddNumber_Handle('9');

        private void Number_AddDecimals(object sender, EventArgs e)
        {
            if (!_CommaUsed)
            {
                _CurrentStack += ",";
                _CommaUsed = true;
                Handle_UpdateCurrentStack();
            }
        }
        #endregion

        #region The Numpad - Operations pt.1 -> [+][-][*][/][+-]
        private void Operator_HandleOp(char op)
        {
            _Result = Convert.ToDouble(_CurrentStack);
            _Equation = _CurrentStack + " " + op;

            if (_Operation != '$')
                Calculator_Calculate(null, null);

            _Operation = op;
            Calculator_ResetCurrentInput(null, null);

            Handle_UpdateCurrentStack();
            Handle_UpdateEquationStack();
        }

        private void Operator_ChangeSign(object sender, EventArgs e)
        {
            _CurrentStack = (_SignOp == 1) ? "-" + _CurrentStack : _CurrentStack[1..];
            _SignOp *= -1; // Flip Sign
            Handle_UpdateCurrentStack();
        }

        private void Operator_Addition(object sender, EventArgs e) => Operator_HandleOp('+');

        private void Operator_Subtraction(object sender, EventArgs e) => Operator_HandleOp('-');

        private void Operator_Multiplication(object sender, EventArgs e) => Operator_HandleOp('✕');

        private void Operator_Division(object sender, EventArgs e) => Operator_HandleOp('÷');

        #endregion

        #region The Numpad - Operations pt.2 -> [^][√][1/x]
        private void Operator_ComplexHandleOp(char op)
        {
            _Result = Convert.ToDouble(_CurrentStack);
            switch (op)
            {
                case 'A':
                    _Result *= _Result;
                    _Equation = _CurrentStack + "²";
                    break;
                case 'B':
                    _Result = Math.Sqrt(_Result);
                    _Equation = "²√(" + _CurrentStack + ")";
                    break;
                case 'C':
                    _Result = 1 / _Result;
                    _Equation = "1/" + _CurrentStack + "";
                    break;
                default:
                    break;
            }

            _CurrentStack = Convert.ToString(_Result);

            Handle_UpdateCurrentStack();

            if (op == 'C') Handle_UpdateEquationStackSubscript();
            else Handle_UpdateEquationStack();
        }

        // design choice @dimitri-dev => The "op" chars have no meaning, it's just the order by which these operations were added.
        private void Operator_Square(object sender, EventArgs e) => Operator_ComplexHandleOp('A');
        private void Operator_SquareRoot(object sender, EventArgs e) => Operator_ComplexHandleOp('B');

        private void Operator_Inverse(object sender, EventArgs e) => Operator_ComplexHandleOp('C');
        #endregion

        #region The Numpad - Percentage Method
        private void Operator_MakeResultPercentage(object sender, EventArgs e)
        {
            _Result = Convert.ToDouble(_CurrentStack);
            _Result /= 100.0f;

            _CurrentStack = Convert.ToString(_Result);

            Handle_UpdateCurrentStack();
        }
        #endregion

        #region Calculator - Input Modification
        private void Calculator_RemoveLastDigit(object sender, EventArgs e)
        {
            _CurrentStack = (_CurrentStack.Length != 1) ? _CurrentStack[..^1] : "0";
            Handle_UpdateCurrentStack();
        }

        private void Calculator_ResetCurrentInput(object sender, EventArgs e)
        {
            _CurrentStack = "0";
            _CommaUsed = false;
            Handle_UpdateCurrentStack();
        }

        private void Calculator_ResetEverything(object sender, EventArgs e)
        {
            _Result = 0.0f;
            _SignOp = 1;

            _Equation = "";
            _CurrentStack = "0";
            _Operation = '$';

            _CommaUsed = false;

            Handle_UpdateCurrentStack();
            Handle_UpdateEquationStack();
        }
        #endregion

        #region Calculator - Calculating
        private void Calculator_Calculate(object sender, EventArgs e)
        {
            switch (_Operation)
            {
                case '+':
                    _Result += Convert.ToDouble(_CurrentStack);
                    _Equation = _Equation + " " + _CurrentStack;
                    break;
                case '-':
                    _Result -= Convert.ToDouble(_CurrentStack);
                    _Equation = _Equation + " " + _CurrentStack;
                    break;
                case '✕':
                    _Result *= Convert.ToDouble(_CurrentStack);
                    _Equation = _Equation + " " + _CurrentStack;
                    break;
                case '÷':
                    _Result /= Convert.ToDouble(_CurrentStack);
                    _Equation = _Equation + " " + _CurrentStack;
                    break;
                default:
                    _Result = Convert.ToDouble(_CurrentStack);
                    _Equation = _CurrentStack;
                    break;
            }

            _Equation += " =";
            _CurrentStack = Convert.ToString(_Result);
            Handle_UpdateCurrentStack();
            Handle_UpdateEquationStack();

            _Operation = '$';
        }
        #endregion
    }
}
