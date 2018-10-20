using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<University> universities = new List<University>();
        int mouseX, mouseY;
        public Form1()
        {
            try
            {
                InitializeComponent();
                universities.Add(new University("", 0, 0, 0, 0, 0, 0));
                InitGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void InitGrid()
        {
            dataGridView1.DataSource = universities;
            dataGridView1.Columns["Name"].HeaderText = "Название университета";
            dataGridView1.Columns["Faculties"].ReadOnly = true;
            dataGridView1.Columns["Faculties"].HeaderText = "Количество факультативов";
            dataGridView1.Columns["Labaratories"].ReadOnly = true;
            dataGridView1.Columns["Labaratories"].HeaderText = "Количество лабораторий";
            dataGridView1.Columns["Students"].ReadOnly = true;
            dataGridView1.Columns["Students"].HeaderText = "Количество студентов";
            dataGridView1.Columns["LectionRooms"].ReadOnly = true;
            dataGridView1.Columns["LectionRooms"].HeaderText = "Количество аудиторий";
            dataGridView1.Columns["Teachers"].ReadOnly = true;
            dataGridView1.Columns["Teachers"].HeaderText = "Количество преподавателей";
            dataGridView1.Columns["Personal"].ReadOnly = true;
            dataGridView1.Columns["Personal"].HeaderText = "Количество персонала";

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.HitTest(mouseX, mouseY).RowIndex;
                if (index >= 0 && index < universities.Count)
                {
                    dataGridView1.DataSource = null;
                    universities[index].addStudent();
                    InitGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dellStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.HitTest(mouseX, mouseY).RowIndex;
                if (index >= 0 && index < universities.Count)
                {
                    dataGridView1.DataSource = null;
                    universities[index].Students -= 1;
                    InitGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addUniversityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            universities.Add(new University("", 0, 0, 0, 0, 0, 0));
            InitGrid();
        }

        private void dellUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.HitTest(mouseX, mouseY).RowIndex;
            if (index >= 0 && index < universities.Count)
            {
                dataGridView1.DataSource = null;
                universities.RemoveAt(index);
                InitGrid();
            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
