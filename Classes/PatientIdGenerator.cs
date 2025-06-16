// Hospital1._0.Classes/PatientIdGenerator.cs
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Hospital1._0.Classes
{
    public static class PatientIdGenerator
    {
        private static readonly string CounterCollectionName = "Counters";
        private static readonly string PatientIdCounterDocName = "PatientIdCounter";
        private static readonly string LastIdFieldName = "currentPatientId";

        /// Retrieves and atomically increments the next available Patient ID from Firestore.
        /// This uses a Firestore transaction to ensure thread-safe ID generation.
        /// <returns>The next unique patient ID.</returns>
        /// <exception cref="InvalidOperationException">Thrown if there's an issue generating the ID.</exception>
        public static async Task<int> GetNextPatientId()
        {
            FirestoreDb db = FirestoreHelper.Database;
            DocumentReference counterRef = db.Collection(CounterCollectionName).Document(PatientIdCounterDocName);

            try
            {
                int nextId = await db.RunTransactionAsync(async transaction =>
                {
                    DocumentSnapshot snapshot = await transaction.GetSnapshotAsync(counterRef);
                    long currentCount = 0;

                    // Check if the counter document exists and has the 'lastId' field
                    if (snapshot.Exists && snapshot.TryGetValue(LastIdFieldName, out object lastIdObj))
                    {
                        currentCount = (long)lastIdObj;
                    }
                    else
                    {
                        transaction.Create(counterRef, new Dictionary<string, object> { { LastIdFieldName, currentCount } });
                    }

                    long newCount = currentCount + 1;
                    transaction.Set(counterRef, new Dictionary<string, object> { { LastIdFieldName, newCount } }); // Update the counter
                    return (int)newCount; // Return the new ID
                });

                return nextId;
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error generating next Patient ID: {ex.Message}");
                throw new InvalidOperationException("Failed to generate a unique Patient ID. Please contact support.", ex);
            }
        }
    }
}