using AulaDecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDecoratorPattern
{
    public class PizzaDecorator:IPizza
    {
        //Base Decorator
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuscarTipoPizza()
        {
            var pizza = _pizza.BuscarTipoPizza();
            return pizza;
        }
        
    }
}

 

