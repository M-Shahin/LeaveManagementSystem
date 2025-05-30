﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4, 150, ErrorMessage ="Name should be between 4 to 150 characters")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1, 90)]
        [Display(Name = "Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}
