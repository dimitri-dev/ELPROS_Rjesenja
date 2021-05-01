using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppControls
{
    public partial class Form1 : Form
    {
        public List<TextBox> inputs = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
            rtbLog.Text = String.Empty;

            inputs.AddRange(new TextBox[] { txtIme, txtPrezime, txtOIB, txtAdresa, txtTelefon });
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetLog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            rtbLog.Text += $"{DateTime.Now.ToString()} - unos u log:\n" +
                           $"Ime: {txtIme.Text}\n" +
                           $"Prezime: {txtPrezime.Text}\n" +
                           $"OIB: {txtOIB.Text}\n" +
                           $"Adresa: {txtAdresa.Text}\n" +
                           $"Broj telefona: {txtTelefon.Text}\n\n";
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            ResetLog();
            foreach (var x in inputs) x.Text = String.Empty;
        
        }

        private void ResetLog()
        {
            rtbLog.Text = String.Empty;
        }

        private void logFile_Click(object sender, EventArgs e)
        {
            if (rtbLog.Text == String.Empty) btnLog_Click(sender, e);
            File.AppendAllText("log.txt", rtbLog.Text + '\n');
        }
    }
}
