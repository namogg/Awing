using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public class FresherExp : Fresher
    {
        public DateTime Workdate { get; set; }
        public int total_worktime
        {
            get { return (ExpInYears + (DateTime.Now.Year - Workdate.Year +1)); }
            set { value = ExpInYears + (DateTime.Now - Workdate).Days; }
        }

        public FresherExp()
        {
            Workdate = DateTime.Now;
        }
        public FresherExp(string name, string Room, string Gender, string Adress, DateTime birth, string graduation_rank, string education, DateTime graduation_date, int exp, DateTime workdate, List<Certificate> c)
        {
            Name = name;
            base.Room = Room;
            base.Gender = Gender;
            base.Adress = Adress;
            Birth = birth;
            Graduation_date = graduation_date;
            Graduation_rank = graduation_rank;
            Education = education;
            LISTCertificates = c;
            ExpInYears = exp;
            Workdate = workdate;
        }
        public FresherExp InputEmployee()
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
            Console.WriteLine("Nhap ngay tot nghiep:");
            DateTime Graduation_date = inputcheck.InputDate();
            Console.WriteLine("Nhap xep hang tot nghiep:");
            string Graduation_rank = Console.ReadLine();
            Console.WriteLine("Nhap truong tot nghiep:");
            string Education = Console.ReadLine();
            Console.WriteLine("Nhap ngay bat dau lam viec");
            DateTime workdate = inputcheck.InputDate();
            Console.WriteLine("Nhap so nam kinh nghiem");
            int exp = inputcheck.InputNumber();
            List<Certificate> L = Certificate.InputCertificates();
            return new FresherExp(Name, room, gender, adress, Birth, Graduation_rank, Education, Graduation_date, exp,workdate,L);
        }
        public FresherExp InputEmployee(int exp)
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
            Console.WriteLine("Nhap ngay tot nghiep:");
            DateTime Graduation_date = inputcheck.InputDate();
            Console.WriteLine("Nhap xep hang tot nghiep:");
            string Graduation_rank = Console.ReadLine();
            Console.WriteLine("Nhap truong tot nghiep:");
            string Education = Console.ReadLine();
            Console.WriteLine("Nhap ngay bat dau lam viec");
            DateTime workdate = inputcheck.InputDate();
            Console.WriteLine("Nhap so nam kinh nghiem");
            List<Certificate> L = Certificate.InputCertificates();
            return new FresherExp(Name, room, gender, adress, Birth, Graduation_rank, Education, Graduation_date, exp , workdate, L);
        }
        public void Show(FresherExp e)
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
            Console.Write("Xep hang tot nghiep ");
            Console.WriteLine(e.Graduation_rank);
            Console.Write("Truong tot nghiep: ");
            Console.WriteLine(e.Education);
            Console.Write("Ngay tot nghiep: ");
            Console.WriteLine(e.Graduation_date);
            Console.Write("So nam kinh nghiem: ");
            Console.WriteLine(e.ExpInYears);
            Console.Write("Bat dau lam viec tu: ");
            Console.WriteLine(e.Workdate);
            Certificate c = new Certificate();
            c.show(e.LISTCertificates);
        }
    }
}
