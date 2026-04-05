using FinalBattler.Character;
using FinalBattler.Interfaces;

namespace FinalBattler.GamePlay
{
    public class Combat : IBattleAction
    {


        public void Attack(List<Creations> fighters)
        {
            if (fighters[0].TotalPower > fighters[1].TotalPower)
            {
                fighters[1].TotalHealth -= fighters[0].TotalPower;
            }
            else if (fighters[0].TotalPower < fighters[1].TotalPower)
            {
                fighters[0].TotalHealth -= fighters[1].TotalPower;
            }
            else if (fighters[0].TotalPower == fighters[1].TotalPower)
            {
                fighters[1].TotalHealth -= fighters[0].TotalPower;
                fighters[0].TotalHealth -= fighters[1].TotalPower;
            }
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

        public void Move()
        {
            
        }
    }
}
