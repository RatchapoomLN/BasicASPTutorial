using BasicASPTutorial.Data;
using BasicASPTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicASPTutorial.Controllers
{
    public class StudentController : Controller
    {
        //เชื่อมฐานข้อมูล
        private readonly ApplicationDBContext _db;
        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }
        //นำข้อมูลส่งกลับจากฐานข้อมูลไป Index (หน้าหลัก) เพื่อเตรียมแสดงผล
        public IActionResult Index()
        {
            /*Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "ก้อย";
            s1.Score = 100;
            var s2 = new Student();
            s2.Id = 2;
            s2.Name = "จี้จี้";
            s2.Score = 80;
            var s3 = new Student();
            s3.Id = 3;
            s3.Name = "ท็อป";
            s3.Score = 45;

            List<Student> allStudent = new List<Student>();
            allStudent.Add(s1);
            allStudent.Add(s2);
            allStudent.Add(s3);*/
            IEnumerable <Student> allStudent = _db.Students;
            return View(allStudent);
        }
        // GET METHOD
        public IActionResult Create()
        {
            return View();
        }
        //สร้าง รับข้อมูลมาเข้าฐานข้อมูล
        [HttpPost]
        public IActionResult Create(Student obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //ตรวจเช็คตัวแปร ID ก่อนส่งไปแก้ไขข้อมูลของ ID นั้นๆ
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // แก้ไข รับข้อมูลมาเข้าฐานข้อมูล
        [HttpPost]
        public IActionResult Edit(Student obj)
        {

            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //ตรวจสอบ ID ที่จะนำมาลบ
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            //ลบ ข้อมูล และ บันทึกเข้าฐานข้อมูล
            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
