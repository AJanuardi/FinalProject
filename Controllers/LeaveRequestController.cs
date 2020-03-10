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
    public class LeaveRequestController : Controller
    {
        private AppDbContext _appdbcontext;
        private readonly ILogger<LeaveRequestController> _logger;

        public LeaveRequestController(ILogger<LeaveRequestController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appdbcontext = appDbContext;
        }
        
        [Authorize]
        public IActionResult Index(string search, int _crntpage=1)
        {
            var y = (from i in _appdbcontext.leaves where i.status == "submitted" select i).Count();
            ViewBag.count = y;
            var z = _appdbcontext.pagings.Find(1);
            z.CurrentPage = _crntpage;
            _appdbcontext.SaveChanges();
            if (z.CurrentPage == 1)
            {
                if (search != null)
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.leaves where (i.name.Contains(search) ||  i.status.Contains(search)) select i;
                    var get = from a in x.Skip(take*(z.CurrentPage - 1)).Take(take) select a;
                    ViewBag.leave = get;
                    ViewBag.page = z;
                    return View();
                }
                else
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.leaves select i;
                    var get = from a in x.Skip(take*(z.CurrentPage - 1)).Take(take) select a;
                    ViewBag.leave = get;
                    ViewBag.page = z;
                    return View();
                }
            }
            else
            {
                if (search != null)
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.leaves where (i.name.Contains(search) ||  i.status.Contains(search)) select i;
                    var get = from a in x.Skip(take*(z.CurrentPage - 1)).Take(take) select a;
                    ViewBag.leave = get;
                    ViewBag.page = z;
                    return View();
                }
                else
                {
                    var take = z.ShowItem;
                    var x = from i in _appdbcontext.leaves select i;
                    var get = from a in x.Skip(take*(z.CurrentPage - 1)).Take(take) select a;
                    ViewBag.leave = get;
                    ViewBag.page = z;
                    return View();
                }
            }
        }

        [Authorize]
        public IActionResult Allow(int id)
        {
            var x = (from i in _appdbcontext.leaves.OrderByDescending(a => a.id) where (i.id == id) select i).FirstOrDefault();
            x.status = "allowed";
            _appdbcontext.SaveChanges();
            return RedirectToAction("Index");   
        }

        [Authorize]
        public IActionResult Reject(int id)
        {
            var x = (from i in _appdbcontext.leaves.OrderByDescending(a => a.id) where (i.id == id) select i).FirstOrDefault();
            x.status = "rejected";
            _appdbcontext.SaveChanges();
            return RedirectToAction("Index");   
        }

        [Authorize]
        public IActionResult Add()
        {
            return View();   
        }

        [Authorize]
        public IActionResult Added(string name, string position, string department, DateTime outtime, DateTime intime, string status)
        {
            Leave leave = new Leave()
            {
                name = name,
                position = position,
                department = department,
                outtime = outtime,
                intime = intime,
                status = "submitted"
            };
            _appdbcontext.leaves.Add(leave);
            _appdbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
