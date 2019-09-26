using System.Collections.Generic;
using FluentBuilder.Models;

namespace FluentBuilder.Builder
{
    public class PizzaFluentBuilder
    {
        private readonly Pizza _pizza;

        public static PizzaFluentBuilder Crear(TamañoEnum tamaño)
        {
            return new PizzaFluentBuilder(tamaño);
        }

        private PizzaFluentBuilder(TamañoEnum tamaño)
        {
            _pizza = new Pizza {Tamaño = tamaño, Relleno = new List<string>()};
        }

        public PizzaFluentBuilder ConMasaSuave()
        {
            _pizza.Masa = "Suave";
            return this;
        }

        public PizzaFluentBuilder ConMasaCocida()
        {
            _pizza.Masa = "Cocido";
            return this;
        }

        public PizzaFluentBuilder ConSalsaRoquefort()
        {
            _pizza.Salsa = "Roquefort";
            return this;
        }

        public PizzaFluentBuilder ConSalsaPicante()
        {
            _pizza.Salsa = "Picante";
            return this;
        }

        public PizzaFluentBuilder AñadirMozzarela()
        {
            _pizza.Relleno.Add("mozzarela");  ;
            return this;
        }

        public PizzaFluentBuilder AñadirParmesano()
        {
            _pizza.Relleno.Add("parmesano");
            return this;
        }

        public PizzaFluentBuilder AñadirOtroIngrediente(string ingrediente)
        {
            _pizza.Relleno.Add(ingrediente);
            return this;
        }

        public Pizza Cocinar()
        {
            return _pizza;
        }
    }
}
