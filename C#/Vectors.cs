namespace Vectors
{
    class Runner
    {
        public static void Main(string[] args)
        {
            vec3 vector = new vec3(3, 1, 4);
            vec3 otherVector = new vec3(1, 5, 9);

            Console.WriteLine(vector + otherVector + 4.7f + 3.0 + 2 / 5.0);
        }
    }

    struct vec3
    {
        public float x, y, z;

        public vec3()
        {
            x = y = z = 0f;
        }

        public vec3(float val)
        {
            x = y = z = val;
        }

        public vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static vec3 operator +(vec3 v1, vec3 v2)
        {
            return new vec3(
                v1.x + v2.x,
                v1.y + v2.y,
                v1.z + v2.z
            );
        }

        public static vec3 operator +(vec3 vec, float val)
        {
            return new vec3(
                vec.x + val,
                vec.y + val,
                vec.z + val
            );
        }

        public static vec3 operator +(vec3 vec, double val)
        {
            return new vec3(
                vec.x + (float)val,
                vec.y + (float)val,
                vec.z + (float)val
            );
        }

        public static vec3 operator -(vec3 v1, vec3 v2)
        {
            return new vec3(
                v1.x - v2.x,
                v1.y - v2.y,
                v1.z - v2.z
            );
        }

        public static vec3 operator -(vec3 vec, float val)
        {
            return new vec3(
                vec.x - val,
                vec.y - val,
                vec.z - val
            );
        }

        public static vec3 operator -(vec3 vec, double val)
        {
            return new vec3(
                vec.x - (float)val,
                vec.y - (float)val,
                vec.z - (float)val
            );
        }

        public static vec3 operator *(vec3 v1, vec3 v2)
        {
            return new vec3(
                v1.x * v2.x,
                v1.y * v2.y,
                v1.z * v2.z
            );
        }

        public static vec3 operator *(vec3 vec, float val)
        {
            return new vec3(
                vec.x * val,
                vec.y * val,
                vec.z * val
            );
        }

        public static vec3 operator *(vec3 vec, double val)
        {
            return new vec3(
                vec.x * (float)val,
                vec.y * (float)val,
                vec.z * (float)val
            );
        }

        public static vec3 operator /(vec3 v1, vec3 v2)
        {
            return new vec3(
                v1.x / v2.x,
                v1.y / v2.y,
                v1.z / v2.z
            );
        }

        public static vec3 operator /(vec3 vec, float val)
        {
            return new vec3(
                vec.x / val,
                vec.y / val,
                vec.z / val
            );
        }

        public static vec3 operator /(vec3 vec, double val)
        {
            return new vec3(
                vec.x / (float)val,
                vec.y / (float)val,
                vec.z / (float)val
            );
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}