using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace C16_Ex01_Tal_201587524_Shay_300332863
{
    public class EnemyMinion : Ship
    {
        override public void Movement() { }
        public override Vector2 Position { get; set; }

        public EnemyMinion()
        {
            Position = new Vector2(0, 40);
        }
    }
}
