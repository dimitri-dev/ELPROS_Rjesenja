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
    public partial class CalculatorParabolaGraph : Form
    {
        #region Constructor
        public CalculatorParabolaGraph()
        {
            InitializeComponent();
            Handle_UI_RemoveFirstFocus();
        }
        #endregion

        #region Handling UI tricks
        private void Handle_UI_RemoveFirstFocus() => this.ActiveControl = placeholderLabel;
        #endregion

        #region Draw Graph Function
        private double f(double a, double b, double c, double x) => (a * (x * x)) + (b * x) + c;

        private void Draw_Graph_Function(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(graph_aVal.Text);
                double b = Convert.ToDouble(graph_bVal.Text);
                double c = Convert.ToDouble(graph_cVal.Text);

                double xOrigin = graphDraw.Width / 2;
                double yOrigin = graphDraw.Height / 2;

                graphDraw.Refresh();

                // @dimitri-dev => unfortunately had to use external graph plotters
                // mostly because this app is in .NET 5.0, and "Chart" only works in .NET Framework..... design choice :)

                var parabolaPositive = new OxyPlot.Series.LineSeries()
                {
                    Color = OxyPlot.OxyColors.Yellow,
                    StrokeThickness = 1,
                };
                
                var parabolaNegative = new OxyPlot.Series.LineSeries()
                {
                    Color = OxyPlot.OxyColors.Yellow,
                    StrokeThickness = 1,
                };

                for (double x = 0; x <= 15; x += 0.01)
                {
                    parabolaPositive.Points.Add(new OxyPlot.DataPoint(x, f(a, b, c, x)));
                    parabolaNegative.Points.Add(new OxyPlot.DataPoint(-x, f(a, b, c, x)));
                }

                var model = new OxyPlot.PlotModel { };
                model.Series.Add(parabolaPositive);
                model.Series.Add(parabolaNegative);

                parabolaPlotter.Model = model;
            }
            catch (Exception)
            {
                // don't do shit, user is dumb
            }
        }
        #endregion
    }
}
