using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public  class Data
    {
        public static void SeedData(ref List<Employee> List)
        {
            List.Add(new Fresher_exp("Nguyen Thanh Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), 4, DateTime.Parse("10/10/2019"), new List<Certificate>()));
            List.Add(new Intern("ABC","201","M","203 Nguyen Huy Tuong",DateTime.Parse("10/10/2000"),"HTTQL", "K65", "DHBK", new List<Certificate>()));
            List.Add(new Experience("Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), 1, "Code", new List<Certificate>()));
        }
    }
}
