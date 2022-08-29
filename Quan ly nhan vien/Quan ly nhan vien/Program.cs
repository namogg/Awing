using System.ComponentModel.DataAnnotations;
using System;
using Quan_ly_nhan_vien;
public class program
{
    public const int require_years = 5;
    public static List<Employee> EmployeesList = new List<Employee>();
    public static void Main(string[] args)
    {   
        //List nhan vien
        
        int n;
        Data.SeedData(ref EmployeesList);
        do
        {
            function f = new function();
            f.PromoteEmployee(ref EmployeesList);
            function.ShowEmployee(EmployeesList);
            Console.WriteLine("==============================");
            Console.WriteLine("Nhap tuy chon");
            Console.WriteLine("1: Hien thi detail nhan vien");
            Console.WriteLine("2: Them nhan vien");
            Console.WriteLine("3: Xoa nhan vien");
            Console.WriteLine("4: Update nhan vien");
            Console.WriteLine("==============================");
            n = inputcheck.InputNumber();
            switch (n)
            {
                case 1:
                    f.PrintEmployee(EmployeesList);
                    break;
                case 2:
                    f.AddEmployee(ref EmployeesList);
                    break;
                case 3:
                    f.DeleteEmployee(ref EmployeesList);
                    break;
                case 4:
                    f.UpdateEmployee(ref EmployeesList);
                    break;
                default:
                    return;
            }
            Console.WriteLine("Nhap ki tu bat ki:");
            Console.ReadKey();
            Console.Clear();
        } while (n >= 1 && n <= 4);
    }
}

