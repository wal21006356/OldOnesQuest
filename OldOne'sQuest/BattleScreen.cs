using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldOne_sQuest
{
    public partial class BattleScreen : Form
    {
        public BattleScreen()
        {

            Single EElement = Stats.random.Next(0, 3);

        InitializeComponent();
            if (Stats.PElement == "Air")
            {
                imgPWizard.Image=OldOne_sQuest.Properties.Resources.fan;
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
            if (EElement == 0)
            {
                //0 is water
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.Fishwizard;
            }
            else if (EElement == 1)
            {
                //1 is air
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.fan;
            }
            else if (EElement == 2)
            {
                //2 is earth
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.Turtlewizard;
            }
            else if (EElement == 3)
            {
                //3 is fire
                imgEWizard.Image = OldOne_sQuest.Properties.Resources.Egg;
            }
            GenerateStats();
            RefreshValues();
        }

        int PHealth;
        static int EMaxHP; //this one has to be static or vstudio throws a tantrum
        int EWisdom;
        int EDexterity;
        int lowerAIRand = 25;
        int upperAIRand = 35;
        int lowerAIHealth = 95;
        int upperAIHealth = 110;


        private void GenerateStats()
        {
            PHealth = Stats.PMaxHP;
            EMaxHP = Stats.random.Next(lowerAIHealth, upperAIHealth);
            Stats.EHealth = EMaxHP;
            EWisdom = Stats.random.Next(lowerAIRand, upperAIRand);
            EDexterity = Stats.random.Next(lowerAIRand, upperAIRand);
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
        }


        private void btnBattle_Click(object sender, EventArgs e)
        {
            Battle();
        }

        private void Battle ()
        {

        }
    }
}
