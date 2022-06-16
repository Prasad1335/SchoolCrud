using School.Services;
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var services = new StudentServices();
            var id = Request.QueryString["id"];
            var st = new Student
            {
                Name = TextBoxName.Text,
                RollNo = int.Parse(TextBoxRollNo.Text),
                Address = TextBoxAddress.Text,
            };
            services.Update(st);


        }


        protected void Show()
        {
            var services = new StudentServices();
            var id = Request.QueryString["id"];

            var st = new Student
            {
           
            };
           


        }
    }
}