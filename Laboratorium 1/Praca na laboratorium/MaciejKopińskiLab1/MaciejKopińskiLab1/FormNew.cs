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
    public partial class FormNew : Form
    {
        //zmienna publiczna pozwalająca na dostęp do jej wartości z poziomu innych obiektów
        public string mainWindowValue = "brak wartości";

        public FormNew()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcjia wywoływana podczas wczytywania okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNew_Load(object sender, EventArgs e)
        {
            //przypisanie wartości ze zmiennej do obiektu label
            labelFormMainValue.Text = mainWindowValue;
        }
    }
}
