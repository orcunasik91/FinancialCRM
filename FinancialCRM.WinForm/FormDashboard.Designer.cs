namespace FinancialCRM.WinForm
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblLastBankProcessAmount = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lblBillAmount = new Label();
            lblTotalBalance = new Label();
            lblBillTitle = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            btnSettings = new Button();
            btnDashboard = new Button();
            btnBankActions = new Button();
            btnSpendings = new Button();
            btnBills = new Button();
            btnBanks = new Button();
            btnCategories = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel6 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // lblLastBankProcessAmount
            // 
            lblLastBankProcessAmount.AutoSize = true;
            lblLastBankProcessAmount.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastBankProcessAmount.ForeColor = SystemColors.ButtonHighlight;
            lblLastBankProcessAmount.Location = new Point(44, 53);
            lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            lblLastBankProcessAmount.Size = new Size(149, 60);
            lblLastBankProcessAmount.TabIndex = 10;
            lblLastBankProcessAmount.Text = "0.00 ₺";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1, 2);
            label4.Name = "label4";
            label4.Size = new Size(149, 23);
            label4.TabIndex = 9;
            label4.Text = "Gelen Son Havale";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(194, 54, 22);
            panel5.Controls.Add(lblLastBankProcessAmount);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(972, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 155);
            panel5.TabIndex = 13;
            // 
            // lblBillAmount
            // 
            lblBillAmount.AutoSize = true;
            lblBillAmount.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillAmount.ForeColor = Color.Black;
            lblBillAmount.Location = new Point(46, 53);
            lblBillAmount.Name = "lblBillAmount";
            lblBillAmount.Size = new Size(149, 60);
            lblBillAmount.TabIndex = 9;
            lblBillAmount.Text = "0.00 ₺";
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBalance.ForeColor = SystemColors.ButtonHighlight;
            lblTotalBalance.Location = new Point(47, 53);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(149, 60);
            lblTotalBalance.TabIndex = 8;
            lblTotalBalance.Text = "0.00 ₺";
            // 
            // lblBillTitle
            // 
            lblBillTitle.AutoSize = true;
            lblBillTitle.BackColor = Color.Transparent;
            lblBillTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillTitle.ForeColor = Color.Black;
            lblBillTitle.Location = new Point(1, 2);
            lblBillTitle.Name = "lblBillTitle";
            lblBillTitle.Size = new Size(60, 23);
            lblBillTitle.TabIndex = 8;
            lblBillTitle.Text = "Fatura";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 42, 86);
            panel3.Controls.Add(lblTotalBalance);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(306, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 155);
            panel3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1, 2);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 4;
            label2.Text = "Toplam Bakiyem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 2;
            label1.Text = "Finansal CRM Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 160, 133);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1291, 48);
            panel2.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(52, 73, 94);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(236, 240, 241);
            btnExit.Location = new Point(37, 429);
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
            btnSettings.Location = new Point(37, 369);
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
            btnDashboard.Location = new Point(37, 308);
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
            btnBankActions.Location = new Point(37, 249);
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
            btnSpendings.Location = new Point(37, 191);
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
            btnBills.Location = new Point(37, 133);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(222, 44);
            btnBills.TabIndex = 2;
            btnBills.Text = "Faturalar";
            btnBills.UseVisualStyleBackColor = false;
            // 
            // btnBanks
            // 
            btnBanks.BackColor = Color.FromArgb(52, 73, 94);
            btnBanks.Cursor = Cursors.Hand;
            btnBanks.FlatStyle = FlatStyle.Flat;
            btnBanks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBanks.ForeColor = Color.FromArgb(236, 240, 241);
            btnBanks.Location = new Point(37, 75);
            btnBanks.Name = "btnBanks";
            btnBanks.Size = new Size(222, 44);
            btnBanks.TabIndex = 1;
            btnBanks.Text = "Bankalar";
            btnBanks.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(52, 73, 94);
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.FromArgb(236, 240, 241);
            btnCategories.Location = new Point(37, 19);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(222, 44);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(1, 163, 164);
            panel4.Controls.Add(lblBillAmount);
            panel4.Controls.Add(lblBillTitle);
            panel4.Location = new Point(640, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(317, 155);
            panel4.TabIndex = 12;
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
            panel1.Location = new Point(1, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 521);
            panel1.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(225, 177, 44);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(307, 215);
            panel6.Name = "panel6";
            panel6.Size = new Size(445, 55);
            panel6.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(366, 23);
            label3.TabIndex = 5;
            label3.Text = "Bankalar ve Hesap Miktarlarına Ait Grafikler";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(72, 126, 176);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(845, 215);
            panel7.Name = "panel7";
            panel7.Size = new Size(444, 55);
            panel7.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 13);
            label5.Name = "label5";
            label5.Size = new Size(387, 23);
            label5.TabIndex = 6;
            label5.Text = "Ödenen ve Ödenmesi Gereken Fatura Grafikleri";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(307, 276);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(445, 293);
            chart1.TabIndex = 16;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(844, 276);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Faturalar";
            chart2.Series.Add(series2);
            chart2.Size = new Size(445, 293);
            chart2.TabIndex = 17;
            chart2.Text = "chart2";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1298, 569);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard CRM";
            Load += FormDashboard_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblLastBankProcessAmount;
        private Label label4;
        private Panel panel5;
        private Label lblBillAmount;
        private Label lblTotalBalance;
        private Label lblBillTitle;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnExit;
        private Button btnSettings;
        private Button btnDashboard;
        private Button btnBankActions;
        private Button btnSpendings;
        private Button btnBills;
        private Button btnBanks;
        private Button btnCategories;
        private Panel panel4;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel6;
        private Label label3;
        private Panel panel7;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}