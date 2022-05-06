using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace HuckabayC971
{
    public class Course
    {
        public Course(string title, DateTime startDate, DateTime endDate, Instructor instructor, string status)
        {
            Title = title;
            StartDate = startDate;
            EndDate = endDate;
            Instructor = instructor;
            Status = status;
            Assessments = new ObservableCollection<Assessment>();
        }

        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Instructor Instructor { get; set; }
        public ObservableCollection<Assessment> Assessments { get; set; }
        public string Status { get; set; }
        public string Dates
        {
            get
            {
                return $"{StartDate.ToString("MMM, yyyy")} - {EndDate.ToString("MMM, yyyy")}";
            }
        }

        public string FullDates
        {
            get
            {
                return $"{StartDate.ToString("d MMM, yyyy")} - {EndDate.ToString("d MMM, yyyy")}";
            }
        }
        public string ShowAssessments()
        {
            string returnString = string.Empty;

            foreach(var assessment in Assessments)
            {
                returnString += $"{assessment.Title}\nAssessment Type: {assessment.AssessmentType}\nDue Date: {assessment.DueDate.ToString("d MMM, yyyy")}\n\n";
            }

            return returnString;
        }
    }
}
