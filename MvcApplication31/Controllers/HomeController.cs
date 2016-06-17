using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication31.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }

    public static class TrafficManager
    {
        public static void LogTraffic(string useragent)
        {
            using (SqlConnection connetion = new SqlConnection(Properties.Settings.Default.ConStr))
            {
                var command = connetion.CreateCommand();
                command.CommandText = "INSERT INTO Traffic (Useragent, Date) VALUES (@ua, @d)";
                command.Parameters.AddWithValue("@ua", useragent);
                command.Parameters.AddWithValue("@d", DateTime.Now);
                connetion.Open();
                command.ExecuteNonQuery();

            }
        }

        public static int GetTrafficCount()
        {
            using (SqlConnection connetion = new SqlConnection(Properties.Settings.Default.ConStr))
            {
                var command = connetion.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Traffic";
                connetion.Open();
                return (int) command.ExecuteScalar();
            }
        }
    }
}
