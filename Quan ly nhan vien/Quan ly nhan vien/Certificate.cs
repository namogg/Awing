using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Quan_ly_nhan_vien
{
    public class Certificate
    {
        public string CertificateName { get; set; }
        
        public string CertificateRank { get; set; }
       
        public DateTime GraduationDate { get; set; }
        public Certificate()
        {
        }
        public Certificate(string certificateName, string certificateRank, DateTime graduationDate)
        {
            CertificateName = certificateName;
            CertificateRank = certificateRank;
            GraduationDate = graduationDate;
        }
        public static void show(Certificate e)
        {
            Console.WriteLine("Ten Certificate");
            Console.WriteLine(e.CertificateName);
            Console.WriteLine("Xep hang Certificate");
            Console.WriteLine(e.CertificateRank);
            Console.WriteLine("Ngay tot nghiep");
            Console.WriteLine(e.GraduationDate);
        }
        public void show(List<Certificate> e)
        {
            for(int i = 0; i < e.Count; i++)
            {
                Console.WriteLine("Certificate "+(i+1));

                show(e[i]);
            }
        }
        public static List<Certificate> Input_Certificates()
        {
            List<Certificate> Temp = new List<Certificate>();
            Console.WriteLine("Nhap so Certificate");
            int n = inputcheck.input_num();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap bang thu:" + (i+1));
                Console.WriteLine("Nhap ten bang");
                string CertificateName = Console.ReadLine();
                Console.WriteLine("Nhap xep hang bang");
                string CertificateRank = Console.ReadLine();
                Console.WriteLine("Nhap ngay tot nghiep");
                DateTime GraduationDate = inputcheck.input_date();
                Temp.Add(new Certificate(CertificateName, CertificateRank, GraduationDate));
            }
            return Temp;
        }
    }
}
