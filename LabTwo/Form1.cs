using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        //data
        List<University> universities = new List<University>();
        int mouseX, mouseY;
        //Form initialization
        public Form1() {
            try {
                InitializeComponent();
                universities.Add(new University());
                InitGrid();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                InitGrid();
            }
        }
        //Grid innitialization
        private void InitGrid() {
            dataGridView1.DataSource = universities;
            dataGridView1.Columns["Name"].HeaderText = "University name";
            dataGridView1.Columns["Faculties"].ReadOnly = true;
            dataGridView1.Columns["Faculties"].HeaderText = "Faculties";
            dataGridView1.Columns["Labaratories"].ReadOnly = true;
            dataGridView1.Columns["Labaratories"].HeaderText = "Labaratories";
            dataGridView1.Columns["Students"].ReadOnly = true;
            dataGridView1.Columns["Students"].HeaderText = "Students";
            dataGridView1.Columns["LectionRooms"].ReadOnly = true;
            dataGridView1.Columns["LectionRooms"].HeaderText = "Lection Rooms";
            dataGridView1.Columns["Teachers"].ReadOnly = true;
            dataGridView1.Columns["Teachers"].HeaderText = "Teachers";
            dataGridView1.Columns["Personal"].ReadOnly = true;
            dataGridView1.Columns["Personal"].HeaderText = "Personal";
        }
        // getting mouse x, y
        private void DataGridView1_MouseUp(object sender, MouseEventArgs e) {
            mouseX = e.X;
            mouseY = e.Y;
        }
        // Choosing University
        void ChooseUniversity(string objectToChange, string function) {
            int index = dataGridView1.HitTest(mouseX, mouseY).RowIndex;
            try {
                if (index >= 0 && index < universities.Count) {
                    dataGridView1.DataSource = null; //without it error occurs 
                    switch (objectToChange)
                    {//using functionality
                        case "University":
                                if (function == "Delete")
                                    universities.RemoveAt(index);
                            break;
                        case "Facultie":
                            if (function == "Add")
                                universities[index].AddFacultie();
                            else
                                universities[index].DellFacultie();
                            break;
                        case "Student":
                            if (function == "Add")
                                universities[index].AddStudent();
                            else if (function == "Delete")
                                universities[index].DellStudent();
                            break;
                        case "Teacher":
                            if (function == "Add")
                                universities[index].AddTeacher();
                            else if (function == "Delete")
                                universities[index].dellTeacher();
                            break;
                        case "Personal":
                            if (function == "Add")
                                universities[index].AddPersonal();
                            else if (function == "Delete")
                                universities[index].dellPersonal();
                            break;
                        case "LabRoom":
                            if (function == "Add")
                                universities[index].AddLabRoom();
                            else if (function == "Delete")
                                universities[index].DellLabRoom();
                            break;
                        case "LecRoom":
                            if (function == "Add")
                                universities[index].AddLecRoom();
                            else if (function == "Delete")
                                universities[index].DellLecRoom();
                            break;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                InitGrid();
            }
            finally {
                InitGrid(); //reloads the grid
            }
        }
        // ToolStripMenu Events
        // Universities
        private void AddUniversityToolStripMenuItem1_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = null;
            universities.Add(new University());
            InitGrid();
        }
        private void DellUniversityToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("University", "Delete");
        // Faculties
        private void AddToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("Facultie", "Add");
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("Facultie", "Delete");
        // Students
        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("Student", "Add");
        private void DellStudentToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("Student", "Delete");
        // Teachers
        private void AddTeacherToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("Teacher", "Add");
        private void DellTeacherToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("Teacher", "Delete");
        //Personal
        private void AddPersonalToolStripMenuItem_Click(object sender, EventArgs e) => ChooseUniversity("Personal", "Add");
        private void DellPersonalToolStripMenuItem1_Click(object sender, EventArgs e) => ChooseUniversity("Personal", "Delete");
        //Lab rooms
        private void addToolStripMenuItem2_Click(object sender, EventArgs e) => ChooseUniversity("LabRoom", "Add");
        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e) => ChooseUniversity("LabRoom", "Delete");
        //LecRooms
        private void AddToolStripMenuItem1_Click(object sender, EventArgs e) => ChooseUniversity("LecRoom", "Add");
        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e) => ChooseUniversity("LecRoom", "Delete");
        // other buttons
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Created by Solodukhina and Shelest (KIUKI-16-7)", Application.ProductName, MessageBoxButtons.OK);
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure?", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
