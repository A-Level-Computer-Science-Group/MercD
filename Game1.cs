﻿using System;
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
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            // Draw Arena
            // borders
            var borderColor = Color.Black;
            spriteBatch.Draw(whitePixel, new Rectangle(0, 0, screenResolution.width, screenResolution.height / 10), borderColor);
            spriteBatch.Draw(whitePixel, new Rectangle(0, screenResolution.height * 9 / 10, screenResolution.width, screenResolution.height / 10), borderColor);
            spriteBatch.Draw(whitePixel, new Rectangle(0, 0, screenResolution.width / 10, screenResolution.height), borderColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 9 / 10, 0, screenResolution.width / 10, screenResolution.height), borderColor);

            // platforms
            var platformColor = Color.Blue;
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 1 / 10, screenResolution.height * 2 / 10, screenResolution.width * 2 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 6 / 10, screenResolution.height * 2 / 10, screenResolution.width * 3 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 3 / 10, screenResolution.height * 3 / 10, screenResolution.width * 1 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 7 / 10, screenResolution.height * 4 / 10, screenResolution.width * 2 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 1 / 10, screenResolution.height * 5 / 10, screenResolution.width * 2 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 4 / 10, screenResolution.height * 5 / 10, screenResolution.width * 1 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 7 / 10, screenResolution.height * 6 / 10, screenResolution.width * 2 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 1 / 10, screenResolution.height * 7 / 10, screenResolution.width * 3 / 10, screenResolution.height * 1 / 10), platformColor);
            spriteBatch.Draw(whitePixel, new Rectangle(screenResolution.width * 5 / 10, screenResolution.height * 7 / 10, screenResolution.width * 4 / 10, screenResolution.height * 1 / 10), platformColor);

            // End Arena

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}