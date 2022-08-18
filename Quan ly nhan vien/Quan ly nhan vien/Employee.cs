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
        public string room { get; set; }
        public string gender { get; set; }
        public string adress { get; set; }
        public DateTime Birth { get; set; }
        public List<Certificate> LISTCertificates;
        public void Show(Employee e)
        {
        }
    }
}
