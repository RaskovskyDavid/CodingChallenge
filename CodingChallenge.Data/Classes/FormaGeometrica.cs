/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 3;
        public const int Circulo = 2;
        public const int Trapecio = 4;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;

        #endregion

        private readonly decimal _lado;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<IGeometrica> formas,
            Dictionary<string, string> diccionario)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(diccionario["h1-vacio"]);                
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(diccionario["h1-no-vacio"]);
                int numero = 0;
                decimal area = 0;
                decimal perimetro = 0;
                int tipo = 0;
                int numeroDeFormas = 0;
                decimal perimetrosDeFormas = 0;
                decimal areaDeFormas = 0;
                var lista = formas.OrderBy(f => f.ObtenerTipo()).ToList();
                string @key = null;
                foreach (var forma in lista)
                {
                    
                    if(forma.ObtenerTipo() != tipo)
                    {
                        if(tipo != 0)
                            sb.Append(ObtenerLinea(numero, area, perimetro, key, diccionario));
                        key = forma.ObtenerkeyDeDiccionario();
                        tipo = forma.ObtenerTipo();                        
                        numero = 1;
                        area = forma.CalcularArea();
                        perimetro = forma.CalcularPerimetro();
                    }
                    else
                    {
                        numero++;
                        area += forma.CalcularArea();
                        perimetro += forma.CalcularPerimetro();
                    }
                    areaDeFormas += forma.CalcularArea();
                    perimetrosDeFormas += forma.CalcularPerimetro();
                    numeroDeFormas++;
                    
                }
                sb.Append(ObtenerLinea(numero, area, perimetro, key, diccionario));

                // FOOTER
                sb.Append(diccionario["total-final"]);
                sb.Append(numeroDeFormas + " " + diccionario["formas"] + " ");
                sb.Append(diccionario["perimetro"] + perimetrosDeFormas.ToString("#.##") + " ");
                sb.Append("Area " + areaDeFormas.ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string @key,
            Dictionary<string, string> diccionario)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma( key, cantidad, diccionario)} | {diccionario["linea-area"]} {area:#.##} | {diccionario["linea-perimetro"]} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string TraducirForma(string @key, int cantidad, 
            Dictionary<string, string> diccionario)
        {
            return cantidad == 1 ? diccionario[key+"-singular"] : diccionario[key + "-plural"];
        }

        public decimal CalcularArea()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * _lado;
                case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal CalcularPerimetro()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * 4;
                case Circulo: return (decimal)Math.PI * _lado;
                case TrianguloEquilatero: return _lado * 3;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}
