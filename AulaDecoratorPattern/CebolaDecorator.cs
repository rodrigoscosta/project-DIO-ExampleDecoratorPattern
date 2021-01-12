using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDecoratorPattern
{
    //Concrete Decorator
    public class CebolaDecorator:PizzaDecorator
    {
        public CebolaDecorator(Interfaces.IPizza pizza)
            : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com cebola extra";
            return pizza;
        }
    }
}
