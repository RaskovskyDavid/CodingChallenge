using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public static class Diccionarios
    {
        public static Dictionary<string, string> Castellano
        {
            get
            {
                var diccionario = new Dictionary<string, string>();
                diccionario.Add("h1-vacio", "<h1>Lista vacía de formas!</h1>");
                diccionario.Add("h1-no-vacio", "<h1>Reporte de Formas</h1>");
                diccionario.Add("total-final", "TOTAL:<br/>");
                diccionario.Add("formas", "formas");
                diccionario.Add("perimetro", "Perimetro ");
                diccionario.Add("cuadrado-singular", "Cuadrado");
                diccionario.Add("cuadrado-plural", "Cuadrados");
                diccionario.Add("circulo-singular", "Círculo");
                diccionario.Add("circulo-plural", "Círculos");
                diccionario.Add("triangulo-singular", "Triángulo");
                diccionario.Add("triangulo-plural", "Triángulos");
                diccionario.Add("linea-area", "Area");
                diccionario.Add("linea-perimetro", "Perimetro");
                return diccionario;
            }
        }
        public static Dictionary<string, string> Ingles
        {
            get
            {
                var diccionario = new Dictionary<string, string>();
                diccionario.Add("h1-vacio", "<h1>Empty list of shapes!</h1>");
                diccionario.Add("h1-no-vacio", "<h1>Shapes report</h1>");
                diccionario.Add("total-final", "TOTAL:<br/>");
                diccionario.Add("formas", "shapes");
                diccionario.Add("perimetro", "Perimeter ");
                diccionario.Add("cuadrado-singular", "Square");
                diccionario.Add("cuadrado-plural", "Squares");
                diccionario.Add("circulo-singular", "Circle");
                diccionario.Add("circulo-plural", "Circles");
                diccionario.Add("triangulo-singular", "Triangle");
                diccionario.Add("triangulo-plural", "Triangles");
                diccionario.Add("linea-area", "Area");
                diccionario.Add("linea-perimetro", "Perimeter");
                return diccionario;
            }
        }
    }
}
