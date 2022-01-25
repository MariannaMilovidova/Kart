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
    public partial class PayForm : Form
    {
        public PayForm(string money, string person)
        {
            InitializeComponent();
            MoneyLabel.Text = money;
            PersonLabel.Text = person;
        }
        /// <summary>
        /// переход на  страницу спонсора .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, EventArgs e)
        {
            (new DonationForm()).Show();
            this.Hide();
        }
    }
}
