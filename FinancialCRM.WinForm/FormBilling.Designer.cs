namespace FinancialCRM.WinForm
{
    partial class FormBilling
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
            panel1 = new Panel();
            btnExit = new Button();
            btnSettings = new Button();
            btnDashboard = new Button();
            btnBankActions = new Button();
            btnSpendings = new Button();
            btnBills = new Button();
            btnBanks = new Button();
            btnCategories = new Button();
            panel2 = new Panel();
            btnUpdateBill = new Button();
            btnRemoveBill = new Button();
            btnAddBill = new Button();
            btnBillList = new Button();
            txtBillPeriod = new TextBox();
            label4 = new Label();
            txtBillAmount = new TextBox();
            label3 = new Label();
            txtBillTitle = new TextBox();
            label2 = new Label();
            txtBillId = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnBankActions);
            panel1.Controls.Add(btnSpendings);
            panel1.Controls.Add(btnBills);
            panel1.Controls.Add(btnBanks);
            panel1.Controls.Add(btnCategories);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 636);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(52, 73, 94);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(236, 240, 241);
            btnExit.Location = new Point(38, 429);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(222, 44);
            btnExit.TabIndex = 7;
            btnExit.Text = "Çıkış Yap";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(52, 73, 94);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(236, 240, 241);
            btnSettings.Location = new Point(38, 369);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(222, 44);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Ayarlar";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(52, 73, 94);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(236, 240, 241);
            btnDashboard.Location = new Point(38, 308);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(222, 44);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBankActions
            // 
            btnBankActions.BackColor = Color.FromArgb(52, 73, 94);
            btnBankActions.Cursor = Cursors.Hand;
            btnBankActions.FlatStyle = FlatStyle.Flat;
            btnBankActions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBankActions.ForeColor = Color.FromArgb(236, 240, 241);
            btnBankActions.Location = new Point(38, 249);
            btnBankActions.Name = "btnBankActions";
            btnBankActions.Size = new Size(222, 44);
            btnBankActions.TabIndex = 4;
            btnBankActions.Text = "Banka Hareketleri";
            btnBankActions.UseVisualStyleBackColor = false;
            // 
            // btnSpendings
            // 
            btnSpendings.BackColor = Color.FromArgb(52, 73, 94);
            btnSpendings.Cursor = Cursors.Hand;
            btnSpendings.FlatStyle = FlatStyle.Flat;
            btnSpendings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSpendings.ForeColor = Color.FromArgb(236, 240, 241);
            btnSpendings.Location = new Point(38, 191);
            btnSpendings.Name = "btnSpendings";
            btnSpendings.Size = new Size(222, 44);
            btnSpendings.TabIndex = 3;
            btnSpendings.Text = "Giderler";
            btnSpendings.UseVisualStyleBackColor = false;
            // 
            // btnBills
            // 
            btnBills.BackColor = Color.FromArgb(52, 73, 94);
            btnBills.Cursor = Cursors.Hand;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBills.ForeColor = Color.FromArgb(236, 240, 241);
            btnBills.Location = new Point(38, 133);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(222, 44);
            btnBills.TabIndex = 2;
            btnBills.Text = "Faturalar";
            btnBills.UseVisualStyleBackColor = false;
            btnBills.Click += btnBills_Click;
            // 
            // btnBanks
            // 
            btnBanks.BackColor = Color.FromArgb(52, 73, 94);
            btnBanks.Cursor = Cursors.Hand;
            btnBanks.FlatStyle = FlatStyle.Flat;
            btnBanks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBanks.ForeColor = Color.FromArgb(236, 240, 241);
            btnBanks.Location = new Point(38, 75);
            btnBanks.Name = "btnBanks";
            btnBanks.Size = new Size(222, 44);
            btnBanks.TabIndex = 1;
            btnBanks.Text = "Bankalar";
            btnBanks.UseVisualStyleBackColor = false;
            btnBanks.Click += btnBanks_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(52, 73, 94);
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.FromArgb(236, 240, 241);
            btnCategories.Location = new Point(38, 19);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(222, 44);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 166, 179);
            panel2.Controls.Add(btnUpdateBill);
            panel2.Controls.Add(btnRemoveBill);
            panel2.Controls.Add(btnAddBill);
            panel2.Controls.Add(btnBillList);
            panel2.Controls.Add(txtBillPeriod);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBillAmount);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtBillTitle);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtBillId);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(297, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 265);
            panel2.TabIndex = 2;
            // 
            // btnUpdateBill
            // 
            btnUpdateBill.BackColor = Color.FromArgb(52, 73, 94);
            btnUpdateBill.Cursor = Cursors.Hand;
            btnUpdateBill.FlatStyle = FlatStyle.Flat;
            btnUpdateBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateBill.ForeColor = Color.FromArgb(236, 240, 241);
            btnUpdateBill.Location = new Point(653, 180);
            btnUpdateBill.Name = "btnUpdateBill";
            btnUpdateBill.Size = new Size(174, 54);
            btnUpdateBill.TabIndex = 11;
            btnUpdateBill.Text = "Ödeme Güncelle";
            btnUpdateBill.UseVisualStyleBackColor = false;
            btnUpdateBill.Click += btnUpdateBill_Click;
            // 
            // btnRemoveBill
            // 
            btnRemoveBill.BackColor = Color.FromArgb(52, 73, 94);
            btnRemoveBill.Cursor = Cursors.Hand;
            btnRemoveBill.FlatStyle = FlatStyle.Flat;
            btnRemoveBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveBill.ForeColor = Color.FromArgb(236, 240, 241);
            btnRemoveBill.Location = new Point(473, 180);
            btnRemoveBill.Name = "btnRemoveBill";
            btnRemoveBill.Size = new Size(174, 54);
            btnRemoveBill.TabIndex = 10;
            btnRemoveBill.Text = "Ödeme Sil";
            btnRemoveBill.UseVisualStyleBackColor = false;
            btnRemoveBill.Click += btnRemoveBill_Click;
            // 
            // btnAddBill
            // 
            btnAddBill.BackColor = Color.FromArgb(52, 73, 94);
            btnAddBill.Cursor = Cursors.Hand;
            btnAddBill.FlatStyle = FlatStyle.Flat;
            btnAddBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBill.ForeColor = Color.FromArgb(236, 240, 241);
            btnAddBill.Location = new Point(293, 180);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(174, 54);
            btnAddBill.TabIndex = 9;
            btnAddBill.Text = "Yeni Ödeme";
            btnAddBill.UseVisualStyleBackColor = false;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // btnBillList
            // 
            btnBillList.BackColor = Color.FromArgb(52, 73, 94);
            btnBillList.Cursor = Cursors.Hand;
            btnBillList.FlatStyle = FlatStyle.Flat;
            btnBillList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBillList.ForeColor = Color.FromArgb(236, 240, 241);
            btnBillList.Location = new Point(113, 180);
            btnBillList.Name = "btnBillList";
            btnBillList.Size = new Size(174, 54);
            btnBillList.TabIndex = 8;
            btnBillList.Text = "Ödeme Listesi";
            btnBillList.UseVisualStyleBackColor = false;
            btnBillList.Click += btnBillList_Click;
            // 
            // txtBillPeriod
            // 
            txtBillPeriod.BackColor = Color.FromArgb(52, 73, 94);
            txtBillPeriod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillPeriod.ForeColor = SystemColors.Window;
            txtBillPeriod.Location = new Point(113, 128);
            txtBillPeriod.Name = "txtBillPeriod";
            txtBillPeriod.Size = new Size(714, 34);
            txtBillPeriod.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 128);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 6;
            label4.Text = "Periyot:";
            // 
            // txtBillAmount
            // 
            txtBillAmount.BackColor = Color.FromArgb(52, 73, 94);
            txtBillAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillAmount.ForeColor = SystemColors.Window;
            txtBillAmount.Location = new Point(113, 88);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.Size = new Size(714, 34);
            txtBillAmount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 4;
            label3.Text = "Miktar:";
            // 
            // txtBillTitle
            // 
            txtBillTitle.BackColor = Color.FromArgb(52, 73, 94);
            txtBillTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillTitle.ForeColor = SystemColors.Window;
            txtBillTitle.Location = new Point(113, 48);
            txtBillTitle.Name = "txtBillTitle";
            txtBillTitle.Size = new Size(714, 34);
            txtBillTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 48);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 2;
            label2.Text = "Başlık:";
            // 
            // txtBillId
            // 
            txtBillId.BackColor = Color.FromArgb(52, 73, 94);
            txtBillId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillId.ForeColor = SystemColors.Window;
            txtBillId.Location = new Point(113, 8);
            txtBillId.Name = "txtBillId";
            txtBillId.Size = new Size(714, 34);
            txtBillId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 8);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Id:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 210, 211);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(297, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 370);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(843, 370);
            dataGridView1.TabIndex = 0;
            // 
            // FormBilling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(149, 175, 192);
            ClientSize = new Size(1142, 635);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormBilling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödemeler Formu";
            Load += FormBilling_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnSettings;
        private Button btnDashboard;
        private Button btnBankActions;
        private Button btnSpendings;
        private Button btnBills;
        private Button btnBanks;
        private Button btnCategories;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button btnUpdateBill;
        private Button btnRemoveBill;
        private Button btnAddBill;
        private Button btnBillList;
        private TextBox txtBillPeriod;
        private Label label4;
        private TextBox txtBillAmount;
        private Label label3;
        private TextBox txtBillTitle;
        private Label label2;
        private TextBox txtBillId;
        private DataGridView dataGridView1;
    }
}