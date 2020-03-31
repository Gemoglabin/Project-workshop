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
            //this.textBox1.Text = data;
            //this.textBox2.Text = data;
        }

        public List<Template> Templates = new List<Template>();
        ClassDataBase db = new ClassDataBase();

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
            comboBox1.Text = textBox1.Text;
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
            comboBox2.Text = textBox2.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InputGroup();
            InputCouple();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                MessageBox.Show("Тут нужно зделать сохранение  в базу пустой пары!!!");
            }
            else
            {
                Attendance atten = new Attendance();
                atten.textBox1.Text = textBox1.Text;
                atten.textBox2.Text = textBox2.Text;
                atten.textBox3.Text = textBox3.Text;
                atten.textBox4.Text = textBox4.Text;
                atten.Show();
                this.Hide();
                Templates.Clear();
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
