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
    public partial class StartManu : Form
    {
        public static Form oldChooseLevel { get; set; }
        public StartManu()
        {
            InitializeComponent();
            startButton.Location = new Point(this.Width/2 - 100, this.Height - 250);
            pictureBox1.Location = new Point(this.Width - 100, 40);
            continueButton.Location = new Point(this.Width / 2 - 100, this.Height - 150);
            oldChooseLevel = null;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ChooseLevel chooseLevel = new ChooseLevel();
            chooseLevel.Show();
            ChooseLevel.prevForm = this;
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press arrows on your keyboard to move through maze. Get to the green squere to finish the level.", "Help");
        }

        private void StartManu_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(this.Width-100, 40); 
            startButton.Location = new Point(this.Width / 2 -100, this.Height - 250);
            continueButton.Location = new Point(this.Width / 2 - 100, this.Height - 150);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (oldChooseLevel != null)
            {
                oldChooseLevel.Show();
                this.Hide();
            }
        }
    }
}
