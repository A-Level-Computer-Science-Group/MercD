using Microsoft.Xna.Framework;

namespace main
{
    public static class intersection
    {
        static bool intersect(Rectangle first, Rectangle second) =>
            ((first.Bottom < second.Bottom) && (first.Bottom < second.Top)
            || ((second.Bottom < first.Top) && (second.Bottom > first.Bottom))
            || ((first.Top < second.Top) && (first.Bottom > second.Bottom))
            || ((second.Top > first.Bottom) && (first.Top > second.Top)) &&
            ((first.Right > second.Left) && first.Right < second.Right)
            || ((first.Left > second.Left) && (first.Left < second.Left))
            || ((second.Right < first.Right) && (second.Right > first.Left))
            || ((second.Left > first.Left) && (second.Left < first.Right)));
    }
}