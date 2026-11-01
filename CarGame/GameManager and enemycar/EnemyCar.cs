
using System;
using System.Windows.Forms;

namespace CarGame
{
    public class EnemyCar : Vehicle
    {
        private static readonly Random random = new Random();

        public EnemyCar(PictureBox sprite) : base(sprite)
        {
        }

        public void MoveDown(int speed)
        {
            Y += speed;
        }

        public void ResetPosition(int minX, int maxX,
                                  int minY, int maxY)
        {
            X = random.Next(minX, maxX + 1);
            Y = random.Next(minY, maxY + 1);
        }
    }
}
