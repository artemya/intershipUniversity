using InternshipTest.Person;
using System;
using System.Collections.Generic;
namespace InternshipTest.Institution
{
    public class University
    {
        string name;
        public List<Student> students = new List<Student>();
        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
