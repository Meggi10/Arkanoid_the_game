using System.Drawing;
using System.Windows.Forms;

namespace ArkanoidGame.Components
{
    public class BrickComponent : PictureBox
    {
        public BrickComponent()
        {
            this.Width = 100;
            this.Height = 32;
            this.BackColor = Color.Cyan;
            this.Tag = "bricks";
        }
    }
}
