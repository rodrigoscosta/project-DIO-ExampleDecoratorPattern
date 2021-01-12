using AulaDecoratorPattern.Interfaces;
using System;

namespace AulaDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza queijoDecorator = new QueijoDecorator(pizza);
            IPizza baconDecorator = new BaconDecorator(queijoDecorator);
            IPizza cebolaDecorator = new CebolaDecorator(baconDecorator);


            Console.WriteLine(cebolaDecorator.BuscarTipoPizza());
            Console.WriteLine();
        }
    }
}
