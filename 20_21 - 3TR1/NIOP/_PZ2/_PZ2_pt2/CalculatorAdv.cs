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
    public partial class CalculatorAdv : Form
    {
        #region Constructor
        public CalculatorAdv()
        {
            InitializeComponent();
            Handle_UI_RemoveFirstFocus();
            Handle_UpdateEquationStack();

            // @dimitri-dev => This is a surprise tool that will help us later :)
            _FontOffset = (int)(input_Equation.Font.Size * 0.15);
            _FontScript = new Font(input_Equation.Font.FontFamily, (float)(input_Equation.Font.Size * 0.7), FontStyle.Bold);
        }
        #endregion

        #region Fields
        private string _EquationResult;
        private int _FontOffset;
        private Font _FontScript;
        #endregion

        #region Handling UI tricks
        private void Handle_UpdateEquationStack()
        {
            input_Equation.Text = _EquationResult;
            input_Equation.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Handle_UpdateEquationStackSubscript()
        {
            input_Equation.Text = _EquationResult;
            input_Equation.SelectionChanged -= new EventHandler(Handle_UI_EquationSelectionChange);

            input_Equation.Select(0, 1);
            input_Equation.SelectionCharOffset = 2 * _FontOffset;
            input_Equation.SelectionFont = _FontScript;

            input_Equation.Select(2, _EquationResult.Length - 2);
            input_Equation.SelectionCharOffset = -_FontOffset;
            input_Equation.SelectionFont = _FontScript;

            input_Equation.SelectionChanged += new EventHandler(Handle_UI_EquationSelectionChange);
            input_Equation.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Handle_UI_RemoveFirstFocus() => this.ActiveControl = placeholderLabel;

        // design choice @dimitri-dev => Event Handler to make user unable to copy current equation. 
        private void Handle_UI_EquationSelectionChange(object sender, EventArgs e) => input_Equation.SelectionLength = 0;
        #endregion

        #region Calculator - Handle Calculate Button
        private void Calculator_Calculate(object sender, EventArgs e)
        {
            try
            {
                _EquationResult = Convert.ToString(calculate(expressionInput.Text));
                if (_EquationResult == "NaN") throw new Exception();
            }
            catch(Exception)
            {
                _EquationResult = "Unable to calculate.";
            }

            Handle_UpdateEquationStack();
        }
        #endregion

        #region Actual Calculator Logic
        // Credits: @dimitri-dev => https://github.com/dimitri-dev/CodeWars_CSharp/blob/main/0032%20-%20My%20BEDMAS%20Aproved%20Calculator/Program.cs
        public static double calculate(string s)
        {
            var x = s.Replace(" ", "");
            return (x.Count(k => k == '^') == 0) ?
                Math.Round(Convert.ToDouble(new DataTable().Compute(x, "")), 10) : Eval(x);
        }

        private static string[] _operators = { "-", "+", "*", "/", "^" };
        private static Func<double, double, double>[] _operations = {
            (a1, a2) => a1 - a2,
            (a1, a2) => a1 + a2,
            (a1, a2) => a1 * a2,
            (a1, a2) => a1 / a2,
            (a1, a2) => Math.Pow(a1, a2)
        };

        public static double Eval(string expression)
        {
            List<string> tokens = getTokens(expression);
            Stack<double> operandStack = new Stack<double>();
            Stack<string> operatorStack = new Stack<string>();
            int tokenIndex = 0;

            while (tokenIndex < tokens.Count)
            {
                string token = tokens[tokenIndex];
                if (token == "(")
                {
                    string subExpr = getSubExpression(tokens, ref tokenIndex);
                    operandStack.Push(Eval(subExpr));
                    continue;
                }
                if (token == ")")
                {
                    throw new ArgumentException("Mis-matched parentheses in expression");
                }
                //If this is an operator  
                if (Array.IndexOf(_operators, token) >= 0)
                {
                    while (operatorStack.Count > 0 && Array.IndexOf(_operators, token) < Array.IndexOf(_operators, operatorStack.Peek()))
                    {
                        string op = operatorStack.Pop();
                        double arg2 = operandStack.Pop();
                        double arg1 = operandStack.Pop();
                        operandStack.Push(_operations[Array.IndexOf(_operators, op)](arg1, arg2));
                    }
                    operatorStack.Push(token);
                }
                else
                {
                    operandStack.Push(double.Parse(token));
                }
                tokenIndex += 1;
            }

            while (operatorStack.Count > 0)
            {
                string op = operatorStack.Pop();
                double arg2 = operandStack.Pop();
                double arg1 = operandStack.Pop();
                operandStack.Push(_operations[Array.IndexOf(_operators, op)](arg1, arg2));
            }
            return operandStack.Pop();
        }

        private static string getSubExpression(List<string> tokens, ref int index)
        {
            StringBuilder subExpr = new StringBuilder();
            int parenlevels = 1;
            index += 1;
            while (index < tokens.Count && parenlevels > 0)
            {
                string token = tokens[index];
                if (tokens[index] == "(")
                {
                    parenlevels += 1;
                }

                if (tokens[index] == ")")
                {
                    parenlevels -= 1;
                }

                if (parenlevels > 0)
                {
                    subExpr.Append(token);
                }

                index += 1;
            }

            if ((parenlevels > 0))
            {
                throw new ArgumentException("Mis-matched parentheses in expression");
            }
            return subExpr.ToString();
        }

        private static List<string> getTokens(string expression)
        {
            string operators = "()^*/+-";
            List<string> tokens = new List<string>();
            StringBuilder sb = new StringBuilder();

            foreach (char c in expression.Replace(" ", string.Empty))
            {
                if (operators.IndexOf(c) >= 0)
                {
                    if ((sb.Length > 0))
                    {
                        tokens.Add(sb.ToString());
                        sb.Length = 0;
                    }
                    tokens.Add(c.ToString());
                }
                else
                {
                    sb.Append(c);
                }
            }

            if ((sb.Length > 0))
            {
                tokens.Add(sb.ToString());
            }
            return tokens;
        }
        #endregion
    }
}
