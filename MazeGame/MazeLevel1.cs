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
    public partial class MazeLevel1 : Form
    {
        public static Form prevForm { get; set; }
        public MazeLevel1()
        {
            InitializeComponent();
        }

        private void MazeLevel1_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 5;

            int topPosition = pictureBox46.Top;
            int leftPosition = pictureBox46.Left;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox46.Left -= stepSize;
                    break;
                case Keys.Right:
                    pictureBox46.Left += stepSize;
                    break;
                case Keys.Up:
                    pictureBox46.Top -= stepSize;
                    break;
                case Keys.Down:
                    pictureBox46.Top += stepSize;
                    break;
            }

            if (pictureBox46.Bounds.IntersectsWith(pictureBox47.Bounds))
            {
                var dialogResult = MessageBox.Show("Congratulations you passed this level, choose new level", "Level passed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    prevForm.Show();
                    ChooseLevel.canEnterLevel2 = true;
                    this.Close();
                }

            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control != pictureBox46)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox46.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        pictureBox46.Top = topPosition;
                        pictureBox46.Left = leftPosition;
                    }
                }
            }
        }
    }
}
