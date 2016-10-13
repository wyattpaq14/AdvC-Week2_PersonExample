using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonClassExample
{
   public class Person
    {
      private string name; //Fields for Name and ID
       private string idnum;

        public Person()//Default constructor
        {
       }
        public Person( string name)
        {
            this.Name = name;
            this.Idnum = "9999";
           
        }

        public Person(string name, string idnum )  //constructor
        {
            this.Name = name;
            this.Idnum = idnum;
        }

        public string Name   //property for name
        {
            get
            {
                
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string
            Idnum //property for ID
        {
            get
            {
                return idnum;
            }
            set
            {

                idnum = value;
            }
   
        }

       public  string getpersoninfo()  //method to display name and ID
       {
           return "The New person's name is " + name + " and their ID is " + idnum;
       }
}
}
