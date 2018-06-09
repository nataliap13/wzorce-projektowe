using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCommandPattern
{
    public class Memento<T>
    {
        Stack<Command<T>> done;
        T value;
        public Stack<Command<T>> Done { get => done; }
        public T Value { get => value; }
        public Memento(Stack<Command<T>> done_, T value_)
        {
            done = done_;
            value = value_;
        }
    }
}
