namespace CoffeeMachine
{
    internal sealed class DoubleEspresso : Espresso
    {
        public DoubleEspresso() : base() { }
        public DoubleEspresso(int levelSugar) : base(levelSugar) { }
        public DoubleEspresso(int levelSugar, int levelFortress) : base(levelSugar, levelFortress) { }
        public int LevelEspresso => 2;
    }
}