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
    public class BatchController : Controller
    {
        private readonly ApplicationDbContext _applicationDbcontent;
        //Constructore injection
        public BatchController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }
        public IActionResult Entry()
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

        [HttpPost]
        public IActionResult Entry(BatchViewModel batchViewModel)
        {
            bool isSuccess = false;
            try
            {
                Batch batch = new Batch();
                //audit columns
                batch.Id = Guid.NewGuid().ToString();
                batch.CreatedDate = DateTime.Now;
                batch.Ip = GetLocalIPAddress();

                //ui columns
                batch.Name = batchViewModel.Name;
                batch.Description = batchViewModel.Description;
                batch.CourseId = batchViewModel.CourseId;
                
                _applicationDbcontent.Batches.Add(batch);//Ading the records Students DBSet
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
            IList<BatchViewModel> batches = _applicationDbcontent.Batches.Select(bb => new BatchViewModel
            {
                Id = bb.Id,
                Name = bb.Name,
                Description = bb.Description,
                CourseName = bb.Course.Name
            }).ToList();
            return View(batches);
        }

        public IActionResult Delete(string id)
        {
            Batch batch = _applicationDbcontent.Batches.Find(id);
            if (batch != null)
            {
                _applicationDbcontent.Batches.Remove(batch);//remove the student record from DBset
                _applicationDbcontent.SaveChanges();//remove effect to the database
            }
            return RedirectToAction("List");
        }

        public IActionResult Edit(string id)
        {
            BatchViewModel batchViewModel = _applicationDbcontent.Batches
                .Where(w => w.Id == id)
                .Select(s => new BatchViewModel
                {
                    
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    CourseId = s.CourseId,
                    CourseName = s.Course.Name
                }).SingleOrDefault();

            ViewBag.CourseList = _applicationDbcontent.Courses.Where(x=>x.Id!=batchViewModel.CourseId)
                .Select(s => new SelectListItem
            {
                Value = s.Id,
                Text = s.Name
            }).ToList();

            return View(batchViewModel);
        }

        [HttpPost]
        public IActionResult Edit(BatchViewModel batchViewModel)
        {
            bool isSuccess = false;
            try
            {
                Batch batch = new Batch();
                //audit columns
                batch.Id = batchViewModel.Id;
                batch.ModifiedDate = DateTime.Now;
                batch.Ip = GetLocalIPAddress();

                //ui columns
                
                batch.Name = batchViewModel.Name;
                batch.Description = batchViewModel.Description;

                _applicationDbcontent.Entry(batch).State = EntityState.Modified;//Updating the existing records in DBSet
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
