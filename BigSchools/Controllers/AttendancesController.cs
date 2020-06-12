﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using BigSchools.Models;
using Microsoft.AspNet.Identity;
using BigSchools.DTOs;

namespace BigSchools.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto adto)
        {            
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendences.Any(a => a.AttendeeId == userId && a.CourseId == adto.CourseId))
                return BadRequest("The Attendances are already exists");
            var attendence = new Attendance
            {
                CourseId = adto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendences.Add(attendence);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}

