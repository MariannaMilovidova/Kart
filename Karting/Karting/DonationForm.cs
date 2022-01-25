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
    public partial class DonationForm : Form
    {
        public DonationForm()
        {
            InitializeComponent();
            DriveCombobox.SelectedIndex = 0;
        }
        /// <summary>
        /// переход на  главную страницу .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, EventArgs e)
        {
            (new MainForm()).Show();
            this.Hide();
        }
        /// <summary>
        /// обработка уменьшения пожертвования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Money.Text) >= 10)
                Money.Text = (Convert.ToInt32(Money.Text) - 10).ToString();
            Moneylabel.Text = "$ " + Money.Text;
        }

        /// <summary>
        /// обработка увеличения пожертвования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plus_Click(object sender, EventArgs e)
        {
            
            Money.Text = (Convert.ToInt32(Money.Text) + 10).ToString();
            Moneylabel.Text = "$ " + Money.Text;
        }
        /// <summary>
        /// переход на подтверждения пожертвования страницу .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pay_Click(object sender, EventArgs e)
        {
            (new PayForm(Moneylabel.Text, DriveCombobox.SelectedItem.ToString())).Show();
            this.Hide();
        }
        /// <summary>
        /// переход на  главную страницу .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            (new MainForm()).Show();
            this.Hide();
        }
    }
}
