namespace ObjectOrientedProgramming
{
    public class Ball
    {
        public Color Color { get; private set; }
        public int Size { get; private set; }
        private int ThrowCount { get; set; }

        public Ball(Color color, int size)
        {
            Color = color;
            Size = size;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                ThrowCount++;
            }
        }

        public int GetThrowCount()
        {
            return ThrowCount;
        }
    }
}