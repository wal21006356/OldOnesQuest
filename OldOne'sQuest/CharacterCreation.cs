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
        }

        int skillpoints = 10;

        private void RefreshLabels()
        {
            lblMaxHP.Text = "Max Health: "+Stats.PMaxHP.ToString();
            lblWisdom.Text = "Wisdom: " + Stats.PWisdom.ToString();
            lblDexterity.Text = "Dexterity: " + Stats.PDexterity.ToString();
            lblSkillPoints.Text = "Skillpoints: " + skillpoints.ToString();
        }

        private void btnHealthDown_Click(object sender, EventArgs e)
        {
            Stats.PMaxHP -= 1;
            skillpoints += 1;
            RefreshLabels();
        }

        private void btnHealthUp_Click(object sender, EventArgs e)
        {
            if (skillpoints > 0)
            {
                Stats.PMaxHP += 1;
                skillpoints -= 1;
                RefreshLabels();
            }
        }

        private void btnWisdomDown_Click(object sender, EventArgs e)
        {
            Stats.PWisdom -= 1;
            skillpoints += 1;
            RefreshLabels();
        }

        private void btnWisdomUp_Click(object sender, EventArgs e)
        {
            if (skillpoints > 0)
            {
                Stats.PWisdom += 1;
                skillpoints -= 1;
                RefreshLabels();
            }
        }

        private void btnDexterityDown_Click(object sender, EventArgs e)
        {
            Stats.PDexterity -= 1;
            skillpoints += 1;
            RefreshLabels();
        }

        private void btnDexterityUp_Click(object sender, EventArgs e)
        {
            if (skillpoints > 0)
            {
                Stats.PDexterity += 1;
                skillpoints -= 1;
                RefreshLabels();
            }
        }
    }
}
