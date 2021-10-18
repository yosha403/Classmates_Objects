using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDB
{
    class Student
    {

        //This object is meant to act as a storage container hence the focus of it is properties
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string FavoriteFood { get; set; }       

        public Student(string Name,string HomeTown,string FavoriteFood) 
            {
            this.Name = Name;
            this.HomeTown = HomeTown;
            this.FavoriteFood = FavoriteFood;            
            }           
    }
}
