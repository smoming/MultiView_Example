using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TryTry
{
	public partial class Style_Example : ContentPage
	{
		public Style_Example()
		{
			InitializeComponent();
			Resources["mystyle"] = Resources["labelstyle1_page"];
		}

		private int clickcount = 0;
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			clickcount++;
			if (clickcount % 2 == 0)
				Resources["mystyle"] = Resources["labelstyle1_page"];
			else
				Resources["mystyle"] = Resources["labelstyle2_page"];
		}
	}
}
