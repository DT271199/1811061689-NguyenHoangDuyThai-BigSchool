using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
// commit ngày 21/3/2022
namespace _1811061689_NguyenHoangDuyThai_BigSchool.Models
{
    public class Course
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public bool IsCanceLed { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }

    
}