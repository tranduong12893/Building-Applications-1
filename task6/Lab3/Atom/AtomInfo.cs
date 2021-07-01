using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom
{
    class AtomCon
    {
        int aNumber;
        string aSymbol;
        string aName;
        float aweight;
        AtomCon[] Atom = new AtomCon[10];
        int i, end;

        public Boolean accept()
        {
            Atom[i] = new AtomCon();
            Console.WriteLine("Enter Atomic number: ");
            Atom[i].aNumber = int.Parse(Console.ReadLine());
            if(Atom[i].aNumber != 0)
            {
                Console.WriteLine("Enter Atom Symbol: ");
                Atom[i].aSymbol = Console.ReadLine();
                Console.WriteLine("Enter Atom Name: ");
                Atom[i].aName = Console.ReadLine();
                Console.WriteLine("Enter Atom Weight: ");
                Atom[i].aweight = float.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Exit");
                end = i;
                return false;
            }
            i++;
            return true;
        }
        public void display()
        {
            for (i = 0; i < end; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", Atom[i].aNumber, Atom[i].aSymbol, Atom[i].aName, Atom[i].aweight);
            }
        }
    }
}
