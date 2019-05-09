using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : Geometria, IFormaGeometrica
    {
        public Circulo(decimal lado)
        {
            Lado = lado;
            Tipo = 2;
        }


        public decimal CalcularArea()
        {
            return(decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }

        public int ObtenerTipo()
        {
            return Tipo;
        }
    }
}
