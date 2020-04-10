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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string data)
        {
            InitializeComponent();
        }

        public List<Template> Templates = new List<Template>();
        public List<Timetable> Timetables = new List<Timetable>();
        ClassDataBase db = new ClassDataBase();

        public string name_gr;
        public string name_couple;
        public string week_day;
        public string number_couple;

        private void InputGroup()
        {
            string z = @"SELECT * FROM template GROUP BY name_gr";
            db.Execute<Template>("testir.db", z, ref Templates);
            for (int i = 0; i < Templates.Count; i++)
            {
                if (!(comboBox1.Items.Contains(Templates[i].name_gr)) && Templates[i].name_gr != "")
                {
                    comboBox1.Items.Add(Templates[i].name_gr);
                }
            }
            comboBox1.Text = name_gr;
        }

        private void InputCouple()
        {
            string m = @"SELECT * FROM template GROUP BY name_couple";
            db.Execute<Template>("testir.db", m, ref Templates);
            for (int i = 0; i < Templates.Count; i++)
            {
                if (!(comboBox2.Items.Contains(Templates[i].name_couple)) && Templates[i].name_couple != "")
                {
                    comboBox2.Items.Add(Templates[i].name_couple);
                }
            }
            comboBox2.Text = name_couple;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InputGroup();
            InputCouple();
        }
        string datetest;
        string timetest;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            datetest = Convert.ToString(date1.ToString("yyyy-MM-dd"));
            if (checkBox1.Checked)
            {
                Timetables.Clear();
                string checkIdTime = @"SELECT * FROM timetable WHERE date = '" + datetest + "' AND number_couple = '" + number_couple + "'";
                db.Execute<Timetable>("testir.db", checkIdTime, ref Timetables);
                for (int i = 0; i < Timetables.Count; i++)
                {
                    timetest = Convert.ToString(Timetables[i].Id_time);
                }
                if(timetest != "")
                {
                    if(MessageBox.Show("Бажаєте видалити збережену пару?", "Видалення існуючої пари", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes){

                        string delvisit = "DELETE FROM visit WHERE id_time = '" + timetest + "' ";
                        db.ExecuteNonQuery("testir.db", delvisit);
                        string deltime = "DELETE FROM timetable WHERE id_time = '" + timetest + "' ";
                        db.ExecuteNonQuery("testir.db", deltime);
                    }
                    timetest = "";
                }
                
                this.Hide();
                Form1 boun = new Form1();
                boun.Show();
            }
            else
            {
                if (comboBox1.Text!="" || comboBox2.Text!="")
                {
                    Attendance atten = new Attendance();
                    atten.name_gr = comboBox1.Text;
                    atten.name_couple = comboBox2.Text;
                    atten.week_day = week_day;
                    atten.number_couple = number_couple;
                    atten.Show();
                    this.Hide();
                    Templates.Clear();
                }
                else
                {
                    MessageBox.Show("Заполните поля");
                }
                
            }
            
        }

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }

        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 boun = new Form1();
			boun.Show();
		}

		private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
	}
}
