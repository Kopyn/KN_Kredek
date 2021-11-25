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
    public partial class CharacterPanel : UserControl
    {

        #region variables describing all resources income

        /// <summary>
        /// variable storing gold income
        /// </summary>
        public int goldIncome = 10;
        /// <summary>
        /// variable storing strength income
        /// </summary>
        public int strengthIncome = 10;
        /// <summary>
        /// variable storing condition income
        /// </summary>
        public int conditionIncome = 10;
        /// <summary>
        /// variable storing luck income
        /// </summary>
        public int luckIncome = 10;
        /// <summary>
        /// variable storing dexterity income
        /// </summary>
        public int dexterityIncome = 10;
        /// <summary>
        /// variable storing intelligence income
        /// </summary>
        public int intelligenceIncome = 10;
        /// <summary>
        /// variable describing income after unlocking every stat
        /// </summary>
        public int boostedIncome = 100;

        #endregion

        /// <summary>
        /// public variable storing gold
        /// </summary>
        public static int gold = 0;
        /// <summary>
        /// public variable storing character's strength
        /// </summary>
        public static int strength = 10;
        /// <summary>
        /// public variable storing character's condition
        /// </summary>
        public static int condition = 10;
        /// <summary>
        /// public variable storing character's luck
        /// </summary>
        public static int luck = 10;
        /// <summary>
        /// public variable storing character's dexterity
        /// </summary>
        public static int dexterity = 10;
        /// <summary>
        /// public variable storing character's intelligence
        /// </summary>
        public static int intelligence = 10;

        /// <summary>
        /// public variable storing character's strength
        /// </summary>
        public bool strengthIncomeFlag = false;
        /// <summary>
        /// public variable storing character's condition
        /// </summary>
        public bool conditionIncomeFlag = false;
        /// <summary>
        /// public variable storing character's luck
        /// </summary>
        public bool luckIncomeFlag = false;
        /// <summary>
        /// public variable storing character's dexterity
        /// </summary>
        public bool dexterityIncomeFlag = false;
        /// <summary>
        /// public variable storing character's intelligence
        /// </summary>
        public bool intelligenceIncomeFlag = false;

        public CharacterPanel()
        {
            InitializeComponent();
        }

        private void CharacterPanel_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Refreshing values on character panel
        /// </summary>
        public void RefreshPanel()
        {
            //updating gold value
            labelGoldAmount.Text = "Złoto - " + gold;
            //updating strength value
            labelStrength.Text = "Siła - " + strength;
            //updating condition value
            labelCondition.Text = "Kondycja - " + condition;
            //updating luck value
            labelLuck.Text = "Szczęście - " + luck;
            //updating dexterity value
            labelDexterity.Text = "Zręczność - " + dexterity;
            //updating intelligence value
            labelIntelligence.Text = "Inteligencja - " + intelligence;
        }

        /// <summary>
        /// Button for enabling/upgrading strength income
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrengthIncome_Click(object sender, EventArgs e)
        {
            //conditional statement
            if(gold >= 100 && !strengthIncomeFlag)
            {
                //taking gold for upgrade
                gold -= 100;
                //unlocks condidion upgrade
                buttonConditionIncome.Enabled = true;
                //changing value to true to inform about income
                strengthIncomeFlag = true;
                //reloads all statistics and gold value
                RefreshPanel();
            }
            if(gold >= 200 && intelligence > 10)
            {
                //taking gold for upgrade
                gold -= 200;
                //improving strength income
                strengthIncome = boostedIncome;
                //reloads all statistics and gold value
                RefreshPanel();
                //disabling strength income button
                buttonStrengthIncome.Enabled = false;
            }
        }

        /// <summary>
        /// Button for enabling/upgrading condition income
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConditionIncome_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (gold >= 100 && !conditionIncomeFlag)
            {
                //taking gold for upgrade
                gold -= 100;
                //enabling luck income button
                buttonLuckIncome.Enabled = true;
                //changing value to true to inform about income
                conditionIncomeFlag = true;
                //reloads all statistics and gold value
                RefreshPanel();
            }
            if (gold >= 200 && intelligence > 10)
            {
                //taking gold for upgrade
                gold -= 200;
                //improving condition income
                conditionIncome = boostedIncome;
                //reloads all statistics and gold value
                RefreshPanel();
                //disabling condition income button
                buttonConditionIncome.Enabled = false;
            }
        }

        /// <summary>
        /// Button for enabling/upgrading luck income
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLuckIncome_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (gold >= 100 && !luckIncomeFlag)
            {
                //taking gold for upgrade
                gold -= 100;
                //enables dexterity income button
                buttonDexterityIncome.Enabled = true;
                //changing value to true to inform about income
                luckIncomeFlag = true;
                //reloads all statistics and gold value
                RefreshPanel();
            }
            if (gold >= 200 && intelligence > 10)
            {
                //taking gold for upgrade
                gold -= 200;
                //improving luck income
                luckIncome = boostedIncome;
                //reloads all statistics and gold value
                RefreshPanel();
                //disabling luck income button
                buttonLuckIncome.Enabled = false;
            }
        }

        /// <summary>
        /// Button for enabling/upgrading dexterity income
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDexterityIncome_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (gold >= 100 && !dexterityIncomeFlag)
            {
                //taking gold for upgrade
                gold -= 100;
                //enables intelligence income button
                buttonIntelligenceIncome.Enabled = true;
                //changing value to true to inform about income
                dexterityIncomeFlag = true;
                //reloads all statistics and gold value
                RefreshPanel();
            }
            if (gold >= 200 && intelligence > 10)
            {
                //taking gold for upgrade
                gold -= 200;
                //improving dexterity income
                dexterityIncome = boostedIncome;
                //reloads all statistics and gold value
                RefreshPanel();
                //disabling dexterity income button
                buttonDexterityIncome.Enabled = false;
            }
        }

        /// <summary>
        /// Button for enabling/upgrading intelligence income
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIntelligenceIncome_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (gold >= 100 && !intelligenceIncomeFlag)
            {
                //taking gold for upgrade
                gold -= 100;
                //changing value to true to inform about income
                intelligenceIncomeFlag = true;
                //reloads all statistics and gold value
                RefreshPanel();
            }
            if (gold >= 200 && intelligence > 10)
            {
                //taking gold for upgrade
                gold -= 200;
                //improving intelligence income
                intelligenceIncome = boostedIncome;
                //reloads all statistics and gold value
                RefreshPanel();
                //disabling intelligence income button
                buttonIntelligenceIncome.Enabled = false;
            }
        }


        /// <summary>
        /// Function showing tooltip on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrengthIncome_MouseHover(object sender, EventArgs e)
        {
            //conditional statement
            if (intelligence > 10)
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 200 złota, aby otrzymywać +100 co każde 10 sekund", buttonStrengthIncome);
            }
            else
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 100 złota, aby otrzymywać +10 co każde 10 sekund", buttonStrengthIncome);
            }
        }

        /// <summary>
        /// Function showing tooltip on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConditionIncome_MouseHover(object sender, EventArgs e)
        {
            //conditional statement
            if (intelligence > 10)
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 200 złota, aby otrzymywać +100 co każde 10 sekund", buttonConditionIncome);
            }
            else
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 100 złota, aby otrzymywać +10 co każde 10 sekund", buttonConditionIncome);
            }
        }

        /// <summary>
        /// Function showing tooltip on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLuckIncome_MouseHover(object sender, EventArgs e)
        {
            //conditional statement
            if (intelligence > 10)
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 200 złota, aby otrzymywać +100 co każde 10 sekund", buttonLuckIncome);
            }
            else
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 100 złota, aby otrzymywać +10 co każde 10 sekund", buttonLuckIncome);
            }
        }

        /// <summary>
        /// Function showing tooltip on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDexterityIncome_MouseHover(object sender, EventArgs e)
        {
            //conditional statement
            if (intelligence > 10)
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 200 złota, aby otrzymywać +100 co każde 10 sekund", buttonDexterityIncome);
            }
            else
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 100 złota, aby otrzymywać +10 co każde 10 sekund", buttonDexterityIncome);
            }
        }

        /// <summary>
        /// Function showing tooltip on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIntelligenceIncome_MouseHover(object sender, EventArgs e)
        {
            //conditional statement
            if (intelligence > 10)
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 200 złota, aby otrzymywać +100 co każde 10 sekund", buttonIntelligenceIncome);
            }
            else
            {
                //showing tooltip on hover
                toolTipIncomeButton.Show("Ulepsz za 100 złota, aby otrzymywać +10 co każde 10 sekund", buttonIntelligenceIncome);
            }
        }
    }
}
