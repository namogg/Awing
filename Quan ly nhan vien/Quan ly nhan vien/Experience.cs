using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Quan_ly_nhan_vien
{
    public class Experience: Employee
    {
        public int ExpInYear { get; set; }
        public string ProSkill { get; set; }
        public void Show(Experience e)
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
            Console.Write("So nam kinh nghiem: ");
            Console.WriteLine(e.ExpInYear);
            Console.Write("Professional skill: ");
            Console.WriteLine(e.ProSkill);
            Console.WriteLine("==============================");
            Certificate c = new Certificate();
            c.show(e.LISTCertificates);
        }
        public Experience()
        {
        }
        public Experience(string name, string Room, string Gender, string Adress, DateTime birth,int exp,string pro,List<Certificate> c)
        {
            Name = name;
            base.Room = Room;
            base.Gender = Gender;
            base.Adress = Adress;
            Birth = birth;
            ExpInYear = exp;
            ProSkill = pro;
            LISTCertificates = c
;       }
        public Experience InputEmployee()
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
            Console.WriteLine("Nhap so nam kinh nghiemn:");
            int ExpInYear = inputcheck.input_exprience_years();
            Console.WriteLine("Nhap ki nang:");
            string ProSkill = Console.ReadLine();
            List<Certificate> L = Certificate.InputCertificates();
            return new Experience(Name, room, gender, adress, Birth, ExpInYear, ProSkill, L);
        }
        public Experience InputEmployee(int ExpInYear)
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
            Console.WriteLine("Nhap ki nang:");
            string ProSkill = Console.ReadLine();
            List<Certificate> L = Certificate.InputCertificates();
            return new Experience(Name, room, gender, adress, Birth, ExpInYear, ProSkill, L);
        }
    }
}
