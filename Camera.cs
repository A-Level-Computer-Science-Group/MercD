using Microsoft.Xna.Framework; 
using Microsoft.Xna.Framework.Input; 
namespace Camera 
{ 
    public class Camera 
    { 
        private int perviousScrollWheelValue = 0;
        public float zoom = 1f;
        public Rectangle scope; 
        public Camera(Rectangle scope) 
        { 
            this.scope = scope; 
        } 
        public void Update(GameTime gameTime) 
        {
            MouseState currentMouseState = Mouse.GetState();
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
            if (currentMouseState.ScrollWheelValue < perviousScrollWheelValue)
            {
                zoom -= 0.1f;
                perviousScrollWheelValue = currentMouseState.ScrollWheelValue;
            }
            if (currentMouseState.ScrollWheelValue > perviousScrollWheelValue)
            {
                zoom = 0.1f;
                perviousScrollWheelValue = currentMouseState.ScrollWheelValue;
            }
        } 
    } 
}