using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_info
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
namespace StudentManespace
{
    internal class StudentNameclass
    {
        public String StudentNameVar { get; set; }

        public StudentNameclass()
        {

        }

        public StudentNameclass(string studentNameVar)
        {
            this.StudentNameVar = studentNameVar;
        }

    }
}
