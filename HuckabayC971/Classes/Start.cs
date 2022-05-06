using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HuckabayC971
{
    public static class Start
    {
        public static void Data(ObservableCollection<Term> terms)
        {
            var instructor = new Instructor("Nathan Huckabay", "918-304-9659", "nhucka1@wgu.edu");
            var assessment1 = new Assessment(AssessmentType.Objective, "Xamarin Objective Assessment", DateTime.Now.AddDays(14));
            var course = new Course("Xamarin 101", DateTime.Now, DateTime.Now.AddDays(30), instructor, "In Progress");
            course.Assessments.Add(assessment1);
            var assessment2 = new Assessment(AssessmentType.Performance, "Xamarin Performance Assessment", DateTime.Now.AddDays(21));
            course.Assessments.Add(assessment2);
            var term = new Term("Term 1", DateTime.Now, DateTime.Now.AddMonths(6));
            term.Courses.Add(course);
            terms.Add(term);
        }
    }
}
