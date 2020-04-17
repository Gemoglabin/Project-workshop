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
    public partial class TemplateConfirm : Form
    {
        public TemplateConfirm()
        {
            InitializeComponent();
        }
        public string name_gr;
        public string name_couple;
        public string week_day;
        public string number_couple;

      


        public List<Template> Templates = new List<Template>();
        public List<Timetable> Timetables = new List<Timetable>();
        public List<Student> Students = new List<Student>();
        ClassDataBase db = new ClassDataBase();


        private void InputGroup()
        {
            string z = @"SELECT * FROM student GROUP BY name_gr";
            db.Execute<Student>("testir.db", z, ref Students);
            for (int i = 0; i < Students.Count; i++)
            {
                if (!(comboBox1.Items.Contains(Students[i].name_gr)) && Students[i].name_gr != "")
                {
                    comboBox1.Items.Add(Students[i].name_gr);
                }
            }
            comboBox1.Text = name_gr; ;
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

        private void TemplateConfirm_Load(object sender, EventArgs e)
        {

            InputGroup();
            InputCouple();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            bool flag=true;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                if (comboBox2.Items[i].ToString() == textBox1.Text)
                {
                    flag = false;
                }
            }
            if (textBox1.Text != "")
            {
                if (flag)
                {
                    comboBox2.Items.Add(textBox1.Text);
                    comboBox2.SelectedItem = textBox1.Text;
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Предмет з такою назвою вже існує");
                }
                
            } 
            else
            {
                MessageBox.Show("Введіть назву предмету");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == name_gr && comboBox2.Text.ToString() == name_couple && checkBox1.Checked == false)
            {
                MessageBox.Show("Вы не внесли жодних змін");
            }
            else
            {
                if (checkBox1.Checked)
                {
                    if (name_gr == "" && name_couple == "")
                    {
                        MessageBox.Show("Вы не внесли жодних змін");
                    }
                    else
                    {
                        string save = "UPDATE template SET name_gr = '', name_couple='' WHERE week_day = '" + week_day + "' and number_couple = " + Convert.ToInt32(number_couple) + ";";
                        db.ExecuteNonQuery("testir.db", save);
                        MessageBox.Show("Збережено");
                       
                    }
                    
                }
                else
                {
                    if (comboBox1.Text.ToString()!="" && comboBox2.Text.ToString()!="")
                    {
                        string save = "UPDATE template SET name_gr = '" + comboBox1.SelectedItem + "', name_couple='" + comboBox2.SelectedItem + "' WHERE week_day = '" + week_day + "' and number_couple = " + Convert.ToInt32(number_couple) + ";";
                        db.ExecuteNonQuery("testir.db", save);
                        MessageBox.Show("Збережено");
                        this.Hide();
                        TemplateForm boun = new TemplateForm();
                        boun.Show();
                    }
                    else
                    {
                        MessageBox.Show("Заповніть обидва поля");
                    }
                    
                }
                
            }
            
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

		private void label8_Click(object sender, EventArgs e)
		{
			this.Hide();
			TemplateForm boun = new TemplateForm();
			boun.Show();
		}
	}
}
