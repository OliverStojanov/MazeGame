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
    public partial class MazeLevel5 : Form
    {
        public static Form prevForm { get; set; }
        public MazeLevel5()
        {
            InitializeComponent();
        }

        private void MazeLevel5_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 5;

            int topPosition = pictureBox65.Top;
            int leftPosition = pictureBox65.Left;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox65.Left -= stepSize;
                    break;
                case Keys.Right:
                    pictureBox65.Left += stepSize;
                    break;
                case Keys.Up:
                    pictureBox65.Top -= stepSize;
                    break;
                case Keys.Down:
                    pictureBox65.Top += stepSize;
                    break;
            }

            if (pictureBox65.Bounds.IntersectsWith(pictureBox66.Bounds))
            {
                var dialogResult = MessageBox.Show("Congratulations you passed this level, choose new level", "Level passed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    prevForm.Show();
                    ChooseLevel.canEnterLevel6 = true;
                    this.Close();
                }

            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control != pictureBox65)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox65.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        pictureBox65.Top = topPosition;
                        pictureBox65.Left = leftPosition;
                    }
                }
            }
        }
    }
}
