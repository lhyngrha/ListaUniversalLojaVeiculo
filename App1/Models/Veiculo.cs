using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class Veiculo
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string ano { get; set; }
        public double preco { get; set; }
        public string fabricante { get; set; }
        public bool situacaoVenda { get; set; }

        public override string ToString()
        {
            return $"{id} - {modelo} - {ano} - {preco} - {fabricante} - {situacaoVenda}";
        }

    }
}
