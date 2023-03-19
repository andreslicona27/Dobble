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
        Dictionary<string, Image> playerOptions = new Dictionary<string, Image>()
        {
            {"rock",  global::SheldonsGame.Properties.Resources.rock},
            {"paper",  global::SheldonsGame.Properties.Resources.paper},
            {"scissors",  global::SheldonsGame.Properties.Resources.scissors},
            {"lizard",  global::SheldonsGame.Properties.Resources.lizard},
            {"spock",  global::SheldonsGame.Properties.Resources.spock}
        };
        string[] rivalOptions = new string[5] { "rock", "paper", "scissors", "lizard", "spock" };

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
            int num = rand.Next(0, playerOptions.Count);

            pbPlayer.Image = playerOptions[((PictureBox)sender).Tag.ToString()];
            pbRival.Image = playerOptions[rivalOptions[num]];

            SetResultLabel(((PictureBox)sender).Tag.ToString(), rivalOptions[num]);
        }

        private void SetResultLabel(String playerOption, String rivalOption)
        {
            switch (playerOption)
            {
                case "rock":
                    if (rivalOption == "rock")
                    {
                        ShowMessage("equals", 0);
                    }
                    else if (rivalOption == "paper")
                    {
                        ShowMessage("paper vs rock", 2);
                    }
                    else if (rivalOption == "scissors")
                    {
                        ShowMessage("rock vs scissors", 1);
                    }
                    else if (rivalOption == "lizard")
                    {
                        ShowMessage("rock vs lizard", 1);
                    }
                    else
                    {
                        ShowMessage("spock vs rock", 2);
                    }
                    break;
                case "paper":
                    if (rivalOption == "rock")
                    {
                        ShowMessage("paper vs rock", 1);
                    }
                    else if (rivalOption == "paper")
                    {
                        ShowMessage("equals", 0);
                    }
                    else if (rivalOption == "scissors")
                    {
                        ShowMessage("scissors vs paper", 2);
                    }
                    else if (rivalOption == "lizard")
                    {
                        ShowMessage("lizard vs paper", 2);
                    }
                    else
                    {
                        ShowMessage("paper vs spock", 1);
                    }
                    break;
                case "scissors":
                    if (rivalOption == "rock")
                    {
                        ShowMessage("rock vs scissors", 2);
                    }
                    else if (rivalOption == "paper")
                    {
                        ShowMessage("scissors vs paper", 1);
                    }
                    else if (rivalOption == "scissors")
                    {
                        ShowMessage("equals", 0);
                    }
                    else if (rivalOption == "lizard")
                    {
                        ShowMessage("scissors vs lizard", 1);
                    }
                    else
                    {
                        ShowMessage("spock vs scissors", 2);
                    }
                    break;
                case "lizard":
                    if (rivalOption == "rock")
                    {
                        ShowMessage("rock vs lizard", 2);
                    }
                    else if (rivalOption == "paper")
                    {
                        ShowMessage("lizard vs paper", 1);
                    }
                    else if (rivalOption == "scissors")
                    {
                        ShowMessage("scissors vs lizard", 2);
                    }
                    else if (rivalOption == "lizard")
                    {
                        ShowMessage("equals", 0);
                    }
                    else
                    {
                        ShowMessage("lizard vs spock", 1);
                    }
                    break;
                case "spock":
                    if (rivalOption == "rock")
                    {
                        ShowMessage("spock vs rock", 1);
                    }
                    else if (rivalOption == "paper")
                    {
                        ShowMessage("paper vs spock", 2);
                    }
                    else if (rivalOption == "scissors")
                    {
                        ShowMessage("spock vs scissors", 1);
                    }
                    else if (rivalOption == "lizard")
                    {
                        ShowMessage("lizard vs spock", 2);
                    }
                    else
                    {
                        ShowMessage("equals", 0);
                    }
                    break;
            }
        }

        int playerPoints = 0;
        int rivalPoints = 0;
        Dictionary<string, string> messages = new Dictionary<string, string>()
            {
                {"equals", "You both were neutralized"},
                {"scissors vs paper", "Scissors cut paper"},
                {"paper vs rock" ,"Paper covers rock"},
                {"rock vs lizard", "Rock smash lizard"},
                {"lizard vs spock", "Lizard poison spock"},
                {"spock vs scissors", "Spock breaks scissors"},
                {"scissors vs lizard", "Scissors decapitate lizard"},
                {"lizard vs paper", "Lizard devours paper"},
                {"paper vs spock", "Paper disallows spock"},
                {"spock vs rock", "Spock vaporize rock"},
                {"rock vs scissors", "Rock smash scissors"}
            };
        private void ShowMessage(string msg, int addPoint)
        {
            btnResult.Text = messages[msg];
            if (addPoint == 1)
            {
                lblPlayer.Text = "Player " + ++playerPoints;
            }
            else if (addPoint == 2)
            {
                lblRival.Text = "Rival " + ++rivalPoints;
            }
        }
    }
}
