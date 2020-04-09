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
    public partial class Group : Form
    {

		public List<Student> Students = new List<Student>();

		ClassDataBase db = new ClassDataBase();



		public Group()
        {
            InitializeComponent();
        }

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void btnback_Click(object sender, EventArgs e)
		{

			
		}

		private void Group_Load(object sender, EventArgs e)
		{
			string s = @"SELECT * FROM student GROUP BY name_gr;";
			db.Execute<Student>("testir.db", s, ref Students);
			for (int i = 0; i < Students.Count; i++)
			{
				comboBox1.Items.Add(Students[i].name_gr);
			}
			comboBox1.SelectedItem = Students[0].name_gr;
			Students.Clear();
		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			ShowDatagridview();
		}

		private void ShowDatagridview()
		{
			dataGridView1.Rows.Clear();
			Students.Clear();
			string s = @"SELECT * FROM student WHERE name_gr='" + comboBox1.Text + "';";
			db.Execute<Student>("testir.db", s, ref Students);
			for (int i = 0; i < Students.Count; i++)
			{
				dataGridView1.Rows.Add(Students[i].fio);
			}
			Students.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				string s = @"SELECT * FROM student WHERE name_gr='" + textBox1.Text + "';";
				db.Execute<Student>("testir.db", s, ref Students);
				if (Students.Count==0)
				{
					comboBox1.Items.Add(textBox1.Text);
					comboBox1.SelectedItem = textBox1.Text;
				}
				else
				{
					MessageBox.Show("Така група вже існує");
				}
				Students.Clear();
			}
			else
			{
				MessageBox.Show("Поле \"Група\" порожнє");
			}
			textBox1.Text = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "")
			{
				string s = @"SELECT * FROM student WHERE fio='" + textBox2.Text + "';";
				db.Execute<Student>("testir.db", s, ref Students);
				if (Students.Count == 0)
				{
					string g = "INSERT INTO student(fio, name_gr) values('" + textBox2.Text + "', '" + comboBox1.SelectedItem + "')";
					db.ExecuteNonQuery("testir.db", g);
				}
				else
				{
					MessageBox.Show("Такий студент вже існує");
				}
				Students.Clear();
			}
			else
			{
				MessageBox.Show("Поле \"ПІБ\" порожнє");
			}
			textBox2.Text = "";
			ShowDatagridview();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			Students.Clear();
			string s = @"SELECT * FROM student WHERE name_gr='" + comboBox1.SelectedItem + "';";
			db.Execute<Student>("testir.db", s, ref Students);
			if (Students.Count == 0)
			{
				MessageBox.Show("Група " + comboBox1.SelectedItem + " порожня. Видалення неможливе");
			}
			else
			{
				if (MessageBox.Show("Ви впевнені?", "Видалення студента",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button1) == DialogResult.Yes )
				{
					int ind = dataGridView1.SelectedCells[0].RowIndex;
					string fioStud = dataGridView1.CurrentCell.Value.ToString();
					string delS = "DELETE FROM student WHERE fio = '" + fioStud + "' ";
					db.ExecuteNonQuery("testir.db", delS);
					dataGridView1.Rows.RemoveAt(ind);
				}
			}
			Students.Clear();
			

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (MessageBox.Show("Ви впевнені?", "Видалення групи",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question,
			MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				string delG = "DELETE FROM student WHERE name_gr = '" + comboBox1.Text + "' ";
				db.ExecuteNonQuery("testir.db", delG);
				comboBox1.Items.Clear();
				string s = @"SELECT * FROM student GROUP BY name_gr;";
				db.Execute<Student>("testir.db", s, ref Students);
				for (int i = 0; i < Students.Count; i++)
				{
					comboBox1.Items.Add(Students[i].name_gr);
				}
				comboBox1.SelectedItem = Students[0].name_gr;
				Students.Clear();
				ShowDatagridview();
			}

		}

		private void Group_FormClosing(object sender, FormClosingEventArgs e)
		{
			//if (MessageBox.Show("Бажаєте вийти з програми?", "Завершення роботи з програмою",
			//MessageBoxButtons.YesNo,
			//MessageBoxIcon.Question,
			//MessageBoxDefaultButton.Button1) != DialogResult.Yes)
			//{
			//	e.Cancel = true;
			//}
		}

		private void label5_Click(object sender, EventArgs e)
		{

			bool check = true;
			for (int i = 0; i < comboBox1.Items.Count; i++)
			{
				Students.Clear();
				string s = @"SELECT * FROM student WHERE name_gr='" + comboBox1.Items[i] + "';";
				db.Execute<Student>("testir.db", s, ref Students);
				if (Students.Count == 0)
				{
					check = false;
					MessageBox.Show("Група " + comboBox1.Items[i] + " порожня. Щоб вийти потрібно додати хоча б одного студента");
				}
			}
			Students.Clear();
			if (check)
			{
				this.Hide();
				Form1 boun = new Form1();
				boun.Show();
			}
		}
	}
}
