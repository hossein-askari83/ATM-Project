
namespace ATM.App
{
    partial class TransferMoneyFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferMoneyFrm));
            this.txtFromCardNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChangeCode = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCvv2 = new System.Windows.Forms.TextBox();
            this.lblCvv2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtToCardNumber = new System.Windows.Forms.ComboBox();
            this.txtMonth = new System.Windows.Forms.NumericUpDown();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator5 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator6 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator7 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator8 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFromCardNumber
            // 
            this.txtFromCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromCardNumber.FormattingEnabled = true;
            this.txtFromCardNumber.Location = new System.Drawing.Point(139, 42);
            this.txtFromCardNumber.Name = "txtFromCardNumber";
            this.txtFromCardNumber.Size = new System.Drawing.Size(245, 28);
            this.txtFromCardNumber.TabIndex = 0;
            this.txtFromCardNumber.SelectedIndexChanged += new System.EventHandler(this.txtFromCardNumber_SelectedIndexChanged);
            this.txtFromCardNumber.TextChanged += new System.EventHandler(this.txtFromCardNumber_TextChanged);
            this.txtFromCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromCardNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Number :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.txtChangeCode);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblMonth);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.txtCvv2);
            this.groupBox1.Controls.Add(this.lblCvv2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFromCardNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Information";
            // 
            // txtChangeCode
            // 
            this.txtChangeCode.Image = global::ATM.App.Properties.Resources._1371476368_Synchronize;
            this.txtChangeCode.Location = new System.Drawing.Point(10, 137);
            this.txtChangeCode.Name = "txtChangeCode";
            this.txtChangeCode.Size = new System.Drawing.Size(58, 58);
            this.txtChangeCode.TabIndex = 3;
            this.txtChangeCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtChangeCode.UseVisualStyleBackColor = true;
            this.txtChangeCode.Click += new System.EventHandler(this.txtChangeCode_Click);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(74, 156);
            this.lblCode.Name = "lblCode";
            this.lblCode.ReadOnly = true;
            this.lblCode.Size = new System.Drawing.Size(85, 27);
            this.lblCode.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(165, 156);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(85, 27);
            this.txtCode.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(256, 99);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(135, 99);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 20);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "Month";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 96);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Expire Date :";
            // 
            // txtCvv2
            // 
            this.txtCvv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvv2.Location = new System.Drawing.Point(528, 96);
            this.txtCvv2.Name = "txtCvv2";
            this.txtCvv2.Size = new System.Drawing.Size(85, 27);
            this.txtCvv2.TabIndex = 4;
            this.txtCvv2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvv2_KeyPress);
            // 
            // lblCvv2
            // 
            this.lblCvv2.AutoSize = true;
            this.lblCvv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCvv2.Location = new System.Drawing.Point(454, 103);
            this.lblCvv2.Name = "lblCvv2";
            this.lblCvv2.Size = new System.Drawing.Size(62, 20);
            this.lblCvv2.TabIndex = 5;
            this.lblCvv2.Text = "CVV2 :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(528, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(423, 49);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(93, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnContinue);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtToCardNumber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Money transfer information";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.SpringGreen;
            this.btnContinue.Location = new System.Drawing.Point(468, 146);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(147, 43);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "Continue ->";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(468, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(618, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Toman";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(468, 47);
            this.txtAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtAmount.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(144, 27);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(144, 100);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(227, 89);
            this.txtDesc.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Description :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(378, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Amount :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Card Number :";
            // 
            // txtToCardNumber
            // 
            this.txtToCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToCardNumber.FormattingEnabled = true;
            this.txtToCardNumber.Location = new System.Drawing.Point(144, 41);
            this.txtToCardNumber.Name = "txtToCardNumber";
            this.txtToCardNumber.Size = new System.Drawing.Size(227, 28);
            this.txtToCardNumber.TabIndex = 0;
            this.txtToCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToCardNumber_KeyPress);
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(196, 96);
            this.txtMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(54, 27);
            this.txtMonth.TabIndex = 14;
            this.txtMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(305, 96);
            this.txtYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.txtYear.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(79, 27);
            this.txtYear.TabIndex = 15;
            this.txtYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtFromCardNumber;
            this.requiredFieldValidator1.ErrorMessage = "!";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtPassword;
            this.requiredFieldValidator2.ErrorMessage = "!";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtYear;
            this.requiredFieldValidator3.ErrorMessage = "!";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtMonth;
            this.requiredFieldValidator4.ErrorMessage = "!";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator5.ControlToValidate = this.txtCvv2;
            this.requiredFieldValidator5.ErrorMessage = "!";
            this.requiredFieldValidator5.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator5.Icon")));
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator6.ControlToValidate = this.txtCode;
            this.requiredFieldValidator6.ErrorMessage = "!";
            this.requiredFieldValidator6.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator6.Icon")));
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator7.ControlToValidate = this.txtToCardNumber;
            this.requiredFieldValidator7.ErrorMessage = "!";
            this.requiredFieldValidator7.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator7.Icon")));
            // 
            // requiredFieldValidator8
            // 
            this.requiredFieldValidator8.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator8.ControlToValidate = this.txtAmount;
            this.requiredFieldValidator8.ErrorMessage = "!";
            this.requiredFieldValidator8.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator8.Icon")));
            // 
            // TransferMoneyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransferMoneyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.TransferMoneyFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtFromCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button txtChangeCode;
        private System.Windows.Forms.TextBox lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCvv2;
        private System.Windows.Forms.Label lblCvv2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtToCardNumber;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator5;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator6;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator7;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator8;
        private System.Windows.Forms.NumericUpDown txtMonth;
        private System.Windows.Forms.NumericUpDown txtYear;
    }
}