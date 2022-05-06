using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HuckabayC971
{
    public enum AssessmentType { Performance, Objective }
    public class Assessment
    {
        public Assessment(AssessmentType assessmentType, string title, DateTime dueDate)
        {
            AssessmentType = assessmentType;
            Title = title;
            DueDate = dueDate;
        }
        public AssessmentType AssessmentType {get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
    }
}
