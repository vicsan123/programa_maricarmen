using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedSample.Models;
using TabbedSample.Services;
using TabbedSample.ViewModels;
using TabbedSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedSample.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();


            BindingContext = _viewModel = new ItemsViewModel();
            this.ItemsListView.ItemsSource = Singleton.Instance.Productos;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}