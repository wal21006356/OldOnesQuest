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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            lblDays.Text = "You survived until Day " + Stats.Days.ToString();
        }
    }
}
