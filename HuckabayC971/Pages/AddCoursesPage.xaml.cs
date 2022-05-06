using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HuckabayC971
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCoursesPage : ContentPage
    {
        private Term _thisTerm;
        public AddCoursesPage(Term term)
        {
            _thisTerm = term;
            InitializeComponent();
        }

        public AddCoursesPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (titleEntry.Text == null || titleEntry.Text.Length < 1)
                errorMessage += "Title is a required field\n";

            if (endDatePicker.Date.CompareTo(startDatePicker.Date) < 1)
                errorMessage += "End Date must be later than Start Date\n";

            if(instructorNameEntry.Text == null || instructorNameEntry.Text.Length < 1)
                errorMessage += "Instructor Name is a required field\n";

            if (instructorPhoneEntry.Text == null || instructorPhoneEntry.Text.Length < 1)
                errorMessage += "Instructor Phone Number is a required field\n";

            if (instructorEmailentry.Text == null || instructorEmailentry.Text.Length < 1)
                errorMessage += "Instructor Email Address is a required field\n";

            if (statusPicker.SelectedItem == null)
                errorMessage += "Status must be selected";

            if (errorMessage.Length > 0)
                DisplayAlert("Error", errorMessage, "OK");
            else
            {
                var instructor = new Instructor(instructorNameEntry.Text, instructorPhoneEntry.Text, instructorEmailentry.Text);
                var course = new Course(titleEntry.Text, startDatePicker.Date, endDatePicker.Date, instructor, statusPicker.SelectedItem as string);
                _thisTerm.Courses.Add(course);
                Navigation.PopAsync();
            }
        }
    }
}