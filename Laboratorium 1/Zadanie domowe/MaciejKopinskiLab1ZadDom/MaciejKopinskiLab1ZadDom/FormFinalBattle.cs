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
    public partial class FormFinalBattle : Form
    {
        public FormFinalBattle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// function to close end game window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            //close window
            this.Close();
        }
    }
}
