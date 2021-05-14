using NIOP;
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
    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            inputMenuStrip.Items[0].PerformClick();


            // @dimitri-dev => Menu strip modifications
            // this.inputMenuStrip.Renderer = new MenuStripRenderer();
            this.inputMenuStrip.Renderer = new ToolStripProfessionalRenderer(new CalculatorColorTable());
        }
        #endregion

        #region Handling Menu Strip Changes
        // @dimitri-dev => Far from the best solution, but thinking at 2:15 AM looks like this
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            // There are stil some memory leak problems ~ 400kB per function call
            if (activeForm != null)
            {
                if (activeForm.Name == childForm.Name)
                {
                    childForm.Close();
                    childForm.Dispose();
                    return;
                }
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void _clickedItemFormLoader(ToolStripItem x)
        {
            // sadly hardcoded
            switch (x.Name)
            {
                case "MenuSelector_Basic":
                    openChildForm(new Calculator());
                    break;
                case "MenuSelector_Advanced":
                    openChildForm(new CalculatorAdv());
                    break;
                case "MenuSelector_ParabolaGraph":
                    openChildForm(new CalculatorParabolaGraph());
                    break;
                default:
                    break;
            }
        }

        private void MenuStripRender_ItemClickedChange(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in inputMenuStrip.Items)
            {
                item.Checked = (item == e.ClickedItem) ? true : false;
                MenuStripRender_ItemCheckedChange(item);
            }

            _clickedItemFormLoader(e.ClickedItem);
        }
        private void MenuStripRender_ItemCheckedChange(ToolStripMenuItem x) => x.BackColor = (x.Checked == true) ? Color.FromArgb(75, 75, 75) : Color.FromArgb(49, 49, 49);
        #endregion
    }

    public class CalculatorColorTable : ProfessionalColorTable
    {
        private Color buttonOperatorStandard = Color.FromArgb(49, 49, 49);
        private Color buttonOperatorHovered = Color.FromArgb(75, 75, 75);

        public override Color MenuBorder { get => buttonOperatorStandard; }
        public override Color MenuItemSelected { get => buttonOperatorStandard; }
        public override Color MenuItemBorder { get => buttonOperatorStandard; }

        public override Color MenuItemSelectedGradientBegin { get => buttonOperatorHovered; }
        public override Color MenuItemSelectedGradientEnd { get => buttonOperatorHovered; }

        // Credits: https://stackoverflow.com/questions/13235627/how-to-change-the-appearance-of-a-menustrip
        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.professionalcolortable?view=net-5.0
    }
}
