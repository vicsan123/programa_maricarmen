using System.ComponentModel;
using TabbedSample.ViewModels;
using Xamarin.Forms;

namespace TabbedSample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}