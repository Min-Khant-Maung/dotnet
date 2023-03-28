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
    public class TeacherReportController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ApplicationDbContext _applicationDbContext;

        public TeacherReportController(IWebHostEnvironment webHostEnvironment, ApplicationDbContext applicationDbContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            _applicationDbContext = applicationDbContext;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
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
            parameters.Add("rp1", $"From Code:{FromCode} To Code :{ToCode}");
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
            localReport.AddDataSource("DsStudentDetail", teachers);
            var result = localReport.Execute(RenderType.Pdf, 1, parameters, null);
            return File(result.MainStream, "application/pdf");
        }
    }
}
