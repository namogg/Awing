using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public class Fresher_exp : Fresher
    {
        public DateTime Workdate { get; set; }
        public int Exp_Years { get; set; }
        public int total_worktime
        {
            get { return (Exp_Years + (DateTime.Now.Year - Workdate.Year +1)); }
            set { value = Exp_Years + (DateTime.Now - Workdate).Days; }
        }

        public Fresher_exp()
        {
            Exp_Years = 0;
            Workdate = DateTime.Now;
        }
        public Fresher_exp(Fresher fresher,int exp, DateTime workdate) : base(fresher)
        {
            Exp_Years = exp;
            Workdate = workdate;
        }
        public Fresher_exp(string name, string Room, string Gender, string Adress, DateTime birth, string graduation_rank, string education, DateTime graduation_date, int exp, DateTime workdate, List<Certificate> c)
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
            Exp_Years = exp;
            Workdate = workdate;
        }
        public Fresher_exp input_Employee()
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
            DateTime Birth = inputcheck.input_date();
            Console.WriteLine("Nhap ngay tot nghiep:");
            DateTime Graduation_date = inputcheck.input_date();
            Console.WriteLine("Nhap xep hang tot nghiep:");
            string Graduation_rank = Console.ReadLine();
            Console.WriteLine("Nhap truong tot nghiep:");
            string Education = Console.ReadLine();
            Console.WriteLine("Nhap ngay bat dau lam viec");
            DateTime workdate = inputcheck.input_date();
            Console.WriteLine("Nhap so nam kinh nghiem");
            int exp = inputcheck.input_num();
            List<Certificate> L = Certificate.Input_Certificates();
            Fresher fresher = new Fresher(Name, room, gender, adress, Birth, Graduation_rank, Education, Graduation_date, L);
            return new Fresher_exp(fresher, exp,workdate);
        }
        public void Show(Fresher_exp e)
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
            Console.Write("So nam kinh nghiem: ");
            Console.WriteLine(e.Exp_Years);
            Console.Write("Bat dau lam viec tu: ");
            Console.WriteLine(e.Workdate);
            Certificate c = new Certificate();
            c.show(e.LISTCertificates);
        }
    }
}
