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
using Microsoft.AspNetCore.Authorization;

namespace SFMS.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _applicationDbcontent;
        //Constructore injection
        public CourseController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }
        [Authorize(Roles = "admin,teacher")]
        public IActionResult Entry()
        {
            return View();
        }
        [Authorize(Roles = "admin,teacher")]
        [HttpPost]
        public IActionResult Entry(CourseViewModel courseViewModel)
        {
            bool isSuccess = false;
            try
            {
                Course course = new Course();
                //audit columns
                course.Id = Guid.NewGuid().ToString();
                course.CreatedDate = DateTime.Now;
                course.Ip = GetLocalIPAddress();

                //ui columns
                course.Name = courseViewModel.Name;
                course.Description = courseViewModel.Description;
                course.OpeningDate = courseViewModel.OpeningDate;
                course.DurationInHour = courseViewModel.DurationInHour;
                course.Fees = courseViewModel.Fees;
                _applicationDbcontent.Courses.Add(course);//Ading the records Students DBSet
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
            IList<CourseViewModel> courses = _applicationDbcontent.Courses.Select
                  (c => new CourseViewModel
                  {
                      Id = c.Id,
                      Name = c.Name,
                      Description = c.Description,
                      OpeningDate = c.OpeningDate,
                      DurationInHour = c.DurationInHour,
                      Fees = c.Fees
                  }).ToList();
            return View(courses);
        }

        public IActionResult Delete(string id)
        {
            Course course = _applicationDbcontent.Courses.Find(id);
            if (course != null)
            {
                _applicationDbcontent.Courses.Remove(course);//remove the student record from DBset
                _applicationDbcontent.SaveChanges();//remove effect to the database
            }
            return RedirectToAction("List");
        }

        public IActionResult Edit(string id)
        {
            CourseViewModel courseViewModel = _applicationDbcontent.Courses
                .Where(w => w.Id == id)
                .Select(s => new CourseViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    OpeningDate = s.OpeningDate,
                    DurationInHour = s.DurationInHour,
                    Fees = s.Fees
                }).SingleOrDefault();
            return View(courseViewModel);
        }

        [HttpPost]
        public IActionResult Edit(CourseViewModel courseViewModel)
        {
            bool isSuccess = false;
            try
            {
                Course course = new Course();
                //audit columns
                course.Id = courseViewModel.Id;
                course.ModifiedDate = DateTime.Now;
                course.Ip = GetLocalIPAddress();

                //ui columns
                course.Name = courseViewModel.Name;
                course.Description = courseViewModel.Description;
                course.OpeningDate = courseViewModel.OpeningDate;
                course.DurationInHour = courseViewModel.DurationInHour;
                course.Fees = courseViewModel.Fees;
                _applicationDbcontent.Entry(course).State = EntityState.Modified;//Updating the existing records in DBSet
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
