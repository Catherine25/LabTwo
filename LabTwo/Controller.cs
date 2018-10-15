using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabTwo.University;

namespace LabTwo {
    class Controller {
        Controller() { }

        void ChangeStudentsCount(ref University _university, int _value) {
            _university.Students += _value;
        }

        void AddLectionRooms(ref University _university, int _value) {
            if (_value < 0) {
                throw new Exception("Impossible to decrease lection rooms count!");
            }
            _university.LectionRooms += _value;
        }

        void AddLabaratories(ref University _university, int _value) {
            if (_value < 0) {
                throw new Exception("Impossible to decrease labaratories count!");
            }
            _university.Labaratories += _value;
        }

        void ChangeTeachersCount(ref University _university, int _teachers) {
            if ((_university.Teachers + _teachers) < (_university.Students / 10 + 1))
                throw new Exception("Not enought teachers for such students!");

            _university.Teachers += _teachers;
        }

        void ChangePersonalCount(ref University _university, int _personal) {
            if ((_university.Personal + _personal) < ((_university.LectionRooms + _university.Labaratories) / 2))
                throw new Exception("Not enought personal for such roomsQ");

            _university.Personal += _personal;
        }
    }
}
