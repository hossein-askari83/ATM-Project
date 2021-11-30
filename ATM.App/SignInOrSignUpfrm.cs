using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using ATM.DataLayer.Contex;
using ATM.DataLayer;

namespace ATM.App
{
    public partial class SignInOrSignUpfrm : Form
    {
        bool IsLogin = true;
        public int UserID = 0;
        public SignInOrSignUpfrm()
        {
            InitializeComponent();
        }

        private void SighnInOrSighnUpfrm_Load(object sender, EventArgs e)
        {
            if (UserID == 0)
            {
                this.Width = 338;
                this.Height = 251;
            }
            else
            {
                IsLogin = false;
                ChangeForm();
                lblLogin.Visible = false;
                btnSighnin.Visible = false;
                this.Text = "Edit";
                btnLogin.Text = "Submit";

                using (UnitOfWork db = new UnitOfWork())
                {
                    txtUserName.Text = Main.LoggedUser.UserName;
                    txtPhone.Text = Main.LoggedUser.UserPhone;
                    txtPassword.Text = Main.LoggedUser.UserPassword;
                    txtEmail.Text = Main.LoggedUser.UserEmail;
                }

            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ChangeForm();
            IsLogin = false;
            this.Text = "Sign UP";
            btnLogin.Text = "Register";

        }

        private void ChangeForm()
        {
            this.Width = 652;
            this.Height = 251;
            lblRegister.Visible = false;
            btnRegister.Visible = false;
        }

        private void btnSighnin_Click(object sender, EventArgs e)
        {
            this.Width = 338;
            this.Height = 251;
            IsLogin = true;
            lblRegister.Visible = true;
            btnRegister.Visible = true;
            this.Text = "Sign IN";
            btnLogin.Text = "Login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsLogin)
            {
                if (CardInputsValidate())
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        Users NewUser = new Users()
                        {
                            UserName = txtUserName.Text,
                            UserPassword = txtPassword.Text,
                            UserPhone = txtPhone.Text,
                            UserEmail = txtEmail.Text,
                        };
                        if (UserID == 0)
                        {
                            db.UserRepository.Insert(NewUser);
                            MessageBox.Show("Register was succseed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Main.LoggedUser = NewUser;
                        }
                        else // if user want to edit 
                        {
                            if (Main.LoggedUser.UserPhone != txtPhone.Text)
                            {
                                if (MessageBox.Show("If you Change Phone your cards will delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    var Cards = db.UsersCardsRepository.GetAll(c => c.UserID == Main.LoggedUser.UserID).ToList();
                                    foreach (var Card in Cards)
                                    {
                                        db.UsersCardsRepository.Delete(Card);
                                    }
                                }
                                else
                                {
                                    return;
                                }
                            }
                            NewUser.UserID = this.UserID;
                            db.UserRepository.Update(NewUser);
                            MessageBox.Show("User edited successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else // if user want to login
            {
                if (validatorUserName.IsValid && validatorPassword.IsValid)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (db.UserRepository.GetUserNamePassword().Any(u => u.Password == txtPassword.Text && u.UserName == txtUserName.Text))
                        {
                            Main.LoggedUser = db.UserRepository.GetByUserName(txtUserName.Text);
                            MessageBox.Show("Welcome", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
        private bool CardInputsValidate()
        {
            bool IsValid = false;

            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    List<ViewModel.UserViewModel> condision = db.UserRepository.GetUsernamePhoneUsercardid();
                    if (UserID != 0)//if user want to edit
                    {
                        condision = db.UserRepository.GetUsernamePhoneUsercardid(u => u.UserName != Main.LoggedUser.UserName && u.Phone != Main.LoggedUser.UserPhone);
                    }
                    if (condision.All(c => c.UserName != txtUserName.Text))// chek card number or phonr or user name are not duplicate
                    {

                        if (txtPhone.Text.Length == 11)
                        {
                            if (condision.All(c => c.Phone != txtPhone.Text))
                            {
                                IsValid = true;
                            }
                            else
                            {
                                MessageBox.Show("This phone is used by another person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Phone Number is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This UserName is used by another person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return IsValid;
        }
        private void chShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
