using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_4___Enkapsulacija
{
    class Ucenik
    {
        #region attributes
        public string ime;
        public string prezime;
        public string razred;

        public int OIB;
        public List<int> ocjene;
        public float prosjek;
        #endregion

        #region constructors
        public Ucenik(string v1, string v2, int razred, int OIB)
        {
            this.ime = v1;
            this.prezime = v2;
            this.razred = Convert.ToString(razred);
            this.OIB = OIB;

            this.ocjene = new List<int>();
        }
        #endregion

        #region methods
        public void AddGrade(int grade)
        {
            ocjene.Add(grade);
        }

        public void AddGrade(int[] grades)
        {
            ocjene.AddRange(grades);
        }

        public void OutputGrades()
        {
            Console.WriteLine($"Ocjene {ime} {prezime}a su: ");
            foreach (int grade in ocjene)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine();
        }

        public void OutputAverage()
        {
            this.prosjek = CalculateAverage();
            Console.WriteLine($"Prosjek {ime} {prezime}a je {prosjek}.");
        }

        private float CalculateAverage()
        {
            return ocjene.Sum() / (float)ocjene.Count;
        }
        #endregion
    }
}
