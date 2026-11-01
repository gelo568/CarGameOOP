
using System.Windows.Forms;

namespace CarGame
{
    public class PlayerCar : Vehicle
    {
        public PlayerCar(PictureBox sprite) : base(sprite)
        {
        }

        public void MovePlayer(
            int dx, int dy,
            int minX, int maxX,
            int minY, int maxY)
        {
            X = System.Math.Max(minX,
                System.Math.Min(maxX, X + dx));

            Y = System.Math.Max(minY,
                System.Math.Min(maxY, Y + dy));
        }
    }
}
