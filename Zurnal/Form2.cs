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
            this.textBox1.Text = data;
            this.textBox2.Text = data;
        }

        public List<Template> Templates = new List<Template>();
        ClassDataBase db = new ClassDataBase();

        private void InputGroup()
        {
            string z = @"SELECT * FROM template GROUP BY name_gr";
            db.Execute<Template>("testir.db", z, ref Templates);
            for (int i = 0; i < Templates.Count; i++)
            {
                if (!(comboBox1.Items.Contains(Templates[i].name_gr)))
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
                if (!(comboBox2.Items.Contains(Templates[i].name_couple)))
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
            
            
            Attendance f = new Attendance();
            f.textBox1.Text = textBox1.Text;
            f.textBox2.Text = textBox2.Text;
            f.ShowDialog();
            Templates.Clear();
        }
    }
}
