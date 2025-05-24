using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetWPF
{
    // 2. feladat (osztály készítése)
    public class Cellovo
    {
        public string Nev { get; private set; }

        public int Elsoloves { get; private set; }

        public int Masodikloves {  get; private set; }

        public int Harmadikloves { get; private set; }

        public int Negyedikloves { get; private set; }

        //3. és 4. feladat (konstruktor készítése)
        public Cellovo(string line)
        {
            string[] darabok = line.Split(';');
            Nev = darabok[0];
            Elsoloves = Convert.ToInt32(darabok[1]);
            Masodikloves = Convert.ToInt32(darabok[2]);
            Harmadikloves = Convert.ToInt32(darabok[3]);
            Negyedikloves = Convert.ToInt32(darabok[4]);
        }

        // 8. feladat (osztály függvény készítése)
        public int Legnagyobb()
        {
            int max = Elsoloves;
            if (Masodikloves > max) { max = Masodikloves; }
            if (Harmadikloves > max) { max = Harmadikloves; }
            if (Negyedikloves > max) { max = Negyedikloves; }
            return max;
        }

        public int Atlag()
        {
            int atlag = (Elsoloves + Masodikloves + Harmadikloves + Negyedikloves) / 4;
            return atlag;
        }

        public override string ToString()
        {
            return $"{Nev} {Elsoloves} {Masodikloves} {Harmadikloves} {Negyedikloves}";
        }
    }
}
