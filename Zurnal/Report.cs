using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurnal
{
    public class Report
    {
        private string Fio;
        private int Na;


        public string fio
        {
            set { Fio = value; }
            get { return Fio; }
        }

        public int na
        {
            set { Na = value; }
            get { return Na; }
        }

        public Report() { fio = ""; na = 0; }
        public Report(string fio, int na)
        { this.fio = fio;  this.na = na;  }
        public Report(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                fio = val[0];
                na = Convert.ToInt32(val[1]);


            }
        }
    }
}
