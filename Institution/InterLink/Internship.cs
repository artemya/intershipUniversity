using System.Collections.Generic;
using InternshipTest.Person;
namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string name;
        List<Student> passStudents = new List<Student>();
        // University university;
        public Internship(string name)
        {
            this.name = name;
        }

        public string GetStudents()
        {
            string str = "";

            foreach (Student student in passStudents)
            {
                return student.name + "\n";
            }

            return str;
        }
        public int AverageKnowledge(University university)
        {
            int sum = 0;
            foreach (Student student in university.students)
            {
                sum += student.knowledge.level;
            }
            ;
            return sum /= university.students.Count;
        }
        public void PassStudents(University university)
        {
            int average = AverageKnowledge(university);
            foreach(Student student in university.students)
            {
                if(student.knowledge.level > average)
                {
                    passStudents.Add(student);
                }
            }
        }
    }
}
