using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo {
    class University {

        //constructors
        public University() { }

        public University(ref string _name, int _faculties, int _labs, int _students, int _lections) {
            Name = _name;
            Faculties = _faculties;
            Labaratories = _labs;
            Students = _students;
            LectionRooms = _lections;
            Teachers = Students / 10 + 1;
            Personal = (Labaratories + LectionRooms) / 2;
        }

        //methods
        public void Copy(ref University _university, ref University _destUniversity) {
            _destUniversity.Name = _university.Name;
            _destUniversity.Faculties = _university.Faculties;
            _destUniversity.Labaratories = _university.Labaratories;
            _destUniversity.Students = _university.Students;
            _destUniversity.LectionRooms = _university.LectionRooms;
            _destUniversity.Teachers = _university.Teachers;
            _destUniversity.Personal = _university.Personal;
        }

        //operators
        public static University operator +(University _u1, University _u2) {
            return new University {
                Name = _u1.Name + _u2.Name,
                Faculties = _u1.Faculties + _u2.Faculties,
                Labaratories = _u1.Labaratories + _u2.Labaratories,
                Students = _u1.Students + _u2.Students,
                LectionRooms = _u1.LectionRooms + _u2.LectionRooms,
                Teachers = _u1.Teachers + _u2.Teachers,
                Personal = _u1.Personal + _u2.Personal
            };
        }

        //Index
        public int this[int index] {
            get {
                if (index == 0) return Labaratories;
                return LectionRooms;
            }
            set {
                if (index == 0) Labaratories = value;
                LectionRooms = value;
            }
        }

        //IEqualityComparer
        public class UniversityComparerByName : IEqualityComparer<University> {
            public bool Equals(University _u1, University _u2) {
                if (_u1.Name.Equals(_u2.Name)) return true;
                else return false;
            }
            public int GetHashCode(University _u) => _u.GetHashCode();
        }

        //Data
        public string Name { get; set; }
        public int Faculties { get; set; }
        public int Labaratories { get; set; }
        public int Students { get; set; }
        public int LectionRooms { get; set; }
        public int Teachers { get; set; }
        public int Personal { get; set; }
    }
}
