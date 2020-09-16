using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    internal class Tea : IDrink
    {
        public int LevelSugar { get; }

        public Tea()
        {
            LevelSugar = 3;
            TypeTea = TypeTea.Black;
        }

        public Tea(int levelSugar)
        {
            if (levelSugar < 0 || levelSugar > 5)
                throw new ArgumentException("Уровень сахара должен иметь значение от 0 до 5", "levelSugar");
            LevelSugar = levelSugar;
            TypeTea = TypeTea.Black;
        }

        public Tea(int levelSugar,TypeTea tea):this(levelSugar) => TypeTea = tea;

        public TypeTea TypeTea { get; }

        public int Price => throw new NotImplementedException();

        public string Name => "Tea";
    }
}