using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStrategyPattern
{
    class OverAgeStudentValidator : StudentValidator
    {
        private int age;
        public OverAgeStudentValidator(int age_)
        { age = age_; }
        public bool Validate(Student s)
        { return s.Age > age; }
    }
}
