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
    public partial class TermsDetailPage : ContentPage
    {
        private Term _thisTerm;
        public TermsDetailPage(Term term)
        {
            _thisTerm = term;
            BindingContext = _thisTerm;
            InitializeComponent();
            listView.ItemsSource = _thisTerm.Courses;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddCoursesPage(_thisTerm));
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new CourseDetailPage(e.Item as Course));
            listView.SelectedItem = null;
        }
    }
}