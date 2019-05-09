using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Geometria
    {
        int _tipo;
        public virtual int Tipo
        {
            get
            {
                return _tipo;
            }
            protected set
            {
                _tipo = value;
            }
        }
        public decimal Lado { get; set; }
    }
}
