using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TryTry
{
	public partial class TabbedPage_Example : TabbedPage
	{
		public TabbedPage_Example()
		{
			InitializeComponent();

			//tabbedPage();
		}

		void tabbedPage()
		{
			Children.Add(new Page1());
			Children.Add(new Page2());
			Children.Add(new Page3());
		}
	}
}
