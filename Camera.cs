using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
namespace Camera
{
    public class Camera
    {
        public Rectangle scope;
        public Camera(Rectangle scope)
        {
            this.scope = scope;
        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                scope.Y -= 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                scope.Y += 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                scope.X -= 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                scope.X += 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Scroll))
            {

            }
        }
    }
}