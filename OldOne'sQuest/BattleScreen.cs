using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OldOne_sQuest
{
    public partial class BattleScreen : Form
    {
        public BattleScreen()
        {
            InitializeComponent();
            GenerateStats();
            RefreshValues();
            DecideAdvantage();
            if (Stats.CharCreated==false)
            {//changes the CharCreated value so that the program knows if the user has already gone through character creation for if they win a round
                timerMusicStart();//Triggers the music to start playing
                Stats.CharCreated = true;
            }
        }

        int PHealth; //playerhealth, but not declared with a value as it gets assigned in the GenerateStats function
        static int EMaxHP; //this one has to be static or vstudio throws a tantrum
        int EWisdom;//enemy wisdom
        int EDexterity;//enemy dexterity
        int PDamage;//player damage variable which I'm using so that when someone has advantage their damage is scaled up
        int EDamage;//ai damage
        



        private void GenerateStats() //generates the stats
        {
            if (Stats.Days != Stats.leaderdays)
            {
                PHealth = Stats.PMaxHP; //generate player health from the maxHP they decided on the character creation screen
                EMaxHP = Stats.random.Next(Stats.lowerAIHealth, Stats.upperAIHealth); //generates the enemy's maxHP, i would just generate the enemy health, but MaxHP is needed for the progressbars as they are refreshed every attack
                Stats.EHealth = EMaxHP;
                EWisdom = Stats.random.Next(Stats.lowerAIRand, Stats.upperAIRand);//using the upper and lower bounds to generate the wisdom and dexterity
                EDexterity = Stats.random.Next(Stats.lowerAIRand, Stats.upperAIRand);
                PDamage = Stats.PWisdom;//the damage is decided by the wisdom
                EDamage = EWisdom;
                Stats.EElement = Stats.random.Next(0, 3); //chooses the enemy's element
                int ainamenum = Stats.random.Next(0, 20); //generates the enemy's name using these two numbers
                int ainamenum2 = Stats.random.Next(0, 20);
                Stats.EName = Stats.WizardNames[0, ainamenum] + " " + Stats.WizardNames[1, ainamenum2];
                Stats.Funenemy = Stats.random.Next(1,50);
            }
            else
            {
                Stats.EName = Stats.currentleader;
                EMaxHP = Stats.leaderHealth;
                EWisdom = Stats.leaderWisdom;
                EDamage = EWisdom; //i could repeat these 4 lines of code outside of the if statement to reduce amount of code
                Stats.EHealth = EMaxHP;
                PHealth = Stats.PMaxHP;
                PDamage = Stats.PWisdom;
                EDexterity= Stats.leaderDexterity;
                Stats.EElement = Stats.leaderElement;
            }
        }


        private void RefreshValues() //refreshes all the values onscreen
        {
            //sets the label values
            lblPName.Text = "Player Name: "+Stats.PName;
            lblEName.Text = "Enemy Name: "+Stats.EName;
            lblPHealth.Text = "Health: " + PHealth.ToString();
            lblPWisdom.Text = "Wisdom: " + Stats.PWisdom.ToString();
            lblPDexterity.Text = "Dexterity: " + Stats.PDexterity.ToString();
            lblEHealth.Text = "Health: " + Stats.EHealth.ToString();
            lblEWisdom.Text = "Wisdom: " + EWisdom.ToString();
            lblEDexterity.Text = "Dexterity: " + EDexterity.ToString();
            lblDay.Text = "Day: " + Stats.Days.ToString();

            if (EWisdom > 50)//when the AI has higher than 50 of a skill, it increases the max of the progress bars to the value
            {
                prbrEWisdom.Maximum = EWisdom;
            }
            if (EDexterity > 50)
            {
                prbrEDexterity.Maximum = EDexterity;
            }
            if (Stats.PWisdom > 50)//when the AI has higher than 50 of a skill, it increases the max of the progress bars to the value
            {
                prbrPWisdom.Maximum = Stats.PWisdom;
            }
            if (Stats.PDexterity > 50)
            {
                prbrPDexterity.Maximum = Stats.PDexterity;
            }
            prbrPHealth.Maximum = Stats.PMaxHP; //progress bars go higher and lower in the wind
            prbrEHealth.Maximum = EMaxHP;
            prbrPHealth.Value = PHealth;
            prbrEHealth.Value = Stats.EHealth;
            prbrPWisdom.Value = Stats.PWisdom;
            prbrEWisdom.Value = EWisdom;
            prbrPDexterity.Value = Stats.PDexterity;
            prbrEDexterity.Value = EDexterity;

            //changes the images to the wizards for that element
            if (Stats.PElement == "Air")
            {
                imgPWizard.Image = OldOne_sQuest.Properties.Resources.fan;
            }
            else if (Stats.PElement == "Fire")
            {
                imgPWizard.Image = OldOne_sQuest.Properties.Resources.Egg;
            }
            else if (Stats.PElement == "Water")
            {
                imgPWizard.Image = OldOne_sQuest.Properties.Resources.Fishwizard;
            }
            else if (Stats.PElement == "Earth")
            {
                imgPWizard.Image = OldOne_sQuest.Properties.Resources.Turtlewizard;
            }
            if (Stats.Funenemy==1)
            {
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.funenemy;
                EDexterity +=10;
            }
            else if (Stats.EElement == 0)
            {
                //0 is water
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.Fishwizard;
            }
            else if (Stats.EElement == 1)
            {
                //1 is air
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.fan;
            }
            else if (Stats.EElement == 2)
            {
                //2 is earth
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.Turtlewizard;
            }
            else if (Stats.EElement == 3)
            {
                //3 is fire
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.Egg;
            }
        }


        private void btnBattle_Click(object sender, EventArgs e)
        {
            //starts the battle routine when they click the attack button, I could have left the code in this function and have more optimised code, but that isn't what I did.
            Battle();
        }

        private void Battle ()
        {
            if (Stats.PDexterity>=EDexterity)//if the player has higher dex or the same amount then the player will attack first, this resolves draws of dexterity in the player's favour for fun things and enjoyment, wahoo!
            {
                Stats.EHealth -= PDamage;
                if (Stats.EHealth<=0)
                {//if enemy is dead
                    Win();
                }
                else
                {
                    PHealth -= EDamage;
                    if (PHealth <= 0)
                    {//if player is dead
                        PHealth = 0;//sets the health to 0 to remove negative numbers from crashing the program
                        Lose();
                    }
                }
            }
            else// if the enemy has higher dex
            {
                PHealth -= EDamage;
                if (PHealth <= 0)
                {//if the player is dead
                    PHealth = 0;
                    Lose();
                }
                else
                {
                    Stats.EHealth -= PDamage;
                    if (Stats.EHealth<=0)
                    {//if the enemy is dead
                        Win();
                    }
                }
            }
            RefreshValues();//refreshes the values on screen again
        }

        void DecideAdvantage() //decides whether the player or enemy gets extra damage because of the element match-ups
        {
            if (Stats.PElement=="Earth"&& Stats.EElement==0)//earth is strong against water
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "You have Advantage!";
            }
            else if (Stats.PElement == "Fire" && Stats.EElement == 1)//fire is strong against air
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "You have Advantage!";
            }
            else if (Stats.PElement == "Air" && Stats.EElement == 2)//air is strong against earth
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "You have Advantage!";
            }
            else if (Stats.PElement == "Water" && Stats.EElement == 3)//water is strong against fire
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "You have Advantage!";
            }
            else if (Stats.PElement == "Earth" && Stats.EElement == 1)//earth is weak to air
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "The Enemy has Advantage!";
            }
            else if (Stats.PElement == "Fire" && Stats.EElement == 0)//fire is weak to water
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "The Enemy has Advantage!";
            }
            else if (Stats.PElement == "Air" && Stats.EElement == 3)//air is weak to fire
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "The Enemy has Advantage!";
            }
            else if (Stats.PElement == "Water" && Stats.EElement == 2)//water is weak to earth
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
                lblAdvantage.Text = "The Enemy has Advantage!";
            }
            else
            {
                lblAdvantage.Text = "";//if noone has advantage than there is no text
            }
        }


        void Win()
        {
            Stats.lowerAIHealth += 1;//increase the upper and lower bounds for the AI stats
            Stats.upperAIHealth += 2;
            Stats.lowerAIRand += 1;
            Stats.upperAIRand += 2;
            Stats.Days += 1; //increases the day counter
            Stats.StatPoints += 4;//gives the extra stat points
            Stats.EHealth = 0;//preventing possible negatives!
            CharacterCreation form = new CharacterCreation();
            form.Show();//sends the user back to the character creator
            this.Hide();
            while (true){

            }
        }

        void Lose()
        {
            GameOver form = new GameOver();
            form.Show();//sends the user to the game over screen
            this.Close();
        }

        private void timerMusicStart()
        {//when the window first opens it does this one so this it can start the music the moment the window opens and doesn't have to wait 2 minutes before starting
            string HorseDir = Environment.CurrentDirectory;
            HorseDir +=@"\HobHor.wav";
            System.Media.SoundPlayer Hoborg = new System.Media.SoundPlayer(HorseDir);
            Hoborg.Play();//the background music!
            timerMusic.Enabled = true;
        }

        private void TimerMusicTick(object sender, EventArgs e)
        {//i can almost definitely just just just just just just just just just just just just just just just just make it call the timer music start function but that that that that?
            string HorseDir = Environment.CurrentDirectory;
            HorseDir += @"\HobHor.wav";
            System.Media.SoundPlayer Hoborg = new System.Media.SoundPlayer(HorseDir);
            Hoborg.Play();//lil horse theme track!
        }
    }
}
