using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital1._0.Classes
{
    [FirestoreData]
    internal class PatientDiagnosisData
    {
        [FirestoreProperty]
        public int PatientId { get; set; }

        [FirestoreProperty]
        public string Symptoms { get; set; }

        [FirestoreProperty]
        public string Diagnosis { get; set; }

        [FirestoreProperty]
        public string Medicines { get; set; }

        [FirestoreProperty]
        public bool WardRequired { get; set; }

        [FirestoreProperty]
        public string TypeOfWard { get; set; }
    }
}
