using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedSample.ViewModels;
using TabbedSample.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using TabbedSample.Models;

namespace TabbedSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientsPage : ContentPage
    {
        public ClientsPage()
        {
            InitializeComponent();
            //BindingContext = _viewModel = new ClientsViewModel();
            ListViewClientes.ItemsSource =  Singleton.Instance.Clientes;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            string texto = searchBar.Text.ToLower();
            ListViewClientes.ItemsSource = Singleton.Instance.Clientes.FindAll(C => C.Nombre.ToLower().Contains(texto) || C.Apellidos.ToLower().Contains(texto));
            //searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }

        private void ListViewClientes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var client = (Cliente)e.SelectedItem;

        }

        private void ListViewClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}