using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMediatorPattern
{
    public interface IMediator
    {
        void Send(String m, ref Component c);
    }
}
