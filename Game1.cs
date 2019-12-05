using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Sprite sprite1;
        private Sprite2 sprite2;
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

            sprite1 = new Sprite(texture)
            {
                position = new Vector2(100,100),
                Speed = 3f,
            };
            sprite2 = new Sprite2(texture)
            {
                position = new Vector2(200,100),
                Speed = 3f,
            };
            
        }

        protected override void Update(GameTime gameTime)
        {
            sprite1.Update();
            sprite2.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            sprite1.Draw(spriteBatch);
            sprite2.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);

        }
    }
}