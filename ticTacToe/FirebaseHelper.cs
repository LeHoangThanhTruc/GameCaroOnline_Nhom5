using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
namespace ticTacToe
{
    public static class FirebaseHelper 
    {
        private const string WebApiKey = "AIzaSyC4VCx7tAbSfPIf6qVH493JVm3q92RW17E";

        public static FirebaseAuthClient GetClient()
        {
            var config = new Firebase.Auth.FirebaseConfig(WebApiKey);

            return new FirebaseAuthClient(config);
        }
    }
}