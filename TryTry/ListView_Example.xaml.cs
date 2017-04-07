using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TryTry
{
	public partial class ListView_Example : ContentPage
	{
		class Person
		{
			public string Name { get; set; }
			public DateTime BirthDay { get; set; }
			public Color FavoriteColor { get; set; }

			public static IEnumerable<Person> Get()
			{
				yield return new Person() { Name = "John", BirthDay = new DateTime(1977, 2, 21), FavoriteColor = Color.Accent };
				yield return new Person() { Name = "Mary", BirthDay = new DateTime(1988, 8, 31), FavoriteColor = Color.Pink };
				yield return new Person() { Name = "Bob", BirthDay = new DateTime(1999, 12, 15), FavoriteColor = Color.Blue };
				yield return new Person() { Name = "Helen", BirthDay = new DateTime(2001, 5, 12), FavoriteColor = Color.Lime };
				yield return new Person() { Name = "Dora", BirthDay = new DateTime(1993, 7, 4), FavoriteColor = Color.Red };
			}
		}

		public ListView_Example()
		{
			InitializeComponent();

			Padding = new OnPlatform<Thickness>()
			{
				iOS = new Thickness(0, 20, 0, 0)
			};
			listView();
		}

		private void listView()
		{
			//xListView.ItemsSource = Enumerable.Range(1, 100).Select(s => s).ToList();
			xListView.ItemsSource = Person.Get();
		}

		async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			//throw new NotImplementedException();
			//await DisplayAlert("ItemTapped", e.Item.ToString(), "OK");

			Person item = e.Item as Person;
			await DisplayAlert("ItemTapped", 
			                   string.Format("Name:{0}; BirthDay:{1}", item.Name, item.BirthDay.ToString("yyyy/MM/dd")), "OK");
		}

		//async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		//{
		//	//throw new NotImplementedException();
		//	await DisplayAlert("ItemSelected", e.SelectedItem.ToString(), "OK");
		//}
	}
}
