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
    public partial class ChooseLevel : Form
    {
        public static Form prevForm { get; set; }
        public static bool canEnterLevel2 { get; set; }
        public static bool canEnterLevel3 { get; set; }
        public static bool canEnterLevel4 { get; set; }
        public static bool canEnterLevel5 { get; set; }
        public static bool canEnterLevel6 { get; set; }
        public ChooseLevel()
        {
            InitializeComponent();
            canEnterLevel2 = false;
            canEnterLevel3 = false;
            canEnterLevel4 = false;
            canEnterLevel5 = false;
            canEnterLevel6 = false;
        }

        private void level1_Click(object sender, EventArgs e)
        {
            MazeLevel1 level1 = new MazeLevel1();
            level1.Show();
            MazeLevel1.prevForm = this;
            this.Hide();
        }

        private void level2_Click(object sender, EventArgs e)
        {
            if (canEnterLevel2)
            {
                MazeLevel2 level2 = new MazeLevel2();
                level2.Show();
                MazeLevel2.prevForm = this;
                this.Hide();
            }
            else {
                MessageBox.Show("You need to pass previous level, to enter this level", "Can't enter level");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StartManu startManu = new StartManu();
            //startManu.Show();
            StartManu.oldChooseLevel = this;
            prevForm.Show();
            this.Hide();
        }

        private void level3_Click(object sender, EventArgs e)
        {
            if (canEnterLevel3)
            {
                MazeLevel3 mazeLevel3 = new MazeLevel3();
                mazeLevel3.Show();
                MazeLevel3.prevForm = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("You need to pass previous level, to enter this level", "Can't enter level");
            }
        }

        private void level4_Click(object sender, EventArgs e)
        {
            if (canEnterLevel4)
            {
                MazeLevel4 mazeLevel4 = new MazeLevel4();
                mazeLevel4.Show();
                MazeLevel4.prevForm = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("You need to pass previous level, to enter this level", "Can't enter level");
            }
        }

        private void level5_Click(object sender, EventArgs e)
        {
            if (canEnterLevel5)
            {
                MazeLevel5 mazeLevel5 = new MazeLevel5();
                mazeLevel5.Show();
                MazeLevel5.prevForm = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("You need to pass previous level, to enter this level", "Can't enter level");
            }
        }

        private void level6_Click(object sender, EventArgs e)
        {
            if (canEnterLevel6)
            {
                MazeLevel6 mazeLevel6 = new MazeLevel6();
                mazeLevel6.Show();
                MazeLevel6.prevForm = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("You need to pass previous level, to enter this level", "Can't enter level");
            }
        }
    }
}
