using AutoMapper;
using Microsoft.Extensions.Configuration;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Data.Services;
using MotorLease.Domain.Interfaces;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class CreateUser : Form
    {
        private readonly IUserService userService;


        public CreateUser()
        {
            userService = Program.GetService<IUserService>();
            InitializeComponent();
        }

        private async void HandleRegisterUser(object sender, EventArgs e)
        {
            try
            {

                await RegisterUser();

                MessageBox.Show("Operation Successful. Please Login to continue");

                Hide();
                
                Form loginForm = new Login();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating user. | {ex.Message}");
            }

        }

        private async Task<CreateUserResponse> RegisterUser()
        {
            var regRequest = new CreateUserRequest
            {
                Username = txtUserRegUsername.Text,
                Password = txtUserRegPassword.Text,
                FirstName = txtUserRegFName.Text,
                LastName = txtUserRegLName.Text,
                IdNumber = txtUserRegIdNo.Text,
                PhoneNumber = txtUserRegPhone.Text,
                Address = txtUserRegUsername.Text,
            };

            try
            {
                var registeredUser = await userService.CreateUser(regRequest);
                if (registeredUser != null)
                {
                    return registeredUser;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating user. | {ex.Message}");
            }
            
        }

        private void AbortlUserRegistration(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetForm(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtUserRegUsername.Text = string.Empty;
            txtUserRegPassword.Text = string.Empty;
            txtUserRegFName.Text = string.Empty;
            txtUserRegLName.Text = string.Empty;
            txtUserRegIdNo.Text = string.Empty;
            txtUserRegPhone.Text = string.Empty;
            txtUserRegAddress.Text = string.Empty;
            txtUserRegUsername.Focus();

        }

        #region Validation Methods

        private void ValidateRegistrationInputs(object sender, EventArgs args)
        {
            CancelEventArgs e = new CancelEventArgs();

            if (!IsUserameValid())
            {
                e.Cancel = true;
                txtUserRegUsername.Select(0, txtUserRegUsername.Text.Length);
                RegisterErrorProvider.SetError(txtUserRegUsername, "Username is required, and must contain only letters and numbers");
                return;
            }
            else if (!IsPasswordValid())
            {
                e.Cancel = true;
                txtUserRegPassword.Select(0, txtUserRegPassword.Text.Length);
                RegisterErrorProvider.SetError(txtUserRegPassword, "Password have minimum of 8 characters, must contain at least one uppercase English letter, one lowercase English letter, one digit and one special character.");
                return;
            }
            else if (!IsFirstNameValid())
            {
                e.Cancel = true;
                txtUserRegFName.Select(0, txtUserRegFName.Text.Length);
                RegisterErrorProvider.SetError(txtUserRegFName, "First Name is required, and must contain only alphabet letters");
                return;
            }
            else if (!IsLastNameValid())
            {
                e.Cancel = true;
                txtUserRegLName.Select(0, txtUserRegLName.Text.Length);
                RegisterErrorProvider.SetError(txtUserRegLName, "Last Name is required, and must contain only alphabet letters");
                return;
            }
            else if (!IsIdNumberValid())
            {
                e.Cancel = true;
                txtUserRegIdNo.Select(0, txtUserRegIdNo.Text.ToString().Length);
                RegisterErrorProvider.SetError(txtUserRegIdNo, "ID number is limited to 10 didgits");
                return;
            }
            else if (!IsIPhoneValid())
            {
                e.Cancel = true;
                txtUserRegPhone.Select(0, txtUserRegPhone.Text.ToString().Length);
                RegisterErrorProvider.SetError(txtUserRegPhone, "Phone number must contain only 10 digits");
                return;
            }
            else if (!IsAddressValid())
            {
                e.Cancel = true;
                txtUserRegAddress.Select(0, txtUserRegAddress.Text.Length);
                RegisterErrorProvider.SetError(txtUserRegAddress, "Address is required");
                return;
            }

            HandleRegisterUser(sender, args);
        }


        #endregion

        #region Validation Checks

        private bool IsUserameValid()
        {
            string pattern = @"^[a-zA-Z0-9]";
            Regex regex = new Regex(pattern);

            //return txtUserRegUsername.Text.Length > 0;
            return regex.IsMatch(txtUserRegUsername.Text);
        }

        private bool IsPasswordValid()
        {
            string pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(txtUserRegPassword.Text);
        }

        private bool IsFirstNameValid()
        {
            string pattern = @"^[a-zA-Z\s]+$";
            Regex regex = new Regex(pattern);
            
            return regex.IsMatch(txtUserRegFName.Text);
        }

        private bool IsLastNameValid()
        {
            string pattern = @"^[a-zA-Z\s]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(txtUserRegLName.Text);
        }

        private bool IsIdNumberValid()
        {
            string pattern = @"^\d{10}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(txtUserRegIdNo.Text);
        }

        private bool IsIPhoneValid()
        {
            string pattern = @"^\d{10}$"; //^[0-9]{10}$
            Regex regex = new Regex(pattern);

            return regex.IsMatch(txtUserRegPhone.Text);
        }

        private bool IsAddressValid()
        {
            string pattern = @"^[a-zA-Z0-9]";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(txtUserRegUsername.Text);
        }

        #endregion

        
    }
}
