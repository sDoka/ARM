namespace ARM
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToExcelBtn = new System.Windows.Forms.Button();
            this.zakazNumberBTN = new System.Windows.Forms.Label();
            this.editTB = new System.Windows.Forms.TextBox();
            this.editBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Все заказы",
            "Выполненные заказы",
            "Заказы в производстве",
            "Детали комплекта..."});
            this.cb1.Location = new System.Drawing.Point(13, 26);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(157, 21);
            this.cb1.TabIndex = 0;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Location = new System.Drawing.Point(13, 53);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.Size = new System.Drawing.Size(616, 150);
            this.dgw1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Какие заказы вы хотели бы просмотреть?";
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(302, 26);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(157, 21);
            this.cb2.TabIndex = 3;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите заказ";
            // 
            // ToExcelBtn
            // 
            this.ToExcelBtn.Location = new System.Drawing.Point(12, 208);
            this.ToExcelBtn.Name = "ToExcelBtn";
            this.ToExcelBtn.Size = new System.Drawing.Size(117, 35);
            this.ToExcelBtn.TabIndex = 5;
            this.ToExcelBtn.Text = "Выгрузить в Excel";
            this.ToExcelBtn.UseVisualStyleBackColor = true;
            this.ToExcelBtn.Click += new System.EventHandler(this.ToExcelBtn_Click);
            // 
            // zakazNumberBTN
            // 
            this.zakazNumberBTN.AutoSize = true;
            this.zakazNumberBTN.Location = new System.Drawing.Point(266, 208);
            this.zakazNumberBTN.Name = "zakazNumberBTN";
            this.zakazNumberBTN.Size = new System.Drawing.Size(77, 13);
            this.zakazNumberBTN.TabIndex = 24;
            this.zakazNumberBTN.Text = "№ заказа п/п";
            this.zakazNumberBTN.Visible = false;
            // 
            // editTB
            // 
            this.editTB.Location = new System.Drawing.Point(266, 222);
            this.editTB.Name = "editTB";
            this.editTB.Size = new System.Drawing.Size(80, 20);
            this.editTB.TabIndex = 23;
            this.editTB.Visible = false;
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(163, 208);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(97, 34);
            this.editBTN.TabIndex = 22;
            this.editBTN.Text = "Завершить заказ";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Visible = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 251);
            this.Controls.Add(this.zakazNumberBTN);
            this.Controls.Add(this.editTB);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.ToExcelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.cb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с заказами";
            this.Resize += new System.EventHandler(this.Заказы_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToExcelBtn;
        private System.Windows.Forms.Label zakazNumberBTN;
        private System.Windows.Forms.TextBox editTB;
        private System.Windows.Forms.Button editBTN;
    }
}