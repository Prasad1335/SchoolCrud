﻿using School.Services;
using School.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolCrud.pages
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (IsPostBack) return;
            Show();
        }

        protected void Submit_Click_Update(object sender, EventArgs e)
        {
            var services = new StudentServices();

            var st = new Student
            {
                Id = int.Parse(Request.QueryString["id"]),
                Name = TextBoxName.Text,
                RollNo = int.Parse(TextBoxRollNo.Text),
                Address = TextBoxAddress.Text,
            };
            services.Update(st);

        }


        protected void Show()
        {
            var services = new StudentServices();
       
            var stt = services.GetById(int.Parse(Request.QueryString["id"]));
            foreach (var student in stt)
            {
                TextBoxName.Text = student.Name;
                TextBoxRollNo.Text = student.RollNo.ToString();
                TextBoxAddress.Text= student.Address;   
            }
        }
    }
}