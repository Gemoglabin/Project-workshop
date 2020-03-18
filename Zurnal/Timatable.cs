using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurnal
{
    public class Timetable
    {
        private int id_time;
        private string name_gr_t;
        private string week_day_t;
        private int number_couple_t;
        private string name_couple_t;
        private string date_t;

        public int Id_time
        {
            set { id_time = value; }
            get { return id_time; }
        }

        public string Name_gr_t
        {
            set { name_gr_t = value; }
            get { return name_gr_t; }
        }

        public string Week_day_t
        {
            set { week_day_t = value; }
            get { return week_day_t; }
        }

        public int Number_couple_t
        {
            set { number_couple_t = value; }
            get { return number_couple_t; }
        }

        public string Name_couple_t
        {
            set { name_couple_t = value; }
            get { return name_couple_t; }
        }

        public string Date_t
        {
            set { date_t = value; }
            get { return date_t; }
        }

        public Timetable() { id_time = -1; number_couple_t = -1; name_couple_t = ""; }
        public Timetable(int id_time, string name_gr_t, string week_day_t, int number_couple_t, string name_couple_t, string date_t)
        { id_time = -1; this.id_time = id_time; this.name_gr_t = name_gr_t; this.week_day_t = week_day_t; number_couple_t = -1; this.number_couple_t = number_couple_t; this.name_couple_t = name_couple_t; this.date_t = date_t; }
        public Timetable(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                id_time = Convert.ToInt32(val[0]);
                name_gr_t = val[1];
                week_day_t = val[2];
                number_couple_t = Convert.ToInt32(val[3]);
                name_couple_t = val[4];
                date_t = Convert.ToString(val[5]);
            }
        }
    }
}
