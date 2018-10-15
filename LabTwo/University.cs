using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class University
    {
        public University(string _name, int _faculties, int _labs, int _students, int _lections) {
            Name = _name;
            Faculties = _faculties;
            Labaratories = _labs;
            Students = _students;
            LectionRooms = _lections;
            Teachers = Students / 10 + 1;
            Personal = (Labaratories + LectionRooms) / 2;
        }

        public void Copy (ref University _university, ref University _destUniversity) {
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
            /* new University {
                ID = 1, Name = "Philips", Sales = 2000000 m, City = "Madrid"
            },
            new University {
                ID = 2, Name = "Pionner", Sales = 1000000 m, City = "Berlin"
            },
            new University {
                ID = 3, Name = "Renault", Sales = 2000000 m, City = "Paris"
            },
            new University {
                ID = 4, Name = "Sony Music", Sales = 500000 m, City = "London"
            },
            new University {
                ID = 5, Name = "Sony SCEE", Sales = 2000000 m, City = "Tokio"
            },
            new University {
                ID = 6, Name = "Pepsi", Sales = 9000000 m, City = "New York"
            },
            new University {
                ID = 6, Name = "LG", Sales = 2000000 m, City = "Rome"        */
            }
        };
        }
}
