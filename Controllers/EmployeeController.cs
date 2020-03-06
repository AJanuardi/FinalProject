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

namespace HR_App.Controllers
{
    public class EmployeeController : Controller
    {
        private AppDbContext _appdbcontext;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appdbcontext = appDbContext;
        }
        public IActionResult Index()
        {
            var x = from i in _appdbcontext.employees select i;
            ViewBag.emp = x;
            return View();
        }

        public IActionResult Data()
        {
            return View();
        }

        public IActionResult AddNew(string name, string email, IFormFile photo, string phone, string gender, DateTime bhirtdate, string bhirtplace, string position, string department, string address, string emergency1, string emergency2, string emergency3, string status, DateTime contract)
        {
                var path = "wwwroot//images";
                Directory.CreateDirectory(path);
                var FileName= Path.Combine(path, Path.GetFileName(photo.FileName));
                photo.CopyTo(new FileStream(FileName, FileMode.Create));
                var file = FileName.Substring(8).Replace(@"\","/");
                Employee data = new Employee()
                {
                    photo = file,
                    name = name,
                    email = email,
                    phone = phone,
                    gender = gender,
                    bhirtdate = bhirtdate,
                    bhirtplace = bhirtplace,
                    position = position,
                    department = department,
                    address = address,
                    emergency1 = emergency1,
                    emergency2 = emergency2,
                    emergency3 = emergency3,
                    status = status,
                    contract = contract
                };
                _appdbcontext.employees.Add(data);
                _appdbcontext.SaveChanges();
                return RedirectToAction("Data");
        }

        public IActionResult Add(string name, string email, IFormFile photo, string phone, string gender, DateTime bhirtdate, string bhirtplace, string position, string department, string address, string emergency1, string emergency2, string emergency3, string status, DateTime contract)
        {
                var path = "wwwroot//images";
                Directory.CreateDirectory(path);
                var FileName= Path.Combine(path, Path.GetFileName(photo.FileName));
                photo.CopyTo(new FileStream(FileName, FileMode.Create));
                var file = FileName.Substring(8).Replace(@"\","/");
                Employee data = new Employee()
                {
                    photo = file,
                    name = name,
                    email = email,
                    phone = phone,
                    gender = gender,
                    bhirtdate = bhirtdate,
                    bhirtplace = bhirtplace,
                    position = position,
                    department = department,
                    address = address,
                    emergency1 = emergency1,
                    emergency2 = emergency2,
                    emergency3 = emergency3,
                    status = status,
                    contract = contract
                };
                _appdbcontext.employees.Add(data);
                _appdbcontext.SaveChanges();
                return RedirectToAction("Index");
        }

        public IActionResult Export()
        {
            var colom = new string[]
            {
                "id",
                "name",
                "photo",
                "email",
                "phone",
                "gender",
                "bhirtdate",
                "bhirtplace",
                "position",
                "department",
                "address",
                "nameugd1",
                "emergency1",
                "nameugd2",
                "emergency2",
                "nameugd3",
                "emergency3",
                "status",
                "contract"
            };
            var employees = (from i in _appdbcontext.employees select new object[]
            {
                i.id,
                i.name,
                i.photo,
                i.email,
                i.phone,
                i.gender,
                i.bhirtdate,
                i.bhirtplace,
                i.position,
                i.department,
                i.address,
                i.nameugd1,
                i.emergency1,
                i.nameugd2,
                i.emergency2,
                i.nameugd3,
                i.emergency3,
                i.status,
                i.contract
            }).ToList();
            var emp = new StringBuilder();
            employees.ForEach(line =>
            {
                emp.AppendLine(string.Join(",", line));
            });
            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", colom)}\r\n{emp.ToString()}");
            return File(buffer, "text/csv", $"Employees Info.csv");
        }

        public IActionResult Import([FromForm(Name="Upload")] IFormFile Upload)
        {
                        using (var sreader = new StreamReader(Upload.OpenReadStream()))
                        {
                            string[] headers = sreader.ReadLine().Split(',');
                            while(!sreader.EndOfStream)
                            {
                                string[] rows = sreader.ReadLine().Split(',');
                                Employee emp = new Employee()
                                {

                                    name = rows[0].ToString(),
                                    photo = rows[1].ToString(),
                                    email = rows[2].ToString(),
                                    phone =rows[3].ToString(),
                                    gender = rows[4].ToString(),
                                    bhirtdate = Convert.ToDateTime(rows[5].ToString()),
                                    bhirtplace = rows[6].ToString(),
                                    position = rows[7].ToString(),
                                    department = rows[8].ToString(),
                                    address = rows[9].ToString(),
                                    nameugd1 = rows[10].ToString(),
                                    emergency1 = rows[11].ToString(),
                                    nameugd2 = rows[12].ToString(),
                                    emergency2 = rows[13].ToString(),
                                    nameugd3 = rows[14].ToString(),
                                    emergency3 = rows[15].ToString(),
                                    status = rows[16].ToString(),
                                    contract = Convert.ToDateTime(rows[17].ToString()),

                                };
                                _appdbcontext.employees.Add(emp);
                            }
                            _appdbcontext.SaveChanges();
                        }
                        return Redirect("Index");
        }

        public IActionResult Information(Guid id)
        {
            var x = from i in _appdbcontext.employees where i.id == id select i;
            ViewBag.emp = x;
            return View("Information");
        }

        public IActionResult Delete(Guid id)
        {
            var x = from i in _appdbcontext.employees where i.id == id select i;
            ViewBag.emp = x;
            return View("Information");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
