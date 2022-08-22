using System.ComponentModel.DataAnnotations;
using System;
using Quan_ly_nhan_vien;
public class program
{
    public const int require_years = 5;
    public static List<Employee> Employees_List = new List<Employee>();
    static void Main(string[] args)
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
            switch (n)
            {
                case 1:
                    function.Print_Employee(Employees_List);
                    break;
                case 2:
                    function.Add_Employee(ref Employees_List);
                    break;
                case 3:
                    function.Delete_Employee(ref Employees_List);
                    break;
                case 4:
                    function.Update_Employee(ref Employees_List);
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

