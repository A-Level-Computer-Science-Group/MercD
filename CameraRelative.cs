using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input; 
using main;
using System;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        private GameTime gameTime;
        MouseState currentMouseState = Mouse.GetState();
        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }
        public void Draw(Texture2D texture, Rectangle destinationRectangle, SpriteBatch spriteBatch, ScreenResolution screenResolution)
        {
            float screenScaleRatioX = (float)screenResolution.width / (float)camera.scope.Width;
            float screenScaleRatioY = (float)screenResolution.height / (float)camera.scope.Height;
            camera.Update(gameTime);
            Rectangle cameraRelativeRectangle = new Rectangle(
                destinationRectangle.X - camera.scope.X,
                destinationRectangle.Y - camera.scope.Y,
                (int)(destinationRectangle.Width * screenScaleRatioX * camera.zoom),
                (int)(destinationRectangle.Height * screenScaleRatioY * camera.zoom)
            );
            Console.Write($"Zoom:{camera.zoom} & Scroll Value:{currentMouseState.ScrollWheelValue}");
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Draw(texture, cameraRelativeRectangle, Color.White);
            }
        }
    }
}
