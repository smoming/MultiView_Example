using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TryTry
{
	public partial class StackLayout_Example : ContentPage
	{
		public StackLayout_Example()
		{
			InitializeComponent();

			//onPlatform();
			//Content = stackLayout();
		}

		private void onPlatform()
		{
			Padding = new OnPlatform<Thickness>()
			{
				iOS = new Thickness(0, 20, 0, 0)
			};

			//Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
		}

		private StackLayout stackLayout()
		{
			var xRed = new Label
			{
				Text = "Red",
				BackgroundColor = Color.Red,
				FontSize = 20,
				TextColor = Color.White,
				WidthRequest= 100,
				HorizontalTextAlignment = TextAlignment.Center
			};

			var xGreen = new Label
			{
				Text = "Green",
				BackgroundColor = Color.Green,
				FontSize = 20,
				TextColor = Color.White,
				WidthRequest = 100,
				HorizontalTextAlignment = TextAlignment.Center
			};

			var xBlue = new Label
			{
				Text = "Blue",
				BackgroundColor = Color.Blue,
				FontSize = 20,
				TextColor = Color.White,
				WidthRequest = 100,
				HorizontalTextAlignment = TextAlignment.Center
			};

			var xStackLayout = new StackLayout
			{
				Spacing = 10,
				Children = { xRed, xGreen, xBlue },
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.End,
				HorizontalOptions = LayoutOptions.Center
			};
			//xStackLayout.Children.Add(xRed);
			//xStackLayout.Children.Add(xGreen);
			//xStackLayout.Children.Add(xBlue);

			return xStackLayout;
		}
	}
}
