using AulaDecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDecoratorPattern
{
    //Concrete Decorator 
    public class BaconDecorator:PizzaDecorator
    {
        public BaconDecorator(Interfaces.IPizza pizza)
            : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com bacon extra";
            return pizza;
        }
    }
}
