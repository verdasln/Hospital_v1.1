using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
