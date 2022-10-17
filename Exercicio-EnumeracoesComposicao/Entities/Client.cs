using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_EnumeracoesComposicao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Olá");
            return text.ToString();
        }
    }
}
