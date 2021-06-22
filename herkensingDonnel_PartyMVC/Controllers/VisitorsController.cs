using herkensingDonnel_PartyMVC.PartyMVCLibrary.Interfaces;
using herkensingDonnel_PartyMVC.PartyMVCLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herkensingDonnel_PartyMVC.Controllers
{
    public class VisitorsController : Controller
    {
       
            private readonly IVisitorRepository _repo;
            public VisitorsController(IVisitorRepository repo)
            {
                _repo = repo;
            }
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(Visitor visitor)
            {
                try
                {
                    _repo.AddVisitor(visitor);
                    ModelState.Clear();
                    return View();
                }
                catch
                {
                    return View();
                }
            }
            [HttpGet]
            public IActionResult Summary()
            {
                ViewBag.TotalGuests = _repo.TotalMembers();
                ViewBag.TotalFamilyGuests = _repo.TotalFamilyMembers();
                ViewBag.YoungestAge = _repo.YoungestMember();
                ViewBag.OldestAge = _repo.OldestMember();
                return View();
            }
        }

    
}
