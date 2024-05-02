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
            StreamReader stream = new StreamReader(filepath);
            string currentleader = stream.ReadLine();
            int leaderdays = Convert.ToInt16(stream.ReadLine());
            stream.Close(); //make sure to close the file or else the machines get cranky!
            //stream.ReadLine()+stream.ReadLine();
            if (leaderdays>Stats.Days)
            {
                //if the user doesn't defeat the current record of days then they get told how long the current wise one has made it
                lblLeaderboard.Text = "But can you beat " + currentleader + " who lasted " + leaderdays.ToString() + " days to become the new Wise One?";
            }
            else if (leaderdays<Stats.Days) //this condition technically allows negative day counts, but as there is hopefully no way to get negative days survived, it should be fine
            {
                lblLeaderboard.Text = "You defeated " + currentleader + "! You are the new Wise One!";
                //this makes the current player the new Wise One if they have a higher day count than the last wise one
                StreamWriter writer = new StreamWriter(filepath, false);
                writer.WriteLine(Stats.PName);
                writer.WriteLine(Stats.Days.ToString());
                writer.Close();//tantrum code if no close!
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); //this kills and destroys the program
        }
    }
}