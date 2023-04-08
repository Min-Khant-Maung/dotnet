using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFMS.Models;
using SFMS.Models.ViewModel;
using SFMS.Models.DAO;
using System.Net;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SFMS.Controllers
{
    public class AttendanceDayEndProcessController : Controller
    {

        private readonly ApplicationDbContext _applicationDbcontent;
        //Constructore injection
        public AttendanceDayEndProcessController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }

        public IActionResult DayEndProcess()
        {
            IList<StudentViewModel> students = _applicationDbcontent.Students.Select(b => new StudentViewModel
            {
                Name = b.Name,
                Id = b.Id,
                Code = b.Code
            }).ToList();
            IList<BatchViewModel> batches = _applicationDbcontent.Batches.Select(b => new BatchViewModel
            {
                Name = b.Name,
                Id = b.Id,
                Description = b.Description
            }).ToList();
            AttendanceDayEndProcessViewModel attendanceDayEndProcessViewModel = new AttendanceDayEndProcessViewModel()
            {
                students = students,
                batches = batches
            };

            return View(attendanceDayEndProcessViewModel);
        }
        [HttpPost]
        public IActionResult DayEndProcess(AttendanceDayEndProcessViewModel viewModel)
        {
            var finePolicy = _applicationDbcontent.FinePolicies.SingleOrDefault();
            bool isSuccess = false;
            try
            {
                var ftsCheckBeforeDayEndProcess = _applicationDbcontent.FineTransitions.Where(x => x.StudentId.Equals(viewModel.StudentId)
                && (x.FinedDate >= viewModel.FromDayEndDate && x.FinedDate <= viewModel.ToDayEndDate)).ToList();

                if (null != ftsCheckBeforeDayEndProcess)
                {
                    _applicationDbcontent.FineTransitions.RemoveRange(ftsCheckBeforeDayEndProcess);
                    _applicationDbcontent.SaveChanges();
                }
                IList<FineTransition> fts = new List<FineTransition>();
                if (!viewModel.StudentId.Equals("so"))
                {
                    var attendances = _applicationDbcontent.Attendances.
                        Where(x => x.StudentId.Equals(viewModel.StudentId) &&
                        x.IsLate == true && (x.AttendanceDate >= viewModel.FromDayEndDate &&
                        x.AttendanceDate <= viewModel.ToDayEndDate)).ToList();
                    foreach (var attendance in attendances)
                    {
                        TimeSpan inTime = TimeSpan.Parse(attendance.Intime);
                        if (inTime.Minutes > finePolicy.FineAfterMinutes)
                        {
                            FineTransition ft = new FineTransition()
                            {
                                Id = Guid.NewGuid().ToString(),
                                CreatedDate = DateTime.Now,
                                Ip = GetLocalIPAddress(),

                                FinedDate = attendance.AttendanceDate,
                                StudentId = attendance.StudentId,
                                FinePolicyId = finePolicy.Id,
                                InTime = attendance.Intime,
                                OutTime = attendance.OutTime,
                                FineAmount =Convert.ToInt32 (finePolicy.FineAmount)
                            };
                            fts.Add(ft);
                        }
                    }
                    _applicationDbcontent.FineTransitions.AddRange(fts);
                    _applicationDbcontent.SaveChanges();
                    isSuccess = true;
                }
            }catch(Exception ex)
            {
                isSuccess = false;
            }

            return View();
        }

            private static string GetLocalIPAddress()
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
        }

}
