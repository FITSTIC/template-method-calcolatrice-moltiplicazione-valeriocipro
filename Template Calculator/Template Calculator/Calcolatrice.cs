using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Calculator
{
    abstract class Calcolatrice
    {
        protected int risultato = 0;
        protected int x = 0;
        protected int y = 0;
        public void Calcola()
        {
            Inputx();
            Inputy();
            Clear();
            Operazione();
            DisplayRisultato();
        }

        private void Clear()
        {
            risultato = 0;
        }

        protected abstract double Operazione();

        private void DisplayRisultato()
        {
            Console.WriteLine("Risultato: "+risultato);
        }

        private void Inputx()
        {
            Console.WriteLine("Inserisci il primo valore: ");
            x = Convert.ToInt32(Console.ReadLine());
        }

        private void Inputy()
        {
            Console.WriteLine("Inserisci il secondo valore: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
