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
    public partial class AddTermsPage : ContentPage
    {
        public AddTermsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (titleEntry.Text == null || titleEntry.Text.Length < 1)
                errorMessage += "Title is a required field\n";

            if (endDatePicker.Date.CompareTo(startDatePicker.Date) < 1)
                errorMessage += "End Date must be later than Start Date";
            if (errorMessage.Length > 0)
                DisplayAlert("Error", errorMessage, "OK");
            else
            {
                MainPage.ListOfTerms.Add(new Term(titleEntry.Text, startDatePicker.Date, endDatePicker.Date));
                Navigation.PopAsync();
            }
        }
    }
}