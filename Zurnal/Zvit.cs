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
			this.Hide();
			Form1 garant = new Form1();
			garant.ShowDialog();
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
	}
}
