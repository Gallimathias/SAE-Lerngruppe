using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    struct SemiVector
    {
        public int X => x;
        public int Y => y;

        public static SemiVector Null => new SemiVector(0, 0);

        private int x;
        private int y;

        public SemiVector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static SemiVector operator *(SemiVector vector1, SemiVector vector2)
            => new SemiVector(vector1.x * vector2.X, vector1.y * vector2.Y);
        public static SemiVector operator *(SemiVector vector, int integer)
            => new SemiVector(vector.X * integer, vector.Y * integer);

        public static SemiVector operator +(SemiVector vector1, SemiVector vector2)
            => new SemiVector(vector1.X + vector2.X, vector1.Y + vector2.Y);

        public static SemiVector operator -(SemiVector vector1, SemiVector vector2)
            => new SemiVector(vector1.X - vector2.X, vector1.Y - vector2.Y);

        public override string ToString() => $"[{x};{Y}]";
    }
}
