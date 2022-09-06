using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.Models.MyCode;

namespace Batch1_DET_2022
{
    internal class CodeFirstApproach
    {
        public static void Main(string[] args)
        {
            //    AddNewBook();
            //    Console.ReadLine();
            // AddnewCustomerandOrder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
        }

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 4;
        //    book.BookName = "You are unique";
        //    book.author = "aru";
        //    book.price = 100;

        //    try
        //    {
        //        ctx.Books.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book addded sucessfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }



        ////delete
        //{
        //    DeleteNewBook();
        //    Console.ReadLine();
        //}

        //private static void DeleteNewBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();
        //    try
        //    {
        //        Books.BookName = "EF core";
        //        ctx.Remove(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("book removed successfully");
        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //update

        //{
        //    UpdateNewBook();
        //    Console.ReadLine();
        //}

        //private static void UpdateNewBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(b => b.BookID == 4).SingleOrDefault();
        //    try
        //    {
        //        Books.BookName = "james";
        //        ctx.Update(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("book updated successfully");
        //    }


        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //get all books


        //    {
        //        GetallBook();
        //        Console.ReadLine();
        //    }

        //    private static void GetallBook(
        //    {

        //            var ctx = new BookContext();
        //            var Books = ctx.Books;
        //            foreach (var book in Books)
        //            {
        //            Console.WriteLine(book.BookName + " ");


        //            }
        //        }


        //private static void AddnewCustomerandOrder()
        ////{
        ////    var ctx = new BookContext();
        ////    Customer customer = new Customer();
        ////    customer.ID = 1;
        ////    customer.Name = "arusha";
        ////    customer.Age = 22;

        ////    Order ord = new Order();
        ////    ord.Order_ID = 101;
        ////    ord.Amount = 5000;
        ////    ord.OrderDate = DateTime.Now;

        ////    ord.cust = customer;
        ////    try
        ////    {
        ////        //ctx.Orders.Add(Customer);
        ////        ctx.Orders.Add(ord);
        ////        ctx.SaveChanges();

        ////        Console.WriteLine("Customer and order is created");
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Console.WriteLine(ex.InnerException.ToString());
        ////    }
        /// <summary>

        /// </summary>









        //private static void GetAllCustomersWithOrder_EagerLoading()
        //{
        //    //Eager loading means that the related data is loaded
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");



        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }



        //connected
        //private static void GetAllCustomersWithOrder_ExplicitLoading()
        //{
        //    //Explicit loading means that the related data is
        //    //explicitly loaded from the database at a later time.
        //    //Needs MARS to be set to TRUE in connection string
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers;

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");


        //            ctx.Entry(customer).Collection(o => o.Orders).Load();

        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());


        //            }
        //            Console.WriteLine("-----");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }



        //disconnected


        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();


            ctx.Dispose();


            UpdateCustomerName(customer);
        }
            private static void UpdateCustomerName(Customer customer)
            {
                var ctx = new BookContext();
                customer.Name = "Mike";
                Console.WriteLine(ctx.Entry(customer).State.ToString());
                //ctx.Update<Customer>(customer);
                //OR
                ctx.Update(customer);
                //OR
                //ctx.Customers.Update(customer);
                //OR

                // ctx.Attach(customer).State = EntityState.Modified;
                ctx.SaveChanges();
                Console.WriteLine("customer name is updated via disconnected mode");


            }


        }
    }




   


