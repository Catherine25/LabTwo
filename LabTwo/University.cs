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
        //конструктор копирования
        public University(University univer)
        {
            this.Name = univer.Name;
            this.Faculties = univer.Faculties;
            this.Labaratories = univer.Labaratories;
            this.Students = univer.Students;
            this.LectionRooms = univer.LectionRooms;
            this.Teachers = univer.Teachers;
            this.Personal = univer.Personal;
        }

        //operators
        public static University operator + (University _u1, University _u2)
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

        //Индексатор по кол-ву ЛК/ЛБ аудиторий
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

        //отчисление студента
        public void dellStudent()
        {
            if (Students == 0)
                throw new Exception("Нет студентов для исключения");
            else
                Students--;
        }
        //удаление ЛК аудитории
        public void dellLecRoom()
        {
            if (LectionRooms == 0)
                throw new Exception("Нет лекционных мест");
            else
                LectionRooms--;
        }
        //зачисление студента
        public void addStudent()
        {
            if (Teachers * 10 == Students)
                throw new Exception("Не хватает преподавателей для зачисления");
            else
                Students++;
        }
        //добавление ЛК аудитории
        public void addLecRoom()
        {
            if (Personal * 2 == LectionRooms)
                throw new Exception("Не хватает персонала для добавления");
            else
                LectionRooms++;
        }
        //добавление ЛБ аудитории
        public void addLabRoom()
        {
            if (Personal * 2 == Labaratories)
                throw new Exception("Не хватает персонала для добавления");
            else
                Labaratories++;
        }
        //удаление ЛБ аудитории
        public void dellLabRoom()
        {
            if (Labaratories == 0)
                throw new Exception("Нет лабораторий");
            else
                Labaratories--;
        }

        //добавление преподавателя
        public void addTeacher()
        {
            Teachers++;
        }
        //удаление преподавателя
        public void dellTeacher()
        {
            if (Teachers == 0)
                throw new Exception("Нет преподавателей");
            else
                Teachers--;
        }
        //добавление персонала
        public void addPersonal()
        {
            Personal++;
        }
        //удаление персонала
        public void dellPersonal()
        {
            if (Personal == 0)
                throw new Exception("Нет преподавателей");
            else
                Personal--;
        }
        //добавление факультета
        public void addFacultie()
        {
            Faculties++;
        }
        //равенство университетов
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