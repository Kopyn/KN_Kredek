using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaciejKopińskiLab1
{
    public partial class FormMain : Form
    {

        #region zmienne dotyczące zarządzania treścią tekstboxów

        /// <summary>
        /// zmienna przechowująca wartość pola textBoxAdd
        /// </summary>
        int number = 1;
        /// <summary>
        /// Zmienna obsługująca zegar
        /// </summary>
        int counter = 1;
        /// <summary>
        /// zmienna przechowująca wartosć pola textBoxMultiply
        /// </summary>
        int multiplyProduct = 1;
        /// <summary>
        /// zmienna przechowująca referencję do nowego okna
        /// </summary>
        FormNew formNew;

        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk zmieniający kolor tła i elementów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //zmiana koloru tła
            BackColor = Color.Green;
            //zmiana koloru przycisku
            buttonColor.BackColor = Color.Pink;
        }

        /// <summary>
        /// Przycisk zmieniający kolor drugiego przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColorClickSecondButton(object sender, EventArgs e)
        {
            //zmiana koloru trzeciego przycisku
            buttonColorSecond.BackColor = Color.Red;
            //zmiana tekstu na przycisku
            buttonColorSecond.Text = "Zmiana";
        }

        /// <summary>
        /// Przycisk zmieniający kolor trzeciego przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColorClickThirdButton(object sender, EventArgs e)
        {
            //zmiana koloru drugiego przycisku
            buttonColorThird.BackColor = Color.Aqua;
        }

        /// <summary>
        /// Przycisk zwiększający wartość textBoxAdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego na liczbę
            number = Int32.Parse(textBoxAdd.Text);
            //dodanie wartości liczbowej
            number += 7;
            //zamiana wartości liczbowej na zmienną typu string
            textBoxAdd.Text = number.ToString();
            //dodanie warunku
            if(number>20) MessageBox.Show("Uwaga przekroczono próg 20!");
            if (number > 40) BackColor = Color.Blue;
        }

        /// <summary>
        /// Przycisk zwiększający wartość wartość textBoxMultiply
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego na liczbę
            multiplyProduct = Int32.Parse(textBoxMultiply.Text);
            //domnożenie wartości z pierwszego pola tekstowego
            multiplyProduct *= number;
            //zamiana wartości liczbowej na zmienną typu string
            textBoxMultiply.Text = multiplyProduct.ToString();
        }

        /// <summary>
        /// Uruchomienie timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //uruchomienie zegara
            timerCounter.Start();
        }

        /// <summary>
        /// Wywołanie funkcji obsługiwanej przez wątek elementu timerCounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //zwiększanie zmiennej counter
            counter++;
            //wypisanie wartości countera w polu textBoxAdd
            textBoxAdd.Text = counter.ToString();
            //dodanie warunku
            if (counter >= 5) BackColor = Color.Brown;
        }

        /// <summary>
        /// Funkcja tworząca nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            //utworzenie nowego obiektu okna FormNew
            formNew = new FormNew();
            //przypisanie wartości do innego okna
            formNew.mainWindowValue = "Maciej Kopiński";
            //otworzenie okna obiektu formNew
            formNew.Show();
        }
    }
}
