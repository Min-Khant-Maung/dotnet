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
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _applicationDbcontent;
        //Constructore injection
        public StudentController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }



        public IActionResult Entry()
        {
            IList<BatchViewModel> batches = _applicationDbcontent.Batches.Select
                      (c => new BatchViewModel
                      {
                          Id = c.Id,
                          Name = c.Name,
                          Description = c.Description
                      }).ToList();
            return View(batches);
        }
        [HttpPost]
        public IActionResult Entry(StudentViewModel studentViewModel)
        {
            bool isSuccess = false;
            try
            {
                Student student = new Student();
                //audit columns
                student.Id = Guid.NewGuid().ToString();
                student.CreatedDate = DateTime.Now;
                student.Ip = GetLocalIPAddress();

                //ui columns
                student.Code = studentViewModel.Code;
                student.Name = studentViewModel.Name;
                student.DOB = studentViewModel.DOB;
                student.FatherName = studentViewModel.FatherName;
                student.Email = studentViewModel.Email;
                student.Phone = studentViewModel.Phone;
                student.Address = studentViewModel.Address;
                student.NRC = studentViewModel.NRC;
                student.FatherName = studentViewModel.FatherName;
                student.BatchId = studentViewModel.BatchId;
                _applicationDbcontent.Students.Add(student);//Ading the records Students DBSet
                _applicationDbcontent.SaveChanges();//Saving the records to the database
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


        // ko pine yay
        //public IActionResult List()
        //{
        //    // Ask Ko Kyaing why i cant use Where method instead of select method
        //   










        //IList<StudentViewModel> students = _applicationDbcontent.Students.Where(s => s.FatherName == "U Ba").sel; new StudentViewModel
        //{
        //    Address = s.Address,
        //    Name = s.Name
        //}).ToList();
        //    return View(students);
 

    public IActionResult List()
        {
            IList<StudentViewModel> stus = _applicationDbcontent.Students.Select
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
                      DOB = s.DOB,
                      BatchName=s.Batch.Name
                  }).ToList();
            return View(stus);
        }

        public IActionResult Delete(string id)
        {
            Student student = _applicationDbcontent.Students.Find(id);
            if (student != null)
            {
                _applicationDbcontent.Students.Remove(student);//remove the student record from DBset
                _applicationDbcontent.SaveChanges();//remove effect to the database
            }
            return RedirectToAction("List");
        }

        public IActionResult Edit(string id)
        {
            StudentViewModel studentViewModel = _applicationDbcontent.Students
                .Where(w => w.Id == id)
                .Select(s => new StudentViewModel
                {
                    Code = s.Code,
                    Id = s.Id,
                    Name = s.Name,
                    Email= s.Email,
                    Phone=s.Phone,
                    Address=s.Address,
                    NRC=s.NRC,
                    DOB=s.DOB,
                    FatherName=s.FatherName,
                    BatchId = s.BatchId

                }).SingleOrDefault();

            ViewBag.Batches = _applicationDbcontent.Batches.Select(s => new SelectListItem
            {
                Value = s.Id,
                Text = s.Name
            }).ToList();
            return View(studentViewModel);
        }
        [HttpPost]
        public IActionResult Edit(StudentViewModel studentViewModel)
        {
            bool isSuccess = false;
            try
            {
                Student student = new Student();
                //audit columns
                student.Id = studentViewModel.Id;
                student.ModifiedDate = DateTime.Now;
                student.Ip = GetLocalIPAddress();

                //ui columns
                student.Code = studentViewModel.Code;
                student.Name = studentViewModel.Name;
                student.DOB = studentViewModel.DOB;
                student.FatherName = studentViewModel.FatherName;
                student.Email = studentViewModel.Email;
                student.Phone = studentViewModel.Phone;
                student.Address = studentViewModel.Address;
                student.NRC = studentViewModel.NRC;
                student.FatherName = studentViewModel.FatherName;
                _applicationDbcontent.Entry(student).State=EntityState.Modified;//Updating the existing records in DBSet
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

        //finding 
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
