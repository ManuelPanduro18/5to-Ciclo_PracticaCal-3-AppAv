using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab08
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnStackL.Clicked += BtnStackL_Clicked;
            btngrid.Clicked += Btngrid_Clicked;
            btnHierchical.Clicked += BtnHierchical_Clicked;
            btnTab.Clicked += BtnTab_Clicked;
            btnForm.Clicked += BtnForm_Clicked;
            btnDate.Clicked += BtnDate_Clicked;
        }

        private void BtnDate_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Datepicker());
        }

        private void BtnForm_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Form());
        }

        private void BtnTab_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Tabbed());
        }

        private void BtnHierchical_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Hierchical());
        }

        private void Btngrid_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Grid());
        }

        private void BtnStackL_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new StackLayout());
        }
    }
}
