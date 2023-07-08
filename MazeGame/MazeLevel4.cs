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
    [Serializable]
    public partial class MazeLevel4 : Form
    {
        public static Form prevForm { get; set; }
        public MazeLevel4()
        {
            InitializeComponent();
        }

        private void MazeLevel4_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 3;

            int topPosition = pictureBox62.Top;
            int leftPosition = pictureBox62.Left;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox62.Left -= stepSize;
                    break;
                case Keys.Right:
                    pictureBox62.Left += stepSize;
                    break;
                case Keys.Up:
                    pictureBox62.Top -= stepSize;
                    break;
                case Keys.Down:
                    pictureBox62.Top += stepSize;
                    break;
            }

            if (pictureBox62.Bounds.IntersectsWith(pictureBox63.Bounds))
            {
                var dialogResult = MessageBox.Show("Congratulations you passed this level, choose new level", "Level passed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    prevForm.Show();
                    ChooseLevel.canEnterLevel5 = true;
                    this.Close();
                }

            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control != pictureBox62)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox62.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        pictureBox62.Top = topPosition;
                        pictureBox62.Left = leftPosition;
                    }
                }
            }
        }

  
    }
}
