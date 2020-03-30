﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Template> Templates = new List<Template>();
        public List<Student> Students = new List<Student>();

        ClassDataBase db = new ClassDataBase();

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = @"SELECT * from template where week_day='ПН';";
            db.Execute<Template>("testir.db", s, ref Templates);
            for (int i = 0; i < 5; i++)
            {


                string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + "  " + Convert.ToString(Templates[i].name_couple);

                if (couple_name_and_group == "  ")
                {
                    dataGridView1.Rows.Add("Окно");
                }
                else
                {
                    dataGridView1.Rows.Add(couple_name_and_group);
                }

            }

            Templates.Clear();

            s = @"SELECT * from template where week_day='ВТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            for (int i = 0; i < 5; i++)
            {
                string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + "  " + Convert.ToString(Templates[i].name_couple);

                if (couple_name_and_group == "  ")
                {
                    dataGridView2.Rows.Add("Окно");
                }
                else
                {
                    dataGridView2.Rows.Add(couple_name_and_group);
                }
            }
            Templates.Clear();

            s = @"SELECT * from template where week_day='СР';";
            db.Execute<Template>("testir.db", s, ref Templates);
            for (int i = 0; i < 5; i++)
            {
                string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + "  " + Convert.ToString(Templates[i].name_couple);

                if (couple_name_and_group == "  ")
                {
                    dataGridView3.Rows.Add("Окно");
                }
                else
                {
                    dataGridView3.Rows.Add(couple_name_and_group);
                }
            }
            Templates.Clear();

            s = @"SELECT * from template where week_day='ЧТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            for (int i = 0; i < 5; i++)
            {
                string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + "  " + Convert.ToString(Templates[i].name_couple);

                if (couple_name_and_group == "  ")
                {
                    dataGridView4.Rows.Add("Окно");
                }
                else
                {
                    dataGridView4.Rows.Add(couple_name_and_group);
                }
            }
            Templates.Clear();

            s = @"SELECT * from template where week_day='ПТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            for (int i = 0; i < 5; i++)
            {
                string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + "  " + Convert.ToString(Templates[i].name_couple);

                if (couple_name_and_group == "  ")
                {
                    dataGridView5.Rows.Add("Окно");
                }
                else
                {
                    dataGridView5.Rows.Add(couple_name_and_group);
                }
            }
            Templates.Clear();
        }

        private void siguiruhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zvit garant = new Zvit();
            garant.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView1.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ПН';";
            db.Execute<Template>("testir.db", s, ref Templates);
            textBox1.Text = Templates[dataGridView1.CurrentRow.Index].name_gr;
            textBox2.Text = Templates[dataGridView1.CurrentRow.Index].name_couple;
            textBox3.Text = Templates[dataGridView1.CurrentRow.Index].week_day;
            textBox4.Text = Convert.ToString(Templates[dataGridView1.CurrentRow.Index].number_couple);
            Form2 f2 = new Form2();
            f2.textBox1.Text = textBox1.Text;
            f2.textBox2.Text = textBox2.Text;
            f2.textBox3.Text = textBox3.Text;
            f2.textBox4.Text = textBox4.Text;
            f2.ShowDialog();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView2.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ВТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            textBox1.Text = Templates[dataGridView2.CurrentRow.Index].name_gr;
            textBox2.Text = Templates[dataGridView2.CurrentRow.Index].name_couple;
            textBox3.Text = Templates[dataGridView1.CurrentRow.Index].week_day;
            textBox4.Text = Convert.ToString(Templates[dataGridView2.CurrentRow.Index].number_couple);
            Form2 f2 = new Form2();
            f2.textBox1.Text = textBox1.Text;
            f2.textBox2.Text = textBox2.Text;
            f2.textBox3.Text = textBox3.Text;
            f2.textBox4.Text = textBox4.Text;
            f2.ShowDialog();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView3.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'СР';";
            db.Execute<Template>("testir.db", s, ref Templates);
            textBox1.Text = Templates[dataGridView3.CurrentRow.Index].name_gr;
            textBox2.Text = Templates[dataGridView3.CurrentRow.Index].name_couple;
            textBox3.Text = Templates[dataGridView1.CurrentRow.Index].week_day;
            textBox4.Text = Convert.ToString(Templates[dataGridView3.CurrentRow.Index].number_couple);
            Form2 f2 = new Form2();
            f2.textBox1.Text = textBox1.Text;
            f2.textBox2.Text = textBox2.Text;
            f2.textBox3.Text = textBox3.Text;
            f2.textBox4.Text = textBox4.Text;
            f2.ShowDialog();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView4_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView4.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ЧТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            textBox1.Text = Templates[dataGridView4.CurrentRow.Index].name_gr;
            textBox2.Text = Templates[dataGridView4.CurrentRow.Index].name_couple;
            textBox3.Text = Templates[dataGridView1.CurrentRow.Index].week_day;
            textBox4.Text = Convert.ToString(Templates[dataGridView4.CurrentRow.Index].number_couple);
            Form2 f2 = new Form2();
            f2.textBox1.Text = textBox1.Text;
            f2.textBox2.Text = textBox2.Text;
            f2.textBox3.Text = textBox3.Text;
            f2.textBox4.Text = textBox4.Text;
            f2.ShowDialog();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView5.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ПТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            textBox1.Text = Templates[dataGridView5.CurrentRow.Index].name_gr;
            textBox2.Text = Templates[dataGridView5.CurrentRow.Index].name_couple;
            textBox3.Text = Templates[dataGridView1.CurrentRow.Index].week_day;
            textBox4.Text = Convert.ToString(Templates[dataGridView5.CurrentRow.Index].number_couple);
            Form2 f2 = new Form2();
            f2.textBox1.Text = textBox1.Text;
            f2.textBox2.Text = textBox2.Text;
            f2.textBox3.Text = textBox3.Text;
            f2.textBox4.Text = textBox4.Text;
            f2.ShowDialog();
            Templates.Clear();
            this.Hide();
        }

        private void jafhefuaegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zvit garant = new Zvit();
            garant.Show();
        }

        private void zdcjhdsguygsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group garant = new Group();
            garant.Show();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}