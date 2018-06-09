using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCommandPattern
{
    public class AddCommand <T> : Command <T>
    {
        T b;
        T c;
        public AddCommand(T b_)
        {
            b = b_;
        }
        public T Go(T a)
        {
            c = ((dynamic) a + (dynamic) b );
            return c;
        }

        public T Reverse()
        {
            return ((dynamic) c - (dynamic) b);
        }
    }
}
