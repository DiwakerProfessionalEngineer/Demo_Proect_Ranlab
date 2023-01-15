using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Reg_User.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace MVC_Reg_User.Controllers
{
    public class NewRegController : Controller
    {
        // GET: NewReg
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(UserClass uc,HttpPostedFileBase file)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[MVCregUser](Uname,Uemail,Upass,Gender,Uimg) values (@Uname,@Uemail,@Upass,@Gender,@Uimg)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@Uname", uc.Uname);
            sqlcomm.Parameters.AddWithValue("@Uemail", uc.Uemail);
            sqlcomm.Parameters.AddWithValue("@Upass", uc.Upass);
            sqlcomm.Parameters.AddWithValue("@Gender", uc.Gender);
            if(file != null && file.ContentLength>0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/User-Images/"), filename);
                file.SaveAs(imgpath);
            }
            sqlcomm.Parameters.AddWithValue("@Uimg", "~/User-Images/" + file.FileName);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            ViewData["Message"] = " User Record " + uc.Uname + " Is Saved Successfully !";
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
            
    }
}