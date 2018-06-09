using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCommandPattern
{
    public interface Command <T>
    {
        T Go(T a);
        T Reverse();
    }
}
