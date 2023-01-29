using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPatron.Models
{
    public class Gerente : Aprobador
    {
        public override string Procesar(Carro c)
        {
            return String.Format("Compra aprobada por {0}",this.GetType().Name);
        }
    }
}
