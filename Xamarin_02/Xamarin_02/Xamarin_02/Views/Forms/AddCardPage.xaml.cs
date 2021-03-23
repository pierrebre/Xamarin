﻿using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Xamarin_02.Views.Forms
{
    /// <summary>
    /// Page to show Add new card.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCardPage : ContentPage
    {
        public AddCardPage()
        {
            InitializeComponent();
        }
    }
}