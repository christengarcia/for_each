using System;

namespace for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] message = { 'H', 'e', 'l', 'l', 'o' };

            // A foreach loop is very useful if you want 
            // to get information from an array or list,
            // without making any changes to it.
            foreach (char i in message)
                Console.Write(i);
        }
    }
}
