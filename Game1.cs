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
        private SpriteFont font;
        private int score = 0;

        private Texture2D arrow;
        private float angle = 0;
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
            arrow = Content.Load<Texture2D>("Images/Arrow");
            font = Content.Load<SpriteFont>("Score");
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
            sprite1.Update(interval, Speed);
            sprite2.Update(interval, Speed);
            System.Console.WriteLine((sprite2.position,sprite1.position));
            angle += 0.1f;

            lastTime = gameTime.TotalGameTime;
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.WhiteSmoke);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            Vector2 location = new Vector2(400, 240);
            Rectangle sourceRectangle = new Rectangle(0, 0, arrow.Width, arrow.Height);
            Vector2 origin = new Vector2(0, 0);
            spriteBatch.Draw(arrow, location, sourceRectangle, Color.White, angle, origin, 1.0f, SpriteEffects.None, 1);
            spriteBatch.DrawString(font, "Score: " + score, new Vector2(100,100), Color.Black);
            sprite1.Draw(spriteBatch);
            sprite2.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}