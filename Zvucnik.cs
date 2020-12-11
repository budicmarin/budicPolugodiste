using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicPolugodiste
{
    class Zvucnik
    {
        string marka;
        string model;
        int snaga;
        string povezivost;
        string posebno=" ";

        public Zvucnik(string marka, string model, int snaga, string povezivost)
        {
            this.marka = marka;
            this.model = model;
            this.snaga = snaga;
            this.povezivost = povezivost;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Snaga { get => snaga; set => snaga = value; }
        public string Povezivost { get => povezivost; set => povezivost = value; }
        public string Posebno { get => posebno; set => posebno = value; }

        public override string ToString()
        {
            String Output = "" + marka + " " + model + " " + snaga + "W " + povezivost + " "+posebno;
            return Output;
        }

    }
}
