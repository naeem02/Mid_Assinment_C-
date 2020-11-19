using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class Faculty
    {
        public string FacultyName { get; set; }
        public string FacultyId { get; set; }
        TeachingHour[] teachingHours;
        public int CreditCount { get; set; }
        public Faculty()
        {
            teachingHours = new TeachingHour[150];
        }
        public Departments Departments { get; set; }
        
        public Faculty(string facultyName, string facultyId)
        {
            this.FacultyName = facultyName;
            this.FacultyId = facultyId;
            teaching_Hours = new Teaching_Hour[150];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + FacultyName);
            Console.WriteLine("Id: " + FacultyId);
        }
        public void AddCredit(params TeachingHour[] teachingHour)
        {
            foreach (var a in teachingHour)
            {
                if (CreditCount < 7)
                {
                    this.teachingHours[CreditCount++] = a;
                   
                }
                else
                {
                    Console.WriteLine("You Can Not  Take More Than 18 Credits");
                    Console.WriteLine("Cann ot take any more course credit : " + a.CreditCount);
                }

            }
            

        }
        public void ShowAllCredits()
        {
            Console.WriteLine("............");
            for (int i = 0; i < CreditCount; i++)
            {
                teaching_Hours[i].ShowInfo();
            }
            Console.WriteLine(".............");
        }
    }
}