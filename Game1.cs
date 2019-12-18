using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ScreenResolution screenResolution = new ScreenResolution();
        public static Random Random;
        private SnowEmitter _snowEmitter;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // FPS limit. 1d = 1 second, 60d = 60fps.
            this.TargetElapsedTime = TimeSpan.FromSeconds(1d / 60d);

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Window.AllowUserResizing = true;
            Random = new Random();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _snowEmitter = new SnowEmitter(new Sprite(Content.Load<Texture2D>("Particles/Snow")));
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            _snowEmitter.Update(gameTime);
            screenResolution.Update(Window);
            screenResolution.ConsoleWrite();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MidnightBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            _snowEmitter.Draw(gameTime, spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}