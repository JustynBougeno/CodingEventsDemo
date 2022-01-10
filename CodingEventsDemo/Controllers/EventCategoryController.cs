using System;
using System.Collections.Generic;
using System.Linq;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;

        }

        public IActionResult Index()
        {
            List<EventCategory> eventCategories = context.EventCategories.ToList();

            return View(eventCategories);
        }

        private IActionResult View(List<Event> events)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/EventCategory/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/EventCategory/Table")]
        public IActionResult ProcessCreateEventCategoryForm()
        {
            return View();
        }
