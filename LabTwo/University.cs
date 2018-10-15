using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class University
    {
        public University(string _name, int _faculties, int _labs, int _students, int _lections)
        {
            Name = _name;
            Faculties = _faculties;
            Labaratories = _labs;
            Students = _students;
            LectionRooms = _lections;
            Teachers = Students / 10 + 1;
            Personal = (Labaratories + LectionRooms) / 2;
        }

        public void Copy(ref University _university, ref University _destUniversity)
        {
            _destUniversity.Name = _university.Name;
            _destUniversity.Faculties = _university.Faculties;
            _destUniversity.Labaratories = _university.Labaratories;
            _destUniversity.Students = _university.Students;
            _destUniversity.LectionRooms = _university.LectionRooms;
            _destUniversity.Teachers = _university.Teachers;
            _destUniversity.Personal = _university.Personal;
        }

        public string Name { get; set; }
        public int Faculties { get; set; }
        public int Labaratories { get; set; }
        public int Students { get; set; }
        public int LectionRooms { get; set; }
        public int Teachers { get; set; }
        public int Personal { get; set; }

        public static IEnumerable<University> GetData()
        {
            return new List<University>() {
                new University("Nure", 8, 30, 8000, 30),
                new University("Kpi", 14, 50, 14000, 50),
                new University("Karazin", 20, 80, 20000, 70),
                new University("Khai", 7, 15, 11000, 20),
                new University("Kart", 5, 7, 10000, 18),
        };
        }
    }
}
