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

			DateTime date1 = new DateTime();
			date1 = DateTime.Today;
			label1.Text = Convert.ToString(date1.ToShortDateString());
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form1 boun = new Form1();
			boun.Show();
		}

		private void Save_Attend()
		{
			string g = "INSERT INTO timetable(name_gr, week_day, number_couple, name_couple, date) values('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + label1.Text + "')";
			int n = db.ExecuteNonQuery("testir.db", g);
			if (n != 0)
			{ MessageBox.Show("Збережено", "Information", MessageBoxButtons.OK); }
			else MessageBox.Show("Помилка");
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Save_Attend();
		}
	}
}
