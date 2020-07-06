using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace livelywpf.Views
{
    /// <summary>
    /// Interaction logic for TemplateView.xaml
    /// </summary>
    public partial class TemplateView : System.Windows.Controls.Page
    {
        //public TemplateViewModel TemplateVM { get; set; }

        public TemplateView()
        {
            InitializeComponent();
            //TemplateVM = new TemplateViewModel();
            //this.DataContext = TemplateVM; //uwp control also gets binded..
        }

        private void LivelyTemplateView_ChildChanged(object sender, EventArgs e)
        {
            //
        }

        private async void LivelyTemplate_SelectionChanged(object sender, Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            //
        }
    }
}
