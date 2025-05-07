using System.Windows.Forms;
using System.Drawing;

namespace ArkanoidGame.Components
{
    public class BallControl : PictureBox
    {
        private BallControl()
        {
            this.Size = new Size(20, 20);
            this.BackColor = Color.Red;
        }
    }
}
