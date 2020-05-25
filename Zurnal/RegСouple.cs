using Devart.Data.Linq.Mapping.Fluent;
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
    public partial class RegСouple : Form
    {
        public List<Student> Students = new List<Student>();
        public List<Template> Templates = new List<Template>();
        public List<Timetable> Timetables = new List<Timetable>();
        public List<backDate> backDates = new List<backDate>();
        ClassDataBase db = new ClassDataBase();

       

        public RegСouple()
        {
            InitializeComponent();
        }

        private void RegСouple_Load(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            currentDay.Text = Convert.ToString(date1.ToString("yyyy-MM-dd"));
            dateTimePicker1.Value = Convert.ToDateTime(date1.ToString("yyyy-MM-dd"));
            dateTimePicker1.MaxDate = dateTimePicker1.Value;
            comboBox2.SelectedItem = comboBox2.Items[0].ToString();

            LoadCombobox();
        }
        private void LoadCombobox()
        {
            #region FirstCombobox
            Students.Clear();
            string z = @"SELECT * FROM student GROUP BY name_gr";
            db.Execute<Student>("testir.db", z, ref Students);
            for (int i = 0; i < Students.Count; i++)
            {
                if (!(comboBox1.Items.Contains(Students[i].name_gr)) && Students[i].name_gr != "")
                {
                    comboBox1.Items.Add(Students[i].name_gr);
                }
            }
            if (Students.Count != 0)
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
            Students.Clear();
            #endregion

          
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        string studentID;
        string timeID = "";

        private void Save_Attend()
        {
            string ifTime = @"SELECT * FROM timetable WHERE date = '" + dateTimePicker1.Text.ToString() + "' AND number_couple = '" + comboBox2.Text.ToString() + "' AND name_gr = '" + comboBox1.Text.ToString() + "' GROUP BY id_time";
            db.Execute<Timetable>("testir.db", ifTime, ref Timetables);
            for (int i = 0; i < Timetables.Count; i++)            
                timeID = Convert.ToString(Timetables[i].Id_time);
            
            if (timeID == "")
            {
                MessageBox.Show("База порожня" );
            }
            else
            {
                if (MessageBox.Show("Бажаєте змінити збережені дані?", "Оновлення відвідування", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    for (int i = 0; i < (dataGridView1.RowCount); i++)
                    {
                        string reason = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string s = @"SELECT * FROM student WHERE fio = '" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + "'";
                        db.Execute<Student>("testir.db", s, ref Students);
                        for (int j = 0; j < Students.Count; j++)
                         studentID = Convert.ToString(Students[j].id_stud);
                            
                        string mark = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "0")
                            reason = "Поважна";
                        string save = "UPDATE visit SET mark = '" + mark + "' WHERE id_time = '" + timeID + "' AND id_stud = '" + studentID + "'";
                        db.ExecuteNonQuery("testir.db", save);
                        string save1 = "UPDATE visit SET reason = '" + reason + "' WHERE id_time = '" + timeID + "' AND id_stud = '" + studentID + "'";
                        db.ExecuteNonQuery("testir.db", save1);
                        Students.Clear();
                    }
                    MessageBox.Show("Збережено", "", MessageBoxButtons.OK);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Save_Attend();
        }
       

      
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateDBInCombobox();

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateDBInCombobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDBInCombobox();
        }
        private void UpdateDBInCombobox()
        {
            dataGridView1.Rows.Clear();
            string Id = "";
            Students.Clear();
            Timetables.Clear();
            Templates.Clear();
            backDates.Clear();
            string ValueCalendar = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string id_time = @"SELECT student.fio,visit.mark,visit.reason from timetable,visit,student WHERE visit.id_stud = student.id_stud AND visit.id_time = timetable.id_time AND timetable.name_gr = '"+comboBox1.Text+"'AND timetable.number_couple = '"+comboBox2.Text+"' AND timetable.date = '"+dateTimePicker1.Text.ToString()+"' ;";
            db.Execute<backDate>("testir.db", id_time, ref backDates);
            for (int i = 0; i < backDates.Count; i++)
                dataGridView1.Rows.Add(backDates[i].fio,Convert.ToString(backDates[i].mark), backDates[i].reason);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
