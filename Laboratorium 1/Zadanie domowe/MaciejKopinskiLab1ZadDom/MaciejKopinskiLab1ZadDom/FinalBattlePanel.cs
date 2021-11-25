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
    public partial class FinalBattlePanel : UserControl
    {
        /// <summary>
        /// variable storing reference to final battle form
        /// </summary>
        FormFinalBattle formFinalBattle;

        public FinalBattlePanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// function to try to defeat the teacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTryFinalBattle_Click(object sender, EventArgs e)
        {
            //variable to store sum of all of character's statistics
            int sum = 0;
            //adding statistic value
            sum += CharacterPanel.strength;
            //adding statistic value
            sum += CharacterPanel.condition;
            //adding statistic value
            sum += CharacterPanel.luck;
            //adding statistic value
            sum += CharacterPanel.dexterity;
            //adding statistic value
            sum += CharacterPanel.intelligence;

            //conditional statement
            if (sum >= 10000)
            {
                //initialize and show new form
                formFinalBattle = new FormFinalBattle();
                formFinalBattle.Show();
            }
        }

        /// <summary>
        /// Function showing tooltip on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTryFinalBattle_MouseHover(object sender, EventArgs e)
        {
            //variable to store sum of all of character's statistics
            int sum = 0;
            //adding statistic value
            sum += CharacterPanel.strength;
            //adding statistic value
            sum += CharacterPanel.condition;
            //adding statistic value
            sum += CharacterPanel.luck;
            //adding statistic value
            sum += CharacterPanel.dexterity;
            //adding statistic value
            sum += CharacterPanel.intelligence;


            //conditional statement
            if (sum >= 10000)
            {
                //showing tooltip on hover
                toolTipFinalBattle.Show("Podejmij wyzwanie!", buttonTryFinalBattle);
            }
            else
            {
                //showing tooltip on hover
                toolTipFinalBattle.Show("Potrzebujesz łącznej wartości 10000 po dodaniu do siebie wszystkich swoich statystyk!", buttonTryFinalBattle);
            }
        }
    }
}
