using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurnal
{
   public class backDate
    {
        private string Fio;
        private int Mark;
        private string Reason;


        public string fio
        {
            set { Fio = value; }
            get { return Fio; }
        }
        public int mark
        {
            set { Mark = value; }
            get { return Mark; }
        }
        public string reason
        {
            set { Reason = value; }
            get { return Reason; }
        }


        public backDate() { mark = -1; reason = ""; fio = ""; }
        public backDate(int mark, string fio, string reason)
        { this.mark = mark; this.fio = fio; this.reason = reason; }
        public backDate(string info)
        {
            if (info.Length > 0)
            {
                string[] val = info.Split('|');
                mark = Convert.ToInt32(val[1]);
                fio = val[0];
                reason = val[2];

            }
        }
    }
}
