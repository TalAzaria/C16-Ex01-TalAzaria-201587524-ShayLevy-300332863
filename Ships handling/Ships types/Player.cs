using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace C16_Ex01_Tal_201587524_Shay_300332863
{
    public class Player : Ship
    {
        public override void Movement() { }

        public override Vector2 Position { get; set; }
        //public override Vector2 Position { get { } set { } }

        public Player()
        {
            Position = new Vector2(0, 6);
        }
            
        public static string spriteImage
        {
            get
            {
                return @"Sprites\Ship01_32x32";
            }
        }

        //SpriteBatch spriteBatch;
        //Texture2D m_SpriteHelloMsg;

        //m_SpriteHelloMsg = Content.Load<Texture2D>(@"Sprites\HelloWorldMsg");

    }
}
