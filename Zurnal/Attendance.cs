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

		private void DataGridComboboxSetDefault()
		{
			for (int i = 0; i < (dataGridView1.RowCount); i++)
			{
				dataGridView1.Rows[i].Cells[1].Value = 0;
			}

		}

		private void Attendance_Load(object sender, EventArgs e)
		{

			string s = @"SELECT * FROM student WHERE name_gr = '" + textBox1.Text + "';";
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
			label1.Text = Convert.ToString(date1.ToString("yyyy-MM-dd"));

			DataGridComboboxSetDefault();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Save_Attend();
		}

		private void Save_Attend()
		{
			string ifTime = @"SELECT * FROM timetable WHERE date = '" + label1.Text + "' AND number_couple = '" + textBox4.Text + "' GROUP BY id_time";
			db.Execute<Timetable>("testir.db", ifTime, ref Timetables);
			for (int i = 0; i < Timetables.Count; i++)
			{
				time.Text = Convert.ToString(Timetables[i].Id_time);
			}
			if (time.Text == "")
			{
				string setTime = "INSERT INTO timetable(name_gr, week_day, number_couple, name_couple, date) values('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + label1.Text + "')";
				db.ExecuteNonQuery("testir.db", setTime);
				string getTime = @"SELECT * FROM timetable ORDER BY id_time DESC LIMIT 1";
				db.Execute<Timetable>("testir.db", getTime, ref Timetables);
				for (int i = 0; i < Timetables.Count; i++)
				{
					getTime = Convert.ToString(Timetables[i].Id_time);
				}
				for (int i = 0; i < (dataGridView1.RowCount); i++)
				{
					string s = @"SELECT * FROM student WHERE fio = '" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + "'";
					db.Execute<Student>("testir.db", s, ref Students);
					for (int j = 0; j < Students.Count; j++)
					{
						textBox5.Text = Convert.ToString(Students[j].id_stud);
					}
					string mark = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
					if (mark == "") { mark = "0"; }
					string save = "INSERT INTO visit(id_stud, id_time, mark) values('" + textBox5.Text + "', '" + getTime + "', '" + mark + "')";
					db.ExecuteNonQuery("testir.db", save);
					Students.Clear();
				}
				MessageBox.Show("Збережено", "", MessageBoxButtons.OK);
			}

			else {
				if (MessageBox.Show("Бажаєте змінити збережені дані?", "Оновлення відвідування", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					for (int i = 0; i < (dataGridView1.RowCount); i++)
					{
						string s = @"SELECT * FROM student WHERE fio = '" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + "'";
						db.Execute<Student>("testir.db", s, ref Students);
						for (int j = 0; j < Students.Count; j++)
						{
							textBox5.Text = Convert.ToString(Students[j].id_stud);
						}
						string mark = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
						if (mark == "") { mark = "0"; }
						string save = "UPDATE visit SET mark = '" + mark + "' WHERE id_time = '" + time.Text + "' AND id_stud = '" + textBox5.Text + "'";
						db.ExecuteNonQuery("testir.db", save);
						Students.Clear();
					}
					MessageBox.Show("Збережено", "", MessageBoxButtons.OK);
				}
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 boun = new Form1();
			boun.Show();
		}

		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}
	}
}