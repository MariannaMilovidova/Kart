using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karting
{
    public partial class CharityForm : Form
    {
        public CharityForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// переход на  страницу о событии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
            this.Hide();
        }
    }
}
