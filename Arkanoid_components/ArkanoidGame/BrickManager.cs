using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArkanoidGame.Components;
using System.Drawing;

namespace ArkanoidGame
{
    public class BrickManager
    {
        private Control parent;
        private Random rnd = new Random();
        public List<BrickComponent> Bricks { get; private set; }

        public BrickManager(Control parentControl)
        {
            parent = parentControl;
            Bricks = new List<BrickComponent>();
        }

        public void PlaceBricks()
        {
            Bricks.Clear();
            int a = 0, top = 50, left = 100;

            for (int i = 0; i < 15; i++)
            {
                var brick = new BrickComponent
                {
                    Left = left,
                    Top = top
                };

                if (++a == 5)
                {
                    top += 50;
                    left = 100;
                    a = 0;
                }
                else
                {
                    left += 130;
                }

                Bricks.Add(brick);
                parent.Controls.Add(brick);
            }
        }

        public void RemoveBricks()
        {
            foreach (var brick in Bricks)
            {
                parent.Controls.Remove(brick);
            }
            Bricks.Clear();
        }
    }
}
