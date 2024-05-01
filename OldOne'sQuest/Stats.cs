using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//I need this, trust me, definitely, yup, totally, just kidding, I do actually need this for the character stats.

namespace OldOne_sQuest
{
    internal class Stats
    {
        public static string PElement;
        public static int PWisdom = 30;
        public static int PMaxHP = 100;
        public static int PDexterity = 30;
        public static string PName;
        public static string EName;
        public static int EHealth;
        public static Single EElement;
        public static int Days = 0;
        public static Random random = new Random();
        public static int Funenemy;
        public static string[,] WizardNames = { { "Flubster", "Gandalf", "Hairy", "Harry", "John", "Moldywart", "Gingelmash", "Gilgamesh", "Gigglemesh", "Uruk", "Sumer", "Tommy", "Luke", "Quincy", "Penelope", "Bingle", "Frengle", "Frodo", "Freddo", "Cadbury", "Tesco" }, { "The Wise", "The Great", "The Grey", "The Flabby", "The Disintegrated", "The Powerful", "The Undefeated", "The Still Living", "The Defeated", "Liver", "The Pope", "Gell", "Sainsbury", "Baggins", "Potter", "The Throngled", "The Drowned", "The Refleshed", "The Fetus", "The Flabster", "Flubberbelly" } };
    }
}
