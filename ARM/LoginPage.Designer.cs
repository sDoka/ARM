namespace ARM
{
    partial class LoginPage
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reg_ll = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.adminEntrance = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tc1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc1
            // 
            this.tc1.Controls.Add(this.tabPage1);
            this.tc1.Location = new System.Drawing.Point(-5, -2);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(289, 205);
            this.tc1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.reg_ll);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.loginLabel);
            this.tabPage1.Controls.Add(this.PassTB);
            this.tabPage1.Controls.Add(this.LoginTB);
            this.tabPage1.Controls.Add(this.adminEntrance);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация мастера";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reg_ll
            // 
            this.reg_ll.ActiveLinkColor = System.Drawing.Color.Blue;
            this.reg_ll.AutoSize = true;
            this.reg_ll.Location = new System.Drawing.Point(30, 142);
            this.reg_ll.Name = "reg_ll";
            this.reg_ll.Size = new System.Drawing.Size(72, 13);
            this.reg_ll.TabIndex = 5;
            this.reg_ll.TabStop = true;
            this.reg_ll.Text = "Регистрация";
            this.reg_ll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_ll_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(33, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(33, 94);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(163, 20);
            this.PassTB.TabIndex = 2;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(33, 44);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(163, 20);
            this.LoginTB.TabIndex = 1;
            // 
            // adminEntrance
            // 
            this.adminEntrance.Location = new System.Drawing.Point(132, 130);
            this.adminEntrance.Name = "adminEntrance";
            this.adminEntrance.Size = new System.Drawing.Size(113, 36);
            this.adminEntrance.TabIndex = 0;
            this.adminEntrance.Text = "Вход";
            this.adminEntrance.UseVisualStyleBackColor = true;
            this.adminEntrance.Click += new System.EventHandler(this.adminEntrance_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(265, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(265, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 194);
            this.Controls.Add(this.tc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPage_FormClosed);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.tc1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Button adminEntrance;
        private System.Windows.Forms.LinkLabel reg_ll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

