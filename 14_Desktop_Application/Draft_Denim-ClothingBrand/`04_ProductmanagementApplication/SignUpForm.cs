using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04_ProductmanagementApplication
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            ClearFields();
            if (CheckNullFields())
            {
                if (Gmail_Validation())
                {
                    if (ValidateConfirmPassword())
                    {
                        string LastName;
                        string FirstName = ValidateName(out LastName);
                         Customer customer = new Customer(FirstName,LastName,this.txtCustomerGmail.Text,this.txtUserName.Text,this.txtPassword.Text);
                         int rowsEffected = customer.InsertDataIntoDatabase();
                         if (rowsEffected > 0)
                         {
                             lblMassegeBox.Text = "Account Created Successfully";
                             lblMassegeBox.BackColor = Color.Green;
                         }
                         else
                         {
                             lblMassegeBox.Text = "Some Error occured.. Try Again";
                             lblMassegeBox.BackColor = Color.Red;
                         }
                    }
                }
            }
        }

        //checking null&whiteSpace fields

        private bool CheckNullFields()
        {
            bool isvalid = true;
            if (string.IsNullOrWhiteSpace(txtCustomerGmail.Text))
            {
                txtCustomerGmail.BackColor = Color.Red;
                isvalid = false;
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.BackColor = Color.Red;
                isvalid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.BackColor = Color.Red;
                isvalid = false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.BackColor = Color.Red;
                isvalid = false;
            }
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                txtCustomerName.BackColor = Color.Red;
                isvalid = false;
            }
            if(!isvalid)
            {
                lblMassegeBox.Text = "Complete All the Fields !!";
                lblMassegeBox.BackColor = Color.Red;
            }
            
            return isvalid;
        }

        //clear textbox when Click and change back color
        int count_Name_click = 0;
        int count_Gmail_click = 0;
        int count_userName_click = 0;
        int count_Password_click = 0;
        int count_ConfirmPassword_click = 0;
        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.LightGray;
            if (count_userName_click == 0)
            {
                count_userName_click++;
                txtUserName.Clear();
            }   
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightGray;
            if (count_Password_click == 0)
            {
                count_Password_click++;
                txtPassword.Clear();
            } 
        }
        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.BackColor = Color.LightGray;
            if (count_ConfirmPassword_click == 0)
            {
                count_ConfirmPassword_click++;
                txtConfirmPassword.Clear();
            }
            
        }
        private void txtCustomerName_Click_1(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.LightGray;
            if (count_Name_click == 0)
            {
                count_Name_click++;
                txtCustomerName.Clear();
            }
        }
        private void txtCustomerGmail_Click_1(object sender, EventArgs e)
        {
            txtCustomerGmail.BackColor = Color.LightGray;
            if (count_Gmail_click == 0)
            {
                count_Gmail_click++;
                txtCustomerGmail.Clear();
            }
        }

        //Checking First Name and Last Name
        private string ValidateName(out string LastName)
        {
            LastName = null;
            string CustomerFullName = txtCustomerName.Text;
                string[] Names = CustomerFullName.Split(' ');
                if (Names.Length > 1)
                {
                    LastName = Names[1];
                }
                else
                {
                    LastName = null;
                }
                return Names[0];
        }

        //clear all fields if values not inserted before signup btn click
        private void ClearFields()
        {
            if (count_Name_click == 0)
            {
                txtCustomerName.Clear();
            }
            if (count_Gmail_click == 0)
            {
                txtCustomerGmail.Clear();
            }
            if (count_userName_click == 0)
            {
                txtUserName.Clear();
            }
            if (count_Password_click == 0)
            {
                txtPassword.Clear();
            }
            if (count_ConfirmPassword_click == 0)
            {
                txtConfirmPassword.Clear();
            }
        }

        //validate gmail
        private bool Gmail_Validation()
        {
            string G_mail = txtCustomerGmail.Text;
            string[] G_mails = G_mail.Split('@');
            if (G_mails.Length > 1)
            {
                if (G_mails[1] == "gmail.com")
                {
                    return true;
                }
                else
                {
                    lblMassegeBox.Text = "Enter valid Gmail";
                    lblMassegeBox.BackColor = Color.Red;
                    return false;
                }
            }
            else
            {
                lblMassegeBox.Text = "Enter valid Gmail";
                lblMassegeBox.BackColor = Color.Red;
                return false;
            }
        }

        //validate confirm password
        private bool ValidateConfirmPassword()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                return true;
            }
            else
            {
                lblMassegeBox.Text = "Match Confirm Password";
                lblMassegeBox.BackColor = Color.Red;
                return false;
            }
        }
    }
}
