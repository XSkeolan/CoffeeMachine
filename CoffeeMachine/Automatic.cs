using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    internal class Automatic : IAutomatic
    {
        public Drinks CurrentDrink
        {
            get => default(int);
        }

        public int CurrentMoney
        {
            get => default(int);
        }

        public int LevelSugar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Instruction => throw new NotImplementedException();

        //Нужно выбрать
        public IDrink[] Drinks { get => throw new NotImplementedException();}

        public void Make(IDrink drink)
        {
            DrinkBeginMade?.Invoke(this, new EventArgs());
            throw new System.NotImplementedException();
        }

        public int ReturnСhange()
        {
            throw new System.NotImplementedException();
        }

        public event System.EventHandler DrinkBeginMade;
        public event System.EventHandler DrinkCancelMade;
    }
}