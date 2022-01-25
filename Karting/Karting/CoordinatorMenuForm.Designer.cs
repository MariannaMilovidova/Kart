
namespace Karting
{
    partial class CoordinatorMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinatorMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Silver;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(139, 212);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(400, 83);
            this.Login.TabIndex = 4;
            this.Login.Text = "Гонщики";
            this.Login.UseVisualStyleBackColor = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logout.Location = new System.Drawing.Point(1141, 37);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(112, 46);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F);
            this.label4.Location = new System.Drawing.Point(543, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Меню координатора";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(799, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(356, 83);
            this.button3.TabIndex = 9;
            this.button3.Text = "Спонсоры";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // CoordinatorMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1349, 720);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CoordinatorMenuForm";
            this.Text = "                                                                                 " +
    "                                                                                " +
    "               Kart Skills 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}