using System;

namespace day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] instructorskills = {"python","java","C#"};
            Instructor instructor = new Instructor("pinky", 4f,3, instructorskills);
            if (instructor.ValidateEligibility())
            {
                Console.WriteLine("Instructor is eligible.");
                if (instructor.CheckSkill("C#"))
                {
                    Console.WriteLine("Instructor has the required skill.");
                }
                else
                {
                    Console.WriteLine("Instructor does not have the required skill.");
                }
            }
            else
            {
                Console.WriteLine("Instructor is not eligible.");
            }
        }
    }

}