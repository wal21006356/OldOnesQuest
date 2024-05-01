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
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();
            RefreshLabels();
            GenerateNames();
        }

        int skillpoints = 10;
        string name1;
        string name2;
        string name3;



        void GenerateNames()
        {
            string[,] WizardNames = { { "Flubster","Gandalf","Hairy","Harry","John","Moldywart","Gingelmash","Gilgamesh","Gigglemesh","Uruk","Sumer","Tommy","Luke","Quincy","Penelope","Bingle","Frengle","Frodo","Freddo","Cadbury","Tesco"} , {"The Wise","The Great","The Grey","The Flabby","The Disintegrated","The Powerful","The Undefeated","The Still Living","The Defeated","Liver","The Pope","Gell","Sainsbury","Baggins","Potter","The Throngled","The Drowned","The Refleshed","The Fetus","The Flabster","Flubberbelly"} };
            int name1num = Stats.random.Next(0,20);
            int name2num = Stats.random.Next(0,20);
            int name3num = Stats.random.Next(0,20);
            int name4num = Stats.random.Next(0, 20);
            int name5num = Stats.random.Next(0, 20);
            int name6num = Stats.random.Next(0, 20);
            int ainamenum = Stats.random.Next(0, 20);
            int ainamenum2 = Stats.random.Next(0, 20);

            name1 = WizardNames[0,name1num] + " " + WizardNames[1,name4num];
            name2 = WizardNames[0, name2num] + " " + WizardNames[1, name5num];
            name3 = WizardNames[0, name3num] + " " + WizardNames[1, name6num];
            Stats.EName = WizardNames[0, ainamenum] + " " + WizardNames[1, ainamenum2];

            btnName1.Text = name1;
            btnName2.Text = name2;
            btnName3.Text = name3;
        }

        private void RefreshLabels()
        {
            lblMaxHP.Text = "Max Health: "+Stats.PMaxHP.ToString();
            lblWisdom.Text = "Wisdom: " + Stats.PWisdom.ToString();
            lblDexterity.Text = "Dexterity: " + Stats.PDexterity.ToString();
            lblSkillPoints.Text = "Skillpoints: " + skillpoints.ToString();
            lblPName.Text ="Player Name: "+Stats.PName;
        }

        private void CheckStart()
        {
            if (Stats.PName!=null&&skillpoints==0&&Stats.PElement!=null)
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
                Stats.PMaxHP -= 1;
                skillpoints += 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnHealthUp_Click(object sender, EventArgs e)
        {
            if (skillpoints > 0)
            {
                Stats.PMaxHP += 1;
                skillpoints -= 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnWisdomDown_Click(object sender, EventArgs e)
        {
            if (Stats.PWisdom > 20)
            {
                Stats.PWisdom -= 1;
                skillpoints += 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnWisdomUp_Click(object sender, EventArgs e)
        {
            if (skillpoints > 0)
            {
                Stats.PWisdom += 1;
                skillpoints -= 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnDexterityDown_Click(object sender, EventArgs e)
        {
            if (Stats.PDexterity>20)
            {
                Stats.PDexterity -= 1;
                skillpoints += 1;
                RefreshLabels();
                CheckStart();
            }
        }

        private void btnDexterityUp_Click(object sender, EventArgs e)
        {
            if (skillpoints > 0)
            {
                Stats.PDexterity += 1;
                skillpoints -= 1;
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
            BattleScreen form = new BattleScreen();
            form.Show();
            this.Hide();
        }
    }
}