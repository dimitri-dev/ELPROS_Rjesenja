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

        public int zakljucna_ocjena;
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
            Console.Write($"Ocjene {ime} {prezime}a (Razred: {razred}, OIB: {OIB}) su: ");
            foreach (int grade in ocjene)
            {
                Console.Write($"{grade} ");
            }
            Console.Write("\n");
        }

        public void OutputAverage()
        {
            this.prosjek = CalculateAverage();
            Console.WriteLine($"Prosjek {ime} {prezime}a je {prosjek:0.00}.");
        }

        #region problem_task_addition
        public void LockGrade()
        {
            Console.Write($"\nUnesite zakljucnu ocjenu {ime} {prezime}a: ");
            zakljucna_ocjena = Convert.ToInt32(Console.ReadLine());

            if (zakljucna_ocjena > Convert.ToInt32(Math.Round(prosjek)))
                Console.WriteLine("Zakljucna ocjena veca je od prosjeka.");
            else if (zakljucna_ocjena < Convert.ToInt32(Math.Round(prosjek)))
                Console.WriteLine("Zakljucna ocjena manja je od prosjeka.");
            else
                Console.WriteLine("Zakljucna ocjena jednaka je prosjeku.");
        }

        public void OutputLockedGrade()
        {
            Console.Write($"Zakljucna ocjena iznosi {zakljucna_ocjena}.\n\n");
        }

        #endregion

        private float CalculateAverage()
        {
            return ocjene.Sum() / (float)ocjene.Count;
        }
        #endregion
    }
}
