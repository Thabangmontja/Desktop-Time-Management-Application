using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using POE.Models;
using System.Windows.Forms;
    
namespace POE.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-PCB0HSD\\SQLEXPRESS;Initial Catalog=POE;Integrated Security=True");
        [HttpGet]
        public ActionResult Login()
        {
            return View();  
        }
        [HttpPost]
            public ActionResult Login(RegisterAndLogin log)
        {
            string query = "SELECT COUNT(*) FROM STUDENT_INFOR WHERE Email = '" + log.Email + "' AND Password = '" + log.Password + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return RedirectToAction("Modules", "Home");
            }
            else
            {
                MessageBox.Show("Invalid username and password!!!");
                return RedirectToAction("Login", "Home");
            }
           
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterAndLogin reg)
        {
            RegisterAndLogin log = new RegisterAndLogin(); 
            string query = "SELECT COUNT(*) FROM STUDENT_INFOR WHERE Email = '" + log.Email + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("User Already exist");
                return RedirectToAction("Register", "Home");
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO STUDENT_INFOR VALUES(@First_name, @Last_name, @Email, @Password)", sql);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@First_name", reg.First_name);
                command.Parameters.AddWithValue("@Last_name", reg.Last_name);
                command.Parameters.AddWithValue("@Email", reg.Email);
                command.Parameters.AddWithValue("@Password", reg.Password);
                sql.Open();
                command.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Registered Successfully!!!!");
                return RedirectToAction("Login", "Home");
            }
          
        }

        [HttpGet]
        public ActionResult Modules()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Modules(Modules mod)
        {
            RegisterAndLogin log = new RegisterAndLogin();
            string query = "SELECT COUNT(*) FROM STUDENT_INFOR WHERE Email = '" + log.Email + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                mod.Self_study = ((mod.Credit * 10) / mod.Weeks) - mod.ClassPerHour;
                mod.Remaining_Hours = mod.Self_study - mod.Used_hours;
                SqlCommand command = new SqlCommand("INSERT INTO MODULES VALUES(@Email, @Code, @Name,  @Credit, @ClassPerHour, @Weeks, @Used_hours, @Self_study, @Remaining_Hours)", sql);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Email", mod.Email);
                command.Parameters.AddWithValue("@Code", mod.Code);
                command.Parameters.AddWithValue("@Name", mod.Name);
                command.Parameters.AddWithValue("@Credit", mod.Credit);
                command.Parameters.AddWithValue("@ClassPerHour", mod.ClassPerHour);
                command.Parameters.AddWithValue("@Weeks", mod.Used_hours);
                command.Parameters.AddWithValue("@Used_hours", mod.Used_hours);
                command.Parameters.AddWithValue("@Self_study", mod.Self_study);
                command.Parameters.AddWithValue("@Remaining_Hours", mod.Remaining_Hours);
                sql.Open();
                command.ExecuteNonQuery();
                sql.Close();
                return View();
            }
            else
            {

                MessageBox.Show("User does not exist");
                return View();
            }
               
        }
        [HttpGet]
        public ActionResult Display()
        {
            string connection = "Data Source=DESKTOP-PCB0HSD\\SQLEXPRESS;Initial Catalog=POE;Integrated Security=True";
            string ver = "SELECT Name, Used_hours FROM MODULES";
            List<Modules> data = new List<Modules>();
            using (SqlConnection sql = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(ver))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sql;
                    sql.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            data.Add(new Modules
                            {
                                Name = rd["Name"].ToString(),
                                Used_hours = Convert.ToInt32(rd["Used_hours"])
                            });

                        }
                    }
                    sql.Close();
                }
            }
            return View(data);
        }
    }
}