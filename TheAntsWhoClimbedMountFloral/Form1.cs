/*
 * Program Name: The Ants Who Climbed Mount Floral
 * Programmer: Trevor Gillam
 * Date: 12/19/2022
 *
 * Description: TAWCMF is a game where you summon ants to journey up a mountain. The game has achievements that unlock
 * after certain conditions are met.
 * 
 */


namespace TheAntsWhoClimbedMountFloral
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Ant> antList = new List<Ant>();
        List<Ant> antHomeList = new List<Ant>();
        int maxAntsHome = 3;
        List<Ant> antExpeditionList = new List<Ant>();
        List<Achievement> allAchievements = new List<Achievement>();
        List<Recipe> allRecipes = new();
        public List<Item> playerItemList = new List<Item>();
        public static int totalAnts = 0;
        public int deadAnts = 0;
        public float currentLuck = 5;
        public float currentSkill = 1;
        public float currentEfficiency = 5;
        public int currentVitality = 3;
        public int homesickRate = 4;
        bool dispelAchievement = false;
        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {

            playerItemList.Add(new Item(0, "dirt", 0));
            playerItemList.Add(new Item(1, "stick", 0));

            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 2000;
            timer.Start();
            InitializeComponent();

            CreateAchievements();
            DrawAchievements();

        }

        #region achievements

        void DrawAchievements()
        {
            foreach(Achievement ach in allAchievements)
            {

                ach.achievementPicBox.Location = new Point((ach.ID)*40,0);
                ach.achievementPicBox.Tag = ach;
                ach.achievementPicBox.Click += new System.EventHandler(Achievement_Click);
                tabPageAchievement.Controls.Add(ach.achievementPicBox);
            }
        }
        public void Achievement_Click(object sender, EventArgs e)
        {
            PictureBox ach = sender as PictureBox;
            ViewAchievement(ach.Tag as Achievement);
        }
        public void ViewAchievement(Achievement ach)
        {
            labelAchName.Text = ach.name;
            labelAchDescription.Text = ach.requirementText;
            pictureBoxAch.Image = ach.achievementPicBox.Image;
            if (ach.recipeUnlock != null && ach.unlocked == true)
            {
                labelRecipeUnlock.Text = "Unlocks " + ach.recipeUnlock.name;
            } else
            {
                labelRecipeUnlock.Text = "";
            }
        }
        void UnlockAchievement(Achievement ach)
        {
            ach.Unlock();
            labelAchievementUnlocked.Visible = true;
            labelAchievementUnlocked.Text = "Achievement Unlocked: \"" + ach.name + "\"";
        }
        void CreateAchievements()
        {
            allAchievements.Add(new Achievement(0, "What's this for?", "Have an ant return home with an item.", null, null));
            allAchievements.Add(new Achievement(1, "A colony forms.", "Have 5 ants in the mound.", null, null));
            allAchievements.Add(new Achievement(2, "The climb commences.", "Have 5 ants on expeditions concurrently.", null, null));
            allAchievements.Add(new Achievement(3, "Seasoned Explorer.", "Have the same ant complete 5 separate expeditions.", null, null));
            allAchievements.Add(new Achievement(4, "Natural Selection WIP", "Send ant #36 on an expedition.",null,null));
            allAchievements.Add(new Achievement(5, "First, not last.", "Have ant #1 die.", null, null));
            allAchievements.Add(new Achievement(6, "The ends justify the means.", "Have 100 ants die.", null, null));
        }
        void CheckAchievements()
        {
            if (!allAchievements[0].unlocked)
            {
                foreach (Item item in playerItemList)
                {
                    if (item.amount > 0)
                    {
                        UnlockAchievement(allAchievements[0]);
                    }
                }
            }
            if (!allAchievements[1].unlocked)
            {
                if (antHomeList.Count >= 5)
                {
                    UnlockAchievement(allAchievements[1]);
                }
            }
            if (!allAchievements[2].unlocked)
            {
                if (antExpeditionList.Count >= 20)
                {
                    UnlockAchievement(allAchievements[2]);
                }
            }
            if (!allAchievements[3].unlocked)
            {
                foreach(Ant ant in antHomeList)
                {
                    if(ant.antExpeditionsCompleted >=5)
                    {
                        UnlockAchievement(allAchievements[3]);
                    }
                }
            }
            if (!allAchievements[4].unlocked)
            {
                foreach(Ant ant in antExpeditionList)
                {
                    if(ant.antNumber == 36)
                    {
                        UnlockAchievement(allAchievements[4]);
                    }
                }
            }
            if (!allAchievements[5].unlocked)
            {
                bool ant1Alive = false;
                foreach(Ant ant in antList)
                {
                    if(ant.antNumber == 1)
                    {
                        ant1Alive = true;
                    }
                }
                if(ant1Alive == false)
                {
                    UnlockAchievement(allAchievements[5]);
                }
            }
            if (!allAchievements[6].unlocked)
            {
                if(deadAnts>=100)
                {
                    UnlockAchievement(allAchievements[7]);
                }
            }

        }
        #endregion
        #region recipes




        #endregion
        private void TimerEventProcessor(object? myObject, EventArgs e)
        {
            AddAntsCheck();
            MoundCheck();
            InventoryCheck();
            CheckAchievements();
            if (antExpeditionList.Count > 0)
            {
                ExpeditionCheck();
                HighestAnt(antExpeditionList).antHeightLabel.Text = ".<--" + HighestAnt(antExpeditionList).antNumber;
            }
            if(labelAchievementUnlocked.Visible == true)
            {
                if(dispelAchievement)
                {
                    labelAchievementUnlocked.Visible = false;
                    dispelAchievement = false;
                } else
                {
                    dispelAchievement = true;
                }
            }
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            int index = rnd.Next(0, antHomeList.Count);
            Ant sendAnt = antHomeList[index];
            sendAnt.GenerateStats(currentLuck, currentSkill, currentEfficiency, currentVitality);
            antExpeditionList.Add(sendAnt);
            panelMountain.Controls.Add(sendAnt.antHeightLabel);
            DrawAnt(sendAnt);
            antHomeList.Remove(sendAnt);
            MoundCheck();
            

        }

        public void MoundCheck()
        {
            labelAntCount.Text = "Ants: " + antHomeList.Count + "/" + maxAntsHome;
            if(antHomeList.Count >0)
            {
                buttonSend.Enabled = true;
            } else
            {
                buttonSend.Enabled = false;
            }
        }
        public void AddAntsCheck()
        {
            if(antList.Count < maxAntsHome)
            {
                MakeAnt();
            }
            
        }
        public void InventoryCheck()
        {
            labelItems.Text = "";
           foreach(Item item in playerItemList)
            {
                if(item.amount >0)
                {
                    labelItems.Text += "\r\n" + item.name + ": " + item.amount;
                }
            } 
        }
        public void ExpeditionCheck()
        {
            
            foreach(Ant ant in antExpeditionList.ToList())
            {
                AntDecision(ant);
                DrawAnt(ant);
            }
                 
        }
        #region ants!
        public void AntDecision(Ant ant)
        {
            float choice = rnd.Next(0, 100);
            ant.antHomesick += homesickRate;
            if(ant.antHomesick>choice)
            {
                ReturnAnt(ant);
                return;
            }
            choice *= ant.antSkill;


            switch (choice)
            {
                case <20:
                    KillAnt(ant);
                    break;
                case < 40:
                    break;
                case < 80:
                    ClimbAnt(ant);
                    break;
                case < 100:
                    FindAnt(ant);
                    break;
                case < 110:
                    ClimbAnt(ant);
                    FindAnt(ant);
                    break;

            }
        }
        public void DrawAnt(Ant ant)
        {
            ant.antHeightLabel.Location = new Point(ant.antHeightLabel.Location.X + rnd.Next(-30, 30), VisualizeHeight(ant.antHeight));

        }
        public Ant HighestAnt(List<Ant> antList)
        {
            Ant highest = new Ant(0,0,0,0,0);
            foreach(Ant ant in antList)
            {
                if(ant.antHeight > highest.antHeight)
                {
                    highest = ant;
                }
            }
            return highest;
        }
        public int VisualizeHeight(float height)
        {
            return panelMountain.Height - 15 - (int)height;
        }
        void MakeAnt()
        {
            totalAnts++;
            Ant newAnt = new Ant(totalAnts, currentLuck, currentSkill, currentEfficiency, currentVitality);
            antList.Add(newAnt);
            antHomeList.Add(newAnt);

        }
        void FindAnt(Ant ant)
        {
            Item itemAdd;
            int choice = rnd.Next(0, 10);
            choice += (int)ant.antHeight;
            choice += (int)ant.antLuck;

            switch(choice)
            {
                case < 5:
                    itemAdd = playerItemList[0];
                    break;
                case < 30:
                    itemAdd = playerItemList[1];
                    break;
                default:
                    itemAdd = playerItemList[0];
                    break;
            }

            ant.antItemsCollected.Add(itemAdd);
            textBoxExStatus.AppendText("\r\n Ant #" + ant.antNumber + " found " + itemAdd.name.ToString() + ".");

        }
        void ClimbAnt(Ant ant)
        {
            ant.antHeight += ant.antEfficiency;
        }
        void ReturnAnt(Ant ant)
        {
            ant.antExpeditionsCompleted++;
            antExpeditionList.Remove(ant);
            antHomeList.Add(ant);
            panelMountain.Controls.Remove(ant.antHeightLabel);
            textBoxExStatus.AppendText("\n Ant #" + ant.antNumber + " returned home.");
            PlayerObtain(ant.antItemsCollected);
        }
        void KillAnt(Ant ant)
        {
            antExpeditionList.Remove(ant);
            panelMountain.Controls.Remove(ant.antHeightLabel);
            textBoxExStatus.AppendText("\r\n Ant #" + ant.antNumber + DeathString());
            antList.Remove(ant);
            deadAnts++;
        }
        string DeathString()
        {
            int msg = rnd.Next(0, 5);
            switch (msg)
            {
                case 0:
                    return " fell.";
                case 1:
                    return " suffocated in an avalanche.";
                case 2:
                    return " starved.";
                case 3:
                    return " froze.";
                case 4:
                    return " went missing.";
                default:
                    return " dissapeared.";
            }
        }
        #endregion

        void PlayerObtain(List<Item> list)
        {
            
            foreach(Item item in list)
            {
                playerItemList[item.ID].amount++;
            }
        }



    }


    public class Item
    {
        public int ID;
        public string name;
        public int amount;

        public Item(int iD, string name, int amount)
        {
            ID = iD;
            this.name = name;
            this.amount = amount;
        }
    }
    public class Achievement
    {
        public int ID;
        public string name;
        public string requirementText;
        public PictureBox achievementPicBox = new PictureBox();
        public bool unlocked = false;
        public Recipe? recipeUnlock;

        public Achievement(int iD, string name, string requirementText, Recipe? recipeUnlock, Image? achievementPicture)
        {
            ID = iD;
            this.name = name;
            this.requirementText = requirementText;
            this.recipeUnlock = recipeUnlock;

            achievementPicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            achievementPicBox.Size = new Size(40, 40);
            achievementPicBox.BackColor = Color.IndianRed;
            achievementPicBox.BorderStyle = BorderStyle.Fixed3D;
            if(achievementPicture !=null)
            {
                achievementPicBox.Image = achievementPicture;
            }
        }
        public void Unlock()
        {
            if(unlocked != true)
            {
                unlocked = true;
                achievementPicBox.BackColor = Color.Green;
            }

        }
    }
    public class Recipe
    {
        public int name;
        public bool craftable = false;
        new List<Item> requiredItems = new();

    }

    public class Ant
    {
        public int antNumber;
        public int antExpeditionsCompleted = 0;
        public float antHeight = 0;
        public float antHomesick = 0;
        public float antLuck;
        public float antSkill;
        public float antEfficiency;
        public float antVitality;
        public Label antHeightLabel;
        public List<Item> antItemsCollected;

        public Ant(int antNumber, float antLuck, float antSkill, float antEfficiency, int antVitality)
        {
            Random rnd = new Random();
            this.antNumber = antNumber;
            antItemsCollected = new List<Item>();
            antHeightLabel = new Label();
            antHeightLabel.Location = new Point(rnd.Next(20, 180), (int)antHeight);
            antHeightLabel.BackColor = System.Drawing.Color.Transparent;
            antHeightLabel.AutoSize = true;
            GenerateStats(antLuck, antSkill, antEfficiency, antVitality);
        }
        public void GenerateStats(float antLuck, float antSkill, float antEfficiency, int antVitality)
        {
            antHeight = 0;
            antHomesick = 0;
            this.antLuck = antLuck;
            this.antSkill = antSkill;
            this.antEfficiency = antEfficiency;
            this.antVitality = antVitality;
            antHeightLabel.Text = ".";
        }
    }
}