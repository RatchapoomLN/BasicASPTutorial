# BasicASPTutorial
ASP.NET Core MVC (.NET 7) | ระบบบันทึก/ลบ คะแนนนักเรียน

## ข้อมูลนี้ ถูกนำมาจาก ช่อง Youtube KongRuksiam Official ไม่มีการตั้งใจลอกเลียนแบบ หรือ คัดลอกมาเพื่อใช้ประโยชน์เชิงพาณิชย์แต่อย่างใด!
- [ดูคลิปกดเลย](https://youtu.be/U77ayrSIrHs)

## 🎓 พื้นฐานที่ต้องเรียนมาก่อน (ฟรี)
- [HTML5](https://www.youtube.com/watch?v=0hfeNPM7piw&list=PLltVQYLz1BMDf-N2ZmyJKEv4VlpM_9m67)
- [CSS3](https://www.youtube.com/watch?v=HcInSUzhaUc&list=PLltVQYLz1BMBeWsNwB06VT3t8m5575qCP)
- [JavaScript](https://www.youtube.com/watch?v=AbjY-ajKgSI&list=PLltVQYLz1BMDsB7SrMh8x6uDTfl7LdNlP)
- [Bootstrap 5](https://www.youtube.com/watch?v=El7FovOjfjE&list=PLltVQYLz1BMDNdxqTqiOm-D2CN3J2PF-F)
- [C# เบื้องต้น](https://www.youtube.com/playlist?list=PLltVQYLz1BMAq2fsXLKzGS1eFNxl0-z0I)
- [เขียนโปรแกรมเชิงวัตถุ (OOP) ด้วย C#](https://www.youtube.com/playlist?list=PLltVQYLz1BMAkJNArwlMybfNpjW8lfSfZ)
- [SQL](https://www.youtube.com/watch?v=sgQiJ-8Ra8c&list=PLltVQYLz1BMAP6veiejiMdwX7J9GqmkZS)

## 🎯 เครื่องมือที่ใช้
- [Visual Studio Community 2022](https://visualstudio.microsoft.com/)
- [SQL Server 2022](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

## 💯 ขั้นตอน
- สร้างโปรเจค ASP.NET Core Web App (Model-View-Controller)
- โหลด Nuget Package Tools > Nuget Package Manager > Nuget Package for Solution > Browse


## 💎 Connection Strings
"ConnectionStrings": { "DefaultConnection": "Server=ชื่อ Sever;
					     Database=ชื่อฐานข้อมูล;
					     Trusted_Connection=True;
					     TrustServerCertificate=True" }

## 🎨 Nuget Package
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer

## 👨‍💻 Package Manager Console (PM Command)
- add-migration
- update-database
