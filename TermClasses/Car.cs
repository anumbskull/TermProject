using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermClasses
{
    public class Car
    {
        private int carid;

        public int Carid
        {
            get { return carid; }
            set { carid = value; }
        }
        private int agencyid;

        public int Agencyid
        {
            get { return agencyid; }
            set { agencyid = value; }
        }
        private string carmake;

        public string Carmake
        {
            get { return carmake; }
            set { carmake = value; }
        }
        private string carmodel;

        public string Carmodel
        {
            get { return carmodel; }
            set { carmodel = value; }
        }
    }
}
