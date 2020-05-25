using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurnal
{
   public class ZvitExcelV2
    {
        private int Id_stud;
        private string Fio;
        private int Mark;
        private int Number_couple;
        private string Name_couple;
        private string Date;
        private int Id_time;

        public int id_stud
        {
            set { Id_stud = value; }
            get { return Id_stud; }
        }
        public int id_time
        {
            set { Id_time = value; }
            get { return Id_time; }
        }
        public string fio
        {
            set { Fio = value; }
            get { return Fio; }
        }
        public string date
        {
            set { Date = value; }
            get { return Date; }
        }

        public string name_couple
        {
            set { Name_couple = value; }
            get { return Name_couple; }
        }
        public int mark
        {
            set { Mark = value; }
            get { return Mark; }
        }
        public int number_couple
        {
            set { Number_couple = value; }
            get { return Number_couple; }
        }


        public ZvitExcelV2() { id_stud = -1;mark = -1;number_couple = -1; fio = ""; date = ""; name_couple = ""; id_time = -1; }
        public ZvitExcelV2(int id_stud, string fio, string date, string name_couple, int mark, int number_couple, int id_time)
        {  this.id_stud = id_stud; this.fio = fio; this.date = date; this.name_couple = name_couple;this.mark = mark; this.number_couple = number_couple; this.id_time = id_time; }
        public ZvitExcelV2(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                id_stud = Convert.ToInt32(val[0]);
                fio = val[1];
                mark = Convert.ToInt32(val[2]);
                number_couple = Convert.ToInt32(val[3]);
                name_couple = val[4];
                date = val[5];
                id_time = Convert.ToInt32(val[6]);




            }
        }
    }
}
