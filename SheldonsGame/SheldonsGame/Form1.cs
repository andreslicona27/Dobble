using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheldonsGame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        //Dictionary<string, Image> options = new Dictionary<string, Image>()
        //{
        //    {"rock",  global::SheldonsGame.Properties.Resources.rock},
        //    {"paper",  global::SheldonsGame.Properties.Resources.paper},
        //    {"scissor",  global::SheldonsGame.Properties.Resources.scissors},
        //    {"lizard",  global::SheldonsGame.Properties.Resources.lizard},
        //    {"spock",  global::SheldonsGame.Properties.Resources.spock}
        //};
        string[] options = new string[5] {"rock", "paper", "scissor", "lizard", "spock"};
        //Image[] images = new Image[5] 
        //{
        //    global:SheldonsGame.Properties.Resources.rock,
        //    global:SheldonsGame.Properties.Resources.paper,
        //    global:SheldonsGame.Properties.Resources.scissors,
        //    global:SheldonsGame.Properties.Resources.lizard,
        //    global:SheldonsGame.Properties.Resources.spock
        //};

        public Form1()
        {
            InitializeComponent();
            GamePanel.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
        }

        private void StartMatch(Object sender, EventArgs e)
        {
            //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);

            //pbRival.Image = options[];
        }
    }
}
