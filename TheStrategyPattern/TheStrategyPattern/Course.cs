using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStrategyPattern
{
    class Course
    {
        private List<Student> participants;
        private StudentValidator validator;
        public Course(StudentValidator validator_)
        {
            ;
            validator = validator_;
            participants = new List<Student>();
        }
        public void AddParticipant(Student s)
        {
            if (validator.Validate(s))
                { participants.Add(s); }
        }

        public List<Student> Participants { get => participants; }
    }
}
