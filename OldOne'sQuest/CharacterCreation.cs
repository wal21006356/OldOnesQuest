using OldOne_sQuest.Properties;
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
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();
            CheckStarted();
            RefreshLabels();
            GenerateNames();
        }

        //declaring the name variables so that they can be used later
        string name1;
        string name2;
        string name3;


        void GenerateNames()
        {
            int name1num = Stats.random.Next(0, 20);
            int name2num = Stats.random.Next(0, 20);
            int name3num = Stats.random.Next(0, 20);
            int name4num = Stats.random.Next(0, 20);
            int name5num = Stats.random.Next(0, 20);
            int name6num = Stats.random.Next(0, 20);

            name1 = Stats.WizardNames[0, name1num] + " " + Stats.WizardNames[1, name4num];
            name2 = Stats.WizardNames[0, name2num] + " " + Stats.WizardNames[1, name5num];
            name3 = Stats.WizardNames[0, name3num] + " " + Stats.WizardNames[1, name6num];

            btnName1.Text = name1;
            btnName2.Text = name2;
            btnName3.Text = name3;
        }

        private void RefreshLabels()
        {
            lblMaxHP.Text = "Max Health: " + Stats.PMaxHP.ToString();
            lblWisdom.Text = "Wisdom: " + Stats.PWisdom.ToString();
            lblDexterity.Text = "Dexterity: " + Stats.PDexterity.ToString();
            lblSkillPoints.Text = "Skillpoints: " + Stats.StatPoints.ToString();
            lblPName.Text = "Player Name: " + Stats.PName;
        }

        private void CheckStart()
        {
            if (Stats.PName != null && Stats.StatPoints == 0 && Stats.PElement != null)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void btnHealthDown_Click(object sender, EventArgs e)
        {
            if (Stats.PMaxHP > 90)
            {
                Stats.PMaxHP -= 5;
                Stats.StatPoints += 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnHealthUp_Click(object sender, EventArgs e)
        {
            if (Stats.StatPoints > 0)
            {
                Stats.PMaxHP += 5;
                Stats.StatPoints -= 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnWisdomDown_Click(object sender, EventArgs e)
        {
            if (Stats.PWisdom > 20)
            {
                Stats.PWisdom -= 1;
                Stats.StatPoints += 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnWisdomUp_Click(object sender, EventArgs e)
        {
            if (Stats.StatPoints > 0)
            {
                Stats.PWisdom += 1;
                Stats.StatPoints -= 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnDexterityDown_Click(object sender, EventArgs e)
        {
            if (Stats.PDexterity > 20)
            {
                Stats.PDexterity -= 1;
                Stats.StatPoints += 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnDexterityUp_Click(object sender, EventArgs e)
        {
            if (Stats.StatPoints > 0)
            {
                Stats.PDexterity += 1;
                Stats.StatPoints -= 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnEarth_Click(object sender, EventArgs e)
        {
            Stats.PElement = "Earth";
            btnEarth.Enabled = false;
            btnAir.Enabled = true;
            btnFire.Enabled = true;
            btnWater.Enabled = true;
            imgCharacter.Image = OldOne_sQuest.Properties.Resources.Turtlewizard;
            CheckStart();
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            Stats.PElement = "Water";
            btnEarth.Enabled = true;
            btnAir.Enabled = true;
            btnFire.Enabled = true;
            btnWater.Enabled = false;
            imgCharacter.Image = OldOne_sQuest.Properties.Resources.Fishwizard;
            CheckStart();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            Stats.PElement = "Fire";
            btnEarth.Enabled = true;
            btnAir.Enabled = true;
            btnFire.Enabled = false;
            btnWater.Enabled = true;
            imgCharacter.Image = OldOne_sQuest.Properties.Resources.Egg;
            CheckStart();
        }

        private void btnAir_Click(object sender, EventArgs e)
        {
            Stats.PElement = "Air";
            btnEarth.Enabled = true;
            btnAir.Enabled = false;
            btnFire.Enabled = true;
            btnWater.Enabled = true;
            imgCharacter.Image = OldOne_sQuest.Properties.Resources.fan;
            CheckStart();
        }

        private void btnName1_Click(object sender, EventArgs e)
        {
            Stats.PName = name1;
            RefreshLabels();
            CheckStart();
        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            Stats.PName = name2;
            RefreshLabels();
            CheckStart();
        }

        private void btnName3_Click(object sender, EventArgs e)
        {
            Stats.PName = name3;
            RefreshLabels();
            CheckStart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //im using this bit to make it so you have to fight the current wise one before you can continue when you reach his daycount
            string filepath = Environment.CurrentDirectory + @"\Leaderboard.txt";
            StreamReader LeaderFile = new StreamReader(filepath);
            Stats.currentleader = LeaderFile.ReadLine();
            Stats.leaderdays = Convert.ToInt16(LeaderFile.ReadLine());
            Stats.leaderHealth = Convert.ToInt16(LeaderFile.ReadLine());
            Stats.leaderWisdom = Convert.ToInt16(LeaderFile.ReadLine());
            Stats.leaderDexterity = Convert.ToInt16(LeaderFile.ReadLine());
            Stats.leaderElement = Convert.ToInt16(LeaderFile.ReadLine());
            LeaderFile.Close();//make sure to close the file or else the machines get cranky!

            BattleScreen form = new BattleScreen();
            form.Show();
            this.Hide();
        }

        private void CheckStarted()//checks if the user has already gone through character creation
        {
            if (Stats.CharCreated == true)
            {
                btnName1.Visible = false;
                btnName2.Visible = false;
                btnName3.Visible = false;
                btnName1.Enabled = false;
                btnName2.Enabled = false;
                btnName3.Enabled = false;
                if (Stats.PElement == "Earth")
                {
                    imgCharacter.Image = Resources.Turtlewizard;
                }
                else if (Stats.PElement == "Air")
                {
                    imgCharacter.Image = Resources.fan;
                }
                else if (Stats.PElement == "Water")
                {
                    imgCharacter.Image = Resources.Fishwizard;
                }
                else
                {
                    imgCharacter.Image = Resources.Egg;
                }
            }
        }
    }
}