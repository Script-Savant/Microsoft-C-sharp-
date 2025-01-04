namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 294);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OwnerTxt.Location = new Point(111, 24);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(293, 35);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountNum.Location = new Point(125, 292);
            AmountNum.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 999999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(279, 35);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(431, 24);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.Size = new Size(440, 241);
            BankAccountsGrid.TabIndex = 4;
            BankAccountsGrid.CellContentClick += BankAccountsGrid_CellContentClick;
            // 
            // DepositBtn
            // 
            DepositBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositBtn.Location = new Point(431, 284);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(216, 50);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WithdrawBtn.Location = new Point(653, 284);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(218, 50);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAccountBtn.Location = new Point(111, 141);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(293, 50);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(165, 30);
            label3.TabIndex = 8;
            label3.Text = "Interest Rate(%):";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InterestRateNum.Location = new Point(208, 84);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(196, 35);
            InterestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 346);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}
