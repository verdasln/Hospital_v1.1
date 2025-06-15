using System;
using Google.Cloud.Firestore;

namespace Hospital1._0.Classes
{
    [FirestoreData]
    internal class PatientData
    {
        [FirestoreProperty]
        public int PatientId { get; set; }

        [FirestoreProperty]
        public string PatientName { get; set; }

        [FirestoreProperty]
        public DateTime PatientDateOfBirth { get; set; }

        [FirestoreProperty]
        public int PatientAge { get; set; }

        [FirestoreProperty]
        public string PatientBloodGroup { get; set; }

        [FirestoreProperty]
        public string PatientContactNo { get; set; }

        [FirestoreProperty]
        public string PatientGender { get; set; }

        [FirestoreProperty]
        public string PatientAddress { get; set; }
    }
}
