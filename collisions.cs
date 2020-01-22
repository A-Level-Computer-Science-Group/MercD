using Microsoft.Xna.Framework;

namespace main
{
    // this intersection class compares two rectangles to output a boolean result based on the outcome.
    public static class intersection
    {
        /*The intersect function compares if atleast one x co-ordinate is contained within 
        either the first rectangle or the second rectangle and also the y co-ordinate is
        contained with either the first or the second rectangle. */
        static bool intersect(Rectangle first, Rectangle second) =>
            ((first.Bottom < second.Bottom) && (first.Bottom < second.Top)
            || ((second.Bottom < first.Top) && (second.Bottom > first.Bottom))
            || ((first.Top < second.Top) && (first.Bottom > second.Bottom))
            || ((second.Top > first.Bottom) && (first.Top > second.Top)) &&
            ((first.Right > second.Left) && first.Right < second.Right)
            || ((first.Left > second.Left) && (first.Left < second.Left))
            || ((second.Right < first.Right) && (second.Right > first.Left))
            || ((second.Left > first.Left) && (second.Left < first.Right)));
    } /* I have also identified corner cases and created a condition for them aswell.*/
}