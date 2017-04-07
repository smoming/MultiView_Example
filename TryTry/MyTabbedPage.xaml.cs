using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TryTry
{
	public partial class MyTabbedPage : ContentPage
	{
		public MyTabbedPage()
		{
			InitializeComponent();
		}

		void GoFacebook(object sender, EventArgs e)
		{
			var page = new Page1();
			xContextPlaceHolder.Content = page.Content;
		}

		void GoGoogle(object sender, EventArgs e)
		{
			var page = new Page2();
			xContextPlaceHolder.Content = page.Content;
		}

		void GoMicrosoft(object sender, EventArgs e)
		{
			var page = new Page3();
			xContextPlaceHolder.Content = page.Content;
		}
	}
}
