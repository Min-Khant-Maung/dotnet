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
    public class AttendanceController : Controller
    {
        private readonly ApplicationDbContext _applicationDbcontent;
        //Constructor injection
        public AttendanceController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }
        public IActionResult Entry()
        {
            IList<StudentViewModel> students = _applicationDbcontent.Students.Select
                      (s => new StudentViewModel
                      {
                          Id = s.Id,
                          Code = s.Code,
                          Name = s.Name,
                          Email = s.Email,
                          Address = s.Address,
                          Phone = s.Phone,
                          FatherName = s.FatherName,
                          NRC = s.NRC,
                          DOB = s.DOB
                      }).ToList();
            return View(students);
        }
        [HttpPost]
        public IActionResult Entry(AttendanceViewModel attendanceViewModel)
        {
            bool isSuccess = false;
            try
            {
                Attendance attendance = new Attendance();
                //audit columns
                attendance.Id = Guid.NewGuid().ToString();
                attendance.CreatedDate = DateTime.Now;
                attendance.Ip = GetLocalIPAddress();

                //ui columns
                attendance.AttendanceDate = attendanceViewModel.AttendanceDate;
                attendance.Intime = attendanceViewModel.Intime;
                attendance.OutTime = attendanceViewModel.OutTime;
                attendance.IsLeave = attendanceViewModel.IsLeave;
                attendance.IsLate = attendanceViewModel.IsLate;
                attendance.StudentId = attendanceViewModel.StudentId;

                _applicationDbcontent.Attendances.Add(attendance);//Ading the records Students DBSet
                _applicationDbcontent.SaveChanges();//Saving the records to the database
                isSuccess = true;
            }
            catch (Exception ex)
            {

            }
            if (isSuccess)
            {
                ViewBag.msg = "Success";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            IList<AttendanceViewModel> attendances = _applicationDbcontent.Attendances.Select
                (bb => new AttendanceViewModel
            {
                AttendanceDate = bb.AttendanceDate,
                Intime = bb.Intime,
                OutTime = bb.OutTime,
                IsLeave = bb.IsLeave,
                IsLate = bb.IsLate,
                StudentName = bb.Student.Name
            }).ToList();
            return View(attendances);
        }

        public IActionResult Delete(string id)
        {
            Attendance attendance = _applicationDbcontent.Attendances.Find(id);
            if (attendance != null)
            {
                _applicationDbcontent.Attendances.Remove(attendance);
                _applicationDbcontent.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public IActionResult Edit(string id)
        {
            AttendanceViewModel attendanceViewModel = _applicationDbcontent.Attendances
                .Where(w => w.Id == id)
                .Select(s => new AttendanceViewModel
                {
                    AttendanceDate = s.AttendanceDate,
                    Intime = s.Intime,
                    OutTime = s.OutTime,
                    IsLeave = s.IsLeave,
                    IsLate = s.IsLate,
                    StudentId = s.StudentId
                }).SingleOrDefault();

            ViewBag.StudentList = _applicationDbcontent.Students.Select(s => new SelectListItem
            {
                Value = s.Id,
                Text = s.Name
            }).ToList();

            return View(attendanceViewModel);
        }


        [HttpPost]
        public IActionResult Edit(AttendanceViewModel attendanceViewModel)
        {
            bool isSuccess = false;
            try
            {
                Attendance attendance = new Attendance();
                //audit columns
                attendance.Id = attendanceViewModel.Id;
                attendance.ModifiedDate = DateTime.Now;
                attendance.Ip = GetLocalIPAddress();

                //ui columns

                attendance.AttendanceDate = attendanceViewModel.AttendanceDate;
                attendance.Intime = attendanceViewModel.Intime;
                attendance.OutTime = attendanceViewModel.OutTime;
                attendance.IsLeave = attendanceViewModel.IsLeave;
                attendance.IsLate = attendanceViewModel.IsLate;

                _applicationDbcontent.Entry(attendance).State = EntityState.Modified;//Updating the existing records in DBSet
                _applicationDbcontent.SaveChanges();//Updating the records to the database
                isSuccess = true;
            }
            catch (Exception ex)
            {

            }
            if (isSuccess)
            {
                TempData["msg"] = "Update Success";
            }
            else
            {
                TempData["msg"] = "Error occur while updating";
            }
            return RedirectToAction("List");
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
