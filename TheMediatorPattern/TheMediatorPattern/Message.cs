using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMediatorPattern
{
    public class MessageBox
    {
        private string receiverId;
        private string message;
        public MessageBox(string receiverid_, string message_)
        {
            receiverId = receiverid_;
            message = message_;
        }
        public string ReceiverName { get => receiverId; }
        public string Message { get => message; }
    }
}
