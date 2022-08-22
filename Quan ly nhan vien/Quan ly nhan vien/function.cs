using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public class function
    {
        public static void show_Employee(List<Employee> e)
        {
            Console.WriteLine("==============================");
            for (int i = 0; i < e.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + e[i].Name);
            }
        }
        //Ham them nhan vien
        public static void Add_Employee(ref List<Employee> employees_List)
        {
            Console.Clear();
            int n;
            Console.WriteLine("Nhap tuy chon");
            Console.WriteLine("1: Nhan vien Fresher");
            Console.WriteLine("2: Nhan vien Intern");
            Console.WriteLine("3: Nhan vien Experience");
            Console.WriteLine("==============================");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Fresher_exp e = new Fresher_exp();
                    employees_List.Add(e.input_Employee());
                    break;
                case 2:
                    Intern I = new Intern();
                    employees_List.Add(I.input_Employee());
                    break;
                case 3:
                    Experience E = new Experience();
                    employees_List.Add(E.input_Employee());
                    break;
                default:
                    return;
            }
            Console.WriteLine("Them thanh cong nhan vien");
        }
        //Ham xoa nhan vien
        public static void Delete_Employee( ref List<Employee> employees_List)
        {
            Console.Clear();
            show_Employee(employees_List);
            Console.WriteLine("Xoa nhan vien thu:");
            int n = inputcheck.input_num();
            if (n > employees_List.Count || n <= 0)
            {
                Console.WriteLine("So thu tu khong hop le");
                return;
            }
            employees_List.RemoveAt(n - 1);
            Console.WriteLine("Xoa thanh cong");
        }
        //Ham update nhan vien
        public static void Update_Employee(ref List<Employee> employees_List)
        {
            show_Employee(employees_List);
            Console.WriteLine("Update nhan vien thu:");
            int i = inputcheck.input_num();
            if (i > employees_List.Count || i <= 0)
            {
                Console.WriteLine("So thu tu khong hop le");
                return;
            }
            if (employees_List[i - 1] is Fresher)
            {
                Fresher e = new Fresher();
                employees_List[i - 1] = e.input_Employee();
                return;
            }
            if (employees_List[i - 1] is Intern)
            {
                Intern e = new Intern();
                employees_List[i - 1] = e.input_Employee();
                return;
            }
            if (employees_List[i - 1] is Experience)
            {
                Intern e = new Intern();
                employees_List[i - 1] = e.input_Employee();
                return;
            }
        }
        //Ham in nhan vien theo so thu tu 
        public static void Print_Employee(List<Employee> employees_List)
        {
            Console.WriteLine("Nhap so thu tu cua nhan vien ban muon hien thi thong tin");
            int i = inputcheck.input_num();
            if (i > employees_List.Count || i <= 0)
            {
                Console.WriteLine("So thu tu khong hop le");
                return;
            }
            Console.Clear();
            if (employees_List[i - 1] is Fresher)
            {
                ((Fresher_exp)employees_List[i - 1]).Show((Fresher_exp)employees_List[i - 1]);
            }
            if (employees_List[i - 1] is Intern)
                ((Intern)employees_List[i - 1]).Show((Intern)employees_List[i - 1]);
            if (employees_List[i - 1] is Experience)
                ((Experience)employees_List[i - 1]).Show((Experience)employees_List[i - 1]);
        }
        public static void promote_employee(ref List<Employee> e)
        {
            Console.WriteLine("=============Danh sach nhan vien duoc thang chuc=================");
            for (int i = 0; i < e.Count; i++)
            {   if (e[i] is Fresher_exp) 
                {
                    Fresher_exp f = (Fresher_exp)(Fresher)e[i];
                    if (f.total_worktime >= 5)
                    {   
                        Console.WriteLine(i + 1 + "." + f.Name +" || So nam kinh nghiem:" +f.total_worktime);
                        Console.WriteLine("Nhap ki nang chuyen mon cho nhan vien:");
                        string pro_skill = Console.ReadLine();
                        e[i] = new Experience(f.Name, f.room, f.gender, f.adress, f.Birth, f.total_worktime, pro_skill, f.LISTCertificates); 
                    }
                }
            }
        }
    }
}
