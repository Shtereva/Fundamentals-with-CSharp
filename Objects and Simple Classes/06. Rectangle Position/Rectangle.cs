using System;

namespace _06.Rectangle_Position
{
    class Rectangle
    {
        public long Left { get; set; }
        public long Top { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }

        public long Bottom 
        {
            get
            {
                return Top + Height;
            }
        }

        public long Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle r)
        {
            return r.Left <= Left && r.Right >= Right && r.Top <= Top && r.Bottom >= Bottom;
        }
    }
}
