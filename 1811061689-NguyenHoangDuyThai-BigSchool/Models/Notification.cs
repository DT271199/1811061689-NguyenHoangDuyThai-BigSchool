using System;

namespace _1811061689_NguyenHoangDuyThai_BigSchool.Models
{
    public class Notification
    {
        public DateTime DateTime { get; internal set; }
        public Course Course { get; internal set; }
        public NotificationType Type { get; internal set; }
    }
}