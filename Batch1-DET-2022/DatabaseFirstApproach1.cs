using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    public class DatabaseFirstApproach1
//    {
//        static void Main(string[] args)
//        {
            //GetAllEmpDetails();
            //GetAllEmpDetailsByID();
            // AddNewEmployee();
            //  UpdateEmpDetails();
            // GetEmployeeSP();
           // CallStoredProcwithSQLParamater_insert();

            //AddNewEmployee();
            //DeleteNewEmployee();
            //UpdateNewEmployee1();
           // Console.ReadLine();

            //private static void AddNewEmployee()
            //{
            //    var ctx = new traningTSQLContext();

//    try
//    {
//        Emp employee = new Models.Emp();
//        employee.Empno = 2959;
//        employee.Ename = "arusha";
//        employee.Sal = 1000;
//        employee.Deptno = 30;
//        employee.Job = "Trainer";
//        ctx.Add(employee);
//        ctx.SaveChanges();
//        Console.WriteLine("new employee added");

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.InnerException.Message);
//    }
// }
//private static void DeleteNewEmployee()
//{
//    var ctx = new traningTSQLContext(); 

//    try
//    {
//        Batch1_DET_2022.Models.Emp employee = new Models.Emp();
//        employee.Empno = 7934;


//        ctx.Remove(employee);
//        ctx.SaveChanges();
//        Console.WriteLine(" employee deleted");

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.InnerException.Message);
//    }
//}

//public static void UpdateEmpDetails()
//{
//    var ctx = new traningTSQL();
//    var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

//    emp.Ename = "arusha";
//    ctx.Update(emp);
//    ctx.SaveChanges();
//    Console.WriteLine("updated");
//}


//private static void GetAllEmpDetailsByID()
//{
//    var ctx = new traningTSQLContext();
//    var Emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
//    Console.WriteLine(Emp.Ename + " " + Emp.Sal + " " + Emp.Job);
//}

//private static void GetAllEmpDetails()
//{
//    var ctx = new traningTSQLContext();
//    var emps = ctx.Emps;

//    foreach (var emp in emps)
//    {
//        Console.WriteLine(emp.Ename + " " + emp.Sal);
//    }
//}
//private static void GetEmployeeSp()
//{
//    var ctx = new Models.traningTSQLContext();
//    var emp = ctx.Emps.FromSqlRaw($"sp_GetEmployeeEname").ToList();

//    foreach (var e in emp)
//    {
//        Console.WriteLine(e.Ename);
//    }

//        private static void CallStoredProcwithSQLParamater_insert()
//        {
//            var ctx = new traningTSQLContext();
//            var param = new SqlParameter[] {
//                        new SqlParameter() {
//                            ParameterName = "@EMPNO",
//                            SqlDbType =  System.Data.SqlDbType.Int,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 6
//                        },

//                         new SqlParameter() {
//                            ParameterName = "@JOB",
//                            SqlDbType =  System.Data.
//                            SqlDbType.VarChar,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = "RDBMS concept"},

//                          new SqlParameter() {
//                            ParameterName = "@ENAME",
//                            SqlDbType =  System.Data.
//                            SqlDbType.Decimal,
//                            Size = 100,
//                            Direction = System.Data.
//                            ParameterDirection.Input,
//                            Value = 10}

//                       };

//            try
//            {
//                var result = ctx.Database.ExecuteSqlRaw("Addnewemp @EMPNO, @JOB, @ENAME", param);
//                Console.WriteLine("added");
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }


//            Console.WriteLine("update successful");

//        }
//    }
//}










