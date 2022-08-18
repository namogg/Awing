using System.ComponentModel.DataAnnotations;
using System;
using Quan_ly_nhan_vien;
public class program
{   
    //List nhan vien
    public static List<Employee> Listnv = new List<Employee>();
    
    //Ham nhap va kiem tra ngay thang
    public static DateTime input_date()
    {
        DateTime date;
        do
        {
            try
            {
                date = DateTime.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ngay sinh khong hop le, vui long nhap lai");
            };
        } while (1+1 == 2);
        return date;
    }
    //Ham in List ten nhan vien 
    public static void show(List<Employee> e)
    {
        Console.WriteLine("==============================");
        for (int i = 0; i < e.Count; i++)
        {
            Console.WriteLine(i+1+"."+ e[i].Name);
        }
    }
    //Ham them nhan vien
    public static void AddNV()
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
                Fresher e = new Fresher();
                Listnv.Add(e.input_NV());
                break;
            case 2:
                Intern I = new Intern();
                Listnv.Add(I.input_NV());
                break;
            case 3:
                Experience E = new Experience();
                Listnv.Add(E.input_NV());
                break;
            default:
                return;
        }
        Console.WriteLine("Them thanh cong nhan vien");
    }
    //Ham xoa nhan vien
    public static void Delete_NV()
    {
        Console.Clear();
        show(Listnv);
        Console.WriteLine("Xoa nhan vien thu:");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n > Listnv.Count || n <= 0)
        {
            Console.WriteLine("ERRROR");
            return;
        }
        Listnv.RemoveAt(n-1);
        Console.WriteLine("Xoa thanh cong");
    }
    //Ham update nhan vien
    public static void Update_NV()
    {
        show(Listnv);
        Console.WriteLine("Update nhan vien thu:");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i > Listnv.Count || i <= 0)
        {
            Console.WriteLine("ERRROR");
            return;
        }
        if (Listnv[i - 1] is Fresher)
        {   Fresher e = new Fresher();
            Listnv[i - 1] = e.input_NV();
            return;
        }
        if (Listnv[i - 1] is Intern)
        {
            Intern e = new Intern();
            Listnv[i - 1] = e.input_NV();
            return;
        }
        if (Listnv[i - 1] is Experience)
        {
            Intern e = new Intern();
            Listnv[i - 1] = e.input_NV();
            return;
        }
    }
    //Ham in nhan vien theo so thu tu 
    public static void PrintNV()
    {   
        Console.WriteLine("Nhap so thu tu cua nhan vien ban muon hien thi thong tin");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i > Listnv.Count || i <= 0)
        {
            Console.WriteLine("ERRROR");
            return;
        }
        Console.Clear();
        if (Listnv[i - 1] is Fresher)
            ((Fresher)Listnv[i - 1]).Show((Fresher)Listnv[i - 1]);
        if (Listnv[i - 1] is Intern)
            ((Intern)Listnv[i - 1]).Show((Intern)Listnv[i - 1]);
        if (Listnv[i - 1] is Experience)
            ((Experience)Listnv[i - 1]).Show((Experience)Listnv[i - 1]);
    }
    static void Main(string[] args)
    {
        int n;
        Data.SeedData(ref Listnv);
        do
        {
            show(Listnv);
            Console.WriteLine("==============================");
            Console.WriteLine("Nhap tuy chon");
            Console.WriteLine("1: Hien thi detail nhan vien");
            Console.WriteLine("2: Them nhan vien");
            Console.WriteLine("3: Xoa nhan vien");
            Console.WriteLine("4: Update nhan vien");
            Console.WriteLine("==============================");

            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    PrintNV();
                    break;
                case 2:
                    AddNV();
                    break;
                case 3:
                    Delete_NV();
                    break;
                case 4:
                    Update_NV();
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