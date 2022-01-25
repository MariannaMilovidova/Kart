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
    public partial class DriveForm : Form
    {
        public DriveForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// переход на  авторизациии страницу .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            (new LoginForm()).Show();
            this.Hide();
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
    }
}
