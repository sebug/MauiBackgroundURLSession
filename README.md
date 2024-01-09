# MAUI Background URL Session
Aims to illustrate a problem I have with the simulator when starting background
URL sessions.

The error I get:

   2024-01-09 17:20:50.631776+0100 MauiBackgroundURLSession[3465:41761] BackgroundSession <A70D22E7-FD9F-4FD9-89DF-221FC3A41EC2> failed to create a background NSURLSessionDownloadTask, as remote session is unavailable
   2024-01-09 17:20:50.638298+0100 MauiBackgroundURLSession[3465:41793] Task <1FCAE53C-7756-4408-8809-3AC3E7D45587>.<1> finished with error [-1] Error Domain=NSURLErrorDomain Code=-1 "unknown error" UserInfo={NSErrorFailingURLStringKey=https://fosdem.org/2024/schedule/, NSErrorFailingURLKey=https://fosdem.org/2024/schedule/, _NSURLErrorRelatedURLSessionTaskErrorKey=(
    "BackgroundDownloadTask <1FCAE53C-7756-4408-8809-3AC3E7D45587>.<1>"
), _NSURLErrorFailingURLSessionTaskErrorKey=BackgroundDownloadTask <1FCAE53C-7756-4408-8809-3AC3E7D45587>.<1>, NSLocalizedDescription=unknown error}

