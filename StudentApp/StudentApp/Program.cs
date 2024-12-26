
namespace StudentApp
{
    class Program
    {
        private static void Main(string[] args)
        {
           


            Console.WriteLine("Student application management system");
            Console.ReadKey();

            /*

           Student s1 = new Student();
           s1.rollnum = Student.incrementId();
           s1.sname = "sankaresh";
           s1.gender = 'M';

           //Console.WriteLine(s1.rollnum + "  " + s1.sname + "   " + s1.gender);

           s1.displayDetails(rollno: s1.rollnum, sname: s1.sname, gender: s1.gender);

           Student s2 = new Student();
           s2.rollnum = Student.incrementId();
           s2.sname = "sam";
           s2.gender = 'M';

           //Console.WriteLine(s2.rollnum + "  " + s2.sname + "   " + s2.gender);

           //Console.ReadKey();


           s2.displayDetails(rollno: s2.rollnum, sname: s2.sname, gender: s2.gender);


           */



            Student s1 = new Student();
            s1.rollno = Student.incrementID();
            s1.pname = "Sankaresh";
            s1.gender = 'M';
            s1.City = "Thanjavur";
            s1.State = "Tamil-Nadu";
            s1.Zipcode = 600018;
            s1.showDetails();
            Console.WriteLine(s1.getAddress());
            s1.email = "sankareshselvaraj7@gmail.com";
            s1.mobile = 9043613800;
            Console.WriteLine(s1.showContact());
        }

    }

}

