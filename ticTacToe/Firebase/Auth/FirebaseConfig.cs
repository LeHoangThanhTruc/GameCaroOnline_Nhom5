
namespace Firebase.Auth
{
    internal class FirebaseConfig : FirebaseAuthConfig
    {
        private string webApiKey;

        public FirebaseConfig(string webApiKey)
        {
            this.webApiKey = webApiKey;
        }
    }
}