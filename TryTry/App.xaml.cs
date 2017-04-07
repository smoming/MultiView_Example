using Xamarin.Forms;

namespace TryTry
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new StackLayout_Example();
			//MainPage = new ListView_Example();
			//MainPage = new TabbedPage_Example();
			//MainPage = new MyTabbedPage();
			MainPage = new MasterDetail_Example();
			//MainPage = new ScrollView_Example();
			//MainPage = new Style_Example();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
