using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ZH2_IQGAMA
{
     class Szemely : ITagolhato
    {
        char vezeteknevKezdo;
        char kersztnevKezdo;
        public char A { get { return vezeteknevKezdo; } set { vezeteknevKezdo = value; } }
        public char B { get { return kersztnevKezdo; } set { kersztnevKezdo = value; } }

        

        public Szemely(char a, char b)
        {
            
            if (a != (int)'A' && a != (int)'B' && a != (int)'C' && a != (int)'D' && a != (int)'E' && a != (int)'F' && a != (int)'G' && a != (int)'H' && a != (int)'I' && a != (int)'J' && a != (int)'K' && a != (int)'L' && a != (int)'M' && a != (int)'N' && a != (int)'O' && a != (int)'P' && a != (int)'Q' && a != (int)'R' && a != (int)'S' && a != (int)'T' && a != (int)'U' && a != (int)'V' && a != (int)'W' && a != (int)'X' && a != (int)'Y' && a != (int)'Z')
            {
                throw new AdathibaException("Nem megfelelő számot adtál meg");
            }
            else if (b != (int)'A' && b != (int)'B' && b != (int)'C' && b != (int)'D' && b != (int)'E' && b != (int)'F' && b != (int)'G' && b != (int)'H' && b != (int)'I' && b != (int)'J' && b != (int)'K' && b != (int)'L' && b != (int)'M' && b != (int)'N' && b != (int)'O' && b != (int)'P' && b != (int)'Q' && b != (int)'R' && b != (int)'S' && b != (int)'T' && b != (int)'U' && b != (int)'V' && b != (int)'W' && b != (int)'X' && b != (int)'Y' && b != (int)'Z')
            {
                throw new AdathibaException("Nem megfelelő számot adtál meg");
            }
            else
            {
                A = a;
                B = b;

            }

        }
    }
}
