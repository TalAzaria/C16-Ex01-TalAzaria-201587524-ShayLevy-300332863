using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;                            //TODO: Delete

namespace C16_Ex01_Tal_201587524_Shay_300332863
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch m_SpriteBatch;
        Opponents opponents = new Opponents(9,1,2,2);
        Dictionary<Ship, string> m_SpriteImages;
        Dictionary<Ship, Texture2D> m_SpriteImageList = new Dictionary<Ship, Texture2D>();
        //List<Texture2D> m_SpriteImageList;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            m_SpriteImages = opponents.getSprites();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            m_SpriteBatch = new SpriteBatch(GraphicsDevice);

            foreach(var i in m_SpriteImages)
            {
                m_SpriteImageList.Add(i.Key, Content.Load<Texture2D>(i.Value));
            }

            //m_SpriteImage = Content.Load<Texture2D>(@"Sprites\MotherShip_32x120");

        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            m_SpriteBatch.Begin();

            //foreach (var minion in m_SpriteImageList.Keys)
            //{
            //    for
            //    Debug.WriteLine(minion.Position);

            //}

            Texture2D texture;
            Debug.WriteLine(" sfkofoskvmfo " + opponents.player);

            if(m_SpriteImageList.TryGetValue(opponents.player, out texture))
            {
                m_SpriteBatch.Draw(texture, opponents.player.Position, Color.White);
            }
            //Debug.WriteLine(" sfkofoskvmfo " + texture + "  " + opponents.player.Position);


            if (m_SpriteImageList.TryGetValue(opponents.enemyMotherShip, out texture))
            {
                m_SpriteBatch.Draw(texture, opponents.enemyMotherShip.Position, Color.White);
            }

            foreach (var minion in opponents.minionsFleet)
            {
                if (m_SpriteImageList.TryGetValue(minion, out texture))
                {
                    m_SpriteBatch.Draw(texture, minion.Position, Color.White);
                }
            }

            //foreach (var i in m_SpriteImageList)
            //{
            //    m_SpriteBatch.Draw(i.Value, new Vector2(30, 30) + , Color.White);
            //}

            m_SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
