using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwo {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var universities = University.GetData();
            Console.WriteLine("There are {universities.Count()} universities.");
            //--------writetotextbox
            var UniversitiesDifferents = universities.Distinct();
            Console.WriteLine("There are {universitiesDifferents.Count()} DIFFERENT universities.");
            Console.Read();
        }
    }
}
