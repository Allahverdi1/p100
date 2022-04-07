using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    internal class Student
    {
        public int No { get; set; }
        public string FullName { get; set; }

        Dictionary<string, int> students = new Dictionary<string, int>();
        private static string _point;
        private static int _examName;

        public void AddContact(int point,string examName)
        {
            students.Add(Student._point, Student._examName);
        }
    }
}
