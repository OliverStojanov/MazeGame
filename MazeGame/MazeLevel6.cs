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
    public partial class MazeLevel6 : Form
    {
        public static Form prevForm { get; set; }
        public MazeLevel6()
        {
            InitializeComponent();
        }

        private void MazeLevel6_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 5;

            int topPosition = pictureBox83.Top;
            int leftPosition = pictureBox83.Left;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox83.Left -= stepSize;
                    break;
                case Keys.Right:
                    pictureBox83.Left += stepSize;
                    break;
                case Keys.Up:
                    pictureBox83.Top -= stepSize;
                    break;
                case Keys.Down:
                    pictureBox83.Top += stepSize;
                    break;
            }

            if (pictureBox83.Bounds.IntersectsWith(pictureBox84.Bounds))
            {
                var dialogResult = MessageBox.Show("Congratulations you passed all levels", "Level passed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    prevForm.Show();
                    this.Close();
                }

            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control != pictureBox83)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox83.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        pictureBox83.Top = topPosition;
                        pictureBox83.Left = leftPosition;
                    }
                }
            }
        }
    }
}
