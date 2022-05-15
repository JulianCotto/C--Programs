namespace Program10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountsTextBox = new System.Windows.Forms.RichTextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.AccountDetailsSplitBox = new System.Windows.Forms.SplitContainer();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNoLabel = new System.Windows.Forms.Label();
            this.CPMTextBox = new System.Windows.Forms.RichTextBox();
            this.MinutesUsedTextBox = new System.Windows.Forms.RichTextBox();
            this.BalanceOwedTextBox = new System.Windows.Forms.RichTextBox();
            this.CXCCNTextBox = new System.Windows.Forms.RichTextBox();
            this.CXAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.CXNameTextBox = new System.Windows.Forms.RichTextBox();
            this.ScreenSizeTextBox = new System.Windows.Forms.RichTextBox();
            this.OSTextBox = new System.Windows.Forms.RichTextBox();
            this.ModelTextBox = new System.Windows.Forms.RichTextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.RichTextBox();
            this.PhoneNoTextBox = new System.Windows.Forms.RichTextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CurrentAccountLabel = new System.Windows.Forms.Label();
            this.CalculateCharges = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.CalculatedOuput = new System.Windows.Forms.Label();
            this.WhichAccount = new System.Windows.Forms.Label();
            this.AccountIncrementer = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Calculations = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MinutesAdjuster = new System.Windows.Forms.RichTextBox();
            this.CalculateBalance = new System.Windows.Forms.Button();
            this.WithAdjustments = new System.Windows.Forms.Label();
            this.WithoutAdjustments = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsSplitBox)).BeginInit();
            this.AccountDetailsSplitBox.Panel1.SuspendLayout();
            this.AccountDetailsSplitBox.Panel2.SuspendLayout();
            this.AccountDetailsSplitBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is Program10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "How many accounts would you like to create?";
            // 
            // AccountsTextBox
            // 
            this.AccountsTextBox.Location = new System.Drawing.Point(219, 71);
            this.AccountsTextBox.Name = "AccountsTextBox";
            this.AccountsTextBox.Size = new System.Drawing.Size(42, 27);
            this.AccountsTextBox.TabIndex = 2;
            this.AccountsTextBox.Text = "";
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(153, 104);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(177, 28);
            this.InputButton.TabIndex = 3;
            this.InputButton.Text = "Input Account Details";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AccountDetailsSplitBox
            // 
            this.AccountDetailsSplitBox.Location = new System.Drawing.Point(12, 154);
            this.AccountDetailsSplitBox.Name = "AccountDetailsSplitBox";
            // 
            // AccountDetailsSplitBox.Panel1
            // 
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label12);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label11);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label10);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label9);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label8);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label7);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label6);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label5);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label4);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.label3);
            this.AccountDetailsSplitBox.Panel1.Controls.Add(this.PhoneNoLabel);
            this.AccountDetailsSplitBox.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // AccountDetailsSplitBox.Panel2
            // 
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.CPMTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.MinutesUsedTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.BalanceOwedTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.CXCCNTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.CXAddressTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.CXNameTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.ScreenSizeTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.OSTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.ModelTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.ManufacturerTextBox);
            this.AccountDetailsSplitBox.Panel2.Controls.Add(this.PhoneNoTextBox);
            this.AccountDetailsSplitBox.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.AccountDetailsSplitBox.Size = new System.Drawing.Size(479, 337);
            this.AccountDetailsSplitBox.SplitterDistance = 159;
            this.AccountDetailsSplitBox.TabIndex = 4;
            this.AccountDetailsSplitBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cost Per Minute";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Minutes Used";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Balance Owed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "CX Credit Card No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Customer Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Diagonal Screen Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone OS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone Manufacturer";
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Location = new System.Drawing.Point(3, 6);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(156, 21);
            this.PhoneNoLabel.TabIndex = 0;
            this.PhoneNoLabel.Text = "Enter Phone Number";
            // 
            // CPMTextBox
            // 
            this.CPMTextBox.Location = new System.Drawing.Point(2, 303);
            this.CPMTextBox.Name = "CPMTextBox";
            this.CPMTextBox.Size = new System.Drawing.Size(314, 24);
            this.CPMTextBox.TabIndex = 10;
            this.CPMTextBox.Text = "";
            // 
            // MinutesUsedTextBox
            // 
            this.MinutesUsedTextBox.Location = new System.Drawing.Point(2, 273);
            this.MinutesUsedTextBox.Name = "MinutesUsedTextBox";
            this.MinutesUsedTextBox.Size = new System.Drawing.Size(314, 24);
            this.MinutesUsedTextBox.TabIndex = 9;
            this.MinutesUsedTextBox.Text = "";
            // 
            // BalanceOwedTextBox
            // 
            this.BalanceOwedTextBox.Location = new System.Drawing.Point(2, 243);
            this.BalanceOwedTextBox.Name = "BalanceOwedTextBox";
            this.BalanceOwedTextBox.Size = new System.Drawing.Size(314, 24);
            this.BalanceOwedTextBox.TabIndex = 8;
            this.BalanceOwedTextBox.Text = "";
            // 
            // CXCCNTextBox
            // 
            this.CXCCNTextBox.Location = new System.Drawing.Point(2, 213);
            this.CXCCNTextBox.Name = "CXCCNTextBox";
            this.CXCCNTextBox.Size = new System.Drawing.Size(314, 24);
            this.CXCCNTextBox.TabIndex = 7;
            this.CXCCNTextBox.Text = "";
            // 
            // CXAddressTextBox
            // 
            this.CXAddressTextBox.Location = new System.Drawing.Point(2, 183);
            this.CXAddressTextBox.Name = "CXAddressTextBox";
            this.CXAddressTextBox.Size = new System.Drawing.Size(314, 24);
            this.CXAddressTextBox.TabIndex = 6;
            this.CXAddressTextBox.Text = "";
            // 
            // CXNameTextBox
            // 
            this.CXNameTextBox.Location = new System.Drawing.Point(2, 153);
            this.CXNameTextBox.Name = "CXNameTextBox";
            this.CXNameTextBox.Size = new System.Drawing.Size(314, 24);
            this.CXNameTextBox.TabIndex = 5;
            this.CXNameTextBox.Text = "";
            // 
            // ScreenSizeTextBox
            // 
            this.ScreenSizeTextBox.Location = new System.Drawing.Point(2, 123);
            this.ScreenSizeTextBox.Name = "ScreenSizeTextBox";
            this.ScreenSizeTextBox.Size = new System.Drawing.Size(314, 24);
            this.ScreenSizeTextBox.TabIndex = 4;
            this.ScreenSizeTextBox.Text = "";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(2, 93);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(314, 24);
            this.OSTextBox.TabIndex = 3;
            this.OSTextBox.Text = "";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(3, 63);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(314, 24);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.Text = "";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(3, 33);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(314, 24);
            this.ManufacturerTextBox.TabIndex = 1;
            this.ManufacturerTextBox.Text = "";
            this.ManufacturerTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PhoneNoTextBox
            // 
            this.PhoneNoTextBox.Location = new System.Drawing.Point(3, 3);
            this.PhoneNoTextBox.Name = "PhoneNoTextBox";
            this.PhoneNoTextBox.Size = new System.Drawing.Size(314, 24);
            this.PhoneNoTextBox.TabIndex = 0;
            this.PhoneNoTextBox.Text = "";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(685, 154);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(76, 33);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Visible = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // CurrentAccountLabel
            // 
            this.CurrentAccountLabel.AutoSize = true;
            this.CurrentAccountLabel.Location = new System.Drawing.Point(602, 130);
            this.CurrentAccountLabel.Name = "CurrentAccountLabel";
            this.CurrentAccountLabel.Size = new System.Drawing.Size(0, 21);
            this.CurrentAccountLabel.TabIndex = 6;
            this.CurrentAccountLabel.Visible = false;
            // 
            // CalculateCharges
            // 
            this.CalculateCharges.AutoSize = true;
            this.CalculateCharges.Location = new System.Drawing.Point(544, 190);
            this.CalculateCharges.Name = "CalculateCharges";
            this.CalculateCharges.Size = new System.Drawing.Size(353, 21);
            this.CalculateCharges.TabIndex = 7;
            this.CalculateCharges.Text = "Do You Want To Calculate Charges For Customer?";
            this.CalculateCharges.Visible = false;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(635, 215);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(57, 37);
            this.YesButton.TabIndex = 8;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Visible = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NoButton.Location = new System.Drawing.Point(737, 215);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(62, 37);
            this.NoButton.TabIndex = 9;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Visible = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(324, 546);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 21);
            this.OutputLabel.TabIndex = 10;
            this.OutputLabel.Visible = false;
            // 
            // CalculatedOuput
            // 
            this.CalculatedOuput.AutoSize = true;
            this.CalculatedOuput.Location = new System.Drawing.Point(10, 564);
            this.CalculatedOuput.Name = "CalculatedOuput";
            this.CalculatedOuput.Size = new System.Drawing.Size(0, 21);
            this.CalculatedOuput.TabIndex = 11;
            this.CalculatedOuput.Visible = false;
            // 
            // WhichAccount
            // 
            this.WhichAccount.AutoSize = true;
            this.WhichAccount.Location = new System.Drawing.Point(494, 261);
            this.WhichAccount.Name = "WhichAccount";
            this.WhichAccount.Size = new System.Drawing.Size(212, 21);
            this.WhichAccount.TabIndex = 12;
            this.WhichAccount.Text = "Which Account | Start with 0?";
            this.WhichAccount.Visible = false;
            this.WhichAccount.Click += new System.EventHandler(this.WhichAccount_Click);
            // 
            // AccountIncrementer
            // 
            this.AccountIncrementer.Location = new System.Drawing.Point(737, 258);
            this.AccountIncrementer.Name = "AccountIncrementer";
            this.AccountIncrementer.Size = new System.Drawing.Size(233, 29);
            this.AccountIncrementer.TabIndex = 13;
            this.AccountIncrementer.Visible = false;
            this.AccountIncrementer.TextChanged += new System.EventHandler(this.AccountIncrementer_TextChanged);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(685, 296);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(82, 31);
            this.Enter.TabIndex = 14;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Visible = false;
            this.Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculations
            // 
            this.Calculations.AutoSize = true;
            this.Calculations.Location = new System.Drawing.Point(10, 553);
            this.Calculations.Name = "Calculations";
            this.Calculations.Size = new System.Drawing.Size(0, 21);
            this.Calculations.TabIndex = 15;
            this.Calculations.Click += new System.EventHandler(this.Calculations_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Enter Adjusted Customer Minutes";
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // MinutesAdjuster
            // 
            this.MinutesAdjuster.Location = new System.Drawing.Point(737, 339);
            this.MinutesAdjuster.Name = "MinutesAdjuster";
            this.MinutesAdjuster.Size = new System.Drawing.Size(233, 29);
            this.MinutesAdjuster.TabIndex = 17;
            this.MinutesAdjuster.Text = "";
            this.MinutesAdjuster.Visible = false;
            this.MinutesAdjuster.TextChanged += new System.EventHandler(this.MinutesAdjuster_TextChanged);
            // 
            // CalculateBalance
            // 
            this.CalculateBalance.Location = new System.Drawing.Point(635, 373);
            this.CalculateBalance.Name = "CalculateBalance";
            this.CalculateBalance.Size = new System.Drawing.Size(177, 30);
            this.CalculateBalance.TabIndex = 18;
            this.CalculateBalance.Text = "Calculate Balance";
            this.CalculateBalance.UseVisualStyleBackColor = true;
            this.CalculateBalance.Visible = false;
            this.CalculateBalance.Click += new System.EventHandler(this.CalculateBalance_Click);
            // 
            // WithAdjustments
            // 
            this.WithAdjustments.AutoSize = true;
            this.WithAdjustments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.WithAdjustments.Location = new System.Drawing.Point(16, 503);
            this.WithAdjustments.Name = "WithAdjustments";
            this.WithAdjustments.Size = new System.Drawing.Size(147, 21);
            this.WithAdjustments.TabIndex = 19;
            this.WithAdjustments.Text = "With Adjustments";
            this.WithAdjustments.Visible = false;
            // 
            // WithoutAdjustments
            // 
            this.WithoutAdjustments.AutoSize = true;
            this.WithoutAdjustments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.WithoutAdjustments.Location = new System.Drawing.Point(324, 503);
            this.WithoutAdjustments.Name = "WithoutAdjustments";
            this.WithoutAdjustments.Size = new System.Drawing.Size(173, 21);
            this.WithoutAdjustments.TabIndex = 20;
            this.WithoutAdjustments.Text = "Without Adjustments";
            this.WithoutAdjustments.Visible = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(737, 553);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(84, 42);
            this.btn.TabIndex = 21;
            this.btn.Text = "End";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Visible = false;
            this.btn.Click += new System.EventHandler(this.End_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.CurrentAccountLabel);
            this.Controls.Add(this.AccountDetailsSplitBox);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.AccountsTextBox);
            this.Controls.Add(this.Calculations);
            this.Controls.Add(this.CalculatedOuput);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.WithoutAdjustments);
            this.Controls.Add(this.WithAdjustments);
            this.Controls.Add(this.CalculateBalance);
            this.Controls.Add(this.MinutesAdjuster);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.AccountIncrementer);
            this.Controls.Add(this.WhichAccount);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.CalculateCharges);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Windows Form Control Examples";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.AccountDetailsSplitBox.Panel1.ResumeLayout(false);
            this.AccountDetailsSplitBox.Panel1.PerformLayout();
            this.AccountDetailsSplitBox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsSplitBox)).EndInit();
            this.AccountDetailsSplitBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox AccountsTextBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.SplitContainer AccountDetailsSplitBox;
        private System.Windows.Forms.Label PhoneNoLabel;
        private System.Windows.Forms.RichTextBox PhoneNoTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CPMTextBox;
        private System.Windows.Forms.RichTextBox MinutesUsedTextBox;
        private System.Windows.Forms.RichTextBox BalanceOwedTextBox;
        private System.Windows.Forms.RichTextBox CXCCNTextBox;
        private System.Windows.Forms.RichTextBox CXAddressTextBox;
        private System.Windows.Forms.RichTextBox CXNameTextBox;
        private System.Windows.Forms.RichTextBox ScreenSizeTextBox;
        private System.Windows.Forms.RichTextBox OSTextBox;
        private System.Windows.Forms.RichTextBox ModelTextBox;
        private System.Windows.Forms.RichTextBox ManufacturerTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label CurrentAccountLabel;
        private System.Windows.Forms.Label CalculateCharges;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label CalculatedOuput;
        private System.Windows.Forms.Label WhichAccount;
        private System.Windows.Forms.TextBox AccountIncrementer;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label Calculations;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox MinutesAdjuster;
        private System.Windows.Forms.Button CalculateBalance;
        private System.Windows.Forms.Label WithAdjustments;
        private System.Windows.Forms.Label WithoutAdjustments;
        private System.Windows.Forms.Button btn;
    }
}

