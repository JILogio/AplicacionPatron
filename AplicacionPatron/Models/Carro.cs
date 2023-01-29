using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPatron.Models
{
    [Table("carro")]
    public class Carro
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }

        [MaxLength(250)]
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public decimal costo { get; set; }
    }
}
