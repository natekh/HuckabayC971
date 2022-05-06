using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HuckabayC971
{
    public class Term
    {
        public Term(string title, DateTime startDate, DateTime endDate)
        {
            Title = title;
            StartDate = startDate;
            EndDate = endDate;
            Courses = new ObservableCollection<Course>();
        }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ObservableCollection<Course> Courses { get; set; }
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
    }
}
