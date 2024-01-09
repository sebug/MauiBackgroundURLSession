#if IOS
using Foundation;
#endif

namespace MauiBackgroundURLSession;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		LoadURL();
    }

    private void LoadURL()
	{
		#if IOS
		var downloadSessionConfiguration = NSUrlSessionConfiguration.CreateBackgroundSessionConfiguration("DownloadSchedule");
        downloadSessionConfiguration.Discretionary = true;
        downloadSessionConfiguration.SessionSendsLaunchEvents = true;
    	downloadSessionConfiguration.WaitsForConnectivity = true;
        var downloadSession = NSUrlSession.FromConfiguration(downloadSessionConfiguration,
    	new DownloadHandler(), null);

		var downloadTask = downloadSession.CreateDownloadTask(new NSUrl("https://fosdem.org/2024/schedule/"));
		downloadTask.Resume();
		#endif
	}
}

