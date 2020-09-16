using System;

namespace CoffeeMachine
{
    public sealed class HotChocolate : IDrink
    {
        public bool WithMilk { get; }
        public HotChocolate(bool milk)
        {
            WithMilk = milk;
            LevelSugar = 3;
        }

        public HotChocolate(bool milk,int levelSugar)
        {
            WithMilk = milk;
            if(levelSugar<0 || levelSugar>5)
                throw new ArgumentException("Уровень сахара должен иметь значение от 0 до 5", "levelSugar");
            LevelSugar = levelSugar;
        }

        public int Price => throw new NotImplementedException();
        public string Name => throw new NotImplementedException();

        public int LevelSugar { get; }
    }
}