using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    public interface IAutomatic
    {
        int LevelSugar { get; set; }
        string Instruction { get; }
        IDrink[] Drinks { get; }

        void Make(IDrink drink);
    }
}