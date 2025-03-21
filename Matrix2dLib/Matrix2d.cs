#nullable disable
using System.Security.AccessControl;

namespace Matrix2DLib
{
    //immutable class
    public class Matrix2D : IEquatable<Matrix2D>
    {
        int a, b, c, d;
        /*
         -    -
        | a  b |
        | c  d |
         -    -
        */
        public int A => a;
        public int B => b;
        public int C => c;
        public int D => d;

        public Matrix2D()
        {
            a = 1;
            b = 0;
            c = 0;
            d = 1;
        }
        public Matrix2D(int a11, int a12, int a21, int a22)
        {
            a = a11;
            b = a12;
            c = a21;
            d = a22;
        }
        public Matrix2D Id => new Matrix2D(1, 0, 0, 1);
        public Matrix2D Zero = new Matrix2D(0, 0, 0, 0);

        public override string ToString()
        {
            return $"[[{a}, {b}], [{c}, {d}]]";
        }
        public bool Equals(Matrix2D other)
        {
            if (other is null) return false;
            return
                a == other.a &&
                b == other.b &&
                c == other.c &&
                d == other.d;
        }
        public static bool operator ==(Matrix2D left, Matrix2D right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Matrix2D left, Matrix2D right)
        {
            return !left.Equals(right);
        }
        public static Matrix2D operator +(Matrix2D left, Matrix2D right)
        {
            return new Matrix2D(
                left.a + right.a,
                left.b + right.b,
                left.c + right.c,
                left.d + right.d
            );
        }
        public static Matrix2D operator -(Matrix2D left, Matrix2D right)
        {
            return new Matrix2D(
                left.a - right.a,
                left.b - right.b,
                left.c - right.c,
                left.d - right.d
            );
        }
        public static Matrix2D operator *(Matrix2D left, Matrix2D right)
        {
            return new Matrix2D(
                left.a * right.a + left.b * right.c,
                left.a * right.b + left.b * right.d,
                left.c * right.a + left.d * right.c,
                left.c * right.b + left.d * right.d
            );
        }
        public static Matrix2D operator *(int k, Matrix2D right)
        {
            return new Matrix2D(
                k * right.a,
                k * right.b,
                k * right.c,
                k * right.d
            );
        }
        public static Matrix2D operator *(Matrix2D left, int k)
        {
            return new Matrix2D(
                left.a * k,
                left.b * k,
                left.c * k,
                left.d * k
            );
        }
        public static Matrix2D Transpose(Matrix2D m)
        {
            return new Matrix2D(m.a, m.c, m.b, m.d);
        }
        public static explicit operator int[,](Matrix2D m)
        {
            return new int[2, 2] { { m.a, m.b }, { m.c, m.d } };
        }
    }
}