using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : Geometria, IGeometrica
    {
        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
            Tipo = 3;
            KeyDeDiccionario = "triangulo";
        }


        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public decimal CalcularPerimetro()
        {
            return Lado * 3;
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
