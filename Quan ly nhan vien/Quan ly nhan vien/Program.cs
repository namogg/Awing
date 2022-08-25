using System.ComponentModel.DataAnnotations;
using System;
using Quan_ly_nhan_vien;
public class program
{
    public const int require_years = 5;
    public static List<Employee> Employees_List = new List<Employee>();
    public static void Main(string[] args)
    {   
        //List nhan vien
        
        int n;
        Data.SeedData(ref Employees_List);
        do
        {
            function.show_Employee(Employees_List);
            Console.WriteLine("==============================");
            Console.WriteLine("Nhap tuy chon");
            Console.WriteLine("1: Hien thi detail nhan vien");
            Console.WriteLine("2: Them nhan vien");
            Console.WriteLine("3: Xoa nhan vien");
            Console.WriteLine("4: Update nhan vien");
            Console.WriteLine("5: Thang chuc cho nhan vien");
            Console.WriteLine("==============================");
            n = inputcheck.input_num();
            function f = new function();
            switch (n)
            {
                case 1:
                    f.Print_Employee(Employees_List);
                    break;
                case 2:
                    f.Add_Employee(ref Employees_List);
                    break;
                case 3:
                    f.Delete_Employee(ref Employees_List);
                    break;
                case 4:
                    f.Update_Employee(ref Employees_List);
                    break;
                case 5:
                    function.promote_employee(ref Employees_List);
                    break;
                default:
                    return;
            }
            Console.WriteLine("Nhap ki tu bat ki:");
            Console.ReadKey();
            Console.Clear();
        } while (n >= 1 && n <= 5);
    }
}

