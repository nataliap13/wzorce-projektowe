using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStrategyPattern
{
    interface StudentValidator
    {
        bool Validate(Student s);
    }
}
