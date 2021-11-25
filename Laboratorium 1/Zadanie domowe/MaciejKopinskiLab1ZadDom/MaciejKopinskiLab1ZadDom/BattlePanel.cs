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
    public partial class BattlePanel : UserControl
    {
        /// <summary>
        /// variable describing player's points
        /// </summary>
        int points = 0;
        /// <summary>
        /// ball's horizontal speed
        /// </summary>
        int speed_horizontal = 15;
        /// <summary>
        /// ball's vertical speed
        /// </summary>
        int speed_vertical = 15;

        public BattlePanel()
        {
            InitializeComponent();
            //hide match panel
            panelBattle.Hide();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button to play match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayMatch_Click(object sender, EventArgs e)
        {
            //give player additional 20 gold
            CharacterPanel.gold += 20;
            //show match panel
            panelBattle.Show();
            //timer start
            timerBattle.Enabled = true;
            //set the racket location
            pictureBoxRacket.Top = panelBattle.Bottom - (panelBattle.Bottom / 10);
        }

        /// <summary>
        /// Funtion showing tooltip on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayMatch_MouseHover(object sender, EventArgs e)
        {
            //show tool tip
            toolTipPlayMatch.Show("Zagraj mecz i zyskaj +20 złota", buttonPlayMatch);
        }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            //Show the actual score
            labelPoints.Text = "Wynik: " + points;

            //Conditional statement
            if (points == 3)
            {
                //hide battle panel
                panelBattle.Hide();
                //reset timer
                timerBattle.Enabled = false;
                //reset points
                points = 0;
            }

            //move racket
            pictureBoxRacket.Left = Cursor.Position.X - (pictureBoxRacket.Width/2);
            //move ball
            pictureBoxBall.Left += speed_horizontal;
            pictureBoxBall.Top += speed_vertical;
            
            //ball-racket collision
            if(pictureBoxBall.Bottom >= pictureBoxRacket.Top && pictureBoxBall.Bottom <= pictureBoxRacket.Bottom
                && pictureBoxBall.Left >= pictureBoxRacket.Left && pictureBoxBall.Right <= pictureBoxRacket.Right)
            {
                //change ball direction
                speed_vertical = -speed_vertical;
                points += 1;
            }
            //ball-left wall collision
            if(pictureBoxBall.Left <= panelBattle.Left)
            {
                //change ball direction
                speed_horizontal = -speed_horizontal;
            }
            //ball-right wall collision
            if (pictureBoxBall.Right >= panelBattle.Right)
            {
                //change ball direction
                speed_horizontal = -speed_horizontal;
            }
            //ball-top wall collision
            if (pictureBoxBall.Top >= panelBattle.Top)
            {
                //change ball direction
                speed_vertical = -speed_vertical;
            }
            //ball-bottom wall collision
            if (pictureBoxBall.Bottom <= panelBattle.Bottom)
            {
                //change ball direction
                speed_vertical = -speed_vertical;
            }
        }
    }
}
