namespace CoffeeMachine
{
    internal class Espresso : Coffee
    {
        public Espresso(int levelSugar) : base(levelSugar) { }
        public Espresso(int levelSugar, int levelFortress) : base(levelSugar, levelFortress) { }
        public Espresso():base() { }
        public int LevelEspresso => 1;
    }
}