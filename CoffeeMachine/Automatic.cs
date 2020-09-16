using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    internal class Automatic : IAutomatic
    {
        private List<IDrink> drinks;
        public Automatic()
        {

        }
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
        public List<IDrink> Drinks { get { return drinks; } }

        public AutomaticState State => throw new NotImplementedException();

        public void Make(IDrink drink)
        {
            DrinkBeginMade?.Invoke(this, new EventArgs());
        }

        public int ReturnСhange()
        {
            throw new System.NotImplementedException();
        }

        public void AddDrink()
        {
            throw new System.NotImplementedException();
        }

        public void AddDrink(IDrink drink)
        {
            throw new NotImplementedException();
        }

        public event System.EventHandler DrinkBeginMade;
        public event System.EventHandler DrinkCancelMade;
        public event EventHandler StateChanged;
    }

    public enum AutomaticState
    {
        ReadyToWork,
        ChooseDrink,
        ReciveMoney,
        Working,
        Canceled,
        Ready
    }
}