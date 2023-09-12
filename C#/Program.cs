using System;
using System.Windows;
using System.Drawing;

namespace Program
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            Renderer raymarcher = new Renderer();
        }
    }

    public class Sphere
    {
        public float x, y, z, radius;

        public float SignedDistance(Sphere sphere)
        {
            return Sphere.Distance(this, sphere) - (radius + sphere.radius);
        }

        public static float Distance(Sphere s1, Sphere s2)
        {
            float dx = s2.x - s1.x;
            float dy = s2.y - s1.y;
            float dz = s2.z - s1.z;

            return MathF.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }

    public class Renderer : Window { 
        
    }
}