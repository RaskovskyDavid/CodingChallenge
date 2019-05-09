using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Geometria, IFormaGeometrica
    {
        public Cuadrado(decimal lado)
        {
            Lado = lado;
            Tipo = 1;
        }


        public decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public decimal CalcularPerimetro()
        {
            return Lado * 4;
        }

        public int ObtenerTipo()
        {
            return Tipo;
        }
    }
}
