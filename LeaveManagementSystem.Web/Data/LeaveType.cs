﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int NumberOfDays { get; set; }
    }
}
