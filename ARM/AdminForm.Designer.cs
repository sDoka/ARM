namespace ARM
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.workers = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findFileBnt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.workSessionBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.done_ordersBTN = new System.Windows.Forms.Button();
            this.new_orderBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gb2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // workers
            // 
            this.workers.Location = new System.Drawing.Point(146, 19);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(89, 37);
            this.workers.TabIndex = 1;
            this.workers.Text = "Информация по персоналу";
            this.workers.UseVisualStyleBackColor = true;
            this.workers.Click += new System.EventHandler(this.workers_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(10, 19);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(89, 37);
            this.results.TabIndex = 2;
            this.results.Text = "Выполненные работы";
            this.results.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.workers);
            this.gb2.Controls.Add(this.results);
            this.gb2.Location = new System.Drawing.Point(14, 12);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(259, 61);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "Отчёты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findFileBnt);
            this.groupBox1.Location = new System.Drawing.Point(14, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск документов";
            // 
            // findFileBnt
            // 
            this.findFileBnt.Location = new System.Drawing.Point(10, 30);
            this.findFileBnt.Name = "findFileBnt";
            this.findFileBnt.Size = new System.Drawing.Size(89, 25);
            this.findFileBnt.TabIndex = 1;
            this.findFileBnt.Text = "Найти";
            this.findFileBnt.UseVisualStyleBackColor = true;
            this.findFileBnt.Click += new System.EventHandler(this.findFileBnt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.workSessionBtn);
            this.groupBox2.Location = new System.Drawing.Point(157, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Учёт рабочего времени";
            // 
            // workSessionBtn
            // 
            this.workSessionBtn.Location = new System.Drawing.Point(10, 30);
            this.workSessionBtn.Name = "workSessionBtn";
            this.workSessionBtn.Size = new System.Drawing.Size(89, 25);
            this.workSessionBtn.TabIndex = 1;
            this.workSessionBtn.Text = "Просмотр";
            this.workSessionBtn.UseVisualStyleBackColor = true;
            this.workSessionBtn.Click += new System.EventHandler(this.workSessionBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.done_ordersBTN);
            this.groupBox3.Controls.Add(this.new_orderBTN);
            this.groupBox3.Location = new System.Drawing.Point(14, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 67);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заказы";
            // 
            // done_ordersBTN
            // 
            this.done_ordersBTN.Location = new System.Drawing.Point(153, 19);
            this.done_ordersBTN.Name = "done_ordersBTN";
            this.done_ordersBTN.Size = new System.Drawing.Size(89, 36);
            this.done_ordersBTN.TabIndex = 2;
            this.done_ordersBTN.Text = "Выполненные заказы";
            this.done_ordersBTN.UseVisualStyleBackColor = true;
            // 
            // new_orderBTN
            // 
            this.new_orderBTN.Location = new System.Drawing.Point(10, 19);
            this.new_orderBTN.Name = "new_orderBTN";
            this.new_orderBTN.Size = new System.Drawing.Size(89, 36);
            this.new_orderBTN.TabIndex = 1;
            this.new_orderBTN.Text = "Новый заказ";
            this.new_orderBTN.UseVisualStyleBackColor = true;
            this.new_orderBTN.Click += new System.EventHandler(this.new_orderBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Завершить работу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.gb2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button workers;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findFileBnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button workSessionBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button done_ordersBTN;
        private System.Windows.Forms.Button new_orderBTN;
        private System.Windows.Forms.Button button1;

    }
}