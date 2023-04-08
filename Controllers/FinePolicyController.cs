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
    public class FinePolicyController : Controller
    {
        private readonly ApplicationDbContext _applicationDbcontent;
        //Constructore injection
        public FinePolicyController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontent = applicationDbContext;
        }
        public IActionResult Entry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entry(FinePolicyViewModel finePolicyViewModel)
        {
            bool isSuccess = false;
            try
            {
                FinePolicy finePolicy = new FinePolicy();
                //audit columns
                finePolicy.Id = Guid.NewGuid().ToString();
                finePolicy.CreatedDate = DateTime.Now;
                finePolicy.Ip = GetLocalIPAddress();

                //ui columns
                finePolicy.Name = finePolicyViewModel.Name;
                finePolicy.Rule = finePolicyViewModel.Rule;
                finePolicy.FineAmount = finePolicyViewModel.FineAmount;
                finePolicy.FineAfterMinutes = finePolicyViewModel.FineAfterMinutes;
                _applicationDbcontent.FinePolicies.Add(finePolicy);//Ading the records Students DBSet
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
