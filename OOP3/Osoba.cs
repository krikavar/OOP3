using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    class Osoba
    {
		public string Jmeno { get; set; }
		public string Prijmeni { get; set; }
		public double _Hmotnost;
		public double Hmotnost
		{
			get { return _Hmotnost; }
			set
			{
				if (value <= 0 || value > 300) { MessageBox.Show("Hmotnost mimo rozsah!"); _Hmotnost = 0; }
				else { _Hmotnost = value; }
			}
		}
		public double _Vyska;
		public double Vyska
		{
			get { return _Vyska; }
			set
			{
				if (value > 3) { _Vyska = (value / 100); }
				else { _Vyska = value; }
			}
		}

		public Osoba(string Jmeno, string Prijmeni, double Hmotnost, double Vyska)
		{
			this.Jmeno = Jmeno;
			this.Prijmeni = Prijmeni;
			this.Hmotnost = Hmotnost;
			this.Vyska = Vyska;
		}

		public double BMI()
		{
			double BMI = Math.Round((Hmotnost / (Vyska * Vyska)), 2);
			return BMI;
		}

		public override string ToString()
		{
			return $"Jmeno: {Jmeno},Prjmeni: {Prijmeni},Hmotnost: {Hmotnost}kg,Vyska: {Vyska}m, BMI: {BMI()}";
		}
	}
}
