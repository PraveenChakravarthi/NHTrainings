using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : 4 Classes Program

    // Customer Class

    class Customer
    {
        private string CustomerName;
        private string CustomerEmailid;
        private int CustomerAge;

        public void ReadCustomer()
        {
            Console.WriteLine("Enter the Name: ");
            CustomerName =  Console.ReadLine();

            Console.WriteLine("Enter the Emailid: ");
            CustomerEmailid = Console.ReadLine();

            Console.WriteLine("Enter the Age: ");
            CustomerAge =Convert.ToInt32(Console.ReadLine());

        }

        public void PrintCustomer()
        {
            Console.WriteLine($"CustomerName={CustomerName}, CustomerEmailid={CustomerEmailid}, CustomerAge={CustomerAge}");
        }
    }

    // Class Product
    class Product
    {
        private string ProductName;
        private string ProductBrand;
        private int ProductPrice;

        public void ReadProduct()
        {
            Console.WriteLine("Enter the ProductName: ");
            ProductName =Console.ReadLine();

            Console.WriteLine("Enter the ProductBrand: ");
            ProductBrand = Console.ReadLine();

            Console.WriteLine("Enter the ProductPrice: ");
            ProductPrice = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintProduct()
        {
            Console.WriteLine($"ProductName={ProductName}, ProductBrand={ProductBrand}, ProductPrice={ProductPrice}");
        }
    }

    // Class Seller
    class Seller
    {
        private string SellerName;
        private string SellerEmailid;
        private int SellerAge;

        public void ReadSeller()
        {
            Console.WriteLine("Enter the SellerName: ");
            SellerName = Console.ReadLine();

            Console.WriteLine("Enter the SellerEmailid: ");
            SellerEmailid = Console.ReadLine();

            Console.WriteLine("Enter the SellerAge: ");
            SellerAge =Convert.ToInt32(Console.ReadLine());
        }

        public void PrintSeller()
        {
            Console.WriteLine($"SellerName={SellerName}, SellerEmailid={SellerEmailid}, SellerAge={SellerAge}");
        }
    }
    
    // Class Department
    class Department
    {
        private string DepartmentHead;
        private string DepartmentType;
        private int DepartmentStrength;

        public void ReadDepartment()
        {
            Console.WriteLine("Enter the DepartmentHead: ");
            DepartmentHead = Console.ReadLine();

            Console.WriteLine("Enter the DepartmenType: ");
            DepartmentType = Console.ReadLine();

            Console.WriteLine("Enter the DepartmentStrength: ");
            DepartmentStrength = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintDepartment()
        {
            Console.WriteLine($"DepartmentHead={DepartmentHead}, DepartmentType={DepartmentType}, DepartmentStrength={DepartmentStrength}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer Cust1 = new Customer();
            Cust1.ReadCustomer();
            Cust1.PrintCustomer();

            Product Prod1 = new Product();
            Prod1.ReadProduct();
            Prod1.PrintProduct();

            Seller Sell1 = new Seller();
            Sell1.ReadSeller();
            Sell1.PrintSeller();

            Department Dept1 = new Department();
            Dept1.ReadDepartment();
            Dept1.PrintDepartment();

            Console.ReadLine();
        }
    }
}
