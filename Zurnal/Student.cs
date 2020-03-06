using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurnal

{
    public class Student
    {


        private int Id_stud;
        private string Fio;
        private string Name_gr;


        public int id_stud
        {
            set { Id_stud = value; }
            get { return Id_stud; }
        }
        public string fio
        {
            set { Fio = value; }
            get { return Fio; }
        }
        public string name_gr
        {
            set { Name_gr = value; }
            get { return Name_gr; }
        }


        public Student() { id_stud = -1; fio = ""; }
        public Student(int id_stud, string fio, string name_gr)
        { id_stud = -1; this.id_stud = id_stud; this.fio = fio; this.name_gr = name_gr; }
        public Student(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                id_stud = Convert.ToInt32(val[0]);
                fio = val[1];
                name_gr = val[2];

            }
        }
    }
}