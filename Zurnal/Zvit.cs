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
    public partial class Zvit : Form
    {
        public Zvit()
        {
            InitializeComponent();
        }

        public List<Template> Templates = new List<Template>();

        public List<Report> Reports = new List<Report>();

        ClassDataBase db = new ClassDataBase();

        private void InputGroup()
        {
            string z = @"SELECT * FROM template GROUP BY name_gr";
            db.Execute<Template>("testir.db", z, ref Templates);
            for (int i = 0; i < Templates.Count; i++)
            {
                if (!(cmbgroup.Items.Contains(Templates[i].name_gr)))
                {
                    cmbgroup.Items.Add(Templates[i].name_gr);
                }
            }
            cmbgroup.Text = textBox3.Text;
        }

        private void розкладToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 garant = new Form1();
            garant.ShowDialog();
        }

        private void Zvit_Load(object sender, EventArgs e)
        {
            InputGroup();
        }

		private void розкладToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void cmbgroup_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void DropDownList(object sender, EventArgs e)
		{

		}

		private void cmbgroup_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 boun = new Form1();
			boun.Show();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and v.id_time=t.id_time and t.name_gr = 'П-62' and t.date BETWEEN date('now','weekday 0', '-14 day') and date('now','weekday 0','-7 day') GROUP BY s.fio ORDER BY s.fio ASC;";
                db.Execute<Report>("testir.db", z, ref Reports);
                for (int i = 0; i < Reports.Count; i++)
                {
                    dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                }
                this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                Reports.Clear();
            }
            if (radioButton2.Checked)
            {
                string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and v.id_time=t.id_time and t.name_gr = 'П-62' and t.date BETWEEN date('now','start of month','-1 month') and date('now','start of month','-1 day') GROUP BY s.fio ORDER BY s.fio ASC;";
                db.Execute<Report>("testir.db", z, ref Reports);
                for (int i = 0; i < Reports.Count; i++)
                {
                    dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                }
                this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                Reports.Clear();
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Я хз как зделать за семестр, так как семестр после зимы стартует по разному, а если брать за все время то туда могут попасть и другие семестры если таковые будут");
            }
            if (radioButton4.Checked)
            {
                dataGridView1.Rows.Clear();
                string datepicker1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string datepicker2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and v.id_time=t.id_time and t.name_gr = '" + cmbgroup.Text + "' and t.date BETWEEN '" + datepicker1 + "' and '" + datepicker2 + "' GROUP BY s.fio ORDER BY s.fio ASC;";
                db.Execute<Report>("testir.db", z, ref Reports);
                for (int i = 0; i < Reports.Count; i++)
                {
                    dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                }
                this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                Reports.Clear();
            }



        }
    }
}
