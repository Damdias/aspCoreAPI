using System.Collections.Generic;

namespace Contoso.Domain.Entities
{
    public class Course
    {
       
        public int CourseID { get; set; }
        public string Title { get; set; }
        public decimal Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
