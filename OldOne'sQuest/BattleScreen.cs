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

        int PHealth;
        static int EMaxHP; //this one has to be static or vstudio throws a tantrum
        int EWisdom;
        int EDexterity;
        int lowerAIRand = 25;
        int upperAIRand = 35;
        int lowerAIHealth = 95;
        int upperAIHealth = 110;
        int PDamage;
        int EDamage;


        private void GenerateStats()
        {
            PHealth = Stats.PMaxHP;
            EMaxHP = Stats.random.Next(lowerAIHealth, upperAIHealth);
            Stats.EHealth = EMaxHP;
            EWisdom = Stats.random.Next(lowerAIRand, upperAIRand);
            EDexterity = Stats.random.Next(lowerAIRand, upperAIRand);
            PDamage = Stats.PWisdom;
            EDamage = EWisdom;
            Stats.EElement = Stats.random.Next(0, 3);

            int ainamenum = Stats.random.Next(0, 20);
            int ainamenum2 = Stats.random.Next(0, 20);
            Stats.EName = Stats.WizardNames[0, ainamenum] + " " + Stats.WizardNames[1, ainamenum2];
            Stats.Funenemy = Stats.random.Next(1,50);
        }
        private void RefreshValues()
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
            prbrPHealth.Maximum = Stats.PMaxHP;
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
            lowerAIHealth += 5;
            upperAIHealth += 5;
            lowerAIRand += 5;
            upperAIRand += 5;
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
