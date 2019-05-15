using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : Geometria, IGeometrica
    {
        public Trapecio(decimal lado)
        {
            Lado = lado;
            Tipo = 4;
            KeyDeDiccionario = "trapecio";

        }


        public decimal CalcularArea()
        {
            decimal area1 = Lado * Lado;
            decimal area2 = area1 / 2;
            return area1 + area2;
        }

        public decimal CalcularPerimetro()
        {
            decimal i = (decimal)Math.Sqrt(2 * Math.Pow((double)Lado, 2));
            return i+ (4 * Lado);
        }
        public string ObtenerkeyDeDiccionario()
        {
            return KeyDeDiccionario;
        }
        public int ObtenerTipo()
        {
            return Tipo;
        }
    }
}
