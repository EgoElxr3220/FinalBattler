using System;
using System.Collections.Generic;
using System.Text;

namespace FinalBattler.Interfaces
{
    public interface IBattleAction
    {
        void Attack();
        void Move();
        void Disengage();
        void Dodge();
        void Hide();

    }
}
