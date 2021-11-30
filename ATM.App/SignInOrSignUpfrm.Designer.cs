
namespace ATM.App
{
    partial class SignInOrSignUpfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInOrSignUpfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSighnin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.chShowPass = new System.Windows.Forms.CheckBox();
            this.validatorUserName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.validatorPassword = new ValidationComponents.RequiredFieldValidator(this.components);
            this.validatorPhone = new ValidationComponents.RequiredFieldValidator(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Vazir", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(116, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(162, 31);
            this.txtUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(35, 103);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Vazir", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(116, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(162, 31);
            this.txtPassword.TabIndex = 5;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(28, 150);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(206, 22);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "Dont have a account yet? click";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegister.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegister.Location = new System.Drawing.Point(190, 147);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(57, 29);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "HERE";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Vazir", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(435, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 31);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Vazir", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(435, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(162, 31);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone :";
            // 
            // btnSighnin
            // 
            this.btnSighnin.BackColor = System.Drawing.SystemColors.Control;
            this.btnSighnin.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSighnin.Location = new System.Drawing.Point(510, 150);
            this.btnSighnin.Name = "btnSighnin";
            this.btnSighnin.Size = new System.Drawing.Size(57, 29);
            this.btnSighnin.TabIndex = 13;
            this.btnSighnin.Text = "HERE";
            this.btnSighnin.UseVisualStyleBackColor = false;
            this.btnSighnin.Click += new System.EventHandler(this.btnSighnin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(348, 154);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(209, 22);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Already have a account ? click ";
            // 
            // chShowPass
            // 
            this.chShowPass.AutoSize = true;
            this.chShowPass.Location = new System.Drawing.Point(145, 105);
            this.chShowPass.Name = "chShowPass";
            this.chShowPass.Size = new System.Drawing.Size(133, 26);
            this.chShowPass.TabIndex = 16;
            this.chShowPass.Text = "Show password";
            this.chShowPass.UseVisualStyleBackColor = true;
            this.chShowPass.CheckedChanged += new System.EventHandler(this.chShowPass_CheckedChanged);
            // 
            // validatorUserName
            // 
            this.validatorUserName.CancelFocusChangeWhenInvalid = false;
            this.validatorUserName.ControlToValidate = this.txtUserName;
            this.validatorUserName.ErrorMessage = "write user name";
            this.validatorUserName.Icon = ((System.Drawing.Icon)(resources.GetObject("validatorUserName.Icon")));
            // 
            // validatorPassword
            // 
            this.validatorPassword.CancelFocusChangeWhenInvalid = false;
            this.validatorPassword.ControlToValidate = this.txtPassword;
            this.validatorPassword.ErrorMessage = "write password";
            this.validatorPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("validatorPassword.Icon")));
            // 
            // validatorPhone
            // 
            this.validatorPhone.CancelFocusChangeWhenInvalid = false;
            this.validatorPhone.ControlToValidate = this.txtPhone;
            this.validatorPhone.ErrorMessage = "write phone";
            this.validatorPhone.Icon = ((System.Drawing.Icon)(resources.GetObject("validatorPhone.Icon")));
            // 
            // SignInOrSignUpfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 198);
            this.Controls.Add(this.chShowPass);
            this.Controls.Add(this.btnSighnin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignInOrSignUpfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sighn IN";
            this.Load += new System.EventHandler(this.SighnInOrSighnUpfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSighnin;
        private System.Windows.Forms.Label lblLogin;
        private ValidationComponents.RequiredFieldValidator validatorUserName;
        private ValidationComponents.RequiredFieldValidator validatorPassword;
        private ValidationComponents.RequiredFieldValidator validatorPhone;
        private System.Windows.Forms.CheckBox chShowPass;
    }
}