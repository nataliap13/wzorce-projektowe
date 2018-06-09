using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStrategyPattern
{
    class Student
    {
        private string name;
        //private string surname;
        //private int math_grade;
        //private int bio_grade;
        private int age;

        public string Name { get => name; }
        //public string Surname { get => surname; }
        //public int Math_grade { get => math_grade; }
        //public int Bio_grade { get => bio_grade; }
        public int Age { get => age; }
        /*
        public Student(string name_, string surname_,
            int math_grade_, int bio_grade_,
            int age_)
        {
            name = name_;
            surname = surname_;
            math_grade = math_grade_;
            bio_grade = bio_grade_;
            age = age_;
        }
        */
        public Student(string name_, int age_)
        {
            name = name_;
            age = age_;
        }
    }
}
