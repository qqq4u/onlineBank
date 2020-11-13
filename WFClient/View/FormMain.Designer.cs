namespace WFClient.View
{
    partial class FormMain
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCardsList = new System.Windows.Forms.DataGridView();
            this.buttonGetCards = new System.Windows.Forms.Button();
            this.buttonCreateNewCard = new System.Windows.Forms.Button();
            this.buttonAddBalance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberCardAddingBalance = new System.Windows.Forms.TextBox();
            this.textBoxMoneyCountAddingBalance = new System.Windows.Forms.TextBox();
            this.textBoxNumberCardTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSendMoney = new System.Windows.Forms.Button();
            this.textBoxMoneyCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxNumberCardFrom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardsList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список ваших карточек";
            // 
            // dataGridViewCardsList
            // 
            this.dataGridViewCardsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCardsList.Location = new System.Drawing.Point(34, 28);
            this.dataGridViewCardsList.Name = "dataGridViewCardsList";
            this.dataGridViewCardsList.Size = new System.Drawing.Size(386, 150);
            this.dataGridViewCardsList.TabIndex = 2;
            // 
            // buttonGetCards
            // 
            this.buttonGetCards.Location = new System.Drawing.Point(140, 195);
            this.buttonGetCards.Name = "buttonGetCards";
            this.buttonGetCards.Size = new System.Drawing.Size(168, 23);
            this.buttonGetCards.TabIndex = 3;
            this.buttonGetCards.Text = "Получить список карточек";
            this.buttonGetCards.UseVisualStyleBackColor = true;
            this.buttonGetCards.Click += new System.EventHandler(this.buttonGetCards_Click);
            // 
            // buttonCreateNewCard
            // 
            this.buttonCreateNewCard.Location = new System.Drawing.Point(153, 238);
            this.buttonCreateNewCard.Name = "buttonCreateNewCard";
            this.buttonCreateNewCard.Size = new System.Drawing.Size(133, 23);
            this.buttonCreateNewCard.TabIndex = 4;
            this.buttonCreateNewCard.Text = "Создать новую карту";
            this.buttonCreateNewCard.UseVisualStyleBackColor = true;
            this.buttonCreateNewCard.Click += new System.EventHandler(this.buttonCreateNewCard_Click);
            // 
            // buttonAddBalance
            // 
            this.buttonAddBalance.Location = new System.Drawing.Point(140, 389);
            this.buttonAddBalance.Name = "buttonAddBalance";
            this.buttonAddBalance.Size = new System.Drawing.Size(133, 23);
            this.buttonAddBalance.TabIndex = 5;
            this.buttonAddBalance.Text = "Пополнение карты";
            this.buttonAddBalance.UseVisualStyleBackColor = true;
            this.buttonAddBalance.Click += new System.EventHandler(this.buttonAddBalance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер карты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сумма пополнения";
            // 
            // textBoxNumberCardAddingBalance
            // 
            this.textBoxNumberCardAddingBalance.Location = new System.Drawing.Point(162, 334);
            this.textBoxNumberCardAddingBalance.Name = "textBoxNumberCardAddingBalance";
            this.textBoxNumberCardAddingBalance.Size = new System.Drawing.Size(161, 20);
            this.textBoxNumberCardAddingBalance.TabIndex = 8;
            // 
            // textBoxMoneyCountAddingBalance
            // 
            this.textBoxMoneyCountAddingBalance.Location = new System.Drawing.Point(191, 361);
            this.textBoxMoneyCountAddingBalance.Name = "textBoxMoneyCountAddingBalance";
            this.textBoxMoneyCountAddingBalance.Size = new System.Drawing.Size(132, 20);
            this.textBoxMoneyCountAddingBalance.TabIndex = 9;
            // 
            // textBoxNumberCardTo
            // 
            this.textBoxNumberCardTo.Location = new System.Drawing.Point(154, 524);
            this.textBoxNumberCardTo.Name = "textBoxNumberCardTo";
            this.textBoxNumberCardTo.Size = new System.Drawing.Size(132, 20);
            this.textBoxNumberCardTo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер карты получателя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер карты отправителя";
            // 
            // buttonSendMoney
            // 
            this.buttonSendMoney.Location = new System.Drawing.Point(140, 595);
            this.buttonSendMoney.Name = "buttonSendMoney";
            this.buttonSendMoney.Size = new System.Drawing.Size(133, 23);
            this.buttonSendMoney.TabIndex = 10;
            this.buttonSendMoney.Text = "Совершить перевод";
            this.buttonSendMoney.UseVisualStyleBackColor = true;
            this.buttonSendMoney.Click += new System.EventHandler(this.buttonSendMoney_Click);
            // 
            // textBoxMoneyCount
            // 
            this.textBoxMoneyCount.Location = new System.Drawing.Point(153, 560);
            this.textBoxMoneyCount.Name = "textBoxMoneyCount";
            this.textBoxMoneyCount.Size = new System.Drawing.Size(132, 20);
            this.textBoxMoneyCount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Сумма перевода";
            // 
            // comboBoxNumberCardFrom
            // 
            this.comboBoxNumberCardFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberCardFrom.FormattingEnabled = true;
            this.comboBoxNumberCardFrom.Location = new System.Drawing.Point(160, 484);
            this.comboBoxNumberCardFrom.Name = "comboBoxNumberCardFrom";
            this.comboBoxNumberCardFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumberCardFrom.TabIndex = 17;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 644);
            this.Controls.Add(this.comboBoxNumberCardFrom);
            this.Controls.Add(this.textBoxMoneyCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNumberCardTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSendMoney);
            this.Controls.Add(this.textBoxMoneyCountAddingBalance);
            this.Controls.Add(this.textBoxNumberCardAddingBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddBalance);
            this.Controls.Add(this.buttonCreateNewCard);
            this.Controls.Add(this.buttonGetCards);
            this.Controls.Add(this.dataGridViewCardsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonGetCards;
        public System.Windows.Forms.DataGridView dataGridViewCardsList;
        public System.Windows.Forms.Button buttonCreateNewCard;
        public System.Windows.Forms.Button buttonAddBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxNumberCardAddingBalance;
        public System.Windows.Forms.TextBox textBoxMoneyCountAddingBalance;
        public System.Windows.Forms.TextBox textBoxNumberCardTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button buttonSendMoney;
        public System.Windows.Forms.TextBox textBoxMoneyCount;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBoxNumberCardFrom;
    }
}