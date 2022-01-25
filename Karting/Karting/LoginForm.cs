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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Back.Visible = false;
            CancelLabel.Visible = false;
            DriveBtn.Visible = false;
            CoordinatorBtn.Visible = false;
            AdminBtn.Visible = false;
        }
        /// <summary>
        /// обработка входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            Title1.Visible = true;
            Title2.Visible = true;
            Body.Visible = true;
            Back.Visible = true;
            CancelLabel.Visible = true;
            CancelLabel.BringToFront();
            DriveBtn.Visible = true;
            DriveBtn.BringToFront();
            CoordinatorBtn.Visible = true;
            CoordinatorBtn.BringToFront();
            AdminBtn.Visible = true;
            AdminBtn.BringToFront();
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
        /// отмена входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelLabel_Click(object sender, EventArgs e)
        {
            Title1.Visible = false;
            Title2.Visible = false;
            Body.Visible = false;
            Back.Visible = false;
            Back.Visible = false;
            CancelLabel.Visible = false;
            DriveBtn.Visible = false;
            CoordinatorBtn.Visible = false;
            AdminBtn.Visible = false;
        }
        /// <summary>
        /// переход на  страницу гонщика.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DriveBtn_Click(object sender, EventArgs e)
        {
            (new DriveMenuForm()).Show();
            this.Hide();
        }
        /// <summary>
        /// переход на  страницу координатора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoordinatorBtn_Click(object sender, EventArgs e)
        {
            (new CoordinatorMenuForm()).Show();
            this.Hide();
        }
        /// <summary>
        /// переход на  страницу админа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminBtn_Click(object sender, EventArgs e)
        {
            (new AdminMenuForm()).Show();
            this.Hide();
        }
    }
}
