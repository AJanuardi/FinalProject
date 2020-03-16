using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HR_App.Models;
using HR_App.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace HR_App.Controllers
{
    public class AttendanceController : Controller
    {
        private AppDbContext _appdbcontext;
        private readonly ILogger<AttendanceController> _logger;

        public AttendanceController(ILogger<AttendanceController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appdbcontext = appDbContext;
        }
        
        [Authorize]
        public IActionResult Index(string search, int _crntpage=1)
        {
            var j = (from i in _appdbcontext.pagings select i).FirstOrDefault();
            ViewBag.search = search;
            var y = (from i in _appdbcontext.leaves where i.status == "submitted" select i).Count();
            ViewBag.count = y;
             if (j == null)
            {
                Paging paging = new Paging()
                {
                    CurrentPage = 1
                };
                _appdbcontext.pagings.Add(paging);
                _appdbcontext.SaveChanges();
                var z = _appdbcontext.pagings.Find(1);
                z.CurrentPage = _crntpage;
                _appdbcontext.SaveChanges();
                if (z.CurrentPage == 1)
                {
                if (search != null)
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.employees.OrderBy(a => a.name) where (i.name.Contains(search)) select i;
                    var get = from a in x.Take(take) select a;
                    ViewBag.emp = get;
                    ViewBag.page = z;
                    return View();
                }
                else
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.employees.OrderBy(a => a.name) select i;
                    var get = from a in x.Take(take) select a;
                    ViewBag.emp = get;
                    ViewBag.page = z;
                    return View();
                }
            }
            else
            {
                if (search != null)
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.employees.OrderBy(a => a.name) where (i.name.Contains(search)) select i;
                    var get = from a in x.Skip(take*(z.CurrentPage-1)).Take(take) select a;
                    ViewBag.emp = get;
                    ViewBag.page = z;
                    return View();
                }
                else
                {
                    var take = z.ShowItem;
                    var x = (from i in _appdbcontext.employees.OrderBy(a => a.name) select i).Skip(take*(z.CurrentPage-1)).Take(take);
                    ViewBag.emp = x;
                    ViewBag.page = z;
                    return View();
                }
            }
            }
            else
            {
            var z = _appdbcontext.pagings.Find(1);
            z.CurrentPage = _crntpage;
            _appdbcontext.SaveChanges();
            if (z.CurrentPage == 1)
            {
                if (search != null)
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.employees.OrderBy(a => a.name) where (i.name.Contains(search)) select i;
                    var get = from a in x.Take(take) select a;
                    ViewBag.emp = get;
                    ViewBag.page = z;
                    return View();
                }
                else
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.employees.OrderBy(a => a.name) select i;
                    var get = from a in x.Take(take) select a;
                    ViewBag.emp = get;
                    ViewBag.page = z;
                    return View();
                }
            }
            else
            {
                if (search != null)
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.employees.OrderBy(a => a.name) where (i.name.Contains(search)) select i;
                    var get = from a in x.Skip(take*(z.CurrentPage-1)).Take(take) select a;
                    ViewBag.emp = get;
                    ViewBag.page = z;
                    return View();
                }
                else
                {
                    var take = z.ShowItem;
                    var x = (from i in _appdbcontext.employees.OrderBy(a => a.name) select i).Skip(take*(z.CurrentPage-1)).Take(take);
                    ViewBag.emp = x;
                    ViewBag.page = z;
                    return View();
                }
            }
            }
        }

        public IActionResult Data(string name)
        {
            var x = (from i in _appdbcontext.attendances.OrderByDescending(a => a.clockin) where (i.name == name) select i);
            ViewBag.att = x;
            var y = (from i in _appdbcontext.attendances.OrderBy(a => a.clockin) where (i.name == name) select i).FirstOrDefault();
            ViewBag.name = y;
            var z = (from i in _appdbcontext.leaves where i.status == "submitted" select i).Count();
            ViewBag.count = z;
            return View();
        }

        [Authorize]
        public IActionResult DataClockIn()
        {
            var y = (from i in _appdbcontext.leaves where i.status == "submitted" select i).Count();
            ViewBag.count = y;
            return View();
        }

        [Authorize]
        public IActionResult DataClockOut()
        {
            var y = (from i in _appdbcontext.leaves where i.status == "submitted" select i).Count();
            ViewBag.count = y;
            return View();
        }

        [Authorize]
        public IActionResult ClockIn(string name, DateTime date)
        {
                Attendance att = new Attendance()
                {
                    name = name,
                    clockin = date
                };
                _appdbcontext.attendances.Add(att);
                _appdbcontext.SaveChanges();
                return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult ClockOut(string name, DateTime date)
        {
                var x = (from i in _appdbcontext.attendances.OrderByDescending(a => a.id) where i.name == name select i).FirstOrDefault();
                if (x.clockin.ToString("MM/dd/yyyy") == date.ToString("MM/dd/yyyy"))
                {
                    x.clockout = date;
                    _appdbcontext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return Ok("Fail");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
