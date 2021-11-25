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
    public partial class FormNegativeAction : Form
    {
        public FormNegativeAction()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloseNegativeActionForm_Click(object sender, EventArgs e)
        {
            //closing the form
            this.Close();
        }
    }
}
