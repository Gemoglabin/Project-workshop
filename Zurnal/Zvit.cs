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

        private void розкладToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 garant = new Form1();
            garant.ShowDialog();
        }
    }
}
