using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_EnumeracoesComposicao.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; } 

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append(this.Name);
            text.Append(", ");
            text.Append(this.Price);
            text.Append(", ");
            return text.ToString();
        }
    }
}
