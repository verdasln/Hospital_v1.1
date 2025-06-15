using Google.Cloud.Firestore;

namespace Hospital1._0.Classes
{
    [FirestoreData]
    internal class HospitalInfo
    {
        [FirestoreProperty]
        public string HospitalName { get; set; }
        [FirestoreProperty]
        public string HospitalAddress { get; set; }

    }
}
