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
        private readonly IUserService userService;

        public Login()
        {
            userService = Program.GetService<IUserService>();
            InitializeComponent();
        }


        private async void HandleLogin(object sender, EventArgs e)
        {
            MyBookings myBookings = new MyBookings();
            CreateBooking form = new CreateBooking(myBookings);
            Home landingPage = new Home(form);

            var validUser = await ValidateUser();

            if (validUser != null)
            {

                ApplicationInfo.UserId = validUser.Id;
                ApplicationInfo.Username = validUser.Username;
                ApplicationInfo.Firstname = validUser.FirstName;
                ApplicationInfo.Phone = validUser.Phone;
                ApplicationInfo.IsAdmin = validUser.IsAdmin;

                LoadLandingPage();

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

        public void LoadLandingPage()
        {
            MyBookings myBookings = new MyBookings();
            CreateBooking form = new CreateBooking(myBookings);
            Form landing = new Home(form);
            Home.Message = $"Welcome, {ApplicationInfo.Firstname}";
            Home.UserId = ApplicationInfo.UserId;
            Hide();
            landing.Show();
            
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
                throw new Exception($"Error creating user. | {ex.Message}");
            }

        }

    }
}
