//// See https://aka.ms/new-console-template for more information
//using Batch1_DET_2022;


//class MyClass
//{
//    public static void Main()
//    {
//        #region "inheritence"
//        try
//        {
//            emp m = new manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
//                                                                                               // Console.WriteLine(m.Print());

//            emp m1 = new manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
//            // Console.WriteLine(m1.Print());  //base class ref can point to derived object

//            emp e1 = new emp(1, "Jiyana", new DateOnly(2020, 1, 5));
//            //Console.WriteLine(e1.Print());

//            Console.WriteLine("enter empid b.w 1001 - 25000");
//            int id = Convert.ToInt32(Console.ReadLine());
//            if (id < 1001 || id > 25000)
//                throw new InvalidEmpIdException("Entered empid is not in the range...");

//            Console.WriteLine("enter emp name");
//            string name = Console.ReadLine();

//            Console.WriteLine("enter doj");
//            DateOnly doj = DateOnly.Parse(Console.ReadLine());

//            emp e2 = new(id, name, doj);


//            List<emp> list = new List<emp>();
//            list.Add(m);
//            list.Add(m1);
//            list.Add(e1);
//            foreach (emp x in list)
//                Console.WriteLine(x.Print());
//        }
//        catch (InvalidEmpIdException e)
//        {
//            Console.WriteLine(e.Message);
//        }
//        catch (Exception e)
//        { }

//        #endregion


//        #region "containment"
//        CompanyManager n = new CompanyManager { Name = "Balaji", Surname = "C", phone = "8050408536" };
//        Company company = new Company { Name = "SSL", Address = "Global city", Manager = n, phone = "944285562", website = "Sonata-Softwaree.com" };
//        Console.WriteLine(company.print());
//        #endregion
//        #region "age"
//        try
//        {
//            Console.WriteLine("enter age btw 0- 100");
//            int age = Convert.ToInt32(Console.ReadLine());
//            if (age > 120)
//                throw new InvalidAge("age is invalid");
//        }
//        catch (InvalidAge e)
//        {
//            Console.WriteLine(e.Message);
//        }
//        catch (Exception e)
//        { }
//        #endregion


//        #region "cat and dog"




//        List<Animal> MakeSounds = new List<Animal>();
//        MakeSounds.Add(new Cat());
//        MakeSounds.Add(new Dog());

//        foreach (Animal a in MakeSounds)
//            Console.WriteLine(a.MakeSounds());



//        #endregion
//    }
//}
