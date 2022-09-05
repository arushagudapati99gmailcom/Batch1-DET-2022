//using Batch1_DET_2022.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    public class DatabaseFirstApproach
//    {
//        static void Main(string[] args)
//        {
//            //GetAllEmpDetails();
//            //GetAllEmpDetailsByID();
//            // AddNewEmployee();
//            //  UpdateEmpDetails();
//            AddNewEmployee();
//            //DeleteNewEmployee();
//            //UpdateNewEmployee1();
//            Console.ReadLine();
//        }
//        private static void AddNewEmployee()
//        {
//            var ctx = new traningTSQLContext();

//            try
//            {
//                Batch1_DET_2022.Models.Emp employee = new Models.Emp();
//                employee.Empno = 2979;
//                employee.Ename = "arusha";
//                employee.Sal = 1000;
//                employee.Deptno = 30;
//                employee.Job = "Trainer";
//                ctx.Add(employee);
//                ctx.SaveChanges();
//                Console.WriteLine("new employee added");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.InnerException.Message);
//            }
//        }
//        //private static void DeleteNewEmployee()
//        //{
//        //    var ctx = new traningTSQLContext(); 

//        //    try
//        //    {
//        //        Batch1_DET_2022.Models.Emp employee = new Models.Emp();
//        //        employee.Empno = 7934;


//        //        ctx.Remove(employee);
//        //        ctx.SaveChanges();
//        //        Console.WriteLine(" employee deleted");

//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        Console.WriteLine(ex.InnerException.Message);
//        //    }
//        //}

//        //public static void UpdateEmpDetails()
//        //{
//        //    var ctx = new traningTSQL();
//        //    var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

//        //    emp.Ename = "arusha";
//        //    ctx.Update(emp);
//        //    ctx.SaveChanges();
//        //    Console.WriteLine("updated");
//        //}


//        //private static void GetAllEmpDetailsByID()
//        //{
//        //    var ctx = new traningTSQLContext();
//        //    var Emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
//        //    Console.WriteLine(Emp.Ename + " " + Emp.Sal + " " + Emp.Job);
//        //}

//        //private static void GetAllEmpDetails()
//        //{
//        //    var ctx = new traningTSQLContext();
//        //    var emps = ctx.Emps;

//        //    foreach (var emp in emps)
//        //    {
//        //        Console.WriteLine(emp.Ename + " " + emp.Sal);
//        //    }
//        //}
//        //private static void UpdateNewEmployee1()

//        //{

//        //    var ctx = new traningTSQLContext();
//        //var EMP = ctx.Emps.FromTSqlRaw($"GetAllEmpsDetailsbyEmpno @p0 ", 1234).ToList();
//        //    foreach (var e in EMP)
//        //    {
//        //        Console.WriteLine(e.Ename);

//        //    }

//    }

//}



    


     
