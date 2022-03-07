using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingsBlahaAllaÖvningar
{
    internal class Uträkning
    {
        public double Tal1;
        public string Operator;
        public double Tal2;
        public double Resultat;
        
        public override string ToString()
        {
            return Tal1 + Operator + Tal2 + "=" + Resultat;
        }
    }
    internal class Miniräknare
    {
        // Inkapsling ingår här
        public double Resultat { get; private set; }
        private double Tal1, Tal2;
        private string Operator;
        private List<Uträkning> historik;

        public Miniräknare()
        {
            historik = new List<Uträkning>();
        }

        public void NyttTal(string input)
        {
            // Kontrollera att det faktiskt kan omvandlas till en double
            try
            {
                double tal;

                if (input.ToUpper() == "MARCUS")
                {
                    tal = 42;
                }
                else
                {
                    tal = double.Parse(input);
                }
                Tal1 = Tal2;
                Tal2 = tal;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }

        public bool NyOperator(string input)
        {
            if(input == "+" || input == "-" || input == "*" || input == "/")
            {
                Operator = input;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RäknaUt()
        {
            switch (Operator)
            {
                case "+":
                    Resultat = Tal1 + Tal2;
                    break;
                case "-":
                    Resultat = Tal1 - Tal2;
                    break;
                case "*":
                    Resultat = Tal1 * Tal2;
                    break;
                case "/":
                    Resultat = Tal1 / Tal2;
                    break;
                default: Console.WriteLine("Du har inte valt en giltig operator, resultatet stämmer inte");
                    break;
            }
            historik.Add(new Uträkning { Tal1 = Tal1, Tal2 = Tal2, Operator = Operator, Resultat = Resultat });
        }
        public void PrintaHistorik()
        {
            Console.WriteLine("---HISTORIK---");
            foreach(var h in historik)
            {
                Console.WriteLine(h.Resultat);
            }
            Console.WriteLine("---/HISTORIK---");
        }
        public void PrintaVersion()
        {
            Console.WriteLine("Miniräknare version 1, standard.");
        }
    }
}
