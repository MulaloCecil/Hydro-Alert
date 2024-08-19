using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;

namespace TradeTalk.Services
{
    namespace TradeTalk.Services
    {
        public class FirebaseAuthService
        {
            private readonly FirebaseAuthProvider _authProvider;
            private readonly string _firebaseApiKey = "AIzaSyDlLdo6xZpC1vb4GgFzEUdiq8cfssw8jQ8";

            public FirebaseAuthService()
            {
                _authProvider = new FirebaseAuthProvider(new FirebaseConfig(_firebaseApiKey));
            }

            public async Task<string> RegisterAsync(string email, string password)
            {
                var auth = await _authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                return auth.FirebaseToken;
            }

            public async Task<string> LoginAsync(string email, string password)
            {
                var auth = await _authProvider.SignInWithEmailAndPasswordAsync(email, password);
                return auth.FirebaseToken;
            }
        }
    }
}
