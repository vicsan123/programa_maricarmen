using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabbedSample.Models;
using TabbedSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedSample.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}