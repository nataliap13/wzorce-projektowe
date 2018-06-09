using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCommandPattern
{
    public class Caretaker<T>
    {
        private List<Memento<T>> history = new List<Memento<T>>();
        public List<Memento<T>> History { get => history; }
        public void Add(Memento<T> m)
        { history.Add(m); }
    }
}
