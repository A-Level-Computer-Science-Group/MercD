using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    public class Game1 : Game
    {
        Settings settings = new Settings();
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        // textures
        private Texture2D whitePixel;
        private Vector2 position;
        private TimeSpan lastTime;
        private float interval;
        ScreenResolution screenResolution = new ScreenResolution();
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
            base.Initialize();
            position.X = 100; position.Y = 100;

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            whitePixel = Content.Load<Texture2D>("white_pixel");
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            screenResolution.Update(Window);
            
            if (settings.consoleDebugScreenDimensions) screenResolution.ConsoleWrite();
            
            base.Update(gameTime);
            lastTime = gameTime.TotalGameTime;
            interval = (float)(gameTime.TotalGameTime - lastTime).TotalSeconds;
            Controls controls = new Controls(whitePixel, position);
            controls.Update(interval);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}