namespace InternshipTest.Person
{
    public class Student
    {
        public string name;
        public Knowledge knowledge;
        public Student(string name, Knowledge knowledge)
        {
            this.name = name;
            this.knowledge = knowledge;
        }
        public Student(string name)
        {
            this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }


    }
}