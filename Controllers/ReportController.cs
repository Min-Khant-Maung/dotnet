using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SFMS.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.Reporting;
using SFMS.ReportHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SFMS.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ApplicationDbContext _applicationDbContext;
        
        public ReportController(IWebHostEnvironment webHostEnvironment,ApplicationDbContext applicationDbContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            _applicationDbContext = applicationDbContext;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public IActionResult StudentDetail()
        {
            IList<StudentDetail> students = _applicationDbContext.Students.Select(s => new StudentDetail
            {
                Code = s.Code
            }).OrderBy(o => o.Code).ToList();
            return View(students);
        }

        public IActionResult StudentDetailFromCodeToCode(string FromCode,string ToCode)
        {
            var rdlcFilePath = $"{webHostEnvironment.WebRootPath}\\Reports\\StudentDetailRDLC.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("rp1", $"From Code:{FromCode} To Code :{ToCode}");
            LocalReport localReport = new LocalReport(rdlcFilePath);
            IList<StudentDetail> students = _applicationDbContext.Students.Where(x => x.Code.CompareTo(FromCode) >= 0 &&
             x.Code.CompareTo(ToCode) <= 0).Select(s => new StudentDetail
             {
                 Code = s.Code,
                 Name = s.Name,
                 Email = s.Email,
                 Address = s.Address,
                 Phone = s.Phone,
                 FatherName = s.FatherName,
                 NRC = s.NRC,
                 DOB = s.DOB
             }).OrderBy(o => o.Code).ToList();
            localReport.AddDataSource("DsStudentDetail", students);
            var result = localReport.Execute(RenderType.Pdf, 1, parameters, null);
            return File(result.MainStream,"application/pdf");
        }

        public IActionResult TeacherDetail()
        {
            IList<TeacherDetail> teachers = _applicationDbContext.TeachersInfo.Select(s => new TeacherDetail
            {
                Name = s.Name
            }).OrderBy(o => o.Name).ToList();
            return View(teachers);
        }

        public IActionResult TeacherDetailFromCodeToCode(string FromCode, string ToCode)
        {
            var rdlcFilePath = $"{webHostEnvironment.WebRootPath}\\Reports\\TeacherDetailRDLC.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Rp1", $"From Code:{FromCode} To Code :{ToCode}");
            LocalReport localReport = new LocalReport(rdlcFilePath);
            IList<TeacherDetail> teachers = _applicationDbContext.TeachersInfo.Where(x => x.Name.CompareTo(FromCode) >= 0 &&
             x.Name.CompareTo(ToCode) <= 0).Select(s => new TeacherDetail
             {
                 Name = s.Name,
                 Email = s.Email,
                 Position = s.Position,
                 Address = s.Address,
                 Phone = s.Phone
             }).OrderBy(o => o.Name).ToList();
            localReport.AddDataSource("DsTeacherDetail", teachers);
            var result = localReport.Execute(RenderType.Pdf, 1, parameters, null);
            return File(result.MainStream, "application/pdf");
        }
    }
}
