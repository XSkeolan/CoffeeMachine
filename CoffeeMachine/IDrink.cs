using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    public interface IDrink
    {
        int Price { get; set; }
        string Name { get; set; }
    }
}