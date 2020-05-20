using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void Weekend()
        {

            label1.Visible = true;

        }

        //private void testWrite()
        //{
        //    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 1);
        //}
        private void FirstLoadOnly()
        {
            string s = @"SELECT * from template;";
            db.Execute<Template>("testir.db", s, ref Templates);
            if (Templates.Count == 0)
            {
               
                    for (int j = 1; j < 6; j++)
                    {
                        Templates.Clear();
                        string setTime = "INSERT  into template(week_day, number_couple) VALUES ('ПН','"+j+"');";
                        db.ExecuteNonQuery("testir.db", setTime);
                        Templates.Clear();
                        
                        
                    }
                    for (int j = 1; j < 6; j++)
                    {
                        Templates.Clear();
                        string setTime = "INSERT  into template(week_day, number_couple) VALUES ('ВТ','" + j + "');";
                        db.ExecuteNonQuery("testir.db", setTime);
                        
                    }
                    for (int j = 1; j < 6; j++)
                    {
                        Templates.Clear();
                        string setTime = "INSERT  into template(week_day, number_couple) VALUES ('СР','" + j + "');";
                        db.ExecuteNonQuery("testir.db", setTime);
                        
                    }
                    for (int j = 1; j < 6; j++)
                    {
                        Templates.Clear();
                        string setTime = "INSERT  into template(week_day, number_couple) VALUES ('ЧТ','" + j + "');";
                        db.ExecuteNonQuery("testir.db", setTime);
                        
                    }
                    for (int j = 1; j < 6; j++)
                    {
                        Templates.Clear();
                        string setTime = "INSERT  into template(week_day, number_couple) VALUES ('ПТ','" + j + "');";
                        db.ExecuteNonQuery("testir.db", setTime);
                        
                    }

                
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FirstLoadOnly();
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            dataGridView3.Enabled = false;
            dataGridView4.Enabled = false;
            dataGridView5.Enabled = false;

           

            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            string dayofweek = date1.DayOfWeek.ToString();

            switch (dayofweek)
            {
                case "Monday": { dataGridView1.Enabled = true; break; }
                case "Tuesday": { dataGridView2.Enabled = true; break; }
                case "Wednesday": { dataGridView3.Enabled = true; break; }
                case "Thursday": { dataGridView4.Enabled = true; break; }
                case "Friday": { dataGridView5.Enabled = true; break; }
                default: Weekend(); break;
            }
            Templates.Clear();
            string n = @"SELECT * from template;";
            db.Execute<Template>("testir.db", n, ref Templates);
            if (Templates.Count != 0)
            {
                string s = @"SELECT * from template where week_day='ПН';";
                db.Execute<Template>("testir.db", s, ref Templates);
                for (int i = 0; i < 5; i++)
                {


                    string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + " " + Convert.ToString(Templates[i].name_couple);

                    if (couple_name_and_group == " ")
                    {
                        dataGridView1.Rows.Add(" Вікно");
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
                    string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + " " + Convert.ToString(Templates[i].name_couple);

                    if (couple_name_and_group == " ")
                    {
                        dataGridView2.Rows.Add(" Вікно");
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
                    string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + " " + Convert.ToString(Templates[i].name_couple);

                    if (couple_name_and_group == " ")
                    {
                        dataGridView3.Rows.Add(" Вікно");
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
                    string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + " " + Convert.ToString(Templates[i].name_couple);

                    if (couple_name_and_group == " ")
                    {
                        dataGridView4.Rows.Add(" Вікно");
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
                    string couple_name_and_group = Convert.ToString(Templates[i].name_gr) + " " + Convert.ToString(Templates[i].name_couple);

                    if (couple_name_and_group == " ")
                    {
                        dataGridView5.Rows.Add(" Вікно");
                    }
                    else
                    {
                        dataGridView5.Rows.Add(couple_name_and_group);
                    }
                }
                Templates.Clear();
            }
        }

        private void siguiruhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zvit garant = new Zvit();
            garant.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView1.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ПН';";
            db.Execute<Template>("testir.db", s, ref Templates);
            Form2 f2 = new Form2();
            f2.name_gr = Templates[dataGridView1.CurrentRow.Index].name_gr;
            f2.name_couple = Templates[dataGridView1.CurrentRow.Index].name_couple;
            f2.week_day = Templates[dataGridView1.CurrentRow.Index].week_day;
            f2.number_couple = Convert.ToString(Templates[dataGridView1.CurrentRow.Index].number_couple);
            f2.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView2.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ВТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            Form2 f2 = new Form2();
            f2.name_gr = Templates[dataGridView2.CurrentRow.Index].name_gr;
            f2.name_couple = Templates[dataGridView2.CurrentRow.Index].name_couple;
            f2.week_day = Templates[dataGridView2.CurrentRow.Index].week_day;
            f2.number_couple = Convert.ToString(Templates[dataGridView2.CurrentRow.Index].number_couple);
            f2.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView3.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'СР';";
            db.Execute<Template>("testir.db", s, ref Templates);
            Form2 f2 = new Form2();
            f2.name_gr = Templates[dataGridView3.CurrentRow.Index].name_gr;
            f2.name_couple = Templates[dataGridView3.CurrentRow.Index].name_couple;
            f2.week_day = Templates[dataGridView3.CurrentRow.Index].week_day;
            f2.number_couple = Convert.ToString(Templates[dataGridView3.CurrentRow.Index].number_couple);
            f2.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView4_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView4.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ЧТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            Form2 f2 = new Form2();
            f2.name_gr = Templates[dataGridView4.CurrentRow.Index].name_gr;
            f2.name_couple = Templates[dataGridView4.CurrentRow.Index].name_couple;
            f2.week_day = Templates[dataGridView4.CurrentRow.Index].week_day;
            f2.number_couple = Convert.ToString(Templates[dataGridView4.CurrentRow.Index].number_couple);
            f2.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {
            string d = dataGridView5.CurrentCell.Value.ToString();
            string s = @"SELECT * FROM template WHERE week_day = 'ПТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            Form2 f2 = new Form2();
            f2.name_gr = Templates[dataGridView5.CurrentRow.Index].name_gr;
            f2.name_couple = Templates[dataGridView5.CurrentRow.Index].name_couple;
            f2.week_day = Templates[dataGridView5.CurrentRow.Index].week_day;
            f2.number_couple = Convert.ToString(Templates[dataGridView5.CurrentRow.Index].number_couple);
            f2.Show();
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

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TemplateForm garant = new TemplateForm();
            garant.Show();
        }



        private void експортуватиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            MessageBox.Show(folderBrowserDialog.SelectedPath.ToString());
        }

        private void імпортуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}