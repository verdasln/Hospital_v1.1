using Google.Cloud.Firestore;

namespace Hospital1._0.Classes
{
    [FirestoreData]
    internal class LoginData
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public string Password { get; set; }
    }
}
