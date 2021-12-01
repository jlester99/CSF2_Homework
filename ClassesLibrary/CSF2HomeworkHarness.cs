using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SignatureLibrary;


namespace ClassesLibrary
{
    class CSF2HomeworkHarness
    {
        static void Main(string[] args)
        {
            Signature.Header("Homework Test Harness");

            #region Student
            Console.WriteLine("\n\n**** Students *****\n");
            Student s1 = new Student(); //default
            s1.FirstName = "Rachel";
            s1.LastName = "Green";
            s1.ID = "1234";
            s1.GPA = 3.59f;

            Console.WriteLine(s1);
            //
            Student s2 = new Student("Monica", "Gellar", "5678", 3.25f);
            Console.WriteLine(s2);

            #endregion

            #region Vehicle
            //string make, string model, int year, float weight
            Console.WriteLine("\n\n**** Vehicles *****\n");
            Vehicle v1 = new Vehicle(); //default
            v1.Make = "Toyota";
            v1.Model = "Highlander";
            v1.Year = 2019;
            v1.Weight = 2000f;

            Console.WriteLine(v1);
            //
            Vehicle v2 = new Vehicle("Honda", "Pilot", 2017, 2100f);
            Console.WriteLine(v2);

            #endregion

            #region Login
            //string username, string password
            Console.WriteLine("\n\n**** Login Info *****\n");
            Login l1 = new Login(); //default
            l1.Username = "RGreen1";
            l1.Password = "EmmaRoss20!";

            Console.WriteLine(l1);
            //
            Login l2 = new Login("MGellar1", "ChandBing!");
            Console.WriteLine(l2);

            #endregion

        }//end svm

    }//end class
}//end namespace
