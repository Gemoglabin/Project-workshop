using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace Zurnal
{
    public partial class Zvit : Form
    {
        public Zvit()
        {
            InitializeComponent();
        }

        public List<Template> Templates = new List<Template>();

        public List<Report> Reports = new List<Report>();
        public List<Student> Students = new List<Student>();

        ClassDataBase db = new ClassDataBase();

        private void InputGroup()
        {
            string z = @"SELECT * FROM student GROUP BY name_gr";
            db.Execute<Student>("testir.db", z, ref Students);
            for (int i = 0; i < Students.Count; i++)
            {
                if (!(cmbgroup.Items.Contains(Students[i].name_gr)) && Students[i].name_gr != "")
                {
                    cmbgroup.Items.Add(Students[i].name_gr);
                }
            }
            if (Students.Count != 0)
            {
                cmbgroup.SelectedItem = cmbgroup.Items[0];
            }
            Students.Clear();
        }

        private void розкладToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 garant = new Form1();
            garant.ShowDialog();
        }

        private void InputCouple()
        {
            comboBox1.Items.Add("Усi предмети");
            string m = @"SELECT * FROM template GROUP BY name_couple";
            db.Execute<Template>("testir.db", m, ref Templates);
            for (int i = 0; i < Templates.Count; i++)
            {
                if (!(comboBox1.Items.Contains(Templates[i].name_couple)) && Templates[i].name_couple != "")
                {
                    comboBox1.Items.Add(Templates[i].name_couple);
                }
            }
            
            comboBox1.Text = "Усi предмети";
        }

        private void Zvit_Load(object sender, EventArgs e)
        {
            InputGroup();
            InputCouple();

            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            dateTimePicker1.Value = Convert.ToDateTime(date1.ToString("yyyy-MM-dd"));
            dateTimePicker1.MaxDate = dateTimePicker1.Value;
            dateTimePicker2.Value = Convert.ToDateTime(date1.ToString("yyyy-MM-dd"));
            dateTimePicker2.MaxDate = dateTimePicker2.Value;
        }

        private void розкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 boun = new Form1();
            boun.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Усi предмети")
                {
                    dataGridView1.Rows.Clear();
                    string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and v.id_time=t.id_time and t.name_gr = '" + cmbgroup.Text + "' and t.date BETWEEN date('now','weekday 0', '-14 day') and date('now','weekday 0','-7 day') GROUP BY s.fio ORDER BY s.fio ASC;";
                    db.Execute<Report>("testir.db", z, ref Reports);
                    for (int i = 0; i < Reports.Count; i++)
                    {
                        dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                    }
                    this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                    Reports.Clear();
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and t.name_couple = '"+comboBox1.Text+"' and v.id_time=t.id_time and t.name_gr = '" + cmbgroup.Text + "' and t.date BETWEEN date('now','weekday 0', '-14 day') and date('now','weekday 0','-7 day') GROUP BY s.fio ORDER BY s.fio ASC;";
                    db.Execute<Report>("testir.db", z, ref Reports);
                    for (int i = 0; i < Reports.Count; i++)
                    {
                        dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                    }
                    this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                    Reports.Clear();
                }
                
            }
            if (radioButton2.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Усi предмети")
                {
                    dataGridView1.Rows.Clear();
                    string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and v.id_time=t.id_time and t.name_gr = '" + cmbgroup.Text + "' and t.date BETWEEN date('now','start of month','-1 month') and date('now','start of month','-1 day') GROUP BY s.fio ORDER BY s.fio ASC;";
                    db.Execute<Report>("testir.db", z, ref Reports);
                    for (int i = 0; i < Reports.Count; i++)
                    {
                        dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                    }
                    this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                    Reports.Clear();
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and t.name_couple = '" + comboBox1.Text + "' and v.id_time=t.id_time and t.name_gr = '" + cmbgroup.Text + "' and t.date BETWEEN date('now','start of month','-1 month') and date('now','start of month','-1 day') GROUP BY s.fio ORDER BY s.fio ASC;";
                    db.Execute<Report>("testir.db", z, ref Reports);
                    for (int i = 0; i < Reports.Count; i++)
                    {
                        dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                    }
                    this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                    Reports.Clear();
                }
                
            }
           
            if (radioButton4.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Усi предмети")
                {
                    dataGridView1.Rows.Clear();
                    string datepicker1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string datepicker2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                    string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and v.id_time=t.id_time and t.name_gr = '" + cmbgroup.Text + "' and t.date BETWEEN '" + datepicker1 + "' and '" + datepicker2 + "' GROUP BY s.fio ORDER BY s.fio ASC;";
                    db.Execute<Report>("testir.db", z, ref Reports);
                    for (int i = 0; i < Reports.Count; i++)
                    {
                        dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                    }
                    this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                    Reports.Clear();
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    string datepicker1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string datepicker2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                    string z = @"SELECT  s.fio, SUM(v.mark) FROM student s, visit v, timetable t WHERE v.id_stud=s.id_stud and t.name_couple = '" + comboBox1.Text + "' and v.id_time=t.id_time and t.name_gr = '" + cmbgroup.Text + "' and t.date BETWEEN '" + datepicker1 + "' and '" + datepicker2 + "' GROUP BY s.fio ORDER BY s.fio ASC;";
                    db.Execute<Report>("testir.db", z, ref Reports);
                    for (int i = 0; i < Reports.Count; i++)
                    {
                        dataGridView1.Rows.Add(Reports[i].fio, Reports[i].na);
                    }
                    this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                    Reports.Clear();
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[1, 7] = "";

            for (int i =1; i < dataGridView1.Columns.Count + 1; i++)
            {
                ExcelWorkSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j =0 ; j < dataGridView1.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            ExcelApp.Columns.AutoFit();

            ExcelApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "Звіт.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        public void Export_Data_To_Word(DataGridView dataGridView1, string filename)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int RowCount = dataGridView1.Rows.Count;
                int ColumnCount = dataGridView1.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //Добавление строк
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = dataGridView1.Rows[r].Cells[c].Value;
                    } //Конец добавления строк
                } //Конец добавления колонок

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //Ориентация таблицы
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //Формат таблицы
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //Стиль названия колонок
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGridView1.Columns[c].HeaderText;
                }

                //Стиль таблицы
                oDoc.Application.Selection.Tables[1].set_Style("Сетка таблицы");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //Сохранение файла
                oDoc.SaveAs2(filename);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
    }
}
