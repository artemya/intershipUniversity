﻿using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            s.SetKnowledge(new Knowledge(4));

            University university = new University("CH.U.I.");
            university.AddStudent(s);
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(3)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(4)));
            university.AddStudent(new Student("Maria Perechrest", new Knowledge(3)));
            
            Internship internship = new Internship("Interlink");
            internship.PassStudents(university);
            
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());

        }
    }
}
