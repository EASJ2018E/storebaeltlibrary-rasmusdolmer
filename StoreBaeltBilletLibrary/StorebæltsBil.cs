using System;
using System.Linq.Expressions;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    /// <summary>
    /// StorebæltsBil klasse med nogle properties, en default constructor og 2 metoder
    /// </summary>
    public class StorebæltsBil : Bil
    {
        /// <summary>
        /// Constructor med parametre fra base klassen køretøj
        /// </summary>
        public StorebæltsBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            this.Nummerplade = nummerplade;
            this.Dato = dato;
            this.Brobizz = brobizz;
        }

        /// <summary>
        /// Denne metode returnerer bilens pris med weekendrabat inkluderet
        /// </summary>
        /// <returns>Returnerer en variabel af typen double</returns>
        public double RabatPris()
        {
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return Pris() * 0.8;
            }

            return Pris();
        }
    }
}
