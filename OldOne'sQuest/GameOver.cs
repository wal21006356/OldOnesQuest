using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldOne_sQuest
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            lblDays.Text = "You survived until Day " + Stats.Days.ToString(); //how long they have lasted, if 0 days they're just bad, no skill, get better at this luck based game
            string filepath = Environment.CurrentDirectory+@"\Leaderboard.txt";
            //lblLeaderboard.Text = filepath;
            //stream.ReadLine()+stream.ReadLine();
            if (Stats.leaderdays>Stats.Days)
            {
                //if the user doesn't defeat the current record of days then they get told how long the current wise one has made it
                lblLeaderboard.Text = "But can you beat " + Stats.currentleader + " who lasted " + Stats.leaderdays.ToString() + " days to become the new Wise One?";
            }
            else if (Stats.leaderdays<Stats.Days) //this condition technically allows negative day counts, but as there is hopefully no way to get negative days survived, it should be fine
            {
                lblLeaderboard.Text = "You defeated " + Stats.currentleader + "! You are the new Wise One!";
                //this makes the current player the new Wise One if they have a higher day count than the last wise one
                StreamWriter writer = new StreamWriter(filepath, false);
                writer.WriteLine(Stats.PName);
                writer.WriteLine(Stats.Days.ToString());
                writer.WriteLine(Stats.PMaxHP.ToString());
                writer.WriteLine(Stats.PWisdom.ToString());
                writer.WriteLine(Stats.PDexterity.ToString());
                if (Stats.PElement == "Air")
                {
                    Stats.EElement = 1;
                }
                else if (Stats.PElement == "Fire")
                {
                    Stats.EElement = 2;
                }
                else if (Stats.PElement == "Water")
                {
                    Stats.EElement = 3;
                }
                else if (Stats.PElement == "Earth")
                {
                    Stats.EElement = 0;
                }
                writer.WriteLine(Stats.EElement);
                writer.Close();//tantrum code if no close!
            }
            else
            {
                lblLeaderboard.Text = "You and the Wise One tied!";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); //this kills and destroys the program
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Stats.CharCreated = false;
            Stats.Days = 0;
            Stats.PDexterity = 30;
            Stats.PElement = null;
            Stats.PMaxHP = 100;//resets the player stats to the base and gives them the stat points back so that it is
            Stats.StatPoints = 10;//ready for them to start again as if they just launched it
            Stats.PWisdom = 30;
            Stats.PName = null;
            CharacterCreation form = new CharacterCreation();
            form.Show();
            this.Hide();
        }
    }
}