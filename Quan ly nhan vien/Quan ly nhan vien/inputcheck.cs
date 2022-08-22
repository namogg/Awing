using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public class inputcheck
    {
        public static DateTime input_date()
        {
            DateTime date = DateTime.Parse("1/1/2000");
                try
                {   
                    date = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ngay thang khong hop le, vui long nhap lai");
                    return input_date();
                }
            return date;
        }
        public static int input_num()
        {
            int n=0;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Khong hop le, vui long nhap lai");
                    return input_num();
                };
            return n;
        }
        public static int input_exprience_years()
        {
            int n = input_num();
            if (n >= program.require_years)
            {
                return n;
            }
            Console.WriteLine("So nam kinh nghiem phai tren " + program.require_years);
            return input_exprience_years();
        }

    }
}
