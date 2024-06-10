using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Hospital1._0.Classes
{
    [FirestoreData]
    internal class PatientData
    {
        [FirestoreProperty]
        public string PatientId { get; set;}
        [FirestoreProperty]
        public string PatientName { get; set;}
        [FirestoreProperty]
        public string PatientGender { get; set;}
        [FirestoreProperty]
        public string PatientDateOfBirth { get; set;}
        [FirestoreProperty]
        public string PatientAddress { get; set;}
        [FirestoreProperty]
        public string PatientAge { get; set;}
        [FirestoreProperty]
        public string PatientBloodGroup { get; set;}
        [FirestoreProperty]
        public string PatientContactNo { get; set;}
    }
}
