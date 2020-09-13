using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    internal class Drink : IDrink
    {
        public int Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public enum Drinks
    {
    }
}