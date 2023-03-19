using Microsoft.EntityFrameworkCore;
using MotorLease.Client.Forms;
using MotorLease.Data.Context;
using MotorLease.Data.Services;
using MotorLease.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotorLease.Methods
{
    public static class AppExtension
    {
        public static Form CurrentForm;
        public static Form PreviousForm;
        public static Form NextForm; 
        public static Form FirstForm;
        public static Form LastForm;

        private static bool _exiting;


        public static string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        public static Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }

        public static void GoBack(Form current, Form previous)
        {
            previous.Hide();
            current.Hide();    
            previous.Show();
        }

        public static void Logout()
        {
            List<Form> formsToClose = new List<Form>();    
            Form formToClose = null;
            Form main = new Main();
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "Main")
                {
                    formToClose = form;
                    formsToClose.Add(formToClose);
                }
            }
            if (formsToClose != null)
            {
                foreach (Form item in formsToClose)
                {
                    item.Close();
                }
                
            }
            //main.Hide();
            //main.Show();
            //main.Visible = true;

            
        }

        public static decimal GetTotalPrice(DateTime from, DateTime to, decimal unitPirce)
        {
            decimal price = 0;
            var diff = Math.Round((decimal)(to - from).TotalDays, 0);
            price = unitPirce * diff;
            return price;
        }

        public static int GetKey<T>(this DBContext context, T entity)
        {
            var keyName = context.Model.FindEntityType(typeof(T)).FindPrimaryKey()
                .Properties.Select(x => x.Name).Single();

            return (int)entity.GetType().GetProperty(keyName).GetValue(entity, null);
        }

        public static void CompleteAsync()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday || DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday || DateTime.Now.DayOfWeek == DayOfWeek.Thursday || DateTime.Now.DayOfWeek == DayOfWeek.Friday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Form main = new Main();
                main.Close();
                Application.Exit();
            }
        }

        public static void ValidateBookingDates(DateTime from, DateTime to)
        {
            if (from < DateTime.Today)
            {
                MessageBox.Show($"Collection date must be greater today");
                return;
            }
            if (to < DateTime.Today)
            {
                MessageBox.Show($"Return date must not be lesser than today");
                return;
            }
            if (from == to || to < from)
            {
                MessageBox.Show($"Return date must be greater than date of collection");
                return;
            }
        }


    }
}
