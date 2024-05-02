using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        int PHealth; //playerhealth, but not declared with a value as it gets assigned in the GenerateStats function
        static int EMaxHP; //this one has to be static or vstudio throws a tantrum
        int EWisdom;//enemy wisdom
        int EDexterity;//enemy dexterity
        //i need these boundaries so that when the player defeats a wizard, the next one can have bigger stats and be harder to defeat
        int lowerAIRand = 25;//sets the lower boundary that the ai can have wisdom and dex for
        int upperAIRand = 35;//sets the the same but the upper boundary
        int lowerAIHealth = 95;//the lower boundary of the ai health
        int upperAIHealth = 110;//the upper health
        int PDamage;//player damage variable which I'm using so that when someone has advantage their damage is scaled up
        int EDamage;//ai damage



        private void GenerateStats() //generates the stats
        {
            PHealth = Stats.PMaxHP; //generate player health from the maxHP they decided on the character creation screen
            EMaxHP = Stats.random.Next(lowerAIHealth, upperAIHealth); //generates the enemy's maxHP, i would just generate the enemy health, but MaxHP is needed for the progressbars as they are refreshed every attack
            Stats.EHealth = EMaxHP;
            EWisdom = Stats.random.Next(lowerAIRand, upperAIRand);//using the upper and lower bounds to generate the wisdom and dexterity
            EDexterity = Stats.random.Next(lowerAIRand, upperAIRand);
            PDamage = Stats.PWisdom;//the damage is decided by the wisdom
            EDamage = EWisdom;
            Stats.EElement = Stats.random.Next(0, 3); //chooses the enemy's element

            int ainamenum = Stats.random.Next(0, 20); //generates the enemy's name using these two numbers
            int ainamenum2 = Stats.random.Next(0, 20);
            Stats.EName = Stats.WizardNames[0, ainamenum] + " " + Stats.WizardNames[1, ainamenum2];
            Stats.Funenemy = Stats.random.Next(1,50);
        }


        private void RefreshValues() //refreshes all the values onscreen
        {
            lblPName.Text = "Player Name: "+Stats.PName;
            lblEName.Text = "Enemy Name: "+Stats.EName;
            lblPHealth.Text = "Health: " + PHealth.ToString();
            lblPWisdom.Text = "Wisdom: " + Stats.PWisdom.ToString();
            lblPDexterity.Text = "Dexterity: " + Stats.PDexterity.ToString();
            lblEHealth.Text = "Health: " + Stats.EHealth.ToString();
            lblEWisdom.Text = "Wisdom: " + EWisdom.ToString();
            lblEDexterity.Text = "Dexterity: " + EDexterity.ToString();

            if (EWisdom > 50)//when the AI has higher than 50 of a skill, it increases the max of the progress bars to the value
            {
                prbrEWisdom.Maximum = EWisdom;
            }
            if (EDexterity > 50)
            {
                prbrEDexterity.Maximum = EDexterity;
            }
            prbrPHealth.Maximum = Stats.PMaxHP; //progress bars go higher and lower in the wind
            prbrEHealth.Maximum = EMaxHP;
            prbrPHealth.Value = PHealth;
            prbrEHealth.Value = Stats.EHealth;
            prbrPWisdom.Value = Stats.PWisdom;
            prbrEWisdom.Value = EWisdom;
            prbrPDexterity.Value = Stats.PDexterity;
            prbrEDexterity.Value = EDexterity;

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
            Battle();
        }

        private void Battle ()
        {
            if (Stats.PDexterity>=EDexterity)
            {
                Stats.EHealth -= PDamage;
                if (Stats.EHealth<=0)
                {
                    Win();
                }
                else
                {
                    PHealth -= EDamage;
                    if (PHealth <= 0)
                    {
                        PHealth = 0;
                        Lose();
                    }
                }
            }
            else
            {
                PHealth -= EDamage;
                if (PHealth <= 0)
                {
                    PHealth = 0;
                    Lose();
                }
                else
                {
                    Stats.EHealth -= PDamage;
                    if (Stats.EHealth<=0)
                    {
                        Win();
                    }
                }
            }
            RefreshValues();
        }

        void DecideAdvantage()
        {
            if (Stats.PElement=="Earth"&& Stats.EElement==0)
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
            }
            else if (Stats.PElement == "Fire" && Stats.EElement == 1)
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
            }
            else if (Stats.PElement == "Air" && Stats.EElement == 2)
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
            }
            else if (Stats.PElement == "Water" && Stats.EElement == 3)
            {
                PDamage = Convert.ToInt16(PDamage * 1.5);
            }
            else if (Stats.PElement == "Earth" && Stats.EElement == 1)
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
            }
            else if (Stats.PElement == "Fire" && Stats.EElement == 0)
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
            }
            else if (Stats.PElement == "Air" && Stats.EElement == 3)
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
            }
            else if (Stats.PElement == "Water" && Stats.EElement == 2)
            {
                EDamage = Convert.ToInt16(PDamage * 1.5);
            }
        }


        void Win()
        {
            lowerAIHealth += 1;
            upperAIHealth += 2;
            lowerAIRand += 1;
            upperAIRand += 2;
            Stats.Days += 1;
            GenerateStats();
        }

        void Lose()
        {
            GameOver form = new GameOver();
            form.Show();
            this.Close();
        }
    }
}
