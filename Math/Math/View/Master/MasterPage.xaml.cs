using Xamarin.Forms;

namespace Math.View.Master
{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();

            MenuListView.ItemTapped += (sender, e) =>
            {
                var mainPage =
                (MasterDetailPage)((NavigationPage)Application.Current.MainPage).CurrentPage;
                mainPage.IsPresented = false;
                mainPage.Detail = (Page)MenuListView.SelectedItem;
                MenuListView.SelectedItem = null;

            };
        }
    }
}
