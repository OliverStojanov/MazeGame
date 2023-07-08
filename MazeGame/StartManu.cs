using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    [Serializable]
    public partial class StartManu : Form
    {
        public static Form oldChooseLevel { get; set; }
        public SaveFileData saveData { get; set; }

        
        public StartManu()
        {
            InitializeComponent();
            startButton.Location = new Point(this.Width/2 - 100, this.Height - 250);
            pictureBox1.Location = new Point(this.Width - 100, 40);
            continueButton.Location = new Point(this.Width / 2 - 100, this.Height - 150);
            oldChooseLevel = null;
            saveData = new SaveFileData();
            
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK) { 
                String path = saveFile.FileName;
                using (FileStream fileStream = new FileStream(path, FileMode.Create)) {
                    IFormatter formatter = new BinaryFormatter();
                    saveData.SetSave();
                    formatter.Serialize(fileStream, saveData);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                String path = openFile.FileName;
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    StartManu startManu = this;
                    saveData = (SaveFileData) formatter.Deserialize(fileStream);
                    saveData.GetSave();
                }
            }
        }
    }
}
