using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomersekletekProjekt.Modell
{
    class Meres
    {
        private string varos;
        private double homerseklet;

        public double Homerseklet { get => homerseklet; set => homerseklet = value; }
        public string Varos { get => varos; set => varos = value; }

        public bool voltEFagy()
        {
            if (homerseklet < 0)
                return true;
            else
                return false;
        }

        public Meres(string fajlsor)
        {
            string[] adatok = fajlsor.Split(' ');
            varos = adatok[0];
            homerseklet = Convert.ToDouble(adatok[1]);
        }

        public override string ToString()
        {
            return varos + " városban a hőmérséklet " + homerseklet + " Celsius volt.";
        }
    }
}
