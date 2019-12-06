using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace main
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        TimeSpan lastTime;
        private Sprite sprite1;
        private Sprite2 sprite2;
        private Texture2D texture;
        private Vector2 position;

        public float Speed = 100f;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            texture = Content.Load<Texture2D>("Images/BlackHouse");
            position = new Vector2(0, 0);

            sprite1 = new Sprite(texture)
            {
                position = new Vector2(100, 100),
            };
            sprite2 = new Sprite2(texture)
            {
                position = new Vector2(200, 100),
            };

        }

        protected override void Update(GameTime gameTime)
        {
            if (lastTime == null)
            {
                lastTime = gameTime.TotalGameTime;
            }

            float interval = (float)(gameTime.TotalGameTime - lastTime).TotalSeconds;
            System.Console.WriteLine(interval);
            sprite1.Update(interval,Speed);
            //sprite2.Update(interval);

            lastTime = gameTime.TotalGameTime;
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            sprite1.Draw(spriteBatch);
            //sprite2.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);

        }
    }
}