using System;

namespace Atom
{
    class Atom
    {
        static void Main(string[] args)
        {
            AtomCon Atom = new AtomCon();
            Console.WriteLine("Atomic Information");
            Console.WriteLine("===============================");
            while (Atom.accept())
            {
                Atom.accept();
            }
            Console.WriteLine("===============================");
            Atom.display();
            Console.ReadLine();
        }
    }
}
