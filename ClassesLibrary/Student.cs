using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {//fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

    //properties
        public string FirstName 
        {
            get { return _firstName; }
            set { _firstName = value; } 
        }//end FirstName

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end LastName

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }//end ID

        public float GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }//end GPA

    //constructors
        //FQ
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            GPA = gpa;
        }//end FQ ctor

        public Student() { } //default

        //methods

        public override string ToString()
        {
            {
                return string.Format($"Name: {FirstName} {LastName}\n" +
                                 $"ID: {ID:n}\n" +
                                 $"GPA: {GPA:f}\n");
            }//end return
        }//end override

    }//end class
}//end namespace
