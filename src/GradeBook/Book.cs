using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
           category ="";
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade<=100 && grade >=0)
            {
                grades.Add(grade);
            }
            else{
                throw new ArgumentException($"Invalid grade{nameof(grade)}");
            }
        }

        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }
        public Statistics GetStatistics()
        {
           var result = new Statistics();
           //var result =0.0;
           result.Average = 0.0;
           result.High = double.MinValue;
           result.Low = double.MaxValue;

            /******************************************
            // foreach loop

            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade,result.Low);
                result.High = Math.Max(grade,result.High);
                result.Average += grade;
            }

            // do while loop

            var index = 0;
            do{
                result.Low = Math.Min(grades[index],result.Low);
                result.High = Math.Max(grades[index],result.High);
                result.Average += grades[index];
                index++;
            } while(index<grades.Count);

           //while loop 
           
           var index = 0;
            while(index<grades.Count)
            {
                result.Low = Math.Min(grades[index],result.Low);
                result.High = Math.Max(grades[index],result.High);
                result.Average += grades[index];
                index++;
            };
           **************************************************/
           
           //for loop
           for(var index =0 ; index < grades.Count; index++)
           {
                result.Low = Math.Min(grades[index],result.Low);
                result.High = Math.Max(grades[index],result.High);
                result.Average += grades[index];

           }
            result.Average/=grades.Count;
            switch(result.Average)
            {
                case var d when d>=90.0:
                    result.Letter = 'A';
                    break;
                case var d when d>=80.0:
                    result.Letter = 'B';
                    break; 
                case var d when d>=70.0:
                    result.Letter = 'C';
                    break; 
                case var d when d>=60.0:
                    result.Letter = 'D';
                    break; 
                default: 
                    result.Letter = 'F';
                    break;

            }
           return result;
        }
        private List<double> grades;

// using  a property
/***************************************************************
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                name = value;
                }
                else{
                    throw new Exception($"Invalid name {nameof(name)}");
                }

            }
        }
        // set property for private member
        private string name;
***********************************************************/

        public string Name
        {
            get;
          //  set;
            private set; // ensures the value is not changes after the constructor is called.

        }
        readonly string category = "Science";   // value can be changed only in the constructor
        public const int UPPERCASEVALUE=3;
        //x++;      // const values cannot be changed anywhere

    }
}