using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using HomersekletekProjekt.Modell;

namespace HomersekletekProjekt.Tarolo
{
    class Meresek
    {
        List<Meres> meresek;

        public Meresek()
        {
            meresek = new List<Meres>();
        }

        public void beolvas()
        {
            StreamReader sr = new StreamReader("homerseklet.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Meres m = new Meres(sor);
                meresek.Add(m);
            }
        }

        public int meresekSzama()
        {
            return meresek.Count();
        }

        public double maxHomerseklet()
        {
            return meresek.Max(x=>x.Homerseklet);
        }

        public int getFagyosNapokSzama()
        {
            return meresek.Count(x => x.voltEFagy());
        }

        public void kiirHomerseklet(int n)
        {
            Console.WriteLine(meresek.ElementAt(n));
        }

        public double varosAtlaghomerseklete(string varos)
        {
            List<Meres> keresettVarosMeresei = new List<Meres>();
            keresettVarosMeresei = meresek.FindAll(x => x.Varos == varos);
            return keresettVarosMeresei.Average(x => x.Homerseklet);
        }

        public int getVarosokSzama()
        {
            HashSet<string> varosok = new HashSet<string>();
            foreach (Meres m in meresek)
            {
                varosok.Add(m.Varos);
            }
            return varosok.Count;

        }
    }
}
