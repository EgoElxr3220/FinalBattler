using FinalBattler.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalBattler.Interfaces
{
    public interface IBattleAction
    {
        void Attack(List<Creations> fighters);
        void Move();
        void Disengage();
        void Dodge();
        void Hide();

    }
}
