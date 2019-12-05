using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D texture;
        private Vector2 position;

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
        }

        protected override void Update(GameTime gameTime)
        {
            if(Keyboard.GetState().IsKeyDown(Keys.W))
            {
                position.Y -= 10; //Position.Y = position.Y - 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.S))
            {
                position.Y += 10; //PosY goes down 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.D))
            {
                position.X += 10; //PosX goes right 1
            }
            if(Keyboard.GetState().IsKeyDown(Keys.A))
            {
                position.X -= 10; //PosX goes left 1
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}