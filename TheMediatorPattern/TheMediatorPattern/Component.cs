using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMediatorPattern
{
    public class Component
    {
        private String name;
        List<String> messages = new List<string>();

        public Component(String name_)
        { name = name_; }
        public string Name { get => name; }
        public List<String> Messages { get => messages; }

        public void Send(String m, ref Mediator mediator, ref Component c)
        {
            Console.WriteLine("Przesyłanie wiadomości od " + name + " do " + c.Name + ": " + m);
            mediator.Send(m, ref c); // Rzeczywista komunikacja odbywa się za pośrednictwem mediatora!!!
        }

        public void Receive(String m)
        {
            Console.WriteLine("Wiadomość odebrana przez " + name + ": " + m);
            messages.Add(m);
        }
    }
}
