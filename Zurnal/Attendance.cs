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

		public string name_gr;
		public string name_couple;
		public string week_day;
		public string number_couple;

		private void DataGridComboboxSetDefault()
		{
			for (int i = 0; i < (dataGridView1.RowCount); i++)
			{
				dataGridView1.Rows[i].Cells[1].Value = 0;
			}
		}

		private void Attendance_Load(object sender, EventArgs e)
		{

			string s = @"SELECT * FROM student WHERE name_gr = '" + name_gr + "';";
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
			currentDay.Text = Convert.ToString(date1.ToString("yyyy-MM-dd"));

			DataGridComboboxSetDefault();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Save_Attend();
		}

		string studentID;
		string timeID = "";

		private void Save_Attend()
		{
			string ifTime = @"SELECT * FROM timetable WHERE date = '" + currentDay.Text + "' AND number_couple = '" + number_couple + "' GROUP BY id_time";
			db.Execute<Timetable>("testir.db", ifTime, ref Timetables);
			for (int i = 0; i < Timetables.Count; i++)
			{
				timeID = Convert.ToString(Timetables[i].Id_time);
			}
			if (timeID == "")
			{
				string setTime = "INSERT INTO timetable(name_gr, week_day, number_couple, name_couple, date) values('" + name_gr + "', '" + week_day + "', '" + number_couple + "', '" + name_couple + "', '" + currentDay.Text + "')";
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
						studentID = Convert.ToString(Students[j].id_stud);
					}
					string mark = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
					if (mark == "") { mark = "0"; }
					string save = "INSERT INTO visit(id_stud, id_time, mark) values('" + studentID + "', '" + getTime + "', '" + mark + "')";
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
							studentID = Convert.ToString(Students[j].id_stud);
						}
						string mark = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
						if (mark == "") { mark = "0"; }
						string save = "UPDATE visit SET mark = '" + mark + "' WHERE id_time = '" + timeID + "' AND id_stud = '" + studentID + "'";
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