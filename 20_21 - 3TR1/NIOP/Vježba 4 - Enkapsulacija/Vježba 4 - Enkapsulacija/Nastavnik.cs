using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_4___Enkapsulacija
{
    class Nastavnik
    {
        #region attributes
        public string ime;
        public string prezime;

        #endregion attributes

        #region constructors
        public Nastavnik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        #endregion

        #region methods
        public void AddGrade(int grade, Ucenik uc)
        {
            uc.AddGrade(grade);
        }

        public void AddGrade(int[] grades, Ucenik uc)
        {
            uc.AddGrade(grades);
        }

        public void OutputAverage(Ucenik uc)
        {
            uc.OutputAverage();
        }

        public void OutputGrades(Ucenik uc)
        {
            uc.OutputGrades();
        }

        #endregion methods
    }
}
