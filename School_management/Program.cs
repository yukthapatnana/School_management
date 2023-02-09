using System;

namespace School_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonTeachingstaff nonteachingstaff = new NonTeachingstaff(303, "rahul", "palasa,srikakulam(dist)", 9876543202, "B.Sc", 40000, "ECE", 67);
            Console.WriteLine(nonteachingstaff.Getdetails());
            
            
            Teachingstaff teachingstaff = new Teachingstaff(404, "navya", "meliaputti,srkakulam(dist)", 2345678903, "M.Tech", 90000, "B.Tech", "Electronics");
            
            Console.WriteLine(teachingstaff.Getdetails());
            
            Student student = new Student(2, "yuktha", "tekkalipatnam,srikakulam(dist)", 9390573895, 8, 75.89f, "B", 89000.00f);
            Console.WriteLine(student.Getdetails());
        }
    }
}
