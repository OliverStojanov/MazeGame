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
    public partial class MazeLevel2 : Form
    {
        public static Form prevForm { get; set; }
        public MazeLevel2()
        {
            InitializeComponent();
        }

        private void MazeLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 2;

            int topPosition = pictureBox3.Top;
            int leftPosition = pictureBox3.Left;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox3.Left -= stepSize;
                    break;
                case Keys.Right:
                    pictureBox3.Left += stepSize;
                    break;
                case Keys.Up:
                    pictureBox3.Top -= stepSize;
                    break;
                case Keys.Down:
                    pictureBox3.Top += stepSize;
                    break;
            }
            if (pictureBox3.Bounds.IntersectsWith(pictureBox72.Bounds)){
                var dialogResult = MessageBox.Show("Congratulations you passed this level, choose new level", "Level passed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    prevForm.Show();
                    this.Close();
                }
                
            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control != pictureBox3)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox3.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        pictureBox3.Top = topPosition;
                        pictureBox3.Left = leftPosition;
                    }
                }
            }
        }
    }
}
