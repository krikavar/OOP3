using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
	class Pacient : Osoba
	{
		double ObvodPasu { get; set; } //v metrech
		public Pacient(string Jmeno, string Prijmeni, double Hmotnost, double Vyska, double ObvodPasu) : base(Jmeno, Prijmeni, Hmotnost, Vyska)
		{
			this.ObvodPasu = ObvodPasu;
		}
		public double ABSI() //ABSI = Obvod pasu / (2/3 BMI x ½ výšky)
		{
			double ABSI = ObvodPasu / ((2 * (BMI() / 3)) * (Vyska * 0.5));
			return ABSI;
		}
		public override string ToString()
		{
			return base.ToString() + $", ABSI:{ABSI()}";
		}
	}
}
