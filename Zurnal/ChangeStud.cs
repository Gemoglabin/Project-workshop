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
    public partial class ChangeStud : Form
    {
        public List<Student> Students = new List<Student>();
        ClassDataBase db = new ClassDataBase();
        
        public ChangeStud()
        {
            InitializeComponent();
        }
        private void ChangeStud_Load(object sender, EventArgs e)
        {
            tbFIO.Text = studFIO;
            InputGroup();
        }

       

        public string studFIO;
        public string group;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string save = "UPDATE student SET fio = '" + tbFIO.Text + "', name_gr = '" + cbGroup.Text + "' WHERE fio = '" + studFIO + "' AND name_gr = '" + group + "'";
            db.ExecuteNonQuery("testir.db", save);
            Students.Clear();
            this.Hide();
            Group garant = new Group();
            garant.Show();
        }

        private void InputGroup()
        {
            string z = @"SELECT * FROM student GROUP BY name_gr";
            db.Execute<Student>("testir.db", z, ref Students);
            for (int i = 0; i < Students.Count; i++)
            {
                if (!(cbGroup.Items.Contains(Students[i].name_gr)) && Students[i].name_gr != "")
                {
                    cbGroup.Items.Add(Students[i].name_gr);
                }
            }
            cbGroup.Text = group;
            Students.Clear();
        }

		private void label8_Click(object sender, EventArgs e)
		{
			this.Hide();
			Group garant = new Group();
			garant.Show();
		}
	}
}
