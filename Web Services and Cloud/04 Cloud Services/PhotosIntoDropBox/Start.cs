namespace PhotosIntoDropBox
{
    using System;
    using System.Diagnostics;
    using System.IO;

    using Spring.IO;
    using Spring.Social.Dropbox.Api;
    using Spring.Social.Dropbox.Connect;
    using Spring.Social.OAuth1;

    public class Start
    {
        // Register your own Dropbox app at https://www.dropbox.com/developers/apps
        // with "Full Dropbox" access level and set your app keys and app secret below
        private const string DropboxAppKey = "***";
        private const string DropboxAppSecret = "***";

        private const string OAuthTokenFileName = "OAuthTokenFileName.txt";

        public static void Main()
        {
            DropboxServiceProvider dropboxServiceProvider =
                new DropboxServiceProvider(DropboxAppKey, DropboxAppSecret, AccessLevel.Full);

            // Authenticate the application (if not authenticated) and load the OAuth token
            if (!File.Exists(OAuthTokenFileName))
            {
                AuthorizeAppOAuth(dropboxServiceProvider);
            }

            OAuthToken oauthAccessToken = LoadOAuthToken();

            // Login in Dropbox
            IDropbox dropbox = dropboxServiceProvider.GetApi(oauthAccessToken.Value, oauthAccessToken.Secret);

            // Display user name (from his profile)
            DropboxProfile profile = dropbox.GetUserProfileAsync().Result;
            Console.WriteLine("Hi " + profile.DisplayName + "!");

            // Create new folder
            string folderName = "New Photo Album " + DateTime.Now.Ticks;
            Entry createFolderEntry = dropbox.CreateFolderAsync(folderName).Result;
            Console.WriteLine("Created folder: {0}", createFolderEntry.Path);

            const string PicturesPath = "../../Pictures/";

            // Upload files
            UploadFile(dropbox, "1.jpeg", PicturesPath, folderName);
            UploadFile(dropbox, "2.jpeg", PicturesPath, folderName);
            UploadFile(dropbox, "3.jpg", PicturesPath, folderName);
            UploadFile(dropbox, "4.jpeg", PicturesPath, folderName);

            // Share files
            DropboxLink sharedUrl = dropbox.GetShareableLinkAsync(folderName).Result;
            Process.Start(sharedUrl.Url);
        }

        private static void UploadFile(IDropbox dropbox, string fileName, string inputFilePath, string outputFolder)
        {
            Entry uploadFileEntry = dropbox.UploadFileAsync(
                new FileResource(inputFilePath + fileName),
                "/" + outputFolder + "/" + fileName).Result;
            Console.WriteLine("Uploaded a file: {0}", uploadFileEntry.Path);
        }

        private static OAuthToken LoadOAuthToken()
        {
            string[] lines = File.ReadAllLines(OAuthTokenFileName);
            OAuthToken oauthAccessToken = new OAuthToken(lines[0], lines[1]);
            return oauthAccessToken;
        }

        private static void AuthorizeAppOAuth(DropboxServiceProvider dropboxServiceProvider)
        {
            // Authorization without callback url
            Console.Write("Getting request token...");
            OAuthToken oauthToken = dropboxServiceProvider.OAuthOperations.FetchRequestTokenAsync(null, null).Result;
            Console.WriteLine("Done.");

            OAuth1Parameters parameters = new OAuth1Parameters();
            string authenticateUrl = dropboxServiceProvider.OAuthOperations.BuildAuthorizeUrl(
                oauthToken.Value, parameters);
            Console.WriteLine("Redirect the user for authorization to {0}", authenticateUrl);
            Process.Start(authenticateUrl);
            Console.Write("Press [Enter] when authorization attempt has succeeded.");
            Console.ReadLine();

            Console.Write("Getting access token...");
            AuthorizedRequestToken requestToken = new AuthorizedRequestToken(oauthToken, null);
            OAuthToken oauthAccessToken =
                dropboxServiceProvider.OAuthOperations.ExchangeForAccessTokenAsync(requestToken, null).Result;
            Console.WriteLine("Done.");

            string[] oauthData = new string[] { oauthAccessToken.Value, oauthAccessToken.Secret };
            File.WriteAllLines(OAuthTokenFileName, oauthData);
        }
    }
}
