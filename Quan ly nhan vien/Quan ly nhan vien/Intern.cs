using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Quan_ly_nhan_vien
{
    public class Intern : Employee
    {
        public string Majors { get; set; }
        public string Semester { get; set; }
        public string UniversityName { get; set; }
        //In ra thong tin nhan vien 
        public void Show(Intern e)
        {
            Console.Write("Ten: ");
            Console.WriteLine(e.Name);
            Console.Write("Phong: ");
            Console.WriteLine(e.Room);
            Console.Write("Gioi tinh: ");
            Console.WriteLine(e.Gender);
            Console.Write("Dia chi: ");
            Console.WriteLine(e.Adress);
            Console.Write("Ngay thang nam sinh: ");
            Console.WriteLine(e.Birth);
            Console.Write("Khoa: ");
            Console.WriteLine(e.Majors);
            Console.Write("Ki hoc ");
            Console.WriteLine(e.Semester);
            Console.Write("Ten truong dai hoc ");
            Console.WriteLine(e.UniversityName);
            Console.WriteLine("==============================");
            Certificate c = new Certificate();
            c.show(e.LISTCertificates);
        }
        public Intern()
        {
        }
        public Intern(string name, string Room, string Gender, string Adress, DateTime birth, string majors, string semester, string university_name, List<Certificate> c)
        {
            Name = name;
            base.Room = Room;
            base.Gender = Gender;
            base.Adress = Adress;
            Birth = birth;
            Majors = majors;
            Semester = semester;
            UniversityName = university_name;
            LISTCertificates = c;
        }
        // Nhap thong tin cho nhan vien moi
        public Intern InputEmployee()
        {
            Console.WriteLine("Nhap ten:");
            string Name = Console.ReadLine();
            Console.WriteLine("Nhap ten phong:");
            string room = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh:");
            string gender = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:");
            string adress = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh:");
            DateTime Birth = inputcheck.InputDate();
            Console.WriteLine("Nhap khoa:");
            string Majors = Console.ReadLine();
            Console.WriteLine("Nhap khoa hoc:");
            string Semester = Console.ReadLine();
            Console.WriteLine("Nhap truong dai hoc:");
            string University_name = Console.ReadLine();
            List<Certificate> L = Certificate.InputCertificates();
            return new Intern(Name, room, gender, adress, Birth, Majors, Semester, University_name, L);
        }
    }
}
