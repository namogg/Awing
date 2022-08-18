using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Quan_ly_nhan_vien
{
    public class Intern : Employee
    {
        [StringLength(30, MinimumLength = 1)]
        [Required]
        public string Majors { get; set; }
        [StringLength(30, MinimumLength = 1)]
        [Required]
        public string Semester { get; set; }
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string University_name { get; set; }
        //In ra thong tin nhan vien 
        public void Show(Intern e)
        {
            Console.Write("Ten: ");
            Console.WriteLine(e.Name);
            Console.Write("Phong: ");
            Console.WriteLine(e.room);
            Console.Write("Gioi tinh: ");
            Console.WriteLine(e.gender);
            Console.Write("Dia chi: ");
            Console.WriteLine(e.adress);
            Console.Write("Ngay thang nam sinh: ");
            Console.WriteLine(e.Birth);
            Console.Write("Khoa: ");
            Console.WriteLine(e.Majors);
            Console.Write("Ki hoc ");
            Console.WriteLine(e.Semester);
            Console.Write("Ten truong dai hoc ");
            Console.WriteLine(e.University_name);
            Console.WriteLine("==============================");
            Certificate.show(e.LISTCertificates);
        }
        public Intern()
        {
        }
        public Intern(string name, string Room, string Gender, string Adress, DateTime birth, string majors, string semester, string university_name, List<Certificate> c)
        {
            Name = name;
            room = Room;
            gender = Gender;
            adress = Adress;
            Birth = birth;
            Majors = majors;
            Semester = semester;
            University_name = university_name;
            LISTCertificates = c;
        }
        // Nhap thong tin cho nhan vien moi
        public Intern input_NV()
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
            DateTime Birth = program.input_date();
            Console.WriteLine("Nhap khoa:");
            string Majors = Console.ReadLine();
            Console.WriteLine("Nhap khoa hoc:");
            string Semester = Console.ReadLine();
            Console.WriteLine("Nhap truong dai hoc:");
            string University_name = Console.ReadLine();
            List<Certificate> L = Certificate.Input_Certificates();
            return new Intern(Name, room, gender, adress, Birth, Majors, Semester, University_name, L);
        }
    }
}
