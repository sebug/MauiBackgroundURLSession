using Foundation;

namespace MauiBackgroundURLSession;

public class DownloadHandler : NSUrlSessionDownloadDelegate
{
    public override void DidFinishDownloading(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
    {
    }

    public override void DidCompleteWithError(NSUrlSession session, NSUrlSessionTask task, NSError? error)
    {
        if (error != null)
        {
            Console.WriteLine("I got the following error: " + error.DebugDescription);
        }
    }
}