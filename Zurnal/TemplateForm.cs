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
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }


        public List<Template> Templates = new List<Template>();
        public List<Student> Students = new List<Student>();

        ClassDataBase db = new ClassDataBase();



        private void TemplateForm_Load(object sender, EventArgs e)
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string s = @"SELECT * FROM template WHERE week_day = 'ПН';";
            db.Execute<Template>("testir.db", s, ref Templates);
            TemplateConfirm TC = new TemplateConfirm();
            TC.name_gr = Templates[dataGridView1.CurrentRow.Index].name_gr;
            TC.name_couple = Templates[dataGridView1.CurrentRow.Index].name_couple;
            TC.week_day = Templates[dataGridView1.CurrentRow.Index].week_day;
            TC.number_couple = Convert.ToString(Templates[dataGridView1.CurrentRow.Index].number_couple);
            TC.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string s = @"SELECT * FROM template WHERE week_day = 'ВТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            TemplateConfirm TC = new TemplateConfirm();
            TC.name_gr = Templates[dataGridView2.CurrentRow.Index].name_gr;
            TC.name_couple = Templates[dataGridView2.CurrentRow.Index].name_couple;
            TC.week_day = Templates[dataGridView2.CurrentRow.Index].week_day;
            TC.number_couple = Convert.ToString(Templates[dataGridView2.CurrentRow.Index].number_couple);
            TC.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            string s = @"SELECT * FROM template WHERE week_day = 'СР';";
            db.Execute<Template>("testir.db", s, ref Templates);
            TemplateConfirm TC = new TemplateConfirm();
            TC.name_gr = Templates[dataGridView3.CurrentRow.Index].name_gr;
            TC.name_couple = Templates[dataGridView3.CurrentRow.Index].name_couple;
            TC.week_day = Templates[dataGridView3.CurrentRow.Index].week_day;
            TC.number_couple = Convert.ToString(Templates[dataGridView3.CurrentRow.Index].number_couple);
            TC.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView4_DoubleClick(object sender, EventArgs e)
        {
            string s = @"SELECT * FROM template WHERE week_day = 'ЧТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            TemplateConfirm TC = new TemplateConfirm();
            TC.name_gr = Templates[dataGridView4.CurrentRow.Index].name_gr;
            TC.name_couple = Templates[dataGridView4.CurrentRow.Index].name_couple;
            TC.week_day = Templates[dataGridView4.CurrentRow.Index].week_day;
            TC.number_couple = Convert.ToString(Templates[dataGridView4.CurrentRow.Index].number_couple);
            TC.Show();
            Templates.Clear();
            this.Hide();
        }

        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {
            string s = @"SELECT * FROM template WHERE week_day = 'ПТ';";
            db.Execute<Template>("testir.db", s, ref Templates);
            TemplateConfirm TC = new TemplateConfirm();
            TC.name_gr = Templates[dataGridView5.CurrentRow.Index].name_gr;
            TC.name_couple = Templates[dataGridView5.CurrentRow.Index].name_couple;
            TC.week_day = Templates[dataGridView5.CurrentRow.Index].week_day;
            TC.number_couple = Convert.ToString(Templates[dataGridView5.CurrentRow.Index].number_couple);
            TC.Show();
            Templates.Clear();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 boun = new Form1();
            boun.Show();
        }
    }
}
