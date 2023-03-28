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

namespace SFMS.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _applicationDbcontent;
        public TeacherController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }

        public IActionResult Entry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entry(TeacherViewModel teacherViewModel)
        {
            bool isSuccess = false;
            try
            {
                Teacher teacher = new Teacher();
                teacher.Id = Guid.NewGuid().ToString();
                teacher.CreatedDate = DateTime.Now;
                teacher.Ip = GetLocalIPAddress();

                teacher.Name = teacherViewModel.Name;
                teacher.Email = teacherViewModel.Email;
                teacher.Position = teacherViewModel.Position;
                teacher.Address = teacherViewModel.Address;
                teacher.Phone = teacherViewModel.Phone;
                _applicationDbcontent.TeachersInfo.Add(teacher);
                _applicationDbcontent.SaveChanges();
                isSuccess = true;
            }
            catch(Exception ex)
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
            IList<TeacherViewModel> teachers = _applicationDbcontent.TeachersInfo.Select(t => new TeacherViewModel
            {
                Id = t.Id,
                Name = t.Name,
                Email = t.Email,
                Position = t.Position,
                Address = t.Address,
                Phone = t.Phone
            }).ToList();
            return View(teachers);
        }

        public IActionResult Delete(string id)
        {
            Teacher teacher = _applicationDbcontent.TeachersInfo.Find(id);
            if(teacher != null)
            {
                _applicationDbcontent.TeachersInfo.Remove(teacher);
                _applicationDbcontent.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public IActionResult Edit(string id)
        {
            TeacherViewModel teacherViewModel = _applicationDbcontent.TeachersInfo.Where(w => w.Id == id)
                .Select(s => new TeacherViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Email = s.Email,
                    Position = s.Position,
                    Address = s.Address,
                    Phone = s.Phone
                }).SingleOrDefault();
            return View(teacherViewModel);
        }
        [HttpPost]
        public IActionResult Edit(TeacherViewModel teacherViewModel)
        {
            bool isSuccess = false;
            try
            {
                Teacher teacher = new Teacher();
                teacher.Id = teacherViewModel.Id;
                teacher.CreatedDate = DateTime.Now;
                teacher.Ip = GetLocalIPAddress();

                teacher.Name = teacherViewModel.Name;
                teacher.Email = teacherViewModel.Email;
                teacher.Position = teacherViewModel.Position;
                teacher.Address = teacherViewModel.Address;
                teacher.Phone = teacherViewModel.Phone;
                _applicationDbcontent.Entry(teacher).State = EntityState.Modified;
                _applicationDbcontent.SaveChanges();
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
