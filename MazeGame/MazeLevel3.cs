using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class MazeLevel3 : Form
    {
        internal static Form prevForm;

        public MazeLevel3()
        {
            InitializeComponent();
        }

        private void MazeLevel3_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 5;

            int topPosition = pictureBox136.Top;
            int leftPosition = pictureBox136.Left;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox136.Left -= stepSize;
                    break;
                case Keys.Right:
                    pictureBox136.Left += stepSize;
                    break;
                case Keys.Up:
                    pictureBox136.Top -= stepSize;
                    break;
                case Keys.Down:
                    pictureBox136.Top += stepSize;
                    break;
            }

            if (pictureBox136.Bounds.IntersectsWith(pictureBox137.Bounds))
            {
                var dialogResult = MessageBox.Show("Congratulations you passed this level, choose new level", "Level passed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    prevForm.Show();
                    ChooseLevel.canEnterLevel4 = true;
                    this.Close();
                }

            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control != pictureBox136)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox136.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        pictureBox136.Top = topPosition;
                        pictureBox136.Left = leftPosition;
                    }
                }
            }
        }
    }
}
