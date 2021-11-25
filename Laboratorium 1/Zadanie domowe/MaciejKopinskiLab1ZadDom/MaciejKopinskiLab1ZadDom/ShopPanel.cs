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
    public partial class ShopPanel : UserControl
    {

        #region variables describing item from shop

        /// <summary>
        /// array containing bonus statistics from items
        /// </summary>
        int[] itemStatistics = { 10, 20, 50, 100, 200, 500, 1000 };
        /// <summary>
        /// array containing item prices
        /// </summary>
        int[] itemPrices = { 10, 20, 50, 70, 100, 150, 200 };
        /// <summary>
        /// index of shoes that appear in shop
        /// </summary>
        int shoesInShopIndex = 0;
        /// <summary>
        /// index of shorts that appear in shop
        /// </summary>
        int shortsFromShopIntex = 0;
        /// <summary>
        /// index of tshirt that appears in shop
        /// </summary>
        int tshirtInShopIndex = 0;
        /// <summary>
        /// index of tennis racket that appears in shop
        /// </summary>
        int tennisRacketInShopIndex = 0;

        #endregion

        public ShopPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to buy rocket from shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyRocket_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (tennisRacketInShopIndex == 5 && CharacterPanel.gold >= itemPrices[5])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[tennisRacketInShopIndex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.condition += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.luck += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.dexterity += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.intelligence += itemStatistics[tennisRacketInShopIndex];
                //disable buy button
                buttonBuyRocket.Enabled = false;
            }
            else if (CharacterPanel.gold >= itemPrices[tennisRacketInShopIndex])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[tennisRacketInShopIndex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.condition += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.luck += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.dexterity += itemStatistics[tennisRacketInShopIndex];
                CharacterPanel.intelligence += itemStatistics[tennisRacketInShopIndex];
                //increase item index
                tennisRacketInShopIndex++;
                
            }
        }

        /// <summary>
        /// Button to buy T-shirt from shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyTshirt_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (tshirtInShopIndex == 5 && CharacterPanel.gold >= itemPrices[5])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[tshirtInShopIndex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[tshirtInShopIndex];
                CharacterPanel.condition += itemStatistics[tshirtInShopIndex];
                CharacterPanel.luck += itemStatistics[tshirtInShopIndex];
                CharacterPanel.dexterity += itemStatistics[tshirtInShopIndex];
                CharacterPanel.intelligence += itemStatistics[tshirtInShopIndex];
                //disable buy button
                buttonBuyTshirt.Enabled = false;
            }
            else if (CharacterPanel.gold >= itemPrices[tshirtInShopIndex])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[tshirtInShopIndex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[tshirtInShopIndex];
                CharacterPanel.condition += itemStatistics[tshirtInShopIndex];
                CharacterPanel.luck += itemStatistics[tshirtInShopIndex];
                CharacterPanel.dexterity += itemStatistics[tshirtInShopIndex];
                CharacterPanel.intelligence += itemStatistics[tshirtInShopIndex];
                //increase item index
                tshirtInShopIndex++;

            }
        }

        /// <summary>
        /// Button to buy shorts from shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyShorts_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (shortsFromShopIntex == 5 && CharacterPanel.gold >= itemPrices[5])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[shortsFromShopIntex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[shortsFromShopIntex];
                CharacterPanel.condition += itemStatistics[shortsFromShopIntex];
                CharacterPanel.luck += itemStatistics[shortsFromShopIntex];
                CharacterPanel.dexterity += itemStatistics[shortsFromShopIntex];
                CharacterPanel.intelligence += itemStatistics[shortsFromShopIntex];
                //disable buy button
                buttonBuyShorts.Enabled = false;
            }
            else if (CharacterPanel.gold >= itemPrices[shortsFromShopIntex])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[shortsFromShopIntex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[shortsFromShopIntex];
                CharacterPanel.condition += itemStatistics[shortsFromShopIntex];
                CharacterPanel.luck += itemStatistics[shortsFromShopIntex];
                CharacterPanel.dexterity += itemStatistics[shortsFromShopIntex];
                CharacterPanel.intelligence += itemStatistics[shortsFromShopIntex];
                //increase item index
                shortsFromShopIntex++;

            }
        }

        /// <summary>
        /// Button to buy shoes from shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyShoes_Click(object sender, EventArgs e)
        {
            //conditional statement
            if (shoesInShopIndex == 5 && CharacterPanel.gold >= itemPrices[5])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[shoesInShopIndex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[shoesInShopIndex];
                CharacterPanel.condition += itemStatistics[shoesInShopIndex];
                CharacterPanel.luck += itemStatistics[shoesInShopIndex];
                CharacterPanel.dexterity += itemStatistics[shoesInShopIndex];
                CharacterPanel.intelligence += itemStatistics[shoesInShopIndex];
                //disable buy button
                buttonBuyShoes.Enabled = false;
            }
            else if (CharacterPanel.gold >= itemPrices[shoesInShopIndex])
            {
                //take player's gold
                CharacterPanel.gold -= itemPrices[shoesInShopIndex];
                //increase player's statistics
                CharacterPanel.strength += itemStatistics[shoesInShopIndex];
                CharacterPanel.condition += itemStatistics[shoesInShopIndex];
                CharacterPanel.luck += itemStatistics[shoesInShopIndex];
                CharacterPanel.dexterity += itemStatistics[shoesInShopIndex];
                CharacterPanel.intelligence += itemStatistics[shoesInShopIndex];
                //increase item index
                shoesInShopIndex++;

            }
        }

        //show tooltip
        private void buttonBuyRocket_MouseHover(object sender, EventArgs e)
        {
            toolTipBuyButton.Show("Kup za " + itemPrices[tennisRacketInShopIndex] + " złota", buttonBuyRocket);
        }

        //show tooltip
        private void buttonBuyTshirt_MouseHover(object sender, EventArgs e)
        {
            toolTipBuyButton.Show("Kup za " + itemPrices[tshirtInShopIndex] + " złota", buttonBuyTshirt);
        }

        //show tooltip
        private void buttonBuyShorts_MouseHover(object sender, EventArgs e)
        {
            toolTipBuyButton.Show("Kup za " + itemPrices[shortsFromShopIntex] + " złota", buttonBuyShorts);
        }

        //show tooltip
        private void buttonBuyShoes_MouseHover(object sender, EventArgs e)
        {
            toolTipBuyButton.Show("Kup za " + itemPrices[shoesInShopIndex] + " złota", buttonBuyShoes);
        }
    }
}
