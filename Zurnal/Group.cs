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

		private void Group_Load(object sender, EventArgs e)
		{
			string s = @"SELECT * FROM student GROUP BY name_gr;";
			db.Execute<Student>("testir.db", s, ref Students);
			for (int i = 0; i < Students.Count; i++)
			{
				cbGroup.Items.Add(Students[i].name_gr);
			}
			if (Students.Count!=0)
			{
				cbGroup.SelectedItem = Students[0].name_gr;
			}
			
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
			string s = @"SELECT * FROM student WHERE name_gr='" + cbGroup.Text + "';";
			db.Execute<Student>("testir.db", s, ref Students);
			for (int i = 0; i < Students.Count; i++)
			{
				dataGridView1.Rows.Add(Students[i].fio);
			}
			Students.Clear();
		}

		private void back_Click(object sender, EventArgs e)
		{
			bool check = true;
			for (int i = 0; i < cbGroup.Items.Count; i++)
			{
				Students.Clear();
				string s = @"SELECT * FROM student WHERE name_gr='" + cbGroup.Items[i] + "';";
				db.Execute<Student>("testir.db", s, ref Students);
				if (Students.Count == 0)
				{
					check = false;
					MessageBox.Show("Група " + cbGroup.Items[i] + " порожня. Щоб вийти потрібно додати хоча б одного студента");
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

		private void delGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (MessageBox.Show("Ви впевнені?", "Видалення групи", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				string delG = "DELETE FROM student WHERE name_gr = '" + cbGroup.Text + "' ";
				db.ExecuteNonQuery("testir.db", delG);
				cbGroup.Items.Clear();
				string s = @"SELECT * FROM student GROUP BY name_gr;";
				db.Execute<Student>("testir.db", s, ref Students);
				for (int i = 0; i < Students.Count; i++)
				{
					cbGroup.Items.Add(Students[i].name_gr);
				}
				if (Students.Count != 0)
				{
					cbGroup.SelectedItem = Students[0].name_gr;
				}
				Students.Clear();
				ShowDatagridview();
			}
		}

		private void delStud_Click(object sender, EventArgs e)
		{
			Students.Clear();
			string s = @"SELECT * FROM student WHERE name_gr='" + cbGroup.SelectedItem + "';";
			db.Execute<Student>("testir.db", s, ref Students);
			if (Students.Count == 0)
			{
				MessageBox.Show("Група " + cbGroup.SelectedItem + " порожня. Видалення неможливе");
			}
			else
			{
				if (MessageBox.Show("Ви впевнені?", "Видалення студента",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button1) == DialogResult.Yes)
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

		private void AddFIO_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "")
			{
				string s = @"SELECT * FROM student WHERE fio='" + textBox2.Text + "';";
				db.Execute<Student>("testir.db", s, ref Students);
				if (Students.Count == 0)
				{
					string g = "INSERT INTO student(fio, name_gr) values('" + textBox2.Text + "', '" + cbGroup.SelectedItem + "')";
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
			Students.Clear();
			ShowDatagridview();
		}

		private void AddGroup_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				string s = @"SELECT * FROM student WHERE name_gr='" + textBox1.Text + "';";
				db.Execute<Student>("testir.db", s, ref Students);
				if (Students.Count == 0)
				{
					cbGroup.Items.Add(textBox1.Text);
					cbGroup.SelectedItem = textBox1.Text;
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
			Students.Clear();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ChangeStud CS = new ChangeStud();
			CS.studFIO = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			CS.group = cbGroup.Text;
			CS.Show();
			this.Hide();

		}

	}
}
