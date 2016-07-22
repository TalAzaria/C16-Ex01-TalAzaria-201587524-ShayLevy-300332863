using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace C16_Ex01_Tal_201587524_Shay_300332863
{
    class EnemyMinionYellow : EnemyMinion
    {
        public static string spriteImage
        {
            get
            {
                return @"Sprites\Enemy0301_32x32";
            }
        }
        public EnemyMinionYellow()
        {
            Position = new Vector2(1, 1);
        }
    }
}
