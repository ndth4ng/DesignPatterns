using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    interface IEmployee
    {
        string Name { get; set; }

        string Dept { get; set; }

        string Designation { get; set; }

        void DisplayDetails();
    }

    //leaf node 
    class Employee : IEmployee
    {
        public string Name { get; set; }

        public string Dept { get; set; }

        public string Designation { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("\t {0} lam viec tai phong {1}. Chi dinh: {2}", Name, Dept, Designation);
        }
    }

    //non-leaf node 
    class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }

        public string Dept { get; set; }

        public string Designation { get; set; }

        private List<IEmployee> sublist = new List<IEmployee>();

        //add an employee
        public void AddEmployee(IEmployee e)
        {
            sublist.Add(e);
        }

        //remove an employee
        public void RemoveEmployee(IEmployee e)
        {
            sublist.Remove(e);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("{0} lam viec tai phong {1}. Chi dinh: {2}", Name, Dept, Designation);
            foreach(IEmployee e in sublist)
            {
                e.DisplayDetails();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Demo composite pattern--------");
            Employee nv1 = new Employee { Name = "Nguyen Van A", Dept = "Khoa Toan", Designation = "Giang Vien" };
            Employee nv2 = new Employee { Name = "Tran Van B", Dept = "Khoa Toan", Designation = "Giang Vien" };
            CompositeEmployee HODnv3 = new CompositeEmployee { Name = "Le Van C", Dept = "Khoa Toan", Designation = "Truong Khoa" };

            //

            HODnv3.AddEmployee(nv1);
            HODnv3.AddEmployee(nv2);

            HODnv3.DisplayDetails();

            Employee CSEE1 = new Employee { Name = "KHMT A", Dept = "KHMT", Designation = "Giang Vien" };
            Employee CSEE2 = new Employee { Name = "KHMT B", Dept = "KHMT", Designation = "Giang Vien" };
            Employee CSEE3 = new Employee { Name = "KHMT C", Dept = "KHMT", Designation = "Giang Vien" };
            CompositeEmployee HODKHMT = new CompositeEmployee { Name = "Le Van D", Dept = "KHMT", Designation = "Truong Khoa" };

            HODKHMT.AddEmployee(CSEE1);
            HODKHMT.AddEmployee(CSEE2);
            HODKHMT.AddEmployee(CSEE3);

            CompositeEmployee HTTruong = new CompositeEmployee { Name = "Dr. S", Dept = "Ke hoach QL", Designation = "Hieu Truong" };

            HTTruong.AddEmployee(HODnv3);
            HTTruong.AddEmployee(HODKHMT);

            Console.ReadKey();
        }
    }
}
