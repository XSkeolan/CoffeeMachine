using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    internal abstract class Coffee : IDrink
    {
        public int Price { get; }
        public string Name { get; }
        protected int levelSugar = 3;
        protected int levelFortress = 2;

        public Coffee(int levelSugar)
        {
            if (levelSugar < 0 || levelSugar > 5)
                throw new ArgumentException("Уровень сахара должен иметь значение от 0 до 5", "levelSugar");
            this.levelSugar = levelSugar;
            levelFortress = 2;
        }

        public Coffee(int levelSugar,int levelFortress):this(levelSugar)
        {
            if(levelFortress <0 || levelFortress >3)
                throw new ArgumentException("Уровень крепкости должен иметь значение от 0 до 3", "levelFortress");
            this.levelFortress = levelFortress;
        }

        public Coffee()
        {
            levelSugar = 3;
            levelFortress = 2;
        }

        public int Fortress { get => levelFortress; }
        public int LevelSugar { get => levelSugar; }
    }

    public enum Drinks
    {
        Espresso,
        Latte,
        Cappuccino,
        HotChocolate,
        DoubleEspresso,
        Americano,
        Tea,
        GreenTea,
        HotChocolateWithMilk
    }
}