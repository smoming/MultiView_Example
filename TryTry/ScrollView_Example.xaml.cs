using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TryTry
{
	public partial class ScrollView_Example : ContentPage
	{
		public ScrollView_Example()
		{
			InitializeComponent();
		}

		void Photo1_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xScrollView.ScrollToAsync(image1, ScrollToPosition.Center, true);
		}

		void Photo2_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xScrollView.ScrollToAsync(image2, ScrollToPosition.Center, true);
		}

		void Photo3_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xScrollView.ScrollToAsync(image3, ScrollToPosition.Center, true);
		}

		void Photo4_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xScrollView.ScrollToAsync(image4, ScrollToPosition.Center, true);
		}

		void Photo5_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			xScrollView.ScrollToAsync(image5, ScrollToPosition.Center, true);
		}
	}
}
