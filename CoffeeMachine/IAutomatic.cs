using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    public interface IAutomatic
    {
        string Instruction { get; }
        List<IDrink> Drinks { get; }
        AutomaticState State { get; }

        void Make(IDrink drink);
        void AddDrink(IDrink drink);
    }
}