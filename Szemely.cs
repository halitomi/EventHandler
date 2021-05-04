using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SZTF2_ZH2_IQGAMA
{
    class Szemely : ITagolhato, IComparable<Szemely>
    {
        char vezeteknevKezdo;
        char kersztnevKezdo;
        /// <summary>
        /// A tulajdonság legyen a vezetéknév kezdőbetűje, 
        /// </summary>
        public char A { get { return vezeteknevKezdo; } set { vezeteknevKezdo = value; } }

        /// <summary>
        /// a B tulajdonság a keresztnév kezdőbetűje
        /// </summary>
        public char B { get { return kersztnevKezdo; } set { kersztnevKezdo = value; } }



        public Szemely(char a, char b)
        {

            // értékadás miatt olyan adat kerülne, amely 
            // nem az angol ABC nagybetűi közül való
            //Legyen nagybetü 
            if (!Char.IsUpper(a))
            {
                throw new AdathibaException("Nem megfelelő számot adtál meg");

            }
            if (Char.IsLower(b))
            {
                throw new AdathibaException("Nem megfelelő számot adtál meg");

            }
            //Legyen angol abc betüje

            bool isCharacterAAlphaBet = Regex.IsMatch(a.ToString(), "[a-z]", RegexOptions.IgnoreCase);
            if (isCharacterAAlphaBet == false)
            {
                throw new AdathibaException("Nem megfelelő számot adtál meg");
            }

            bool isCharacterBAlphaBet = Regex.IsMatch(b.ToString(), "[a-z]", RegexOptions.IgnoreCase);
            if (isCharacterBAlphaBet == false)
            {
                throw new AdathibaException("Nem megfelelő számot adtál meg");
            }

            vezeteknevKezdo = a;
            kersztnevKezdo = b;

        }

        public int CompareTo(Szemely other)
        {//TODO: valamit megvalositani
            throw new NotImplementedException();
        }
    }
}

