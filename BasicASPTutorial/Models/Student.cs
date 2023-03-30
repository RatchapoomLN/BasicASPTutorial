﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Models
{
    //รับตัวแปรผ่านคีย์บอร์ดมาตรวจเช็คก่อนส่งต่อ
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="กรุณาป้อนชื่อนักเรียน")]
        [DisplayName("ชื่อนักเรียน")]
        public string Name { get; set; }

        [DisplayName("คะแนนสอบ")]
        [Range(0,100,ErrorMessage ="กรุณาป้อนคะแนนสอบในช่วง 1-100")]
        public int Score { get; set; }
    }
}
