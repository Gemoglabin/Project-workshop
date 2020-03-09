using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurnal
{
    public class Template
    {

        private string Name_gr;
        private string Week_day;
        private int Number_couple;
        private string Name_couple;

        public string name_gr
        {
            set { Name_gr = value; }
            get { return Name_gr; }
        }

        public string week_day
        {
            set { Week_day = value; }
            get { return Week_day; }
        }

        public int number_couple
        {
            set { Number_couple = value; }
            get { return Number_couple; }
        }
       
        public string name_couple
        {
            set { Name_couple = value; }
            get { return Name_couple; }
        }


        public Template() { number_couple = -1; name_couple = ""; }
        public Template(string name_gr, string week_day,int number_couple,string name_couple)
        {  this.name_gr = name_gr; this.week_day = week_day; number_couple = -1; this.number_couple = number_couple; this.name_couple = name_couple; }
        public Template(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                 name_gr = val[0];
                 week_day = val[1];
                 number_couple = Convert.ToInt32(val[2]);
                 name_couple = val[3];
             

            }
        }
    }
}
//Приветули