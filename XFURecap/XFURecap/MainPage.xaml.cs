using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFURecap
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}


		void Button_OnClicked(object sender, EventArgs e)
		{
			Resources["fgColor"] = Color.FromHex("#C0C0C0");
			Resources["bgColor"] = Color.FromHex("#606060");
		}
	}
}
