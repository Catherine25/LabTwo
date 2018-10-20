using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class University : IEqualityComparer<University>
    {

        //constructors
        public University() { }

        public University(string _name, int _faculties, int _labs, int _students, int _lections, int _teachers, int _personal)
        {
            if (Personal * 2 < LectionRooms || Personal * 2 < Labaratories || Teachers * 10 < Students)
                throw new Exception("Ошибка");
            else
            {
                Name = _name;
                Faculties = _faculties;
                Labaratories = _labs;
                Students = _students;
                LectionRooms = _lections;
                Teachers = _teachers;
                Personal = _personal;
            }

        }

        //methods
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

        //operators
        public static University operator +(University _u1, University _u2)
        {
            return new University
            {
                Name = _u1.Name + " " + _u2.Name,
                Faculties = _u1.Faculties + _u2.Faculties,
                Labaratories = _u1.Labaratories + _u2.Labaratories,
                Students = _u1.Students + _u2.Students,
                LectionRooms = _u1.LectionRooms + _u2.LectionRooms,
                Teachers = _u1.Teachers + _u2.Teachers,
                Personal = _u1.Personal + _u2.Personal
            };
        }

        //Index
        public int this[int index]
        {
            get
            {
                if (index == 0) return Labaratories;
                return LectionRooms;
            }
            set
            {
                if (index == 0) Labaratories = value;
                LectionRooms = value;
            }
        }


        public void dellStudent()
        {
            if (Students == 0)
                throw new Exception("Нету студентов для исключения");
            else
                Students--;
        }

        public void dellLecRoom()
        {
            if (LectionRooms == 0)
                throw new Exception("Нету лекционных мест");
            else
                LectionRooms--;
        }

        public void addStudent()
        {
            if (Teachers * 10 == Students)
                throw new Exception("Не хватает учителей для зачисления");
            else
                Students++;
        }

        public void addLecRoom()
        {
            if (Personal * 2 == LectionRooms)
                throw new Exception("Не хватает персонала для добавления");
            else
                LectionRooms++;
        }

        public void addLabRoom()
        {
            if (Personal * 2 == Labaratories)
                throw new Exception("Не хватает персонала для добавления");
            else
                Labaratories++;
        }

        public void dellLabRoom()
        {
            if (Labaratories == 0)
                throw new Exception("Нету лабораторий");
            else
                Labaratories--;
        }


        public void addTeacher()
        {
            Teachers++;
        }

        public void dellTeacher()
        {
            if (Teachers == 0)
                throw new Exception("Нету учителей");
            else
                Teachers--;
        }

        public void addPersonal()
        {
            Personal++;
        }

        public void dellPersonal()
        {
            if (Personal == 0)
                throw new Exception("Нету учителей");
            else
                Personal--;
        }

        public bool Equals(University _u1, University _u2)
        {
            if (_u1 == null && _u2 == null)
                return true;
            else if (_u1 == null || _u2 == null)
                return false;
            else if (_u1.Name.Equals(_u2.Name)) return true;
            else return false;
        }
        public int GetHashCode(University _u) => _u.GetHashCode();

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