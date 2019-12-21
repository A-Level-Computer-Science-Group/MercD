using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Camera;
namespace main
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ScreenResolution screenResolution = new ScreenResolution();
        Texture2D texture;
        Camera.Camera camera = new Camera.Camera(new Rectangle(0, 0, 200, 200));
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
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            texture = Content.Load<Texture2D>("Untitled");
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            screenResolution.Update(Window);
            screenResolution.ConsoleWrite();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Rectangle destinationRectangle = new Rectangle(0, 0, 100, 100);
            spriteBatch.Begin();
            camera.Update(gameTime);
            // TODO: Add your drawing code here
            (new CameraRelative(new Camera.Camera(new Rectangle(0, 0, 200, 200)))).Draw(texture, destinationRectangle, spriteBatch, screenResolution);

            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}