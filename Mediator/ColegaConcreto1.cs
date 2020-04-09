using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ColegaConcreto1 : Colega
    {
        public ColegaConcreto1(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do colega 1: " + mensagem);
        }
    }
}
