
using FinalBattler.GamePlay;
using FinalBattler.Character;
using FinalBattler.Interfaces;

public class Program
{
    static void Main()
    {
        List<Creations> fightingEntities = new List<Creations>() { new Monster(), new Hero()};
        Combat combat = new Combat();
        combat.Attack(fightingEntities);
    }
}

