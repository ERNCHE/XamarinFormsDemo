using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
            InitializeComponent();
		}
        public void Button_OnClicked(object sender, EventArgs e)
        {
            string text = MainEntry.Text;

            MainLabel.Text = "Hello" + text;
        }
        public async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}