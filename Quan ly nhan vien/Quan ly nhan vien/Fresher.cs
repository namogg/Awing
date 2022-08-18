using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Quan_ly_nhan_vien
{
    public class Fresher : Employee
    {

        public string Graduation_rank { get; set; }
        public string Education { get; set; }
        public DateTime Graduation_date { get; set; }
        public Fresher()
        {
        }
        public Fresher(string name, string Room, string Gender, string Adress, DateTime birth, string graduation_rank, string education, DateTime graduation_date, List<Certificate> c)
        {
            Name = name;
            room = Room;
            gender = Gender;
            adress = Adress;
            Birth = birth;
            Graduation_date = graduation_date;
            Graduation_rank = graduation_rank;
            Education = education;
            LISTCertificates = c;
        }
        public void Show(Fresher e)
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
            Console.Write("Xep hang tot nghiep ");
            Console.WriteLine(e.Graduation_rank);
            Console.Write("Truong tot nghiep: ");
            Console.WriteLine(e.Education);
            Console.Write("Ngay tot nghiep: ");
            Console.WriteLine(e.Graduation_date);

            Certificate.show(e.LISTCertificates);
        }
        
        
        public Fresher input_NV()
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
            Console.WriteLine("Nhap ngay tot nghiep:");
            DateTime Graduation_date = program.input_date();
            Console.WriteLine("Nhap xep hang tot nghiep:");
            string Graduation_rank = Console.ReadLine();
            Console.WriteLine("Nhap truong tot nghiep:");
            string Education = Console.ReadLine();
            List<Certificate> L = Certificate.Input_Certificates();
            return new Fresher(Name, room, gender, adress, Birth, Graduation_rank, Education, Graduation_date, L);
        }
    }
}
