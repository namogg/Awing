using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTest
{
    [TestClass]
    public class QLNVTEST
    {   
        [TestMethod]
        public void Test_show_Employee()
        {
            //arrange
            Listnv.Add(new Fresher("Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), new List<Certificate>()));
            //act 
            function.Add_Employee(Employees_List);
            //assert
            assert
        }
    }
}
