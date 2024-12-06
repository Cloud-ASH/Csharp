namespace ObjectOrientedProgramming
{
    public class Color
    {
        public int Red { get; private set; }
        public int Green { get; private set; }
        public int Blue { get; private set; }
        public int Alpha { get; private set; }

        public Color(int red, int green, int blue, int alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public int GetGrayScale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}