using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_vien
{
    public  class Data
    {
        public static void SeedData(ref List<Employee> Listnv)
        {
            Listnv.Add(new Fresher("Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("Huy", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("Minh", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("A", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("B", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("C", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("D", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("E", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("E", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("F", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("G", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("H", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("S", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("R", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Fresher("L", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            Listnv.Add(new Intern("M","201","M","203 Nguyen Huy Tuong",DateTime.Parse("10/10/2000"),"HTTQL", "K65", "DHBK", new List<Certificate>()));
            Listnv.Add(new Experience("Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), 1, "Code", new List<Certificate>()));
        }
    }
}
