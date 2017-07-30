﻿using System;
using System.Collections.Generic;
namespace Contoso.Domain.Entities
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }


    }
    
   
}
