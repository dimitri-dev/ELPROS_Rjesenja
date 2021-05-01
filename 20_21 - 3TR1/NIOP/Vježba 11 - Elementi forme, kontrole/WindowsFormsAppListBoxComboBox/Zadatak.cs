using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppListBoxComboBox
{
    public partial class Zadatak : Form
    {
        #region Osoba prop
        private Osoba input = new Osoba();
        #endregion

        #region Ctor
        public Zadatak()
        {
            InitializeComponent();
        }
        #endregion

        #region Grade Setter
        private void input_choiceGrade1_CheckedChanged(object sender, EventArgs e)
        {
            input.Razred = 1;
        }

        private void input_choiceGrade2_CheckedChanged(object sender, EventArgs e)
        {
            input.Razred = 2;
        }

        private void input_choiceGrade3_CheckedChanged(object sender, EventArgs e)
        {
            input.Razred = 3;
        }

        private void input_choiceGrade4_CheckedChanged(object sender, EventArgs e)
        {
            input.Razred = 4;
        }
        #endregion

        #region Gender Setter
        private void input_choiceMale_CheckedChanged(object sender, EventArgs e)
        {
            input.Spol = "Muško";
        }

        private void input_choiceFemale_CheckedChanged(object sender, EventArgs e)
        {
            input.Spol = "Žensko";
        }

        private void input_choiceOther_CheckedChanged(object sender, EventArgs e)
        {
            if (input_choiceOther_txt.Text != String.Empty)
                input.Spol = input_choiceOther_txt.Text;
            else
                input.Spol = "N/A";
        }
        #endregion

        #region Photo & Output
        private void input_getPhoto_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                input.Slika = new Bitmap(dialog.FileName);
                userPicture.BackgroundImage = input.Slika;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input_choiceOther.Checked)
                input.Spol = input_choiceOther_txt.Text;

            richTextBox1.Text = input.Ispis;
        }
        #endregion

        #region Personal Data
        private void input_userName_TextChanged(object sender, EventArgs e)
        {
            input.Ime = input_userName.Text;
        }

        private void input_userLastName_TextChanged(object sender, EventArgs e)
        {
            input.Prezime = input_userLastName.Text;
        }
        #endregion

        #region Hobiji
        private void hobiAdd_Click(object sender, EventArgs e)
        {
            input.DodajHobi(input_hobies.Text);
            input_hobies.DataSource = input.Hobiji;
        }
        #endregion
    }

    class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public int Razred { get; set; }
        public Bitmap Slika { get; set; }

        public List<string> Hobiji = new List<string>();

        public void DodajHobi(string hobi)
        {
            Hobiji.Add(hobi);
        }

        public string Ispis
        {
            get
            {
                return $"Ime: {Ime}\n" +
                       $"Prezime: {Prezime}\n" +
                       $"Spol: {Spol}\n" +
                       $"Razred: {Razred}\n" +
                       $"Hobiji: {String.Join(",", Hobiji)}\n";
            }
        }
    }
}
