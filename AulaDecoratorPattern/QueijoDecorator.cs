using AulaDecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDecoratorPattern
{
    //Concrete Decorator
    public class QueijoDecorator:PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza)
            :base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com queijo extra";
            return pizza;
        }
    }
}
