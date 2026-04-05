using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero, IBattleAction
    {
        public int Health { get; private set; }
        public int Power { get; private set; }
        public int Luck { get; private set; }
        public int Mana { get; private set; }
        public int ExperienceRemaining { get; private set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Level = 0;
            Health = 10;
            Power = 1;
            Luck = 1;
            Mana = 1;
        }

        public void DisplayStats(bool showTotalStats = false)
        {
            if (showTotalStats)
            {
                CalculateTotals();
                Console.WriteLine(Level);
                Console.WriteLine(TotalHealth);
                Console.WriteLine(TotalPower);
                Console.WriteLine(TotalLuck);
                Console.WriteLine(Mana);
            }
            else
            {
                Console.WriteLine(Level);
                Console.WriteLine(Health);
                Console.WriteLine(Power);
                Console.WriteLine(Luck);
                Console.WriteLine(Mana);
            }
        }
        public void LevelUp()
        {
            Random random = new Random();
            Level++;
            switch (CombatClass)
            {
                case CombatClass.Wizard: 
                    Health += random.Next(1, 16);
                    Power += random.Next(3, 6);
                    Luck += random.Next(1, 4);
                    Mana += random.Next(10, 21);
                    break;
                case CombatClass.Warrior:
                    Health += random.Next(10, 21);
                    Power += random.Next(1, 4);
                    Luck += random.Next(1, 4);
                    Mana += random.Next(1, 6);
                    break;
                case CombatClass.Rogue:
                    Health += random.Next(1, 16);
                    Power += random.Next(1, 4);
                    Luck += random.Next(3, 6);
                    Mana += random.Next(5, 11);
                    break;
            }
        }
        public void CalculateTotals()
        {
            TotalHealth += Health;
            TotalPower += Power;
            TotalLuck += Luck;
            
        }

        public void Attack(List<Creations> fighters)
        {

        }
        public void Move()
        {

        }
        public void Disengage()
        {

        }
        public void Dodge()
        {

        }
        public void Hide()
        {

        }
    }
}
