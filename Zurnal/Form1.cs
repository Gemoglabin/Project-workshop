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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Template> Templates = new List<Template>();

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
                    dataGridView2.Rows.Add("Окно");
                }
                else
                {
                    dataGridView2.Rows.Add(couple_name_and_group);
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
                    dataGridView3.Rows.Add("Окно");
                }
                else
                {
                    dataGridView3.Rows.Add(couple_name_and_group);
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
                    dataGridView4.Rows.Add("Окно");
                }
                else
                {
                    dataGridView4.Rows.Add(couple_name_and_group);
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
                    dataGridView5.Rows.Add("Окно");
                }
                else
                {
                    dataGridView5.Rows.Add(couple_name_and_group);
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
                    dataGridView6.Rows.Add("Окно");
                }
                else
                {
                    dataGridView6.Rows.Add(couple_name_and_group);
                }

            }
            Templates.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
} 