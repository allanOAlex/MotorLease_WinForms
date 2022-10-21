using AutoMapper;
using MotorLease.Data.Dtos;
using MotorLease.Data.Dtos.Forms;
using MotorLease.Domain.Models;
using MotorLease.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class ManageUsers : Form
    {
        public static string Message { get; set; }
        private readonly IUserService userService;

        List<UserGridResponse> gridUsers = new List<UserGridResponse>();

        DataGridViewButtonColumn editUser = new DataGridViewButtonColumn();
        DataGridViewButtonColumn deleteUser = new DataGridViewButtonColumn();
        public ManageUsers()
        {
            userService = Program.GetService<IUserService>();
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            lblLanding.Text = Message;
            LoadUsers();
        }

        public void LoadUsers()
        {
            var users = userService.GetUsers();
            List<User> userList = users.ToList();

            var ResponseMap = new MapperConfiguration(cfg => cfg.CreateMap<User, UserGridResponse>());
            IMapper ResponseMapper = ResponseMap.CreateMapper();

            if (userList.Count == 0)
            {
                var emptyResults = new UserGridResponse
                {
                    
                };

                gridUsers.Add(emptyResults);
                return;
            }

            foreach (var listItem in userList)
            {
                var result = ResponseMapper.Map<User, UserGridResponse>(listItem);

                result = new UserGridResponse
                {
                    FirstName = listItem.FirstName,
                    LastName = listItem.LastName,
                    IdNumber = listItem.IdNumber,
                    PhoneNumber = listItem.PhoneNumber,
                    Address = listItem.Address
                };

                gridUsers.Add(result);
            }

            DefineLandingFormDataGrid(dataGridAllUsers);
            dataGridAllUsers.DataSource = gridUsers;
            AddExtraColumnsManageBookingsFormGrid(dataGridAllUsers);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Form register = new CreateUser();
            register.Show();
        }

        public DataGridView DefineLandingFormDataGrid(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowTemplate.Height = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridView.AutoResizeColumns();

            return dataGridView;
        }

        public DataGridView AddExtraColumnsManageBookingsFormGrid(DataGridView dataGridView)
        {
            if (!dataGridView.Columns.Contains("editBooking") || !dataGridView.Columns.Contains("cancelBooking") || !dataGridView.Columns.Contains("reviewBooking"))
            {
                dataGridView.Columns.Add(GenerateManageUsersEditButtonColumn(editUser));
                dataGridView.Columns.Add(GenerateManageUsersDeleteButtonColumn(deleteUser));
            }
            else
            {
                //Do absolutley nothing, life continues;
            }

            return dataGridView;
        }

        public DataGridViewButtonColumn GenerateManageUsersEditButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Edit";
            column.Name = "editUser";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 70;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }

        public DataGridViewButtonColumn GenerateManageUsersDeleteButtonColumn(DataGridViewButtonColumn column)
        {
            column.HeaderText = "";
            column.Text = "Delete";
            column.Name = "deleteUser";
            column.FlatStyle = FlatStyle.Popup;
            column.Width = 70;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            column.UseColumnTextForButtonValue = true;

            return column;
        }

    }
}
