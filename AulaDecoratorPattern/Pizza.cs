using AulaDecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDecoratorPattern
{
    public class Pizza:IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Pizza normal";
            return pizza;
        }
    }
}
