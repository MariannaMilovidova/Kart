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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// переход на  главную страницу гонщика .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DriveRegistration_Click(object sender, EventArgs e)
        {
            (new DriveForm()).Show();
            this.Hide();
        }
        /// <summary>
        /// переход на  главную страницу спонсора .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DonationRegistration_Click(object sender, EventArgs e)
        {
            (new DonationForm()).Show();
            this.Hide();
        }
        /// <summary>
        /// переход на  главную страницу о событии .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
            this.Hide();
        }
        /// <summary>
        /// переход на  главную страницу авторизации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            (new LoginForm()).Show();
            this.Hide();
        }
    }
}
