
namespace Karting
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DriveRegistration = new System.Windows.Forms.PictureBox();
            this.DonationRegistration = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DriveRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonationRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1349, 562);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                                     ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(541, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Skills 2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(521, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Москва, Россия 20 июня 2017";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(630, 675);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 38);
            this.TimeLabel.TabIndex = 3;
            // 
            // DriveRegistration
            // 
            this.DriveRegistration.ErrorImage = ((System.Drawing.Image)(resources.GetObject("DriveRegistration.ErrorImage")));
            this.DriveRegistration.Image = ((System.Drawing.Image)(resources.GetObject("DriveRegistration.Image")));
            this.DriveRegistration.InitialImage = ((System.Drawing.Image)(resources.GetObject("DriveRegistration.InitialImage")));
            this.DriveRegistration.Location = new System.Drawing.Point(141, 213);
            this.DriveRegistration.Name = "DriveRegistration";
            this.DriveRegistration.Size = new System.Drawing.Size(182, 183);
            this.DriveRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DriveRegistration.TabIndex = 4;
            this.DriveRegistration.TabStop = false;
            this.DriveRegistration.Click += new System.EventHandler(this.DriveRegistration_Click);
            // 
            // DonationRegistration
            // 
            this.DonationRegistration.Image = ((System.Drawing.Image)(resources.GetObject("DonationRegistration.Image")));
            this.DonationRegistration.InitialImage = ((System.Drawing.Image)(resources.GetObject("DonationRegistration.InitialImage")));
            this.DonationRegistration.Location = new System.Drawing.Point(409, 213);
            this.DonationRegistration.Name = "DonationRegistration";
            this.DonationRegistration.Size = new System.Drawing.Size(183, 183);
            this.DonationRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DonationRegistration.TabIndex = 5;
            this.DonationRegistration.TabStop = false;
            this.DonationRegistration.Click += new System.EventHandler(this.DonationRegistration_Click);
            // 
            // About
            // 
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.Location = new System.Drawing.Point(708, 213);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(188, 183);
            this.About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.About.TabIndex = 6;
            this.About.TabStop = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Login
            // 
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.Location = new System.Drawing.Point(987, 213);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(184, 183);
            this.Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login.TabIndex = 7;
            this.Login.TabStop = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(121, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Регистрация гонщика";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(391, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Регистрация спонсора";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(737, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "О событии";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(989, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вход в систему";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1349, 720);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.About);
            this.Controls.Add(this.DonationRegistration);
            this.Controls.Add(this.DriveRegistration);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "                                                                                 " +
    "                                                                                " +
    "               Kart Skills 2017";
            ((System.ComponentModel.ISupportInitialize)(this.DriveRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonationRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox DriveRegistration;
        private System.Windows.Forms.PictureBox DonationRegistration;
        private System.Windows.Forms.PictureBox About;
        private System.Windows.Forms.PictureBox Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

