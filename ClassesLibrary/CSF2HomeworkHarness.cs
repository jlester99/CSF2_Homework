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

        }//end svm

    }//end class
}//end namespace
