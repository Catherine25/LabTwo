using System.Collections.Generic;

namespace WindowsFormsApp1 {
    class University : IEqualityComparer<University> {
        //default constructor
        public University() { }
        //constructor with all fields
        public University(string name, int faculties, int labs, int students, int lections, int teachers, int personal) {
            //check data
            Controller.IsPersonalEnough(personal, lections, labs);
            Controller.IsTeachersEnough(teachers, students);
            //initialization
            Name = name;
            Faculties = faculties;
            Labaratories = labs;
            Students = students;
            LectionRooms = lections;
            Teachers = teachers;
            Personal = personal;
        }
        // copy constructor
        public University(University u) {
            Name = u.Name;
            Faculties = u.Faculties;
            Labaratories = u.Labaratories;
            Students = u.Students;
            LectionRooms = u.LectionRooms;
            Teachers = u.Teachers;
            Personal = u.Personal;
        }
        // + operator
        public static University operator + (University u1, University u2) {
            return new University(u1.Name + " " + u2.Name,
                u1.Faculties + u2.Faculties,
                u1.Labaratories + u2.Labaratories,
                u1.Students + u2.Students,
                u1.LectionRooms + u2.LectionRooms,
                u1.Teachers + u2.Teachers,
                u1.Personal + u2.Personal);
        }
        // get fields with index (lection/lab rooms)
        public int this[int index] {
            get {
                if (index == 0)
                    return Labaratories;
                return LectionRooms;
            }
            set {
                if (index == 0)
                    Labaratories = value;
                LectionRooms = value;
            }
        }
        // deleting student
        public void DellStudent() {
            Controller.CanDelete(Students);
            Students--;
        }
        // deleting lection room
        public void DellLecRoom() {
            Controller.CanDelete(LectionRooms);
            LectionRooms--;
        }
        // adding student
        public void AddStudent() {
            Controller.CanAddStudents(Teachers, Students);
            Students++;
        }
        // adding lectionRooms
        public void AddLecRoom() {
            Controller.CanAddAuditories(Personal, LectionRooms, Labaratories);
            LectionRooms++;
        }
        // adding labaratories
        public void AddLabRoom() {
            Controller.CanAddAuditories(Personal, LectionRooms, Labaratories);
                Labaratories++;
        }
        // deleting labaratories
        public void DellLabRoom() {
            Controller.CanDelete(Labaratories);
            Labaratories--;
        }
        // adding teachers
        public void AddTeacher() => Teachers++;
        // deleting teachers
        public void dellTeacher() {
            Controller.CanDelete(Teachers);
            Teachers--;
        }
        // adding Personal
        public void AddPersonal() => Personal++;
        // deleting Personal
        public void dellPersonal() {
            Controller.CanDelete(Personal);
            Personal--;
        }
        // adding Facultie
        public void AddFacultie() => Faculties++;
        // deleting Facultie
        public void DellFacultie() {
            Controller.CanDelete(Faculties);
            Faculties--;
        }
        // university equality by name
        public bool Equals(University u1, University u2) {
            if (u1 == null && u2 == null)
                return true;
            else if (u1 == null || u2 == null)
                return false;
            else if (u1.Name.Equals(u2.Name))
                return true;
            else
                return false;
        }
        // necessary function for interface
        public int GetHashCode(University u) => u.GetHashCode();
        // data
        public string Name { get; set; }
        public int Faculties { get; set; }
        public int Labaratories { get; set; }
        public int Students { get; set; }
        public int LectionRooms { get; set; }
        public int Teachers { get; set; }
        public int Personal { get; set; }
    }
}