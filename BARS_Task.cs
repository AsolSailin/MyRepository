using System;
using System.Collections.Generic;
using System.Text;

namespace BARS_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var subs = new Key();
            subs.OnKeyPressed += (_, c) => Console.WriteLine(c);

            subs.Run();
        }
    }
    
    public class Key
    {
        public event EventHandler <char> OnKeyPressed;

        public void Run()
        {
            char key = Console.ReadKey().KeyChar;
            while (key != 'c')
            {
                OnKeyPressed?.Invoke(this, key);
            }
        }
    }
}
