using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HuckabayC971
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseDetailPage : ContentPage
    {
        private Course _thisCourse;
        public CourseDetailPage(Course course)
        {
            _thisCourse = course;
            BindingContext = _thisCourse;
            InitializeComponent();
            assessmentsLabel.Text = _thisCourse.ShowAssessments();
        }
    }
}