using FluentBuilder.Builder;
using FluentBuilder.Models;
using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizzaPersonalizada = PizzaFluentBuilder.Crear(TamañoEnum.Familiar)
                .ConMasaSuave()
                .ConSalsaRoquefort()
                .AñadirMozzarela()
                .AñadirParmesano()
                .Cocinar();

            Pizza pizzaPersonalizada2 = PizzaFluentBuilder.Crear(TamañoEnum.Mediana)
                .ConMasaCocida()
                .ConSalsaPicante()
                .AñadirMozzarela()
                .AñadirParmesano()
                .AñadirOtroIngrediente("Chorizo")
                .Cocinar();

            Console.WriteLine(pizzaPersonalizada.ToString());
            Console.WriteLine(pizzaPersonalizada2.ToString());

            Console.ReadKey();
        }
    }
}
