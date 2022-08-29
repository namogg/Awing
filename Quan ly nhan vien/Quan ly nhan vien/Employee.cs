using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Room { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public DateTime Birth { get; set; }
        public int ExpInYears { get; set; }
        public List<Certificate> LISTCertificates { get; set; }
        public void Show(Employee e)
        {

        }
    }
}
