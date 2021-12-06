using Commerce.Models;
using Commerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Controllers
{
    
    public class AllSecurityController : Controller
    {
        private readonly AppDbContext _Db;
        public AllSecurityController(AppDbContext _Db)
        {
            this._Db = _Db;
        }

        [HttpPost]
        public IActionResult checkLogin(Login login)
        {
            
            var data = _Db.Logins.Where(x => x.UserName == login.UserName && x.UserPassword == login.UserPassword).FirstOrDefault();
            if (data != null)
            {
                string accno = _Db.Customers.Where(x => x.UserId == data.UserId).Select(x => x.AccountNumber).FirstOrDefault().ToString();
                HttpContext.Session.SetString("userid", accno);
                HttpContext.Session.SetString("uid", data.UserId);
                HttpContext.Session.SetString("user", login.UserName);
                ViewBag.name = HttpContext.Session.GetString("user");
                LoginHistory loginHistory = new LoginHistory();
                loginHistory.UserId = data.UserId;
                loginHistory.LoginTime = System.DateTime.Now;
                _Db.LoginHistories.Add(loginHistory);
                _Db.SaveChanges();
                return RedirectToAction("Welcome","AllSecurity");
            }


            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult Welcome()
        {
            string uid=HttpContext.Session.GetString("uid");
            var data=_Db.LoginHistories.Where(x=>x.UserId==uid).ToList();
            ViewBag.dat=data;
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult notifications()
        {
            string acc = HttpContext.Session.GetString("userid");
            var list = _Db.Notifications.Where( x=> x.AccNumber == acc).ToList();
            
            return View(list);
        }
        [HttpGet]
        public IActionResult Addnotifications()
        {

            return View();
        }
        public IActionResult Managenofication()
        {
            var dat = _Db.NotficationRules.Where(x => x.AccountNumber == HttpContext.Session.GetString("userid")).FirstOrDefault();
            if (dat != null)
            {
                ViewBag.status = "data";
                ViewBag.AccountNumber = dat.AccountNumber;
                ViewBag.ID = dat.Nrid;
                ViewBag.Location = dat.Location;
                ViewBag.startTime = dat.StartTime;
                ViewBag.EndTime = dat.EndTime;
                ViewBag.Locationstatus = dat.Locationstatus;
                ViewBag.TimeFrame = dat.TimeFrame;
            }
            return View();
        }
    
        public IActionResult notificationsPartial()
        {
            string acc = HttpContext.Session.GetString("userid");
            var list = _Db.Notifications.Where(x => x.AccNumber == acc).ToList();
            return Json(list);
       
        }
        public IActionResult UpdateLocation()
        {
            string acc = HttpContext.Session.GetString("userid");
            var data = _Db.NotficationRules.Where(x => x.AccountNumber == acc).FirstOrDefault();
            data.Locationstatus = false;
            _Db.NotficationRules.Update(data);
            _Db.SaveChanges();
            return Json(true);

        }
        public IActionResult UpdateTime()
        {
            string acc = HttpContext.Session.GetString("userid");
            var data = _Db.NotficationRules.Where(x => x.AccountNumber == acc).FirstOrDefault();
            data.TimeFrame = false;
            _Db.NotficationRules.Update(data);
            _Db.SaveChanges();

            return Json(true);

        }
        public IActionResult DeleteNotficationRule()
        {
            string acc = HttpContext.Session.GetString("userid");
            var data = _Db.NotficationRules.Where(x => x.AccountNumber == acc).FirstOrDefault();
             _Db.NotficationRules.Remove(data);
            _Db.SaveChanges();

            return Json("true");

        }
        public IActionResult Delete(string id) 
        {
            var notification = _Db.Notifications.Where(x => x.NotificationId == id).FirstOrDefault();
            _Db.Remove(notification);
            _Db.SaveChanges();

            return RedirectToAction("notifications", "AllSecurity");
        }
        public IActionResult Delete2(int id)
        {
            var notificationRule = _Db.NotficationRules.Where(x => x.Nrid == id).FirstOrDefault();
            _Db.Remove(notificationRule);
            _Db.SaveChanges();

            return RedirectToAction("notifications", "AllSecurity");
        }
        [HttpPost]
        public IActionResult Index(System.DateTime startdate, System.DateTime Enddate)
        {
            var data = _Db.Transactions.Where(x => x.ProcessingDate >= startdate && x.ProcessingDate <= Enddate).ToList();
           
            ViewBag.dat = data;
            return View();
        }

        [HttpGet]
        public IActionResult NewTransaction()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewTransaction(Transaction transaction)
        {
            transaction.ProcessingDate = System.DateTime.Now;
            transaction.AccountNo = HttpContext.Session.GetString("userid");
            transaction.TransactionId = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            _Db.Transactions.Add(transaction);
            _Db.SaveChanges();
            var dat = _Db.NotficationRules.Where(x => x.AccountNumber == HttpContext.Session.GetString("userid")).FirstOrDefault();
            if (dat != null)
            {
                string msg="";
                System.DateTime dateTime = DateTime.Now;
         
                if (dat.Location == transaction.Location && dat.Locationstatus==true)
                {
                    msg = "Out of state Transaction";
                }

                if (dateTime >= dat.StartTime && dateTime <= dat.EndTime && dat.TimeFrame==true)
                {
                    msg = msg + " out of Time Transaction";
                }
                if (msg != null)
                {
                    Notification noti = new Notification();
                    noti.AccNumber = transaction.AccountNo;
                    noti.NotificationId = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    noti.NotificationMessage = msg;
                    _Db.Notifications.Add(noti);
                    _Db.SaveChanges();

                }
            }
      
            return View("Index");
        }
        [HttpPost]
        public IActionResult setnotfi(NotficationRule notficationRule)
        {
            
            notficationRule.AccountNumber = HttpContext.Session.GetString("userid");
            if (notficationRule.Location != null)
            {
                notficationRule.Locationstatus = true;
            }
            else 
            {
                notficationRule.Locationstatus = false;
            }
            if (notficationRule.StartTime != null && notficationRule.EndTime != null)
            {

                notficationRule.TimeFrame = true;
            }
            else
            {
                notficationRule.TimeFrame = false;
            }
            _Db.NotficationRules.Add(notficationRule);
            _Db.SaveChanges();
            return RedirectToAction("Welcome","AllSecurity");
        }
    }
}
