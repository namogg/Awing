using NUnit.Framework;
using Moq;
using Quan_ly_nhan_vien;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestQLSV
{
    public class Tests
    {
        
        StringBuilder Console_output;
        Mock<TextReader> Console_Input;
        [SetUp]
        public void Setup()
        {
            Console_output = new StringBuilder();
            var console_putput_writer = new StringWriter(Console_output);
            Console_Input = new Mock<TextReader>();
            Console.SetOut(console_putput_writer);
            Console.SetIn(Console_Input.Object);
        }
        private MockSequence User_respond(params string[] userResponses)
        {
            var sequence = new MockSequence();
            foreach(var response in userResponses)
            {
                Console_Input.InSequence(sequence).Setup(x=>x.ReadLine()).Returns(response);
            }
            return sequence;
        }
        private string[] Run_show_Employee_And_Get_OutPut()
        {   
            program.Main(default);
            return Console_output.ToString().Split("\r\n");
        }
        [Test]
        public void Test_input_number()
        {
            //arrange
            //act
            User_respond("abc");
            var expect_putput = "Khong hop le, vui long nhap lai";
            var outputLines = Run_show_Employee_And_Get_OutPut();
            //assert
            Assert.IsTrue(outputLines.Contains(expect_putput));
        }
        [Test]
        public void Test_Print_Employee_OutOfRange()
        {
            //arrange
            List<Employee> employees = new List<Employee>();
            employees.Add(new Fresher_exp("Nguyen Thanh Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), 4, DateTime.Parse("10/10/2019"), new List<Certificate>()));
            employees.Add(new Intern("ABC", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "HTTQL", "K65", "DHBK", new List<Certificate>()));
            employees.Add(new Experience("Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), 1, "Code", new List<Certificate>()));
            function f = new function();
            User_respond("100");
            f.Print_Employee(employees);
            //act
            var expect_putput = "So thu tu khong hop le";
            var outputLines = Console_output.ToString();
            //assert
            Assert.IsTrue(outputLines.Contains(expect_putput));
            Assert.IsTrue(employees.Count() == 3);
        }
        [Test]
        public void Test_Delete_Empty_List()
        {
            //arrange
            List<Employee> employees = new List<Employee>();
            function f = new function();
            //act
            //assert
            Assert.IsTrue(f.Delete_Employee(ref employees));
        }
        [Test]
        public void Test_Delete_List()
        {
            //arrange
            List<Employee> employees = new List<Employee>();
            employees.Add(new Fresher_exp("Nguyen Thanh Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "gioi", "DHBK", DateTime.Parse("10/10/2000"), 4, DateTime.Parse("10/10/2019"), new List<Certificate>()));
            employees.Add(new Intern("ABC", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), "HTTQL", "K65", "DHBK", new List<Certificate>()));
            employees.Add(new Experience("Nam", "201", "M", "203 Nguyen Huy Tuong", DateTime.Parse("10/10/2000"), 1, "Code", new List<Certificate>()));
            function f = new function();
            //act
            User_respond("1");
            f.Delete_Employee(ref employees);
            var outputLines = Console_output.ToString();
            //assert
            Assert.IsTrue(employees.Count == 2);
            Assert.IsTrue(outputLines.Contains("Xoa thanh cong"));
        }
        [Test]
        public void Test_Add_Employee_Fresher()
        {
            //arrange
            List<Employee> employees = new List<Employee>();
            function f = new function();
            //act
            User_respond("1", "Nguyen Thanh Nam", "201", "M", "203 Nguyen Huy Tuong", "10/10/2000", "gioi", "DHBK", "10/10/2000", "4" ,"10/10/2019","1","HTTTQL","Gioi","1/1/2022" );
            f.Add_Employee(ref employees);
            var outputLines = Console_output.ToString();
            //assert
            Assert.IsTrue(employees.Count() == 1);
            Assert.IsTrue(outputLines.Contains("Them thanh cong nhan vien"));
            Fresher_exp fresher_Exp = (Fresher_exp)employees[0];
            Assert.IsTrue(fresher_Exp.Name == "Nguyen Thanh Nam");
        }
        [Test]
        public void Test_Add_Employee_Intern()
        {
            //arrange
            List<Employee> employees = new List<Employee>();
            function f = new function();
            //act
            User_respond("2", "Nguyen Thanh Nam", "201", "M", "203 Nguyen Huy Tuong", "10/10/2000", "HTTQL", "K65", "DHBK", "1", "HTTTQL", "Gioi", "1/1/2022");
            f.Add_Employee(ref employees);
            var outputLines = Console_output.ToString();
            //assert
            Assert.IsTrue(employees.Count() == 1);
            Assert.IsTrue(outputLines.Contains("Them thanh cong nhan vien"));
            Intern intern = (Intern)employees[0];
            Assert.IsTrue(intern.Name == "Nguyen Thanh Nam");
        }
        [Test]
        public void Test_Add_Employee_Experience()
        {
            //arrange
            List<Employee> employees = new List<Employee>();
            function f = new function();
            //act
            User_respond("3", "Nguyen Thanh Nam", "201", "M", "203 Nguyen Huy Tuong", "10/10/2000","5","Code", "1", "HTTTQL", "Gioi", "1/1/2022");
            f.Add_Employee(ref employees);
            var outputLines = Console_output.ToString();
            //assert
            Assert.IsTrue(employees.Count() == 1);
            Assert.IsTrue(outputLines.Contains("Them thanh cong nhan vien"));
            Experience experience = (Experience)employees[0];
            Assert.IsTrue(experience.Name == "Nguyen Thanh Nam");
        }
        [Test]
        public void Test_Add_Employee_Experience_LowEXP_exeption()
        {
            //arrange
            List<Employee> employees = new List<Employee>();
            function f = new function();
            //act
            User_respond("3", "Nguyen Thanh Nam", "201", "M", "203 Nguyen Huy Tuong", "10/10/2000", "1","5" ,"Code", "1", "HTTTQL", "Gioi", "1/1/2022");
            f.Add_Employee(ref employees);
            var outputLines = Console_output.ToString();
            //assert
            Assert.IsTrue(outputLines.Contains("So nam kinh nghiem phai tren 5"));
            
        }
    }
}