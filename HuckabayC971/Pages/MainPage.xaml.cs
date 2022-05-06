using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HuckabayC971
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static ObservableCollection<Term> ListOfTerms = new ObservableCollection<Term>();
        public MainPage()
        {
            Start.Data(ListOfTerms);
            InitializeComponent();
            listView.ItemsSource = ListOfTerms;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddTermsPage());
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new TermsDetailPage(e.Item as Term));
            listView.SelectedItem = null;
        }
    }
}
