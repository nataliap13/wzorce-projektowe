using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCommandPattern
{
    class Calculator<T>
    {
        Caretaker<T> caretaker = new Caretaker<T>();
        Stack<Command<T>> done = new Stack<Command<T>>();
        T value;
        public T Value { get => value; }
        public void Save()
        {
            Stack<Command<T>> bufor = new Stack<Command<T>>();
            while (done.Count() > 0)
            {
                bufor.Push(done.Pop());
            }
            Stack<Command<T>> save = new Stack<Command<T>>();
            while (bufor.Count() > 0)
            {
                var item = bufor.Pop();
                done.Push(item);
                save.Push(item);
            }
            Memento<T> memento = new Memento<T>(save, value);
            caretaker.Add(memento);
        }
        public void Restore(int index)
        {
            done = caretaker.History[index].Done;
            value = caretaker.History[index].Value;
        }
        //public void ClearCalculations(int index)
        //{
        //    done = new Stack<Command<T>>();
        //    value = (dynamic)0;
        //}
        public void Calculate(Command<T> c)
        {
            value = c.Go(value);
            done.Push(c);
        }
        public void Reverse()
        {
            try
            {
                var com = done.Pop();
                if (com != null)
                { value = com.Reverse(); }
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
        }
    }
}
