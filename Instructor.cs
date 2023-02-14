using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Encodings.Web;

namespace day7
{
    internal class Instructor
    {
        public string instructorName;
        public float avgFeedback;
        public int experience;
        public string[] instructorskills;

        public Instructor(string name, float feedback, int exp, string[] skills)
        {
            instructorName = name;
            avgFeedback = feedback;
            experience = exp;
            instructorskills = skills;
        }

        public bool ValidateEligibility()
         
        {
            if (experience > 3 && avgFeedback >= 4.5)
            {
                return true;
            }
            else if (experience <= 3 && avgFeedback >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckSkill(string technology)
        {
            if (ValidateEligibility())
            {
                foreach (string skill in instructorskills)
                {
                    if (technology.Equals(skill))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}

