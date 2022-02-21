using System;
using System.Collections.Generic;
using System.Text;

namespace At_class
{
    class Group:Student
    {
        public string No;
        public int Limit;        
        private Student[] _students;        

        public Group(string name, string surname, string no, int limit):base(name, surname)
        {
            _students = new Student[0];
            No = no;
            Limit = limit;
        }

        public void AddStudent(Student student)
        {
            if (_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public Student[] GetStudents()
        {
            return _students;
        }
    }
}
