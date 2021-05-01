using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppListBoxComboBox
{
    public partial class Form1 : Form
    {
        #region Properties     
        public bool Reseting { get; set; } = false;

        private ControlVars ctrl = new ControlVars();
        #endregion

        #region Fields
        private const int ProgressIncrement = 25;
        #endregion

        #region Ctor        
        public Form1()
        {
            InitializeComponent();
            PostaviKorisnike();
            PostaviHobije();
            PostaviKontrole();
        }
        #endregion

        #region Methods
        private void PostaviKontrole()
        {
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            pbSlika.Visible = false;
        }
        private void PostaviKorisnike()
        {
            List<ControlSourceItem> korisnici = new List<ControlSourceItem>();
            korisnici.Add(new ControlSourceItem() { Key = "0", Text = "Odaberi vrijednost" });
            korisnici.Add(new ControlSourceItem() { Key = "1", Text = "Pero" });
            korisnici.Add(new ControlSourceItem() { Key = "2", Text = "Ivo" });
            korisnici.Add(new ControlSourceItem() { Key = "3", Text = "Mario" });
                        
            cmbKorisnici.DisplayMember = nameof(ControlSourceItem.Text);
            cmbKorisnici.ValueMember = nameof(ControlSourceItem.Key);
            cmbKorisnici.DataSource = korisnici;
        }
        private void PostaviHobije()
        {
            List<ControlSourceItem> hobiji = new List<ControlSourceItem>();
            hobiji.Add(new ControlSourceItem() { Key = "0", Text = "Odaberi vrijednost" });
            hobiji.Add(new ControlSourceItem() { Key = "1", Text = "Skijanje" });
            hobiji.Add(new ControlSourceItem() { Key = "2", Text = "Nogomet" });
            hobiji.Add(new ControlSourceItem() { Key = "3", Text = "Boks" });

            lbHobiji.DisplayMember = nameof(ControlSourceItem.Text);
            lbHobiji.ValueMember = nameof(ControlSourceItem.Key);
            lbHobiji.DataSource = hobiji;
        }
        #endregion

        #region UI Events

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reseting = true;

            progressBar.Value = 0;
            cmbKorisnici.SelectedIndex = 0;
            cbKlikni.Checked = false;
            rbPokaziSliku.Checked = false;
            lbHobiji.SelectedIndex = 0;

            ctrl = new ControlVars();
            ctrl.lbUpdator = true;
            ctrl.cmbUpdator = true;

            Reseting = false;
        }

        private void SetProgressBar()
        {
            if (!Reseting)
            {
                if (progressBar.Value + ProgressIncrement <= progressBar.Maximum)
                    progressBar.Value += ProgressIncrement;
            }
        }

        private void cmbKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ctrl.cmbUpdator) { ctrl.cmbUpdator = true; return; }
            if (!ctrl.cmbChanged && sender.GetType().Name == "ComboBox") { SetProgressBar(); ctrl.cmbChanged = true; }
        }

        private void cbKlikni_CheckedChanged(object sender, EventArgs e)
        {
            if (!ctrl.cbChanged) { SetProgressBar(); ctrl.cbChanged = true; }
        }

        private void lbHobiji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ctrl.lbUpdator) { ctrl.lbUpdator = true; return; }
            if (!ctrl.lbChanged && sender.GetType().Name == "ListBox") { SetProgressBar(); ctrl.lbChanged = true; }
        }

        private void rbPokaziSliku_CheckedChanged(object sender, EventArgs e)
        {
            if (!ctrl.rbChanged) { SetProgressBar(); ctrl.rbChanged = true;
                bool pokaziSliku = rbPokaziSliku.Checked; pbSlika.Visible = pokaziSliku; }
        }

        #endregion
    }

    class ControlVars
    {
        public bool cmbChanged = false;
        public bool cbChanged = false;
        public bool lbChanged = false;
        public bool rbChanged = false;

        public bool cmbUpdator = false;
        public bool lbUpdator = false;
    }
}
