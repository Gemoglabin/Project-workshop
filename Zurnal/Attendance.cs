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
		public List<Template> Templates = new List<Template>();
		public List<Timetable> Timetables = new List<Timetable>();
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
			label1.Text = Convert.ToString(date1.ToString("dd.MM.yyyy"));
			button1.Enabled = true;
		}

        private void button1_Click(object sender, EventArgs e)
        {
		
		}

		private void Save_Time()
		{
			string g = "INSERT INTO timetable(name_gr, week_day, number_couple, name_couple, date) values('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + label1.Text + "')";
			db.ExecuteNonQuery("testir.db", g);
		}

		private void Save_Attend()
		{
			string time = @"SELECT * FROM timetable ORDER BY id_time DESC LIMIT 1";
			db.Execute<Timetable>("testir.db", time, ref Timetables);
			for (int i = 0; i < Timetables.Count; i++) {
				time = Convert.ToString(Timetables[i].Id_time);
			}
			for (int i = 0; i < (dataGridView1.RowCount); i++) {
				string s = @"SELECT * FROM student WHERE fio = '"+ Convert.ToString(dataGridView1.Rows[i].Cells[0].Value)+ "'";
				db.Execute<Student>("testir.db", s, ref Students);
				for (int j = 0; j < Students.Count; j++) {
					textBox5.Text = Convert.ToString(Students[j].id_stud);
				}
				string mark = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
				if (mark == "") { mark = "0"; }
				string save = "INSERT INTO visit(id_stud, id_time, mark) values('" + textBox5.Text + "', '" + time + "', '" + mark + "')";
				db.ExecuteNonQuery("testir.db", save);
				Students.Clear();
			}
			MessageBox.Show("Збережено", "", MessageBoxButtons.OK);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Save_Time();
			Save_Attend();
			button1.Enabled = false;
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 boun = new Form1();
			boun.Show();
		}
	}
}