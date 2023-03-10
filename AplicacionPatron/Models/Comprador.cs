using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPatron.Models
{
    public class Comprador : Aprobador
    {
        public override string Procesar(Carro c)
        {
            if(c.costo < 50000)
            {
                return String.Format("Compra aprobada por {0}",this.GetType().Name);
            }
            else
            {
                return _siguiente.Procesar(c);
            }
        }
    }
}
