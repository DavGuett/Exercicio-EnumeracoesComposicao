using Exercicio_EnumeracoesComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_EnumeracoesComposicao.Entities
{
    internal class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public void AddItem(OrderItem item) {

        }
        public void RemoveItem(OrderItem item) {
        }

        public double Total()
        {
            return 0;
        }

        public Order(DateTime moment, OrderStatus status)
        {
            this.moment = moment;
            this.status = status;
        }
    }
}
