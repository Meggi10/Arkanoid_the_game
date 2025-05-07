using System.Drawing;
using System.Windows.Forms;

namespace ArkanoidGame.Components
{
    public class PlayerComponent : PictureBox
    {
        private PlayerComponent()
        {
            this.Width = 120;
            this.Height = 20;
            this.BackColor = Color.Blue;
            this.Tag = "player";
            this.Top = 450;
            this.Left = 300;
        }
    }
}
