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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Show();
        }

        protected void Submit_Click_Delete(object sender, EventArgs e)
        {

           var Id = int.Parse(Request.QueryString["id"]);
            var sr = new StudentServices();
            sr.Delete(Id);  
        }

        protected void Show()
        {
            var services = new StudentServices();

            var stt = services.GetById(int.Parse(Request.QueryString["id"]));
            foreach (var student in stt)
            {
                TextBoxName.Text = student.Name;
                TextBoxRollNo.Text = student.RollNo.ToString();
                TextBoxAddress.Text = student.Address;
            }
        }
    }
}