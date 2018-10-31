using System;

//Class to check data
namespace WindowsFormsApp1 {
    public static class Controller {
        //initialization check
        public static void IsPersonalEnough(int personal, int lections, int labs) {
            if (personal * 2 < lections + labs)
                throw new Exception("Not enough personal for such rooms");
        }
        public static void IsTeachersEnough(int teachers, int students) {
            if (teachers < students * 10)
                throw new Exception("Not enough teachers for such students");
        }
        //change check
        public static void CanDelete(int value) {
            if (value == 0)
                throw new Exception("Not enough objects for deleting");
        }
        public static void CanAddStudents(int teachers, int students) {
            if (teachers == students * 10)
                throw new Exception("Not enough teachers for adding students");
        }
        public static void CanAddAuditories(int personal, int lectionRooms, int labs) {
            if (personal == lectionRooms + labs)
                throw new Exception("Not enough personal for adding auditories");
        }
    }
}
