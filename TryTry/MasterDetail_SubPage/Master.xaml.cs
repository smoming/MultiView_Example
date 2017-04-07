using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TryTry
{
	public partial class Master : ContentPage
	{
		public Master()
		{
			InitializeComponent();

			xListView.ItemsSource = new List<MenuItemDemo>()
			{
				new MenuItemDemo() { Name = "StackLayout", View = typeof(StackLayout_Example) },
				new MenuItemDemo() { Name = "ListView", View = typeof(ListView_Example) },
				new MenuItemDemo() { Name = "TabbedPage", View = typeof(TabbedPage_Example) },
				new MenuItemDemo() { Name = "MyTabbedPage", View = typeof(MyTabbedPage) },
				new MenuItemDemo() { Name = "ScrollView", View = typeof(ScrollView_Example) },
				new MenuItemDemo() { Name = "Style", View = typeof(Style_Example) }
			};
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			//throw new NotImplementedException();
			var menuitem = e.SelectedItem as MenuItemDemo;
			if (menuitem == null)
				return;

			var master = Parent as MasterDetailPage;
			if (master == null)
				return;

			xListView.SelectedItem = null;
			master.IsPresented = false;
			master.Detail = new NavigationPage((Page)Activator.CreateInstance(menuitem.View));
		}
	}

	public class MenuItemDemo
	{
		public string Name { get; set; }
		public Type View { get; set; }
	}
}
