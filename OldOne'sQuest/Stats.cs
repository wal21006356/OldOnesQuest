using System;

//I need this, trust me, definitely, yup, totally, just kidding, I do actually need this for the character stats.

namespace OldOne_sQuest
{
    internal class Stats
    {
        public static string PElement;//player element
        public static int PWisdom = 30;
        public static int PMaxHP = 100;
        public static int PDexterity = 30;
        public static string PName;
        public static string EName;
        public static int EHealth;
        public static Single EElement;
        public static int Days = 0;
        public static int StatPoints = 10;
        public static Random random = new Random();
        public static bool CharCreated;
        public static int Funenemy;
        public static string[,] WizardNames = { { "Flubster", "Gandalf", "Hairy", "Harry", "John", "Moldywart", "Gingelmash", "Gilgamesh", "Gigglemesh", "Uruk", "Sumer", "Tommy", "Luke", "Quincy", "Penelope", "Bingle", "Frengle", "Frodo", "Freddo", "Cadbury", "Tesco" }, { "The Wise", "The Great", "The Grey", "The Flabby", "The Disintegrated", "The Powerful", "The Undefeated", "The Still Living", "The Defeated", "Liver", "The Pope", "Gell", "Sainsbury", "Baggins", "Potter", "The Throngled", "The Drowned", "The Refleshed", "The Fetus", "The Flabster", "Flubberbelly" } };
        //i need these boundaries so that when the player defeats a wizard, the next one can have bigger stats and be harder to defeat
        public static int lowerAIRand;//sets the lower boundary that the ai can have wisdom and dex for
        public static int upperAIRand = 35;//sets the the same but the upper boundary
        public static int lowerAIHealth = 95;//the lower boundary of the ai health
        public static int upperAIHealth = 110;//the upper health
        //im using this bit to make it so you have to fight the current wise one before you can continue when you reach his daycount
        public static string currentleader;
        public static int leaderdays;
        public static int leaderHealth;
        public static int leaderWisdom;
        public static int leaderDexterity;
        public static int leaderElement;
    }
}
