using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class Player
    {
        public int attack = 20;
        public int defense = 8;
        public int health = 40;

        public int level = 1;
        public int expAmount = 0;
        public int expPerLevel;

        public int GetLevel()
        {
            SaveLoad saveLoad = new SaveLoad();
            level = saveLoad.loadDataLevel();
            return level;
        }

        public int GetAttack()
        {
            attack = GetLevel() + attack;
            return attack;
        }

        public int GetDefense()
        {
            defense = GetLevel() + defense;
            return defense;
        }

        public int GetHealth()
        {
            health = GetLevel() + health;
            return health;
        }

    }
}
