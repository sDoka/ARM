namespace ARM
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.excel_our = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.fire_workerBTN = new System.Windows.Forms.Button();
            this.new_workerBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.hireBTN = new System.Windows.Forms.Button();
            this.fioCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgw1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.GridColor = System.Drawing.SystemColors.Control;
            this.dgw1.Location = new System.Drawing.Point(12, 7);
            this.dgw1.MultiSelect = false;
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.RowTemplate.ReadOnly = true;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgw1.Size = new System.Drawing.Size(854, 159);
            this.dgw1.TabIndex = 0;
            this.dgw1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgw1_MouseDown);
            // 
            // excel_our
            // 
            this.excel_our.Location = new System.Drawing.Point(777, 175);
            this.excel_our.Name = "excel_our";
            this.excel_our.Size = new System.Drawing.Size(89, 38);
            this.excel_our.TabIndex = 2;
            this.excel_our.Text = "Экспорт в Excel";
            this.excel_our.UseVisualStyleBackColor = true;
            this.excel_our.Click += new System.EventHandler(this.excel_our_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 193);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // fire_workerBTN
            // 
            this.fire_workerBTN.Location = new System.Drawing.Point(526, 175);
            this.fire_workerBTN.Name = "fire_workerBTN";
            this.fire_workerBTN.Size = new System.Drawing.Size(112, 38);
            this.fire_workerBTN.TabIndex = 4;
            this.fire_workerBTN.Text = "Уволить работника";
            this.fire_workerBTN.UseVisualStyleBackColor = true;
            this.fire_workerBTN.Click += new System.EventHandler(this.fire_workerBTN_Click);
            // 
            // new_workerBTN
            // 
            this.new_workerBTN.Location = new System.Drawing.Point(194, 177);
            this.new_workerBTN.Name = "new_workerBTN";
            this.new_workerBTN.Size = new System.Drawing.Size(112, 38);
            this.new_workerBTN.TabIndex = 5;
            this.new_workerBTN.Text = "Новый работник";
            this.new_workerBTN.UseVisualStyleBackColor = true;
            this.new_workerBTN.Click += new System.EventHandler(this.new_workerBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ф.И.О. работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ф.И.О.";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 24);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Разряд";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(131, 24);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Стаж";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(251, 24);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Адрес";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(370, 24);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Телефон";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(496, 24);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 20);
            this.tb5.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Образование";
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(617, 24);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(100, 20);
            this.tb6.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Примечание";
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(741, 24);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(100, 20);
            this.tb7.TabIndex = 20;
            // 
            // hireBTN
            // 
            this.hireBTN.Location = new System.Drawing.Point(752, 78);
            this.hireBTN.Name = "hireBTN";
            this.hireBTN.Size = new System.Drawing.Size(89, 36);
            this.hireBTN.TabIndex = 22;
            this.hireBTN.Text = "Нанять";
            this.hireBTN.UseVisualStyleBackColor = true;
            this.hireBTN.Click += new System.EventHandler(this.hireBTN_Click);
            // 
            // fioCB
            // 
            this.fioCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fioCB.FormattingEnabled = true;
            this.fioCB.Location = new System.Drawing.Point(400, 189);
            this.fioCB.Name = "fioCB";
            this.fioCB.Size = new System.Drawing.Size(121, 21);
            this.fioCB.TabIndex = 23;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 225);
            this.Controls.Add(this.fioCB);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.hireBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_workerBTN);
            this.Controls.Add(this.fire_workerBTN);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.excel_our);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personal_FormClosing);
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Button excel_our;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button fire_workerBTN;
        private System.Windows.Forms.Button new_workerBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.Button hireBTN;
        private System.Windows.Forms.ComboBox fioCB;
    }
}