using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zurnal
{
	public partial class Attendance : Form
	{
		public Attendance()
		{
			InitializeComponent();
		}

        public List<Student> Students = new List<Student>();
        ClassDataBase db = new ClassDataBase();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Attendance_Load(object sender, EventArgs e)
		{
            string s = @"SELECT * FROM student WHERE name_gr = '"+textBox1.Text+"';";
            db.Execute<Student>("testir.db", s, ref Students);
            for (int i = 0; i < Students.Count; i++)
			{
				dataGridView1.Rows.Add(Convert.ToString(Students[i].fio));
				
				
            }
			//for (int j = 0; j < 3; j++)
			//{
			//	Column2.Items.Add(j);
			//}
		}

		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}
	}
}
