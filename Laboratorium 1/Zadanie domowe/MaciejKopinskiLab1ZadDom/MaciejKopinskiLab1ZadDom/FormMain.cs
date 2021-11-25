using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaciejKopinskiLab1ZadDom
{
    public partial class FormMain : Form
    {

        /// <summary>
        /// variable containing reference to negative action window
        /// </summary>
        FormNegativeAction formNegativeAction;

        /// <summary>
        /// timer handler
        /// </summary>
        int counter = 0;


        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function hiding all user controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //hide panel
            characterPanel1.Hide();
            //hide panel
            battlePanel1.Hide();
            //hide panel
            finalBattlePanel1.Hide();
            //hide panel
            shopPanel1.Hide();
        }

        /// <summary>
        /// Start of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            //enabling the timer
            timerResourcesIncome.Start();
            //showing character panel at the beginning of the game
            characterPanel1.Show();
            //disabling buttonStartGame
            buttonStartGame.Enabled = false;
            //disabling the background image
            BackgroundImage = null;
            //enabling every other button
            buttonCharacter.Enabled = true;
            buttonFinalBattle.Enabled = true;
            buttonMatch.Enabled = true;
            buttonShop.Enabled = true;
        }

        /// <summary>
        /// Function to switch to character view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCharacter_Click(object sender, EventArgs e)
        {
            //show panel
            characterPanel1.Show();
            //hide panel
            battlePanel1.Hide();
            //hide panel
            finalBattlePanel1.Hide();
            //hide panel
            shopPanel1.Hide();
        }

        /// <summary>
        /// Function to switch to shop view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShop_Click(object sender, EventArgs e)
        {
            //hide panel
            characterPanel1.Hide();
            //hide panel
            battlePanel1.Hide();
            //hide panel
            finalBattlePanel1.Hide();
            //show panel
            shopPanel1.Show();
        }

        /// <summary>
        /// Function to switch to battle view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMatch_Click(object sender, EventArgs e)
        {
            //hide panel
            characterPanel1.Hide();
            //show panel
            battlePanel1.Show();
            //hide panel
            finalBattlePanel1.Hide();
            //hide panel
            shopPanel1.Hide();
        }

        /// <summary>
        /// Function to switch to final battle view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFinalBattle_Click(object sender, EventArgs e)
        {
            //hide panel
            characterPanel1.Hide();
            //hide panel
            battlePanel1.Hide();
            //show panel
            finalBattlePanel1.Show();
            //hide panel
            shopPanel1.Hide();
        }

        /// <summary>
        /// A call to a function handled by a thread timerCounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerResourcesIncome_Tick(object sender, EventArgs e)
        {
            //counter value increase
            counter++;
            //conditional statement to give income every 10 seconds
            if (counter % 100 == 0)
            {
                //creating random object
                Random rnd = new Random();
                //added condition
                if(rnd.Next(100) > 95 && CharacterPanel.strength < 100)
                {
                    //open negative action form
                    formNegativeAction = new FormNegativeAction();
                    formNegativeAction.Show();
                    //take half of player's gold
                    CharacterPanel.gold -= CharacterPanel.gold / 2;
                }
                
                //give character 10 gold
                CharacterPanel.gold += characterPanel1.goldIncome;

                //conditional statement to provide income
                if (characterPanel1.strengthIncomeFlag)
                    CharacterPanel.strength += characterPanel1.strengthIncome;
                //conditional statement to provide income
                if (characterPanel1.conditionIncomeFlag)
                    CharacterPanel.condition += characterPanel1.conditionIncome;
                //conditional statement to provide income
                if (characterPanel1.luckIncomeFlag)
                    CharacterPanel.luck += characterPanel1.luckIncome;
                //conditional statement to provide income
                if (characterPanel1.dexterityIncomeFlag)
                    CharacterPanel.dexterity += characterPanel1.dexterityIncome;
                //conditional statement to provide income
                if (characterPanel1.intelligenceIncomeFlag)
                    CharacterPanel.intelligence += characterPanel1.intelligenceIncome;

                //refreshing statistics and gold amount
                characterPanel1.RefreshPanel();
            }
            //refreshing statistics and gold amount
            characterPanel1.RefreshPanel();
        }
    }
}
