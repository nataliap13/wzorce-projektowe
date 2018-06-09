using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMediatorPattern
{
    public class Mediator : IMediator
    {
        public void Send(String m, ref Component c)
        {//do something to adapt message to receiver
            c.Receive(m);
        }
    }
}
