using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Models;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{

    public partial class Login : Form
    {
        FormClosingEventArgs formClosingEventArgs;

        private readonly IUserService userService;

        public Login()
        {
            userService = Program.GetService<IUserService>();
            InitializeComponent();
        }


        private async void HandleLogin(object sender, EventArgs e)
        {
            Home landingPage = new Home();

            var validUser = await ValidateUser();

            if (validUser != null)
            {

                ApplicationInfo.UserId = validUser.Id;
                ApplicationInfo.Username = validUser.Username;
                ApplicationInfo.Firstname = validUser.FirstName;
                ApplicationInfo.Phone = validUser.Phone;
                ApplicationInfo.Address = validUser.Address;
                ApplicationInfo.IsAdmin = validUser.IsAdmin;

                LoadHomePage();
                
            }
            else
            {
                MessageBox.Show("Invalid Username/Password");
                ReloadThisForm();
            }

        }

        private void Cancel_Login(object sender, EventArgs e)
        {
            Clear();
        }

        private void RegisterUser(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.Hand;

            Form regForm = new CreateUser();
            regForm.Show();

            Hide();
        }

        public void LoadHomePage()
        {
            MyBookings myBookings = new MyBookings();
            Form home = new Home();
            Form main = new Main();
            Home.Message = $"Welcome, {ApplicationInfo.Firstname}";
            Home.UserId = ApplicationInfo.UserId;
            
            Close();
            Hide();
            main.Visible = false;
            home.Show();
            
        }

        public void ReloadThisForm()
        {
            Show();
            Clear();
        }

        public void Clear()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Focus();

        }

        private async Task<LoginResponse> ValidateUser()
        {
            var loginRequest = new LoginRequest
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };

            try
            {
                var registeredUser = await userService.ValidateUser(loginRequest);
                if (registeredUser != null)
                {
                    return registeredUser;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while trying to login. | {ex.Message}");
            }

        }

    }
}
