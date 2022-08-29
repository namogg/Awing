using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public class inputcheck
    {
        public static DateTime InputDate()
        {
            DateTime date = DateTime.Parse("1/1/2000");
                try
                {   
                    date = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ngay thang khong hop le, vui long nhap lai");
                    return InputDate();
                }
            return date;
        }
        public static int InputNumber()
        {   
            int n=0;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0) 
                    { 
                    Console.WriteLine("Khong hop le, vui long nhap lai"); 
                    return InputNumber(); 
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Khong hop le, vui long nhap lai");
                    return InputNumber();
                };
            return n;
        }
        public static int input_exprience_years()
        {
            int n = InputNumber();
            if (n >= program.require_years)
            {
                return n;
            }
            Console.WriteLine("So nam kinh nghiem phai tren " + program.require_years);
            return input_exprience_years();
        }

    }
}
