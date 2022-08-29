using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public class function
    {
        public static void ShowEmployee(List<Employee> e)
        {
            Console.WriteLine("==============================");
            for (int i = 0; i < e.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + e[i].Name);
            }
        }
        //Ham them nhan vien
        public void AddEmployee(ref List<Employee> EmployeesList)
        {
            int n;
            Console.WriteLine("Nhap tuy chon");
            Console.WriteLine("1: Nhan vien chinh thuc");
            Console.WriteLine("2: Nhan vien Intern");
            Console.WriteLine("==============================");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    InputOfficialEmployee(ref EmployeesList);
                    break;
                case 2:
                    Intern I = new Intern();
                    EmployeesList.Add(I.InputEmployee());
                    break;
                default:
                    return;
            }
            Console.WriteLine("Them thanh cong nhan vien");
        }
        public void InputOfficialEmployee(ref List<Employee> EmployeesList)
        {
            Console.WriteLine("Nhap so nam kinh nghiem");
            int Exp = inputcheck.InputNumber();
            if (Exp < program.require_years)
            {   
                FresherExp e = new FresherExp();
                e.ExpInYears = Exp;
                EmployeesList.Add(e.InputEmployee(Exp));
                return;
            } else
            {
                Experience E = new Experience();
                E.ExpInYear = Exp;
                EmployeesList.Add(E.InputEmployee(Exp));
                return;
            }
        }
        //Ham xoa nhan vien
        public bool DeleteEmployee( ref List<Employee> employees_List)
        {
            ShowEmployee(employees_List);
            if(employees_List.Count == 0)
            {
                Console.WriteLine("Danh sach rong");
                return true;
            }
            Console.WriteLine("Xoa nhan vien thu:");
            int n = inputcheck.InputNumber();
            if (n > employees_List.Count || n <= 0)
            {
                Console.WriteLine("So thu tu khong hop le");
                return false;
            }
            employees_List.RemoveAt(n - 1);
            Console.WriteLine("Xoa thanh cong");
            return true;
        }
        //Ham update nhan vien
        public void UpdateEmployee(ref List<Employee> employees_List)
        {
            ShowEmployee(employees_List);
            Console.WriteLine("Update nhan vien thu:");
            int i = inputcheck.InputNumber();
            if (i > employees_List.Count || i <= 0)
            {
                Console.WriteLine("So thu tu khong hop le");
                return;
            }
            if (employees_List[i - 1] is Fresher)
            {
                Fresher e = new Fresher();
                employees_List[i - 1] = e.InputEmployee();
                return;
            }
            if (employees_List[i - 1] is Intern)
            {
                Intern e = new Intern();
                employees_List[i - 1] = e.InputEmployee();
                return;
            }
            if (employees_List[i - 1] is Experience)
            {
                Intern e = new Intern();
                employees_List[i - 1] = e.InputEmployee();
                return;
            }
        }
        //Ham in nhan vien theo so thu tu 
        public void PrintEmployee(List<Employee> employees_List)
        {
            Console.WriteLine("Nhap so thu tu cua nhan vien ban muon hien thi thong tin");
            int i = inputcheck.InputNumber();
            if (i > employees_List.Count || i <= 0)
            {
                Console.WriteLine("So thu tu khong hop le");
                return;
            }
            if (employees_List[i - 1] is FresherExp)
            {   
                ((FresherExp)employees_List[i - 1]).Show((FresherExp)employees_List[i - 1]);
            }
            if (employees_List[i - 1] is Intern)
                ((Intern)employees_List[i - 1]).Show((Intern)employees_List[i - 1]);
            if (employees_List[i - 1] is Experience)
                ((Experience)employees_List[i - 1]).Show((Experience)employees_List[i - 1]);
        }
        public void PromoteEmployee(ref List<Employee> e)
        {
            int count = 0;
            for (int i = 0; i < e.Count; i++)
            {   if (e[i] is FresherExp) 
                {
                    FresherExp f = (FresherExp)(Fresher)e[i];
                    //Total_EXP = EXP + Work_time
                    if (f.total_worktime >= program.require_years)
                    {
                        if(count==0) Console.WriteLine("=============Danh sach nhan vien duoc thang chuc=================");
                        Console.WriteLine(i + 1 + "." + f.Name + " || So nam kinh nghiem:" + f.total_worktime);
                        string pro_skill = "Chua nhap ki nang chuyen mon, vui long update";
                        e[i] = new Experience(f.Name, f.Room, f.Gender, f.Adress, f.Birth, f.total_worktime, pro_skill, f.LISTCertificates);
                        count++;
                    }
                }
            }
        }
    }
}
